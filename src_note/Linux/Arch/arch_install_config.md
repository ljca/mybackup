<link href="../../css/style.css" rel="stylesheet" type="text/css" />


# Arch Linux 的安装配置笔记

> *本次安装的 Arch Linux 从 UEFI 启动，使用纯 UEFI & GPT 引导[^uefi][^secure_boot]的硬盘～ grub2 引导加载器，init 使用的是 systemd；*

**你必须已经准备好了引导盘[^boot]，可以是可启动的 U 盘，光盘，甚至如果你有系统镜像并且系统上已经安装了某一个 Linux 发行使用 GRUB2 引导，你还可以直接使用 GRUB2 引导。同时，你还可以选择从网络引导。**

## Start Install[^start]

### set network

```Bash
systemctl restart dhcpcd@enp2s0.service
# 或者
systemctl stop dhcpcd@enp2s0.service
ifconfig enp2s0f1 up
dhcpcd enp2s0f1 
```

>  `wifi-menu` 可以用来直接选择并连接到一个无线网络[^wifi_menu]。 参考：

+ [Arch Linux实现wifi和有线联网_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2016-11/137666.htm)
+ [archlinux 无线网卡资料一-heiyou-ChinaUnix博客](http://blog.chinaunix.net/uid-108863-id-136997.html)
+ [Network configuration (简体中文) - ArchWiki][network]
+ [NetworkManager (简体中文) - ArchWiki][nm]
+ [en_users_Documentation_iw - Linux Wireless](http://linuxwireless.org/en/users/Documentation/iw/)
+ [Wireless network configuration - ArchWiki](https://wiki.archlinux.org/index.php/Wireless_network_configuration#Manual_setup)
+ [Wirelessnetworkconfiguration简体中文-ArchWiki][wireless]

[nm]: https://wiki.archlinux.org/index.php/NetworkManager_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[network]: https://wiki.archlinux.org/index.php/Network_configuration_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)#.E5.90.AF.E7.94.A8.E5.92.8C.E7.A6.81.E7.94.A8.E7.BD.91.E7.BB.9C.E6.8E.A5.E5.8F.A3
[wireless]: https://wiki.archlinux.org/index.php/Wireless_network_configuration_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)

### Update system date and timezone

> **请务必确认系统时钟正确与否，因为系统时钟错误将会产生非常严重的后果。。。**

```Bash
# 使用hwcolock或者clock工具。
hwcolok --show|-r 显示硬件时间 -s 将硬件始终设置为当前时钟。
date -s "2016-1-10 20:00:00" && hwcolock -w --localtime

# Or 使用`ntp`同步时间服务器更新系统时间。或者 直接使用date工具来更改，然后写入BIOS
timedatectl set-ntp true
timedatectl set-time "" 
timedatectl set-localtime-rtc true
```

### Set mirrorlist

```Bash
cd /etc/pacman.d
grep -i -A1 "china" mirrorlist | vim -
# 编辑软件源配置文件之后需要初始化源和软件源钥匙环文件(gpg)
#pacman-key --init && pacman-key --populate archlinux
pacman -Syy
```

### Set partitions
我们假定你使用 UEFI[^uefi] 来引导系统，并且`EFI启动分区`[^boot_efi]在磁盘上已经存在。准备`Arch Linux`分区。我的分区规划是：

- /
- home
- swap [^swap]

```Bash
cfdisk /dev/sda
mkfs -t ext4 -L "Arch" /dev/sda3 
mkfs -t xfs -L "Home" /dev/sda7
# 
mkswap -L Swap /dev/sda9
swapon /dev/sda9
# 
mkdir -pv /mnt/{home,boot/efi} /media/tmp
mount /dev/disk/by-label/Arch /mnt
mount -t xfs /dev/disk/by-label/Home /mnt/home
mount /dev/sda1 /mnt/boot/efi
mount -v --bind /media/Others /mnt/media/tmp
```

```Bash
mkdir -pv /mnt/boot/efi
mount -vw -t vfat /dev/sda1 /mnt/boot/efi #将系统efi分区挂载到/mnt/boot/efi目录下

```

### Install the base system

```Bash
pacstrap [-i] /mnt base base-devel net-tools
```

## *[Chroot][chroot]*

>***Chroot 之前必要的准备工作:  安装必要的工具并复制 /etc/resolv.conf 到新系统***

```Bash
# 如果你不使用 wifi-menu，dialog 现阶段就是没有必要安装的。
pastrap -i --needed /mnt iproute2 iw wpa_supplicant wireless_tools
cp -Libv /etc/resolv.conf /mnt/etc/
pacstrap -i --needed /mnt vim 
```

+ 配置更新文件系统挂载表[/etc/fstab][fstab]

```Bash
# genfstab脚本从指定的根生成文件挂载表文件/etc/fstab # create fstab use volume label
genfstab -p -L /mnt >> /mnt/etc/fstab
less /mnt/etc/fstab
```

> 准备 chroot，arch-chroot 脚本已经正确配置了 chroot 环境。  `arch-chroot /mnt /bin/bash`

[fstab]: https://wiki.archlinux.org/index.php/Fstab_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)

## Configure System

```Bash
ln -sfv /usr/share/zoneinfo/Asia/Shanghai /etc/localtime
date -s ""
hwcolock -w --localtime

echo LANG='"en_US.UTF-8"' > /etc/locale.conf
grep -iE 'zh_CN|en_US' /etc/locale.gen | vim - && locele-gen
echo '' > /etc/hostname
vim /etc/hosts
```

```Bash
# Add new users and change the password....

# Install 常用 Program
.....
```
### 安装 Grub[^grub]

```
# Install Grub to the Disk boot partition And Update Grub Configure
pacman -S --needed os-prober grub efibootmgr dosfstools
grub-install --target=x86_64-efi --efi-directory=/boot/efi --bootloader-id=boot --boot-directory=/boot/efi/EFI/boot --compress="xz" --debug

cd /boot/efi/EFI/boot
mv -ibv grubx64.efi bootx64.efi 
# Or grub-mkstandalone --directory="/usr/lib/grub/x86_64-efi" --format="x86_64-efi" --compress="xz" --output="arch_grub.efi" "boot/grub/grub.cfg=/tmp/grub.cfg"
# Then Update Grub Configure:
grub-mkconfig -o /boot/efi/EFI/boot/grub/grub.cfg
```

```Bash
# 生成内核镜像和系统初始化镜像
mkinitcpio -p linux

sync;sync;sync;sync;sync;sync;sync;

# exit Or Ctrl D 

# -R 选项可以递归卸载
umount -R /mnt
reboot
```

> 参考：

+ [Installation guide (简体中文) - ArchWiki][guide]
+ [Arch based distributions (active) (简体中文) - ArchWiki][base_install]
+ [archlinux2015](http://my.oschina.net/wzkiron/blog/511458)
+ [Arch Linux 安装指南2016](http://bbs.archlinuxcn.org/viewtopic.php?id=1037)
+ [archlinux201501版，最小化精减安装的步骤要点，系统大小在1G内_老圃无蔓_新浪博客](http://blog.sina.com.cn/s/blog_69e5d8400102vp00.html)
+ [Archlinux安装笔记 - 时光旅行的懒猫 - 博客园]( http://www.cnblogs.com/timeship/archive/2013/02/28/2937635.html)
+ [Archlinux 安装教程 - 撸代码 - LuCode](http://blog.lucode.net/linux/archlinux-install-tutorial.html)
+ [把Arch Linux安装到U盘上的具体教程_LINUX_操作系统_脚本之家](http://www.jb51.net/LINUXjishu/401298.html)

[guide]: https://wiki.archlinux.org/index.php/Installation_guide_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[base_install]: https://wiki.archlinux.org/index.php/Arch_based_distributions_(active)_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)


## 桌面环境的配置

一键恢复从系统源中安装的软件： `pacman -S --needed $(cat pacqnq.log)`

> 参考：

+ [General recommendations (简体中文) - ArchWiki][general_recom]
+ [Archlinux CN 镜像源使用帮助 [LUG@USTC]](https://lug.ustc.edu.cn/wiki/mirrors/help/archlinuxcn)
+ [Arch Linux 下Intel + NVIDIA 双显卡3D 游戏配置（dota2@steam） - 河 的 第 三 条 岸 - 博客频道 - CSDN](http://blog.csdn.net/ispeller/article/details/37765999)
+ [Archlinux中文化－－怎么显示中文的界面](http://www.360doc.com/content/12/0713/15/6828497_223986769.shtml)
+ [Arch Linux Localization (简体中文) - ArchWiki][arch_localization]
+ [在 Arch Linux 上安装 XFCE - ReJaVu的个人页面](https://my.oschina.net/ReJaVu/blog/182581?p=1)
+ [Arch Linux办公环境安装配置纯小白包通过教程_沉沦的菩提_新浪博客](http://blog.sina.com.cn/s/blog_6379f4350102wicg.html)
+ [Arch Linux安装后的一些初始设置简介_LINUX_操作系统_脚本之家](http://www.jb51.net/LINUXjishu/401340.html)
+ [对《Arch Linux办公环境安装配置纯小白包通过教程》的补充，关于无线和蓝牙_沉沦的菩提_新浪博客](http://blog.sina.com.cn/s/blog_6379f4350102wifv.html)
+ [infinality-bundle_ good looking fonts made (even) easier _ Community Contributions _ Arch Linux Forums](https://bbs.archlinux.org/viewtopic.php?id=162098)
+ [Fonts (简体中文) - ArchWiki][fonts]
+ [Font configuration (简体中文) - ArchWiki][fonts_conf]
+ [Power management (简体中文) - ArchWiki][pm]
+ [创建自己的软件仓库][ur]

[arch_localization]: https://wiki.archlinux.org/index.php/Arch_Linux_Localization_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[general_recom]: https://wiki.archlinux.org/index.php/General_recommendations_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[fonts]: https://wiki.archlinux.org/index.php/Fonts_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[fonts_conf]: https://wiki.archlinux.org/index.php/Font_configuration_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[pm]: https://wiki.archlinux.org/index.php/Power_management_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[ur]: https://wiki.archlinux.org/index.php/Unofficial_user_repositories_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)#archlinuxcn

> 优化：

+ [CPU frequency scaling (简体中文) - ArchWiki][cpu_freq]
+ [Daemons List (简体中文) - ArchWiki][daemons]
+ [Display Power Management Signaling (简体中文) - ArchWiki][dpms]
+ [Laptop Mode Tools (简体中文) - ArchWiki][laptop]
+ [pm-utils (简体中文) - ArchWiki][pm-utils]
+ [tmpfs - ArchWiki](https://wiki.archlinux.org/index.php/Tmpfs)
+ [Kernel parameters (简体中文) - ArchWiki][kernel]
+ [Arch boot process (简体中文) - ArchWiki][boot_process]
+ [Kernelmodule-ArchWiki][kernel_module]

[cpu_freq]: https://wiki.archlinux.org/index.php/CPU_frequency_scaling_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[daemons]: https://wiki.archlinux.org/index.php/Daemons_List_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[dpms]: https://wiki.archlinux.org/index.php/Display_Power_Management_Signaling_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[laptop]: https://wiki.archlinux.org/index.php/Laptop_Mode_Tools_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[pm-utils]: https://wiki.archlinux.org/index.php/Pm-utils_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[kernel]: https://wiki.archlinux.org/index.php/Kernel_parameters_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[boot_process]: https://wiki.archlinux.org/index.php/Arch_boot_process_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[kernel_module]: https://wiki.archlinux.org/index.php/Kernel_module#Blacklisting

-------------------------------
# 附

## *`Chroot环境`* ：配置虚拟文件系统（可选）[^option]

[^option]: 据称，只要 Bash 的版本合适，这些虚拟文件系统甚至可以不必配置。

如果没有 arch-chroot 脚本，你就需要手动(正常的chroot环境包括根 /  分区，home分区(这并不是必须的)以及(Live系统环境)挂载必需的虚拟文件系统（它们包括 ： devtmpfs      dev/pts   proc    sys      run）。这些虚拟文件系统对于系统来说是必须的，其中某些需要使用绑定挂载。

+ dev：`mount --bind -v /dev /mnt/dev`
+ dev/pts： `mount -vt devpts devpts /mnt/dev/pts`
+ proc：`mount -vt proc none /mnt/proc`
+ sys：`mount -vt tmpfs tmpfs /mnt/sys`
+ run：`mount -vt tmpfs tmpfs /mnt/run`

手动chroot：`chroot /mnt /bin/bash`

> 参考：  [Change root (简体中文) - ArchWiki][chroot]

[chroot]: https://wiki.archlinux.org/index.php/Change_root_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)

## 软件包[列表](list.md)，[List of applications (简体中文) - ArchWiki][list_package]

*`Install Arch Linux base system  from USB, 2017-1-21 16:40:00`*

[list_package]: https://wiki.archlinux.org/index.php/List_of_applications_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)#.E6.88.AA.E5.8F.96.E5.B1.8F.E5.B9.95

--------------------------------

# FAQ

[^uefi]: 你可以在 [UEFI WIKI] 获得关于 UEFI 和 BIOS 的详细解释。如果你不打算使用 UEFI，那么以下的磁盘分区方案和 grub 安装引导方式将不适合您的计算机，你可能需要再次查看 Arch Linux wiki. boot目录下用于安装系统内核和初始化文件系统，这个目录名称最好不要随意更改,为了不将引导和内核混在一起，`/boot/efi`。

[^secure_boot]: 一般而言，安装 Linux 并不困难，不过安全引导（secure boot）和快速启动（quick boot）都会使 UEFI 跳过 Linux 的引导。安全引导[^secureboot]并非不可引导 Linux（实际上，经过特殊处理过的 efi 也可引导操作系统。不过，使用 secure boot 引导的 Windows 没法在系统启动时加载一些需要使用注册表加载的自启程序），你只要在 UEFI 设置中添加自己信任的 efi 引导文件后适当的调整一下引导顺序即可，然后就无需理会 Windows Boot Manager（是的，完全无需理会！也不用去管 Windows 的 bcdedit 了。我甚至还在 EFI 目录下改掉了 Microsoft 这个名字，只因不想 UEFI 发现 Windows 自带的 Windows Boot Manager 并尝试加载它）。当然，这有可能需要更新 BIOS。如果你更新了 BIOS 还是没能发现添加 efi 的选项，并且无所谓那个病毒的恐吓，我建议还是禁用掉 secure boot 吧。

[^boot]: 制作启动盘的方式是多样的。在 Linux 上，你可以直接使用 dd 或者 cat。 在 Windows 上，可以试下 rufus（旧版软碟通并不支持UEFI方式启动）。不过你要是希望被用作启动盘后的 U 盘还可以作为普通的磁盘读写，可以试下转换 U 盘分区表到 GPT（哦，对了，转换分区表并不需要对U盘重新格式化），在 Windows 平台，无损转换分区表的软件有很多。转换 U 盘分区表为 GPT 之后（这种方式同样支持 windows 8），并创建一个 fat32 的首分区（为了可以用来安装 Windows 8.1，我分给了它足足 4 个多 G 的空间。至于为什么还要弄其它分区，那是因为 Fat32 限制了单个文件的大小超过 4G）。然后挂载 U 盘首分区和 Arch Linux iso 并复制ISO镜像中的所有目录和文件到刚才创建好的 fat32 分区根目录下(最好备份U盘文件，也可以将之前文件和目录集中放到一个临时目录下，为了避免与系统文件和目录出现混淆，另外，重设卷标)，当然，这只适合 UEFI GPT 硬盘的的启动以及引导方式。

[^start]: **我们假定你已经准备好了启动盘和规划好了系统分区，后期版本的Arch系统并没有提供安装框架(伪图形界面的安装引导程序)；所以，在这里，所有安装任务都需要使用命令（会有一份详细指南）完成。Live系统默认采用的shell是zsh,并且提供了bash，/root 目录下的 install.log 简要的叙述了安装步骤。 如果一切顺利，将会出现Arch的引导菜单(如果使用自定义的制作启动盘的方式，并且没有将U盘卷标设为镜像文件挂载之后的卷标，则务必编辑引导菜单中的label的值部分（或者，可以不用 label 而是直接用设备名或者是 UUID 什么的）,在这里，默认值为系统名称和发行时间。lable值应该和 U 盘卷标一样)，然后回车引导系统；如果顺利，系统将会初始化多个虚拟控制台，并且在第一个控制台tty1出现一个命令提示符并以 root 用户自动登录，否则会卡在挂载文件系统这一项系统任务上。**

[^wifi_menu]: 有时候，对于使用 wpa+ 加密的无线网络，我更愿意使用 wpa_supplicant 和 dhcpcd，因为 wifi_menu 不认识中文的 ESSID 。

[^swap]: 我们非常建议你启用一个交换分区（即使你的计算机拥有足够多的内存而又不打算休眠系统，那么设置交换空间这种做法看上去好像很鸡肋），不过 Linux 用作开发，在编译某些大型软件时，交换分区还是很有用的。不必太大，当然，如果内存不是很富足，不应该尝试使用交换分区来代替物理内存，那是没有用的。

[^efi]: **如果你打算用其它系统的 grub 来引导，那就可以不用安装和挂载 EFI～**

[^boot_efi]: 没有 EFI 分区而又打算使用 UEFI 启动，创建 EFI 系统分区：`mkfs.vfat -F32 -s1 -n ESP /dev/sda1`

[^secureboot]: 有资料显示这是为了阻止某种病毒。UEFI 默认引导管理器的 efi 文件存放的位置和名称总是固定的（`EFI/boot/bootx64.efi`，这是 64 位的），除非使用另外的方式。据说这是为了解决 MBR 的弊端。每一个组织都希望用自己的引导管理器来引导其它的操作系统，因此，如果是在安装 Windows 之前安装的 Linux，就算是安装了其它的引导管理器，如果没有进行配置，依旧不能进入 Linux。Windows Boot Manager 会将原来的引导管理器覆盖掉（是的，覆盖掉，并且还不会去搜索硬盘上的其它非 Win 系统。一旦出现这种事情，那就不得不重新安装可以发现硬盘上所有 OS 的引导管理器，我们称之为`引导修复`）。

[^grub]: grub 就是一个可以用来搜索并引导硬盘上 OS 的引导管理器。在 grub 没有出现之前， loli 担任了这个任务。而 syslinux 是一种驱动。
