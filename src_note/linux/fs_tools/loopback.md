<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# Loop Device：a magic device（奇妙的环回设备）。

::: alert-info

我们可以将一个文件来作为磁盘读写，做法与创建交换文件作为操作系统交换空间类似,其原理是将这个文件全用0来填充，然后将它像磁盘一样格式化，但挂载时需要将它挂载为环回设备。 我们首先需要使用 **`dd`** 指令[^dd]创建一个由特殊字符 '\0' 填充的数据文件[^size]，特殊设备 `/dev/zero` 可以完成这个任务。 `mkdir tmp;dd if=/dev/zero of=tmp/loop.iso bs=1024M count=1`

:::

[^dd]: 

[^size]: 由于系统占用，实际空间可能会比这更小,这里使用了iso来做为文件的扩展名，但实际上这只是一个具有iso扩展名的伪光盘映像文件，上面并没有光盘镜像文件所独有的iso9660文件系统,而且事实上这种文件系统是只读的。按照我的理解，这个特殊的文件扩展名应该是随意的，或者干脆就不需要有。Linux也不是使用文件的扩展来判断文件类型的(除了某些应用软件)。

在这个特殊的文件上创建文件系统 `sudo mkfs -t ext4 -L "Loop" tmp/loop.iso` 。将它以环回设备挂载 `mkdir loop;sudo mount -o loop  tmp/loop.iso ./loop`。使用 file 指令可以成功的识别出来：

```log
tmp/loop.iso: Linux rev 1.0 ext4 filesystem data (needs journal recovery) (extents) (huge files)
```

::: alert-info

为了不与系统动态创建的环回设备混淆，我们可以手动创建一个环回设备 `sudo mknod /dev/loop8 b 7 8`。同时，将手动创建的环回设备和那个存在文件系统的特殊文件映射和关联,设置环回设备 ` sudo losetup /dev/loop8 tmp/loop.iso` 。这样就可以直接挂载环回设备，而不需要使用-o loop的方式。

:::

[^_^]: 有时候我们会把这个文件放到U盘，并且还将它与一个环回设备相关联了，那么在卸载U盘时需要先取消它与环回设备的关联之后才能卸载U盘。否则卸载U盘时会弹出一个设备忙的消息。

```Bash
sudo umount -v ./loop
sudo losetup -d /dev/loop8
```

## 在文件上创建～挂载多个分区

<div class="p">

为了使这个特殊文件像一个真正的磁盘那样可以创建多个可读写的分区，可以直接使用 fdisk 这样的磁盘工具来完成多个分区的创建，但在为这些分区创建文件系统和挂载时依然需要对分区配置 offset 选项。



为了创建文件系统，需要继续使用环回设置命令losetup设置创建好的分区，但要使用不同的环回设备且要使用-o选项来设置偏移量(以字节单位,不正确的偏移量可能会让设置好的分区无法挂载和使用),具有MBR分区表的磁盘应该从第63个扇区开始,第1个扇区保存了硬盘的MBR,随后的62个扇区是保留扇区，这一部分貌似不可用。

不过不要急，在为这个文件上的分区创建文件系统之前，我们还需要对文件分区设置偏移量和系统的环回设备进行关联，根据需要手动创建几个环回设备：

</div>

```Bash
sudo mknod /dev/loop9 b 7 9
sudo mknod /dev/loop10 b 7 10
sudo mknod /dev/loop11 b 7 11
....
```

[^_^]: 将一个文件(假设这个文件已经成功创建了,可以稍大，比如8G以上)设置到一个环回设备上 `sudo losetup /dev/loop9 tmp/loop2.iso`；现在的/dev/loop9已经可以作为一个全新的磁盘来处理了,使用一个磁盘分区工具比如fdisk，或者cfdisk,parted等来创建这个特殊磁盘的分区表和分区 `sudo fdisk /dev/loop9`。

+  设置第一个分区 `sudo losetup -o 32256 /dev/loop10 tmp/loop2.iso `
+  设置第二个分区 `sudo losetup -o 偏移量 /dev/loop11 /tmp/loop2.iso`

>  依次为它们创建文件系统

```Bash
sudo mkfs -t ext4 -L "Loop2" /dev/loop10 
sudo mkfs -t ext4 -L "Loop3" /dev/loop11
```

最后，使用 file 命令进行识别 `file tmp/*.iso`


## 读取 img[^img]镜像

[^img]: 对于某些在上面直接创建文件系统的 img 镜像文件（这可以通过 file 命令进行识别），可以直接像 iso 镜像文件一样直接挂载。但是对于一些以磁盘分区的形式出现的镜像，这时候在挂载时需要使用 offset 这个选项（offset 可以通过分区的（起点 x 扇区大小）计算得出，而扇区的起始位置和大小可以通过系统的磁盘工具得到）。

`sudo mount -o loop FD12FULL.img /tmp/tmp`

```log
mount: /tmp/tmp: 文件系统类型错误、选项错误、/dev/loop0 上有坏超级块、缺少代码页或帮助程序或其他错误.
```

`^_^-$  file ~2/FD12FUL*`

```log
/home/user/Arch/Downloads/fd12full/FD12FULL.img:  DOS/MBR boot sector, FREE-DOS Beta 0.9 MBR; partition 1 : ID=0x6, active, start-CHS (0x0,1,1), end-CHS (0x27,31,63), startsector 63, 1048257 sectors
/home/user/Arch/Downloads/fd12full/FD12FULL.vmdk: ASCII text
```

::: alert-info

因为大多数具有 MBR 分区表的磁盘扇区大小都是 512 字节。

:::

`:(-$  l`
FD12FULL.img*  README.md*  FD12FULL.vmdk*

`^_^-$  sudo fdisk FD12FULL.img`

```log

欢迎使用 fdisk (util-linux 2.37.2)。
更改将停留在内存中，直到您决定将更改写入磁盘。
使用写入命令前请三思。


命令(输入 m 获取帮助)：m

帮助：

  DOS (MBR)
   a   开关 可启动 标志
   b   编辑嵌套的 BSD 磁盘标签
   c   开关 dos 兼容性标志

  常规
   d   删除分区
   F   列出未分区的空闲区
   l   列出已知分区类型
   n   添加新分区
   p   打印分区表
   t   更改分区类型
   v   检查分区表
   i   打印某个分区的相关信息

  杂项
   m   打印此菜单
   u   更改 显示/记录 单位
   x   更多功能(仅限专业人员)

  脚本
   I   从 sfdisk 脚本文件加载磁盘布局
   O   将磁盘布局转储为 sfdisk 脚本文件

  保存并退出
   w   将分区表写入磁盘并退出
   q   退出而不保存更改

  新建空磁盘标签
   g   新建一份 GPT 分区表
   G   新建一份空 GPT (IRIX) 分区表
   o   新建一份的空 DOS 分区表
   s   新建一份空 Sun 分区表


命令(输入 m 获取帮助)：p
Disk FD12FULL.img：512 MiB，536870912 字节，1048576 个扇区
单元：扇区 / 1 * 512 = 512 字节
扇区大小(逻辑/物理)：512 字节 / 512 字节
I/O 大小(最小/最佳)：512 字节 / 512 字节
磁盘标签类型：dos
磁盘标识符：0x00000000

设备          启动 起点    末尾    扇区   大小 Id 类型
FD12FULL.img1 *      63 1048319 1048257 511.8M  6 FAT16

命令(输入 m 获取帮助)：q

```

```bash
:(-$  sudo mount -o loop,offset=$((63*512)) FD12FULL.img /tmp/tmp
^_^-$  p /tmp/tmp
^_^-$  l
^_^-$  l -l
```

```log
COMMAND.COM*  KERNEL.SYS*  FDSETUP/  SETUP.BAT*  AUTOEXEC.BAT*  FDCONFIG.SYS*

总用量 152K
-r-xr-xr-x 1 root root  66K  8月 28  2006 COMMAND.COM*
-r-xr-xr-x 1 root root  46K  5月 11  2016 KERNEL.SYS*
drwxr-xr-x 8 root root 8.0K 12月 20  2016 FDSETUP/
-rwxr-xr-x 1 root root 6.3K  5月  6  2016 SETUP.BAT*
-rwxr-xr-x 1 root root 1.9K 12月 20  2016 AUTOEXEC.BAT*
-rwxr-xr-x 1 root root  225 12月 20  2016 FDCONFIG.SYS*
```


> 参考：

+ Linux Shell 脚本攻略
+ [linux系统中如何打开察看img文件内容](https://blog.csdn.net/weixin_34343689/article/details/91506135)

