<link href="../css/style.css" rel="stylesheet" type="text/css" />


# 数据恢复笔记

## ext4magic 

关于`Linux`上可扩展文件(Ext)系统的数据存放原理及组织方式，我不得而知。以下仅对其恢复工具的用法进行简要的讨论：

> `Linux`平台[^lin][^win]  Ext 系列文件系统目前已知的数据恢复工具：

| extcuteble | ext3grep | ext4magic[^note] | 
| -------------- | ----------- | ---------------------- |
| ext2,ext3  | ext3       | ext3,ext4           |

> 不过在恢复数据之前，最好注意：

+ 数据被误删最好立即进行恢复，否则数据被覆盖之后再恢复将会出现不完整的情况。
+ 要恢复数据的分区在恢复数据之前最好卸载。
+ 用于存放恢复数据的分区必须具备足够的容量。且不应该和要恢复数据的分区是同一分区，以免覆盖掉要恢复的数据。


```Bash
# 最简用法: ext4magic 必选项 [可选项] 文件系统
ext4magic -M /dev/sda7 

```

最常用的几个选项如下：

必须选项： 这几个选项是互相冲突的。也就是说只能选其一使用。

 + -r | -R : 恢复目录结构
 + -M | -m：恢复所有误删除的文件
 + -l | -L：

可选项：

`-a`和`-b`选项分别用来指定起始日期。
`-f`用来指定要恢复文件的文件名
`-d` 用于指定发现文件的最终存放目录，否则就放在当前目录下的`RECOVERDIR`中。

```Bash
sudo ext4magic  -R -a $(date -d "-30day" +%s) /dev/sda7 -d /mnt

sudo ext4magic  -R -b $(date -d "-42day" +%s) /dev/sda7 -d /mnt
```

[^lin]: 因为`Linux`上的数据恢复工具似乎从未有过图形界面，而命令行工具选项的复杂使得使用难度增加了不少。

[^win]: 在`Windows`上，你可以尝试一下D-Recovery等工具，一些新的工具正在开发中，也许不久之后就会上市。

## ntfsundelete[^undelete]：恢复在 NTFS 文件系统上误删的文件。

```Bash
sudo ntfsundelete /dev/sda9 -u -i `sudo ntfsundelete /dev/sda9 -m "*.mp4"|sed '1,2d;/^$/d;$d'|cut -d" " -f-1|xargs|tr ' ' ','` -d ./tmp
```

```Bash
for d in $(for i in `find ../video/ -type f -size 0 -name "*.mp4"`;do basename $i;done|xargs);do cp -ibv "$d" ../video/1069/;done
```

[^ntfs]: 虽然 Linux 内核已经提供了 NTFS 模块，但只能读取 NTFS 文件而不支持写入。如果想要在 NTFS 上创建、删除、更新文件，还要在 Linux 上安装 ntfs-3g。ntfs-3g 软件包不仅提供了支持 NTFS 读取/写入的模块，还提供了一系列用于 NTFS 的工具集。

[^undelete]: ntfsundelete 属于 ntfs-3g，似乎更快更高效。最简用法：`sudo ntfsundelete /dev/sda9 -m "*.mp4"` [output](ntfsundelete.logs)

[^note]: 对于 `extcuteble` 和 `ext3grep`，已经不再适用于 `Ext4` 文件系统，仅 `ext4magic` 提供了恢复`Ext4`文件系统上已删除文件的功能。