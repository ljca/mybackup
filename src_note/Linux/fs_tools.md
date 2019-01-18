# Other FS Tools
## [`LVM`：逻辑卷管理](fs_tools/lvm.md)
## [`RAID`：磁盘阵列](fs_tools/raid.md)
## [Loop Device：a magic device（奇妙的环回设备）](fs_tools/loopback.md)
## [quota：磁盘配额工具](fs_tools/quota.md)

## 磁盘分区创建与调整工具

+ `gfdisk`
+ `gdisk`
+ `parted`

GUI 磁盘工具：`gparted`。

## 基于文件系统的工具：
### mtools

### [NTFS 工具集](fs_tools/ntfs-utils.md)
### [exfat](fs_tools/exfat_utils.md)

+ `fat`系列卷标修改工具`mlabel`（mlabel命令由mtools软件包提供，然而，并不是所有的Linux发行都会会默认安装mtools软件包）。

&nbsp;&nbsp;如果你正在使用`Linux`并希望修改`U`盘或者`移动硬盘`卷标而且又不喜欢使用命令行，可以直接使用`gparted`修改。

```Bash
# 下面是 gparted 用于修改卷标的详细指令（在终端无效）：
# mlabel /dev/sdb1 ::work
# fat 系列卷除了 exfat 外，其它的似乎都不支持卷标小写……
# mlabel ::"BACKUP" -i /dev/sdb1
```

&nbsp;&nbsp;如果你喜欢使用命令行，首先安装`mtools`软件包并像`Windows`那样在`/etc/mtools.conf`中给`移动磁盘`映射一个虚拟驱动器号：

=========== /etc/mtools.conf ============

```config
# # First SCSI hard disk partition
# drive c: file="/dev/sda1"
drive g: file="/dev/sdb1"
drive h: file="/dev/sdb2"

# 忽略大小写
mtools_lower_case=1
```

然后以根用户权限执行`mlabel`（可能需要先挂载`fat`卷）更改你希望更改的`fat 卷`卷标：

```Bash
# mlabel 如果不带任何参数，且没有在命令行上指定卷标名，系统将会提示键入新的卷标：
mlabel h: 

mlabel --help
mlabel /dev/sdb1 X
mlabel /dev/sdb1
mlabel -N X /dev/sdb1
mlabel /dev/sdb1
```

### [Ext 文件系统工具集](fs_tools/ext_fs_utils.md)

+ jfs
+ xfs
+ `reiser2fs`
+ btrfs
+ hfs|hfs+

> 基于`iso9660/UDF`文件系统的工具：

+ mkisofs
+ genisoimage
+ eject

# 附
## testdisk
