# CentOS7在VirtualBox的安装
# §. CentOS 7 在 VirtualBox 里的安装

> ViretualBox 同时支持 `BIOS` 和 `UEFI` [^uefi]。 关于系统存储控制器的选择有几种：

+ IDE
+ SATA
+ SCSI
+ ......

> &nbsp;&nbsp;对于低版本的 VirtualBox，如果你选择了用 UEFI 来引导安装的系统，在安装完成之后，你需要通过 UEFI SHELL 启动 CentOS 并在系统中调整 efi 位置[^efi]。如果你的系统在 VirtualBox 能顺利引导的话就不必这样了。

```Batch
FS0:\EFI\centos\grubx64.efi 

# 直接在 VirtualBox 的 UEFI SHELL 里调整位置
FS0:
cd EFI
dir
cp centos\grubx64.efi BOOT
dir BOOT
```


> &nbsp;&nbsp;在大多数情况下，我们在虚拟机上安装了~~用于学习的Linux~~之后，通常都会希望在主机上能够直接通过 `ssh` 程序连接到它并进行管理。 除了 `VirtualBox` 上的网络配置，你还需要正确配置了虚拟机里系统的防火墙和 `ssh` 服务。

## §. 系统里的设置
### 1. ssh server

> 你需要在系统中安装了 ssh 服务包 `open-ssh` 及它的客户端并对其正确配置。

+ dir: /etc/ssh
  + file: sshd_config
  + file: ssh_config

```Bash

# init 使用SysV方式的系统比如centos 6.5
chkconfig --level 2345 sshd on

# 或者手动将sshd链接到/etc/init.d目录下

# init 使用systemd的系统:
systemctl enable sshd

测试：
ssh [-p port] [user@]192.168.56.1
```

### 2. 防火墙 firewalld [^firewalld]服务规则


[^uefi]: 统一可扩展固件的缩写。

[^efi]: 如果是通过 `EFI` 安装的 `CentOS`，可能需要自行配置 `/boot/efi` 分区。还需要对 `CentOS 的可启动efi` 的位置作出微小调整以便 `VirtualBox 的 UEFI SHELL` 能正确找到并启动系统，因为 `Virtualbox` 的 `EFI` 扫描目录是固定的 `EFI\BOOT`，而且版本较低的 `VirtualBox` 是不支持扫描其它目录的。你需要在 `UEFI SHELL` 或者 `CentOS` 系统中将 `CentOS 可启动efi` 自行拷贝过去。

[^firewalld]: 防火墙。

> 参考：

+ [linux命令行下安装配置virtualbox虚拟机 - awu999328的专栏 - 博客频道 - CSDN.NET](http://blog.csdn.net/awu999328/article/details/22663829)