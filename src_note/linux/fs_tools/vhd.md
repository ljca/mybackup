<link href="../css/style.css" rel="stylesheet" type="text/css" />

::: alert-info

`file *.vhd`：Linux 无法直接读取的虚拟磁盘 vhd 文件。

FreeDOS1.3_data.vhd: data
FreeDOS1.3.vhd:      data

:::


# Linux[^linux] 挂载 vhd 虚拟磁盘

[^linux]: 本次测试使用的发行版是 Arch Linux。

::: alert-info

首先安装 vdfuse。

:::


> file: /etc/fuse.conf

```config
# 允许普通用户挂载....
user_allow_other

#....
```

+ `md /tmp/tmp;vdfuse -f FreeDOS1.3_data.vhd /tmp/tmp;l /tmp/tmp`[^alias]

[^alias]: md is mkdir, l is ls.

EntireDisk  Partition1

+ 识别：`^_^-$  file /tmp/tmp/*`

```log
/tmp/tmp/EntireDisk: DOS/MBR boot sector; partition 1 : ID=0xb, active, start-CHS (0x0,1,1), end-CHS (0x3f7,15,63), startsector 63, 1023057 sectors
/tmp/tmp/Partition1: DOS/MBR boot sector, code offset 0x58+2, OEM-ID "MSDOS5.0", sectors/cluster 8, reserved sectors 6208, Media descriptor 0xf8, sectors/track 63, heads 255, hidden sectors 63, sectors 1023057 (volumes > 32 MB), FAT (32 bit), sectors/FAT 992, serial number 0xc407b4cf, unlabeled
```

+ `^_^-$  fdisk -l /tmp/tmp/EntireDisk`

```log
Disk /tmp/tmp/EntireDisk：500 MiB，524288000 字节，1024000 个扇区
单元：扇区 / 1 * 512 = 512 字节
扇区大小(逻辑/物理)：512 字节 / 512 字节
I/O 大小(最小/最佳)：512 字节 / 512 字节
磁盘标签类型：dos
磁盘标识符：0x8276e5cd

设备                 启动 起点    末尾    扇区   大小 Id 类型
/tmp/tmp/EntireDisk1 *      63 1023119 1023057 499.5M  b W95 FAT32
```

+ 接下来使用 mount 以环回设备直接挂载分区即可：`sudo mount -o loop /tmp/tmp/Partition1 /media/tmp`。[^mount]

[^mount]: 最后不要忘了卸载设备：`sudo umount /media/tmp;sudo umount /tmp/tmp`


::: alert-info

安装 libguestfs 使用 guestmount 挂载。此法在我的计算机上貌似不可用。

:::


> 参考：

+ [Debian7（Linux）下挂载包含bitlocker加密的VHD虚拟磁盘](http://blog.chinaunix.net/uid-10062010-id-5207173.html)
+ [linux下挂载VHD等虚拟磁盘文件的方法](http://www.manongjc.com/article/135611.html)

