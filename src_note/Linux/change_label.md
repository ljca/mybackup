# 如何在 Linux 上修改磁盘分区卷标：

+ Ext 系列 使用 e2label[^e2label]：修改 Ext 系列文件系统卷标: `sudo e2label /dev/sda4 Lfs`
+ NTFS 使用 ntfslabel[^ntfslabel]：`ntfslabel `
+ mlabel[^mlabel]: `fat`系列卷标修改工具

 =========== /etc/mtools.conf ============

```config
# 下面是 gparted 用于修改卷标的详细指令（在终端无效）：
# mlabel /dev/sdb1 ::work
# fat 系列卷除了 exfat 外，其它的似乎都不支持卷标小写……
# mlabel ::"BACKUP" -i /dev/sdb1

# # First SCSI hard disk partition
# 映射驱动器
# drive c: file="/dev/sda1"
drive g: file="/dev/sdb1"
drive h: file="/dev/sdb2"

# 忽略大小写
mtools_lower_case=1
```

&nbsp;&nbsp;然后以根用户权限执行`mlabel h: LIN`（可能需要先挂载`fat`卷）更改`fat 卷`卷标，mlabel 如果不带任何参数，且没有在命令行上指定卷标名，系统将会提示键入新的卷标, 更多用法参考 `mlabel --help`。

## 文件系统检查[^disk_check]：

+ Ext 系列：fsck 
+ NTFS 使用 ntfsfix[^fix]：NTFS 分区检查工具， `sudo ntfsfix /dev/sda8`

```log
Mounting volume... The disk contains an unclean file system (0, 0).
Metadata kept in Windows cache, refused to mount.
FAILED
Attempting to correct errors...
Processing $MFT and $MFTMirr...
Reading $MFT... OK
Reading $MFTMirr... OK
Comparing $MFTMirr to $MFT... OK
Processing of $MFT and $MFTMirr completed successfully.
Setting required flags on partition... OK
Going to empty the journal ($LogFile)... OK
Checking the alternate boot sector... OK
NTFS volume version is 3.1.
NTFS partition /dev/sda8 was processed successfully.
```

> 数据恢复：[数据恢复](recovery_data.md)

[^e2label]: e2label 在 e2fsprogs 软件包中，只要文件系统是 ext 系列的，应该就会安装。

[^ntfslabel]: ntfslabel 属于 ntfs-3g 软件包。

[^mlabel]: mlabel命令由mtools软件包提供，然而，并不是所有的Linux发行都会默认安装。可以直接使用`gparted`修改`U`盘或者`移动硬盘`卷标。同样，也可以使用命令行由`mtools`软件包提供的 mlabel 修改。当然，这需要先在/etc/mtools.conf中给`移动磁盘`映射一个虚拟驱动器号。

[^disk_check]: 我们不可避免的会遇到这个问题。或者是因为停电，或者是误操作，或者是不小心碰到了电源开关。

[^fix]: ntfsfix 同样属于 ntfs-3g 软件包，系统并不会默认安装。很多时候，不正常的关机（冷关机，断电等）都会导致 NTFS 卷无法再次在 Linux 上以读写的方式挂载。这个时候，要么启动到 Windows 进行修复，要么直接使用 ntfs-3g 提供的 ntfsfix 进行检查修复，要么选择只读的方式挂载。

