# mount：挂载磁盘或者分区

**&nbsp;&nbsp;现代 Linux 一般直接给文件管理器配置了 `gvfs`[^gvfs]，这也就意味着：你不需要终端模拟器就可以随时在文件管理器中方便地进行挂载和卸载某个分区或者某个磁盘。**

[^gvfs]: 如果你需要在插入 移动磁盘后让系统的文件管理器可以自动挂载它，安装 `gvfs` 以及所需的`文件系统工具和模块`并启用`默认文件管理器的卷管理并配置可移动驱动器。`

&nbsp;&nbsp;如果你不得不手动挂载[^mount]某一个分区或者某个磁盘（指令类似： `mount [选项] 块设备 挂载点`），为此，你需要在挂载之前知晓那个磁盘分区和挂载点[^mount_point]信息。当然，个人 Linux 一般都可以不用使用选项[^opt]就能直接挂载其它分区，除了 fat 系文件系统。 


**&nbsp;&nbsp;如果你希望查看磁盘和分区信息，没有问题。Linux 上已经有很多个这样的工具了。你可以使用不需要超级用户权限[^root_perm]的 `lsblk` 以树型目录显示磁盘和分区信息，也可以使用需要以根用户权限执行的 `blkid` 以及 `fdisk -l` 的指令查看分区的信息：包括卷标，分区UUID和类型以及文件系统类型。甚至，你还可以直接查看 `/dev` 下的设备文件（现代Linux使用的udev会在设备插入时自动检测并创建可用的持久化块设备文件)： `ll /dev/[s,h]d* /dev/disk/by-{label,uuid,}`。**

> e.g：

```Bash
mkdir ./vfat -pv
mount -t vfat -o rw,flush,utf8=1,iocharset=iso8859-1,uid=$UID /dev/sdb1 ./vfat
mount -t vfat -o rw,utf8,uid=$UID /dev/disk/by-label/tmp ./vfat
```

> `mount`：

```

/dev/sdb1   /media/TMP    vfat rw,nosuid,nodev,relatime,fmask=0022,dmask=0077,codepage=cp437,iocharset=ascii,shortname=mixed,utf8,flush,errors=remount-ro  0  0 

/dev/sdb2         /media/tmp        ext4 rw,seclabel,nosuid,nodev,relatime,barrier=1,data=ordered 0  0

/dev/sdb1 on /media/tmp type vfat (rw,nosuid,nodev,utf8=1,flush)
/dev/sdb1 /media/tmp vfat rw,nosuid,nodev,relatime,fmask=0022,dmask=0022,codepage=cp437,iocharset=ascii,shortname=mixed,utf8,flush,errors=remount-ro 0 0 
```

[^mount]: 在 Linux 系统上，手动挂载一个磁盘或者分区是一件很繁琐的事儿，特别是文件系统还是vfat(exfat,fat16/fat32..)系列时。在没有安装配置 gvfs 和所支持的文件系统驱动模块并启用系统默认文件管理器的`卷管理`之前，一些系统的文件管理器在检测到可移动磁盘插入之后不会自动挂载它.(即使已经在系统设置中勾选了，这也不会生效)。在 gvfs 没有出现之前，你可能会厌倦手动挂载因为 Windows 而出现的各种文件系统（Vfat 系列的（包括 Extfat） ，NTFS 的），如果这些系列的文件系统是以默认选项挂载的，可能会出现各种令人头疼的问题：文件名乱码，文件内容也乱码，然后就是权限引起的问题（这方面，vfat 很常见）。你不得不寻求查看手册页，然后以合适的选项重新进行挂载。

[^opt]: -o 选项允许使用逗号分隔多个选项，不过，只有 root 用户，才能使用这个选项。块设备除了可以是获取的块设备持久化名外，还可以是卷标和UUID(当然得是以/dev/disk/by..开始的绝对路径)。uid 选项可以让普通用户正常使用磁盘而没有权限问题，iocharset和utf8选项使系统可以正常处理中文字符集。nouser 选项允许任何用户卸载移动U盘。尽管UUID对于磁盘和磁盘分区是唯一的标识符，但对于我来说仍然不习惯使用(那一串长长的由数字和字母组成的标识符让我望而生畏。），相较于UUID，卷标(volume)显然可读性更强，对于人类而言。而且更重要的是，一旦磁盘分区被重新格式化，分区的UUID就会重新被设置(这让我实在有点厌烦，因为如果没有及时更新系统的分区挂载表，启动系统就会进入一个所谓的安全shell。)，唯一变化不勤快的是卷标，我习惯格式化磁盘分区时也给一个卷标。


[^mount_point]: 比如分区卷标或者块设备持久化设备名，要把磁盘或者分区挂到哪儿。所谓的挂载点其实就是一个目录,理论上讲可以是除系统核心目录以外的任意位置(针对系统所谓的移动磁盘标准挂载点/media /mnt而言)，但这个目录最好应该是一个空目录。(不是空的其实也无所谓。如果将一个磁盘分区手动挂载到一个非空目录下，系统出于保护的原因，会让那个非空目录下原本的文件暂时隐藏而无法访问，直到挂载的分区被卸载时才会被系统释放)； mount 手册页提供了更多的用法和解释。

[^root_perm]: 因为blkid指令允许直接查看分区UUID，如果你没有使用根用户权限来执行，那也不会有任何问题。就是不会有任何输出，就像ip等可以操作配置网卡的工具一样。但是 `fdisk` 工具可以直接操作系统磁盘分区，因此必须以根用户权限执行，即使仅仅只是查看系统磁盘和分区信息也不行!

# umount：卸载磁盘或者分区

**&nbsp;&nbsp;你只需要给 umount 带上挂载时的挂载点或者是诸如 `/dev/sdb1` 一样的设备名就可以直接卸载分区了。如果你没有卸载掉，可以试试 -R 选项或者使用 `fuser` 或者 `lsof` 检查下是否存在着文件占用问题。如果你在挂载 fat 系文件系统时用了 nouser 选项，那还可以不用根用户权限就可以直接卸载掉 fat 系的文件系统。**
