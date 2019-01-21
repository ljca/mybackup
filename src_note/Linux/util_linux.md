# util-linux：Linux工具

+ addpart：
+ agetty：
+ blkdiscard：
+ blkid：获取磁盘分区信息 `sudo blkid`

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
+ cal：
+ cfdisk：
+ chcpu：
+ chfn：
+ chrt：
+ chsh：
+ col：
+ colcrt：
+ colrm：
+ column：
+ ctrlaltdel：
+ delpart：
+ dmesg：
+ eject：
+ fallocate：
+ fdformat：
+ fdisk：
+ findfs：
+ findmnt：
+ flock：
+ fsck：
+ fsck.cramfs：
+ fsck.minix：
+ fsfreeze：
+ fstrim：
+ getopt：
+ hexdump：
+ hwclock：
+ i386：
+ ionice：
+ ipcmk：
+ ipcrm：
+ ipcs：
+ isosize：
+ kill：
+ last：
+ lastb：
+ ldattach：
+ linux32：
+ linux64：
+ logger：
+ login：
+ look：
+ losetup：
+ lsblk：
+ lscpu：
+ lsipc：
+ lslocks：
+ lslogins：
+ lsns：
+ mcookie：
+ mesg：
+ mkfs：
+ mkfs.bfs：
+ mkfs.cramfs：
mkfs.minix：
mkswap：
+ more：
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
+ rename：
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
+ sfdisk：
+ su：
+ sulogin：
+ swaplabel：
+ swapoff：
+ swapon：
+ switch_root：
+ taskset：
+ ul：
+ <a href="util-linux/mount.md#umount">umount：卸载磁盘或者分区</a>
+ uname26：
+ unshare：
+ utmpdump：
+ uuidd：
+ uuidgen：
+ vigr：
+ vipw：
+ wall：
+ wdctl：
+ whereis：指令文件定位
+ wipefs：
+ write：
+ x86\_64：
+ zramctl：

[mount]: util-linux/mount.md
[script]: util-linux/script.md
