#  Loop Device：a magic device（奇妙的环回设备）。

&nbsp;&nbsp;  我们还可以将一个文件来作为磁盘读写，做法与创建交换文件作为操作系统交换空间类似,其原理是将这个文件全用0来填充，然后将它像磁盘一样格式化，但挂载时需要将它挂载为环回设备。 我们首先需要使用 **`dd`** 指令[^dd]创建一个由特殊字符 '\0' 填充的数据文件[^size]，特殊设备 `/dev/zero` 可以完成这个任务。 `mkdir tmp;dd if=/dev/zero of=tmp/loop.iso bs=1024M count=1`

[^dd]: 

[^size]: 由于系统占用，实际空间可能会比这更小,这里使用了iso来做为文件的扩展名，但实际上这只是一个具有iso扩展名的伪光盘映像文件，上面并没有光盘镜像文件所独有的iso9660文件系统,而且事实上这种文件系统是只读的。按照我的理解，这个特殊的文件扩展名应该是随意的，或者干脆就不需要有。Linux也不是使用文件的扩展来判断文件类型的(除了某些应用软件)。

 &nbsp;&nbsp;在这个特殊的文件上创建文件系统 `sudo mkfs -t ext4 -L "Loop" tmp/loop.iso` 。将它以环回设备挂载 `mkdir loop;sudo mount -o loop ./loop tmp/loop.iso`。

&nbsp;&nbsp;为了不与系统动态创建的环回设备混淆，我们可以手动创建一个环回设备 `sudo mknod /dev/loop8 b 7 8`。同时，将手动创建的环回设备和那个存在文件系统的特殊文件映射,设置环回设备 ` sudo losetup /dev/loop8 tmp/loop.iso` 。这样就可以直接挂载环回设备，而不需要使用-o loop的方式；如果有必要， 如果将这个文件放到了U盘，并且还将它与一个环回设备相关联了，那么在卸载U盘时需要先取消它与环回设备的关联之后才能卸载U盘。否则卸载U盘时会弹出一个设备忙的消息。

```Bash
sudo umount -v ./loop
sudo losetup -d /dev/loop8
```

&nbsp;&nbsp;为了使这个特殊文件像一个真正的磁盘那样可以创建多个可读写的分区，我们还需要设置对文件分区并设置偏移量了。 将文件设置为一个环回设备之前，我们可以根据需要手动创建几个环回设备：

```Bash
sudo mknod /dev/loop9 b 7 9
sudo mknod /dev/loop10 b 7 10
sudo mknod /dev/loop11 b 7 11
....
```

&nbsp;&nbsp; 将一个文件(假设这个文件已经成功创建了,可以稍大，比如8G以上)设置到一个环回设备上 `sudo losetup /dev/loop9 tmp/loop2.iso`；现在的/dev/loop9已经可以作为一个全新的磁盘来处理了,使用一个磁盘分区工具比如fdisk，或者cfdisk,parted等来创建这个特殊磁盘的分区表和分区 `sudo fdisk /dev/loop9`。

 &nbsp;&nbsp;继续使用环回设置命令losetup设置创建好的分区，但要使用不同的环回设备且要使用-o选项来设置偏移量(以字节单位,不正确的偏移量可能会让设置好的分区无法挂载和使用),具有MBR分区表的磁盘应该从第63个扇区开始,第1个扇区保存了硬盘的MBR,随后的62个扇区是保留扇区，这一部分貌似不可用。

>  设置第一个分区 `sudo losetup -o 32256 /dev/loop10 tmp/loop2.iso `

>  设置第二个分区 `sudo losetup -o 偏移量 /dev/loop11 /tmp/loop2.iso`

>  依次为它们创建文件系统

```Bash
sudo mkfs -t ext4 -L "Loop2" /dev/loop10 
sudo mkfs -t ext4 -L "Loop3" /dev/loop11
```

file命令可以将这些已经被特殊处理过的"特殊文件"识别出来 `file tmp/*.iso`

```
tmp/loop.iso: Linux rev 1.0 ext4 filesystem data (needs journal recovery) (extents) (huge files)
```

> 参考：

+ Linux Shell 脚本攻略

