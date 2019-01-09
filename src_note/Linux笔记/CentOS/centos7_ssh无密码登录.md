# ssh：安全连接到远程主机

## ssh 服务配置

> 更改 ssh 服务的端口号 `/etc/ssh/sshd_config`

```config
# 你只需要给 Port 字段重新设置一个数值（这个数值不能是系统预留的端口号，并且要在 65530 以内），然后重启 ssh 服务就行了。
Port=
```

&nbsp;&nbsp;然而，如果你在 `CentOS`上没有禁用 `SELinux`或者对它进行配置，它将会阻止你服务器上的服务重新进行端口绑定。当然，防火墙也可能会阻止。你在客户端上怎么也连不上，你将会收到一个 Connection Refrused 的消息。 你可以尝试在服务端使用 `netstat` 来检查 `ssh` 服务是否正常运行，同时查看系统日志也会知晓服务运行的状态信息。 ***一旦你成功更改了 目标系统上 ssh 服务的端口，那么在使用 ssh 客户端时，需要同时使用 -P 选项来指定端口号。***

> 如果你没有正确配置 SELinux，它会妨碍端口的重新绑定和监听。

&nbsp;&nbsp;CentOS 7 继承了红帽系的`SELinux`工具，然而迄今为止，我仍然没有搞清楚它的运作方式。它需要占用非常多的系统内存来运行。但它确实会给配置系统带来麻烦，所以在使用这个系统的多数时候，我都会选择将它禁用。

> `/etc/selinux/config`

```config
enable=disabled
```

# ssh 客户端
## SSH 免密登录

**ssh 通过密钥对进行认证已经被证实比使用系统的密码验证要安全，因此，选择通过密钥对进行认证登录也就不奇怪了。**

&nbsp;&nbsp;虽然这篇文章是在 CentOS 7 平台上，但实际上，关于 SSH 无密码登录的配置在大多数 `Linux` 和 `Unix 变体`上是通用的。只是因为 CentOS 属于 `RedHat`系，与其它的`Linux`发行在某些方面存在着差异。

&nbsp;&nbsp;我们必须先在客户端上生成密钥对（公钥和私钥）。

```Bash
ssh-keygen -t rsa
```
然后想办法在生成密钥对的客户端上将公钥(. pub文件)添加到服务器上用户目录下的固定文件中。

```Bash
# 之所以使用 ssh-copy-id，那是因为这个 shell 脚本所做的工作能准确达成我们的目的（除了将公钥添加到服务器端用户目录下 .ssh下的authrized_keys中，还会正确配置它们的权限）。你还可以使用 scp，或者在服务端执行 cat 的方式添加，但二者权限却需要你自己动手配置。
# .ssh 700，.ssh/authorized_keys 600.
# ssh-copy-id <[-i] *.pub> user@host # 如果你用 ssh-keygen 生成的公钥文件不是默认的 id_rsa.pub ，你就需要用 -i 选项指定它的位置和文件名。如果你更改了 ssh 服务的默认端口，你还要用 -P 选项来指定目标系统的端口号。
ssh-copy-id -i ~/.ssh/centos_rsa.pub tmp@192.168.43.191

```


## 使用别名来替代用户名等命令行参数

**为了简写诸如主机，用户名和端口等长长的一串命令行参数**，我们可以根据需要在客户端创建 `~/.ssh/config`：

```config
# 根据需要，你可以添加 User 字段，Port 字段....
host name
  Hostname ip/hostname
  User user
  Port Port
  ....
```

然后就可以直接使用`ssh name`的方式连接服务器。

# 附

## Arch Linux 配置 ssh(`openssh-server` `openssh-client`)

profile:
/etc/ssh/ssh\_config,/etc/ssh/sshd\_config

```Bash
ssh [options] [user@]host|ip [command]
```

> options:

 * -P port:指定其它端口号.
 * -u user:指定用户名.
 * -c compression:指定是否需要将数据压缩之后在传输.

启动ssh服务： `systemctl start sshd.service`

本机测试: `ssh -P port $USER@localhost`

## sshfs(`sshfs` `fuse`)：通过ssh的方式挂载或者映射远程主机目录到本地……

```Bash
sshfs --help
```

> 一组选项使用逗号分隔:
```Bash
sshfs user@ip|host:remount_dir local_mount_point [options]
```

> options:

 * -o allowe_other 允许其它用户访问.
 * -o uid 指定用户uid
 * -o compression 允许数据在传输前压缩，节省带宽，网络流量
 * -o reconnect 允许断线自动重连

测试:

``` Bash
sshfs $USER@localhost:/tmp /mnt -o allow_other,compression=yes,uid=$UID
```

卸载可以使用常规卸载方式：
``` Bash
umount -v local_mount_point
```

或者:
``` Bash
fusermount -u local_mount_point
```


``` Bash
systemctl stop sshd.service
```

> 参考：

+ [ssh连接到虚拟机的一般方法 - 简书](http://www.jianshu.com/p/eca72e767d71)
+ [VirtualBox中开启Linux的SSH（CentOS） - gangzz的个人页面 - 开源中国社区](https://my.oschina.net/pangyangyang/blog/177869)
