<link href="../css/style.css" rel="stylesheet" type="text/css" />

# util-linux：Linux工具

+ addpart：
+ agetty：
+ blkdiscard：
+ blkid：读取磁盘分区信息 `sudo blkid`

```log
/dev/sda1: SEC_TYPE="msdos" LABEL="ESP" UUID="0000-4823" TYPE="vfat" PARTLABEL="EFI System Partition" PARTUUID="69d56666-9053-4130-b728-c551d84346f1"
/dev/sda2: LABEL="windows8.1" UUID="E2D09041D0901DBB" TYPE="ntfs" PARTLABEL="Basic data partition" PARTUUID="5955e854-8a49-4b4a-bb1a-9fb22e8437c4"
/dev/sda3: LABEL="Arch" UUID="ae912fc6-72dc-4fd3-80a0-d799dd919f33" TYPE="ext4" PARTUUID="d7775fc6-2a52-400b-a39b-b15d78ca4af5"
/dev/sda4: LABEL="Fedora" UUID="4d43cf85-d29c-43ee-bb08-657a246004a4" TYPE="ext4" PARTUUID="070a565f-1ad6-4d62-9114-f66007fb6e9f"
/dev/sda5: LABEL="Gentoo" UUID="54e88760-50fa-4bd9-b423-4f3da369237d" TYPE="ext4" PARTUUID="2409e23b-bb72-4877-a5b7-0d67658522db"
/dev/sda6: LABEL="Lfs" UUID="fe31d6fa-344d-49a8-ad09-8a6475edb4e9" TYPE="ext4" PARTUUID="49681ac5-5049-4343-864c-adcb2973cbf7"
/dev/sda7: LABEL="Home" UUID="310e162d-b839-46a2-afe4-daaef5930d51" TYPE="ext4" PARTUUID="c45793da-843b-4b88-99e9-ccf40dd9377d"
/dev/sda8: LABEL="Applications" UUID="0000678400004823" TYPE="ntfs" PARTLABEL="Basic data partition" PARTUUID="3b7f0983-87cf-46fb-9b33-dc8918fda6d6"
/dev/sda9: LABEL="Others" UUID="70D35C2C1C8ED47A" TYPE="ntfs" PARTLABEL="Basic data partition" PARTUUID="67a250b5-86c1-40ae-b574-0a144c5cf8b9"
/dev/sda10: LABEL="Swap" UUID="097f25f0-ceb5-4510-aa5a-cd1760969406" TYPE="swap" PARTLABEL="Linux swap partition" PARTUUID="4341375d-0f64-4368-a565-cb150999ef7c"
/dev/loop0: LABEL="Ext4" UUID="69fab154-0de1-4747-b12b-e8e73e41600b" TYPE="ext4"
/dev/loop1: LABEL="Xfs" UUID="ced03b26-bafe-4d0d-b780-5079946b3f69" TYPE="xfs"
```

+ blockdev：
+ cal：命令行日历
+ cfdisk：伪 GUI 分区编辑工具
+ chcpu：
+ chfn：更改用户信息, `chfn `
+ chrt：
+ chsh：更改用户 shell, `chsh -s /bin/bash user`
+ col：格式化列
+ colcrt：
+ colrm：
+ column：
+ ctrlaltdel：
+ delpart：
+ dmesg：读取内核开机自检信息
+ eject：
+ fallocate：
+ fdformat：
+ fdisk：一个命令行下的分区编辑工具
+ findfs：
+ findmnt：
+ flock：
+ fsck：检查 ext 系列文件系统
+ fsck.cramfs：
+ fsck.minix：
+ fsfreeze：
+ fstrim：
+ getopt：获取命令行选项
+ hexdump：读取二进制数据并转换为十六进制
+ hwclock：读取，调整硬件时钟
+ i386：
+ ionice：
+ ipcmk：
+ ipcrm：
+ ipcs：
+ isosize：
+ kill：给进程发送信号
+ last：显示最后登录用户
+ lastb：
+ ldattach：
+ linux32：
+ linux64：
+ logger：
+ login：
+ look：
+ losetup：设置环回设备
+ lsblk：读取并列出硬盘及其分区信息
+ lscpu：读取 CPU 参数
+ lsipc：
+ lslocks：
+ lslogins：
+ lsns：
+ mcookie：
+ mesg：
+ mkfs：在硬盘或者分区上创建文件系统
+ mkfs.bfs：
+ mkfs.cramfs：
+ mkfs.minix：
+ mkswap：将分区格式化为交换分区
+ more：命令行分页器，类似的有 less, most.
+ <a href="util-linux/mount.md#mount"> mount：挂载磁盘或者分区</a>
+ mountpoint：
+ namei：
+ newgrp：
+ nologin：
+ nsenter：
+ partx：
+ pivot_root：
+ prlimit：
+ raw：
+ readprofile：
+ rename：批量重命名文件。
+ renice：
+ resizepart：
+ rev：
+ rtcwake：
+ runuser：
+ [script][script]
+ [scriptreplay][script]
+ setarch：
+ setsid：
+ setterm：
+ sfdisk：命令行分区工具
+ su：用户切换
+ sulogin：
+ swaplabel：设置交换分区卷标
+ swapoff：关闭交换分区
+ swapon：启用交换分区
+ switch_root：
+ taskset：
+ ul：
+ <a href="util-linux/mount.md#umount">umount：卸载磁盘或者分区</a>
+ uname26：
+ unshare：
+ utmpdump：
+ uuidd：
+ uuidgen：
+ vigr：更安全的编辑 `/etc/group` 方式
+ vipw：更安全的的编辑 `/etc/passwd`方式
+ wall：
+ wdctl：
+ whereis：指令文件定位
+ wipefs：
+ write：
+ x86\_64：
+ zramctl：

[mount]: util-linux/mount.md
[script]: util-linux/script.md
