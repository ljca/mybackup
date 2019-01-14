# centos 7 配置 nfs & Samba


# 附

## Arch Linux 配置 nfs(nfs-utils)

profile：/etc/exports

exportfs工具允许修改了/etc/exports后不需重启nfs服务就可以应用更改.

挂载一个远程nfs系统到本地: `mount -vt nfs ip/host:dir local_mount_point`

卸载: `umount -v local_mount_point`

`showmount`

```Bash
showmount -a
```


## sambashare

> 参考：

+ [NFS (简体中文) - ArchWiki][nfs]
+ [Samba (简体中文) - ArchWiki][samba]

[nfs]: https://wiki.configlinux.org/index.php/Nfs_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[samba]: https://wiki.configlinux.org/index.php/Samba_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
