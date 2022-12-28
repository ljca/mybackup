<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# Arch Linux 笔记

## [pacman：Arch Linux 软件包管理器](pacman.md)

# 附
## [安装 & 配置](arch_install_config.md)
## 让Arch Linux“滚回”到以前的版本

::: alert-info

<div class="p">

﻿也许`Arch Linux`滚动式发行的特点能让系统一下子就更新到最新状态，但不幸的是：并非所有的旧硬件(比如我的)都能适应这种变化。经过升级的软件包释出的一些新特性也许并不兼容`PC`机上的旧硬件。或者在使用之前至少需要对某其中的一项做出微小调整后才能正常工作。因此，此时的你也许对新版本的软件包并不感冒，而希望将它降级后使用。

`Arch Linux`中的某个软件包因为一些问题需要降级，可以从存档库中下载历史版本然后手动降级[^1]。然而，当我尝试从 Arch Linux 回滚机[^archive]上降级`Arch Linux`时，遇到了下面的一些问题[^problem]。

</div>

:::

```Bash
# shell
sudo pacman -Syy
```

> log::
 
```log
:: 正在同步软件包数据库...
错误：无法从 archive.archlinux.org : SSL certificate problem: certificate is not yet valid 获取文件 'core.db'
错误：无法升级 core (下载函数库出错)
错误：无法从 archive.archlinux.org : SSL certificate problem: certificate is not yet valid 获取文件 'extra.db'
错误：无法升级 extra (下载函数库出错)
错误：无法从 archive.archlinux.org : SSL certificate problem: certificate is not yet valid 获取文件 'community.db'
错误：无法升级 community (下载函数库出错)
错误：无法同步任何数据库
错误：无法初始化事务处理 (下载函数库出错)
```

```Bash
pacman -S sl
```

```log
正在解决依赖关系...
正在查找软件包冲突...

软件包 (1)  新版本  净变化  下载大小
community/sl  5.02-4  0.01 MiB  0.01 MiB
下载大小:   0.01 MiB
全部安装大小：  0.01 MiB
:: 进行安装吗？ [Y/n] 
:: 正在获取软件包......
错误：无法从 archive.archlinux.org : SSL certificate problem: certificate is not yet valid 获取文件 'sl-5.02-4-x86_64.pkg.tar.xz'
警告：无法获取某些文件
错误：无法提交处理 (下载函数库出错)
发生错误，没有软件包被更新。
error setting certificate verify locations:
```

::: alert-error

当然，如果你并不介意这些问题，那么则可以直接将源的地址写死到回滚机的某个时间点，然后尝试降级系统。

:::

=============== /etc/pacman.d/mirrorlist =================

```
# gcc 5.3
Server = https://archive.archlinux.org/repos/2016/05/01/$repo/os/$arch
```

```Bash
# 以根用户权限执行降级系统命令。为了顺利执行，可能需要先清除系统缓存
pacman -Scc
# 启用降级
pacman -Syyuu
```

遗憾的是：这样出问题的机率并不小。如果你希望回到以前而又不介意重装系统，则可以尝试进入`Arch Linux`的`Live CD`环境，将软件源设为回滚机的某一个时间点，重建缓存后开始基本系统的安装和配置工作。

```Bash
pacman -Scc

pacman -Syy

# 确认软件版本，如果能返回预期的结果，则可以开始：
pacman -Ss gcc

# Install and configure base system……
mount /dev/disk/by-label/Arch /mnt
pacstrap -i /mnt base base-devel net-tools wpa_supplicant dhcpcd
# ...
```

[^1]: 手动降级某个软件包时，pacman并不会顺带解决依赖问题。所以在降级时可以需要连其依赖一起降级。不过，AUR上提供了一个用来降级软件包的工具downgrade和downgrader。它们都可以根据需要降级指定的软件包并尝试解决依赖问题，而使用它们降级软件包时也只需要提供一个要降级的软件包名，然后从多个历史版本中选择一个版本就能降级这个软件包到某个历史版本。除了下载速度有些慢之外。如果你希望了解更多，请参考 Arch Linux 存档库维基。

[^archive]: 回滚机可以把系统“回滚”到以前的某种“状态”。不过，也许只有滚动式发行的才有，Arch Linux 的在[这里](https://archive.archlinux.org)。不幸的是：这同时也会降低系统的安全性。

[^problem]: 如果系统时钟错误，可能会无法正常访问网络……


<!-- 

# FAQ
## Arch Linux滚系统后pacman无法正常使用
[^archlinux]: Arch Linux 是一个比较"前卫"的滚动式(系统没有版本号，一条指令能更新系统中所有的软件到最新版本)Linux 发行，因为它使用的软件包版本始终都是最新的。

我在滚系统时收到了 pacman 因为依赖关系破坏的提示而导致无法更新任何软件包。不过呢，pacman 同步和移除软件包都有一个不被推荐使用的选项那就是在同步或者移除软件包时允许跳过所有的依赖关系检查(使用时只需传递两个 dd 选项给 pacman)。这样一来，就会出很多问题。

我果断的用了这个选项滚了系统，之后系统果然出了问题。连 pacman 都无法好好工作了，说是自己要的一个动态库(它找不到的那个动态库叫libnghttp2.so.14，虽然它也是一个符号链接)找不到了。怎么办呢？

首先，我用了常规解决方案，看看系统中有没有这个动态库？没有，那有没有这个软件包？没有？从 Arch Linux 官网上下一个。libnghttp2  属于 Core 的，而 pacman  的启动依赖于这个软件包。

因为 Arch Linux 的软件包实际上就是一个经过 tar 打包然后用 xz 压缩过的归档。所以解决方案就是直接解开软件包并将解开后的文件放到合适的位置(虽然放到 usr下再用 pacman 工作正常，但依然无法将缺的这个软件包装上，会提示已经存在同名文件，不过，为了让 pacman 工作正常，传递 --force 选项给 pacman 进行覆盖安装好了)放到 /usr/local 下更好或者其它位置，但需要进行另外配置。)之后，pacman 能正常工作了。这时重新安装安装 pacman 所缺的这个软件包已经没有了问题。虽然在 Live 环境的 pacstrap 也能完成这个工作，不过却是显得有些繁琐了。

## 为什么fcitx不显示输入候选框
当我启动`fcitx`尝试输入中文时，很奇怪，中文输入候选并没有被显示出来。再切换`fcitx`中英文状态时，也无任何提示与动静。

```Bash
#先杀掉 fcitx，再杀掉与之相关的进程。最后重启 fcitx。或者由窗口管理器或者桌面环境启动它更好。
pkill fcitx
ps aux|grep -v grep|grep fcitx
kill ...
fcitx
```

```log
fcitx
/usr/bin/dbus-daemon --fork --print-pid 4 --print-address 6 --config-file /usr/share/fcitx/dbus/daemon.conf
/usr/bin/fcitx-dbus-watcher unix:abstract=/tmp/dbus-XJ2UaZDEff,guid=76c012a9503a6d08e86385215a3bc192 13121
```

```Bash
sudo kill xxxx
rm -rf ~/.config/fcitx/{cached_layout,dbus}
```

## 为什么我的ArchLinux会莫名其妙的死机
> 最近几个月，我在使用 Arch Linux 时，遇到了一个问题：那就是当我的系统开机运行过一段时间后就会莫名其妙的死机，并会停止一切响应（不在响应鼠标和键盘输入（除了`Alt+Sysrq+reisub`））。

我对这个莫名其妙的问题觉得很困惑。我不知道这是怎么了，在我以前的 Arch Linux 系统上似乎从未遇到过这样的问题，但最近遇到这样的问题却很频繁。

我查询了一些资料。不幸的是，并没有找到适合我计算机系统的解决方案。为此……我尝试跟踪了一下系统日志： 但我很快发现这没什么用。

```Bash
# 假如你的 Linux 系统使用的 init 是 systemd 的话也可以尝试这么做：
journalctl -f | tee sys_faild.log

```

后来我无意注意到了引导参数的不同。我尝试重新阅读了`Wiki`上关于`intel-ucode`节的详细介绍并进行了一些测试，最后发现：我的计算机处理器不需要在系统引导时载入内核后更新所谓的微指令……

我的解决方案是：将`intel-ucode`包从系统中移除并更新了引导，重新引导系统之后测试发现：偶尔还是会死机。我发现是`laptopmode-tools`的电源管理方案和我的计算机系统冲突（假如我有时间的话也许还会尝试解决）。 因此，即便这个工具对笔记本很便捷我仍然选择将它从我的系统中移除了。

## 当我注销掉xfce4-session后再次启动xfce-session时，被lxdm拒绝.....
我遇到了一个问题，那就是当我注销掉 xfce4-session 然后尝试重新登录时，lxdm 就会弹出几个错误框并拒绝了启动 xfce4-session。

+ `未能与设置服务器联系`
+ `Failed to conencet socket /run/user/996/bus：拒绝连接`
+ `未能载入安全会话`
+ `未能确定安全会话名称。可能由于 xfconfd 没有运行(D-Bus设置问题)，未正确设置环境变量 $XDG_CONFIG_DIRS (必须包含 "/etc")或 xfce4-session 未正确安装。`

我重新建立了一个用户并尝试注销掉 xfce4-session 然后重新登录，结果一切正常。
然后我尝试查找 xfce4 的 xfconf 的配置文件(很顺利，它们就位于 ~/.config/xfce4/xfconf 目录下，是一组xml文档。备份它们之后删掉了原来的文件，然后注销掉会话并尝试重新登录系统(xfce4 除了要求重新配置 xfce4-panal 之外，其它的一切正常)。
后来我注意到，这些原因可能仅仅是因为我取消了注销系统而不必询问的选项，如果引起以上问题的真正的原因就是如此，那么解决方案会更简单，仅仅需要在 xfce4 设置的会话和启动中将注销方式设置为注销时提示就行了。

## 当我在terminal上输入汉字时，输入的汉字在terminal上却直接变成了unicode字符的编码
由于 fcitx 的某些 bug 让我很难受，我尝试使用了 ibus 输入法。但当我安装好 ibus 后从 fcitx 切换到了 ibus 时，ibus-setup 启动了 ibus 守护进程，一切似乎很顺利。但不幸的是，ibus 中文输入法敲出的中文字符在 terminal 上好像不能正常显示；再然后，无论使用那种输入法，在 terminal 上输入什么中文字符都会变成类似于下面这样：

\345\346\350\346\345\346\350\346\347\350\344\346\350\344\345\351\346\345\346\346\350\345\346

我觉得很不爽，我只是想要换一个输入法而已。

最后，我不得不清除了缓存 ~/.cache 目录和 fcitx 配置目录 ~/.config/fcitx 以及 ibus 用户配置文件并换回了 fcitx 拼音输入法。

## 用的好好的Arch Linux突然放不出了声音
用的好好的 Arch Linux 不知怎么突然没声音了，检查了驱动和固件一切正常。结果发现竟然是我不知道什么时候 Mute audio output，真是尴尬。

解决方法也简单的很，在 xfce4 面板上的 pulseAduio 插件取消勾选 Mute audio output 就行了.(如果没有找到这个插件的话可能需要先用 pacman 安装 xfce4-gooies 软件包组下的 xfce4-pulseaudio-plugin,并将它添加到 xfce4 面板上)

顺便说一句，xfce4 面板上的很多插件是可以配置为同时管理笔记本的亮度，声音控制快捷键(单独配置全局快捷键也是可以的，但没这方便)，当然，这需要正确安装了驱动和正确配置了面板插件(如果需要的话),不借助这个方法也是可以的，但那要复杂的多。

在仅安装了 Xfce4  桌面环境的 Arch Linux 系统上，一开始是不能使用亮度/声音全局控制键的(比如宏碁笔记本用来调节亮度的Fn ←/Fn → 和调节声音的Fn ↓/Fn ↑)，不过物理功能控制键(Fn F7.....)是正常的。

> ！！！![](../images/tips/tips.png) 属于`alsa-utils`的`speaker-test`可以用来测试喇叭是否工作正常。

## 当我的Arch Linux自动挂起之后被重新唤醒时，Thunar等Gtk程序的菜单（右键上下文和菜单栏）等变成了英文

> 这也许是锁屏工具带来的影响……

在我的 *Arch Linux* 上，屏幕保护程序不能很好的在我的计算上工作（或许是我的显示器原因导致的花屏问题），而用户级 .xprofile 却需要（或者类似）一个登录管理器的程序才能正常被读取，一些屏幕保护程序提供了此类功能，比如 *xscreensaver*。

如果系统语言设置成了英文的，而用户语言设置成了中文，使用的又不是此类锁屏软件（我用的是 *xtrlock*），可能会导致一些问题。

为了使用 *xtrlock*，我在 *xflock4* 脚本靠近首部处添加了下列行：

```bash
for lock_cmd in "xtrlock";do $lock_cmd -f -b &> /dev/null &\
  exit
done
```

问题就是只有手动挂起（一个叫做 xflock4 的 shell 脚本会在 xfce4 -session 手动注销或者挂起时被调用）才会正常锁屏，重新唤醒系统之后是正常的。

然而这对自动挂起无效，自动挂起然后重新唤醒系统之后就出现这种问题。

为了使用中文菜单，我只好选择注销之后重新登录或者手动挂起系统然后重新唤醒系统。原因可能是一些锁屏工具看起来有 GUI，但还是遵循了 Unix 哲学而设计。

--------------------------------
> user-dirs.dirs & user-dirs.locales 可能产生的影响……

当我启动 Linux 并使用 lxdm 进入 xfce 会话时，`xdg-settings`自动在我的用户主目录下生成了一系列用户目录并告诉我某些程序要用，然而，因为我的 Linux 用户主目录位于单独的分区上，因此，久而久之，里面有一堆的文件和目录。

我并需要其中的某些用户目录（但让我无奈的是，某些程序说它们需要用来存放数据，然后系统就帮忙创建了它们），我私下里认为假如我要存放一些文档，是不会把它们放到这儿的。因此我自作聪明的将 一些用户目录符号链接到了 windows 分区（在 windows 上可以共享)。不过不幸的是，一些程序还是受到了影响，比如 Thunar，vlc 等程序。它们在直接被打开时（某些从命令行传递 LANG 也不管用），UI 有可能会变作英文。 

我尝试重新设置了用户目录。以下是配置文件内容：

+ ![](../images/tips/conf.png) [$HOME/.config/user-dirs.dirs](../config/user-dirs.dirs)
+ ![](../images/tips/conf.png) [$HOME/.config/user-dir.locale]()

```config
en_US
```

--------------------------------------------
> Note：不正确设置用户目录可能让应用程序的国际化受到影响。当国际化失败时，可以尝试：

 + 保存会话后注销重新登录
 + 检查用户目录是否正确配置
  
## 当我启动Arch Linux时，我发现了一些晦涩难懂的错误消息

> 通过查看日志时发现了更多的错误

```Bash
sudo journalctl -p 3 -xb --no-hostname --no-pager
```

```log
6月 01 12:07:53 kernel: usb 1-5: string descriptor 0 read error: -22
6月 01 12:07:53 kernel: ACPI Error: [\_SB_.PCI0.LPCB.H_EC.ECWT] Namespace lookup failure, AE_NOT_FOUND (20160930/psargs-359)
6月 01 12:07:53 kernel: ACPI Error: Method parse/execution failed [\_TZ.FN00._ON] (Node ffff88015a0ec640), AE_NOT_FOUND (20160930/psparse-543)
6月 01 12:07:53 kernel: ACPI Error: [\_SB_.PCI0.LPCB.H_EC.ECWT] Namespace lookup failure, AE_NOT_FOUND (20160930/psargs-359)
6月 01 12:07:53 kernel: ACPI Error: Method parse/execution failed [\_TZ.FN00._ON] (Node ffff88015a0ec640), AE_NOT_FOUND (20160930/psparse-543)
6月 01 12:07:53 kernel: acpi PNP0C0B:00: Failed to set initial power state

6月 01 12:07:53 kernel: ACPI Error: [\_SB_.PCI0.LPCB.H_EC.ECRD] Namespace lookup failure, AE_NOT_FOUND (20160930/psargs-359)
6月 01 12:07:53 kernel: ACPI Error: Method parse/execution failed [\_TZ.TZ00._TMP] (Node ffff88015a0ef438), AE_NOT_FOUND (20160930/psparse-543)
6月 01 12:07:53 kernel: ACPI Error: [\_SB_.PCI0.LPCB.H_EC.ECRD] Namespace lookup failure, AE_NOT_FOUND (20160930/psargs-359)
6月 01 12:07:53 kernel: ACPI Error: Method parse/execution failed [\_TZ.TZ01._TMP] (Node ffff88015a0ef4d8), AE_NOT_FOUND (20160930/psparse-543)
6月 01 12:07:56 laptop-mode[1056]: Failed to set power saving mode for wireless card

6月 01 12:22:16 NetworkManager[3495]: <error> [1496290936.3023] dispatcher: could not get dispatcher proxy! Error calling StartServiceByName for org.freedesktop.nm_dispatcher: GDBus.Error:org.freedesktop.systemd1.NoSuchUnit: Unit dbus-org.freedesktop.nm-dispatcher.service not found.
6月 01 12:22:50 laptop-mode[4629]: Failed to re-set power saving mode for wireless card
6月 01 14:21:17 sudo[11083]: pam_unix(sudo:auth): conversation failed
6月 01 14:21:17 sudo[11083]: pam_unix(sudo:auth): auth could not identify password for [hcra]

6月 01 15:50:11 kernel: ACPI Error: [\_SB_.PCI0.LPCB.H_EC.ECWT] Namespace lookup failure, AE_NOT_FOUND (20160930/psargs-359)
6月 01 15:50:11 kernel: ACPI Error: Method parse/execution failed [\_TZ.FN04._OFF] (Node ffff88015a0ecc80), AE_NOT_FOUND (20160930/psparse-543)
6月 01 15:50:11 kernel: ACPI Error: [\_SB_.PCI0.LPCB.H_EC.ECWT] Namespace lookup failure, AE_NOT_FOUND (20160930/psargs-359)
6月 01 15:50:11 kernel: ACPI Error: Method parse/execution failed [\_TZ.FN03._OFF] (Node ffff88015a0ec140), AE_NOT_FOUND (20160930/psparse-543)
6月 01 15:50:11 kernel: ACPI Error: [\_SB_.PCI0.LPCB.H_EC.ECWT] Namespace lookup failure, AE_NOT_FOUND (20160930/psargs-359)
6月 01 15:50:11 kernel: ACPI Error: Method parse/execution failed [\_TZ.FN02._OFF] (Node ffff88015a0ecf50), AE_NOT_FOUND (20160930/psparse-543)
6月 01 15:50:11 kernel: ACPI Error: [\_SB_.PCI0.LPCB.H_EC.ECWT] Namespace lookup failure, AE_NOT_FOUND (20160930/psargs-359)
6月 01 15:50:11 kernel: ACPI Error: Method parse/execution failed [\_TZ.FN01._OFF] (Node ffff88015a0ec398), AE_NOT_FOUND (20160930/psparse-543)
6月 01 15:50:14 kernel: ACPI Error: [\_SB_.PCI0.LPCB.H_EC.ECWT] Namespace lookup failure, AE_NOT_FOUND (20160930/psargs-359)
6月 01 15:50:14 kernel: ACPI Error: Method parse/execution failed [\_TZ.FN00._OFF] (Node ffff88015a0ec168), AE_NOT_FOUND (20160930/psparse-543)
```

其中有几个错误都和 laptopmode-tools 直接有关，因此我首先尝试了禁用掉了 laptop-mode 服务： `sudo systemctl disable laptop-mode.service`，但我很快发觉这并没有什么用，重新引导系统后，最初出现的错误依旧没有消失。很困惑，有人认为这可能跟位于主板上的`BIOS`存在一定的关联性，难道是因为我的计算机更换了主板后一直没有更新`BIOS`的原因吗？或许我应该尝试更新一下它？

-->

## 怎样在 Arch Linux 安装 Rhythmcat[^rhythmcat]？

<!--
gstreamer [源码树](https://gstreamer.freedesktop.org/src/). gstreamer [项目地址](https://gitlab.com/gstreamer-sdk/). gstreamer0.10-plugins-good-0.10.31 [补丁](https://patchwork.openembedded.org/patch/35979/). 

gstreamer0.10-plugins-good-0.10.31 编译[出错][20]。
-->

[^rhythmcat]: Rhythmcat 是开源项目，作者已经提交到 github。可选择克隆安装。当然，如果系统是 Arch Linux，AUR 上也有人提交了 PKGBUILD。


> 以下是一些无关的链接：

<div class="pages">

- [怎样在 Arch Linux 构建一个简单的软件包？](structure_pkg.md)
- [ACPI modules (简体中文) - ArchWiki](#)
- [Advanced Linux Sound Architecture (简体中文) - ArchWiki](#)
- [Arch based distributions (active) (简体中文) - ArchWiki](#)
- [Arch boot process (简体中文) - ArchWiki](#)
- [archlinux201501版，最小化精减安装的步骤要点，系统大小在1G内_老圃无蔓_新浪博客](#)
- [archlinux2015.09.01基本系统安装 - wzk的个人页面 - 开源中国社区](#)
- [Archlinux CN 镜像源使用帮助 [LUG@USTC]](#)
- [Arch Linux Localization (简体中文) - ArchWiki](#)
- [Archlinux安装笔记 - 时光旅行的懒猫 - 博客园](#)
- [Arch Linux安装后的一些初始设置简介_LINUX_操作系统_脚本之家](#)
- [Archlinux 安装教程 - 撸代码 - LuCode.net](#)
- [ArchLinux安装完没有声音之解决办法 - 待一切尘埃落定 - SegmentFault](#)
- [Arch Linux 安装指南[2016.01] _ 安装问题 _ Arch Linux 中文论坛](#)
- [ArchLinux 的 pacman 命令详解 - 开源中国社区](#)
- [Arch Linux实现wifi和有线联网_Linux教程_Linux公社-Linux系统门户网站](#)
- [archlinux 无线网卡资料一-heiyou-ChinaUnix博客](#)
- [Archlinux 下Intel + NVIDIA 双显卡3D 游戏配置（dota2@steam） - 河 的 第 三 条 岸 - 博客频道 - CSDN.NET](#)
- [Arch Linux 下Intel + NVIDIA 双显卡3D 游戏配置（dota2@steam） - 河 的 第 三 条 岸 - 博客频道 - CSDN.NET](#)
- [Archlinux中文化－－怎么显示中文的界面](#)
- [Arch Linux办公环境安装配置纯小白包通过教程_沉沦的菩提_新浪博客](#)
- [AUR (en) - laptop-mode-tools](#)
- [Change root (简体中文) - ArchWiki](#)
- [Core utilities (简体中文) - ArchWiki](#)
- [CPU frequency scaling (简体中文) - ArchWiki](#)
- [Daemons List (简体中文) - ArchWiki](#)
- [Display Power Management Signaling (简体中文) - ArchWiki](#)
- [en_users_Documentation_iw - Linux Wireless](#)
- [fbcon](#)
- [Fbterm (简体中文) - ArchWiki](#)
- [Font configuration (简体中文) - ArchWiki](#)
- [Fonts (简体中文) - ArchWiki](#)
- [fstab (简体中文) - ArchWiki](#)
- [General recommendations (简体中文) - ArchWiki](#)
- [GNOME (简体中文) - ArchWiki](#)
- [Google Code Archive - Long-term storage for Google Code Project Hosting.](#)
- [GRUB (简体中文) - ArchWiki](#)
- [IBus (简体中文) - ArchWiki](#)
- [infinality-bundle_ good looking fonts made (even) easier _ Community Contributions _ Arch Linux Forums](#)
- [Installation guide (简体中文) - ArchWiki](#)
- [Kernel parameters (简体中文) - ArchWiki](#)
- [Laptop Mode Tools (简体中文) - ArchWiki](#)
- [Linux问题解决_arch系统安装完没有声音 - FaceYe](#)
- [List of applications (简体中文) - ArchWiki](#)
- [makepkg (简体中文) - ArchWiki](#)
- [Network configuration (简体中文) - ArchWiki](#)
- [NetworkManager (简体中文) - ArchWiki](#)
- [NVIDIA (简体中文) - ArchWiki](#)
- [pacman.conf(5)](#)
- [pacman_Package signing (简体中文) - ArchWiki](#)
- [Pacman_Tips and tricks (简体中文) - ArchWiki](#)
- [PacmanTips and tricks (简体中文) - ArchWiki](#)
- [Pacman (简体中文) - ArchWiki](#)
- [pm-utils (简体中文) - ArchWiki](#)
- [Power management (简体中文) - ArchWiki](#)
- [RGB颜色查询对照表](#)
- [Systemd (简体中文) - ArchWiki](#)
- [Systemd (简体中文) - ArchWiki.MHT](#)
- [tmpfs - ArchWiki](#)
- [Unofficial user repositories (简体中文) - ArchWiki](#)
- [Wireless network configuration - ArchWiki](#)
- [Wirelessnetworkconfiguration简体中文-ArchWiki](#)
- [Wireless network configuration (简体中文) - ArchWiki](#)
- [xinitrc (简体中文) - ArchWiki](#)
- [Xorg (简体中文) - ArchWiki](#)
- [Zsh (简体中文) - ArchWiki](#)
- [把Arch Linux安装到U盘上的具体教程_LINUX_操作系统_脚本之家](#)
- [对《Arch Linux办公环境安装配置纯小白包通过教程》的补充，关于无线和蓝牙_沉沦的菩提_新浪博客](#)

</div>

[acpi_modules]: https://wiki.archlinux.org/index.php/ACPI_modules_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[alsa]: https://wiki.archlinux.org/index.php/Advanced_Linux_Sound_Architecture_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)#.E7.94.A8.E6.88.B7.E6.9D.83.E9.99.90
[active]: https://wiki.archlinux.org/index.php/Arch_based_distributions_(active)_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[arch_boot_process]: https://wiki.archlinux.org/index.php/Arch_boot_process_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[arch_i18n]: https://wiki.archlinux.org/index.php/Arch_Linux_Localization_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[chroot]: https://wiki.archlinux.org/index.php/Change_root_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[core_utils]: https://wiki.archlinux.org/index.php/Core_utilities_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)#cat
[cpu_freq]: https://wiki.archlinux.org/index.php/CPU_frequency_scaling_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[damons_list]: https://wiki.archlinux.org/index.php/Daemons_List_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[dpm]: https://wiki.archlinux.org/index.php/Display_Power_Management_Signaling_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[iw]: http://linuxwireless.org/en/users/Documentation/iw/
[fbcon]: https://www.kernel.org/doc/Documentation/fb/fbcon.txt
[fbterm]: https://wiki.archlinux.org/index.php/Fbterm_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[font]: https://wiki.archlinux.org/index.php/Font_configuration_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[fonts]: https://wiki.archlinux.org/index.php/Fonts_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[fstab]: https://wiki.archlinux.org/index.php/Fstab_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[General_recommendations_]: https://wiki.archlinux.org/index.php/General_recommendations_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[gnome]: https://wiki.archlinux.org/index.php/GNOME_%28%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87%29
[fbterm_src]: https://code.google.com/archive/p/fbterm/
[grub]: https://wiki.archlinux.org/index.php/GRUB_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)#x86_64
[ibus]: https://wiki.archlinux.org/index.php/IBus_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[viewtopic]: https://bbs.archlinux.org/viewtopic.php?id=162098
[install_guide]: https://wiki.archlinux.org/index.php/Installation_guide_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[kernel_parameters]: https://wiki.archlinux.org/index.php/Kernel_parameters_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[laptop]: https://wiki.archlinux.org/index.php/Laptop_Mode_Tools_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[list_app]: https://wiki.archlinux.org/index.php/List_of_applications_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)#.E6.88.AA.E5.8F.96.E5.B1.8F.E5.B9.95
[makepkg]: https://wiki.archlinux.org/index.php/Makepkg_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[network_config]: https://wiki.archlinux.org/index.php/Network_configuration_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)#.E5.90.AF.E7.94.A8.E5.92.8C.E7.A6.81.E7.94.A8.E7.BD.91.E7.BB.9C.E6.8E.A5.E5.8F.A3
[networkmanager]: https://wiki.archlinux.org/index.php/NetworkManager_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[nvidia]: https://wiki.archlinux.org/index.php/NVIDIA_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[pacman.conf]: https://www.archlinux.org/pacman/pacman.conf.5.html#_package_and_database_signature_checking
[package_signe]: https://wiki.archlinux.org/index.php/Pacman/Package_signing_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)#.E9.85.8D.E7.BD.AE_pacman
[pacman_tips]: https://wiki.archlinux.org/index.php/Pacman/Tips_and_tricks_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[pacman]: https://wiki.archlinux.org/index.php/Pacman_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)#.E5.88.A0.E9.99.A4.E8.BD.AF.E4.BB.B6.E5.8C.85
[pm-utils]: https://wiki.archlinux.org/index.php/Pm-utils_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[pm]: https://wiki.archlinux.org/index.php/Power_management_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[rgb]: https://www.114la.com/other/rgb.htm
[systemd]: https://wiki.archlinux.org/index.php/Systemd_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[tmpfs]: https://wiki.archlinux.org/index.php/Tmpfs
[aur]: https://wiki.archlinux.org/index.php/Unofficial_user_repositories_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)#archlinuxcn
[wireless_cnofig]: https://wiki.archlinux.org/index.php/Wireless_network_configuration_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[xinitrc]: https://wiki.archlinux.org/index.php/Xinitrc_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[xorg]: https://wiki.archlinux.org/index.php/Xorg_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[zsh]: https://wiki.archlinux.org/index.php/Zsh_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[fs]: https://wiki.archlinux.org/index.php/File_systems_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[1]: http://blog.sina.com.cn/s/blog_69e5d8400102vp00.html
[2]: http://my.oschina.net/wzkiron/blog/511458
[3]: https://lug.ustc.edu.cn/wiki/mirrors/help/archlinuxcn
[4]: http://www.cnblogs.com/timeship/archive/2013/02/28/2937635.html
[4]: http://www.jb51.net/LINUXjishu/401340.html
[5]: http://blog.lucode.net/linux/archlinux-install-tutorial.html
[6]: http://www.tuicool.com/articles/AvaiuqI
[7]: http://bbs.archlinuxcn.org/viewtopic.php?id=1037
[8]: http://www.oschina.net/question/54100_29072
[9]: http://www.linuxidc.com/Linux/2016-11/137666.htm
[10]: http://blog.chinaunix.net/uid-108863-id-136997.html
[11]: http://blog.csdn.net/ispeller/article/details/37765999
[12]: http://blog.csdn.net/ispeller/article/details/37765999
[13]: http://www.360doc.com/content/12/0713/15/6828497_223986769.shtml
[14]: http://blog.sina.com.cn/s/blog_6379f4350102wicg.html
[15]: https://aur.archlinux.org/packages/laptop-mode-tools/
[16]: http://www.jb51.net/LINUXjishu/401298.html
[17]: http://blog.sina.com.cn/s/blog_6379f4350102wifv.html
[18]: http://www.faceye.net/search/98807.html
[19]: https://segmentfault.com/a/1190000002918394?utm_source=tuicool&utm_medium=referral
[20]: http://blog.csdn.net/zwlq1314521/article/details/42965035
