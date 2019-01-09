#  当我的Arch Linux自动挂起之后被重新唤醒时，Thunar等Gtk程序的菜单（右键上下文和菜单栏）等变成了英文
> 这也许是锁屏工具带来的影响……

&nbsp;&nbsp;在我的 *Arch Linux* 上，屏幕保护程序不能很好的在我的计算上工作（或许是我的显示器原因导致的花屏问题），而用户级 .xprofile 却需要（或者类似）一个登录管理器的程序才能正常被读取，一些屏幕保护程序提供了此类功能，比如 *xscreensaver*。

&nbsp;&nbsp;如果系统语言设置成了英文的，而用户语言设置成了中文，使用的又不是此类锁屏软件（我用的是 *xtrlock*），可能会导致一些问题。

&nbsp;&nbsp;为了使用 *xtrlock*，我在 *xflock4* 脚本靠近首部处添加了下列行：
```bash
for lock_cmd in "xtrlock";do $lock_cmd -f -b &> /dev/null &\
  exit
done
```

&nbsp;&nbsp;问题就是只有手动挂起（一个叫做 xflock4 的 shell 脚本会在 xfce4 -session 手动注销或者挂起时被调用）才会正常锁屏，重新唤醒系统之后是正常的。

&nbsp;&nbsp;然而这对自动挂起无效，自动挂起然后重新唤醒系统之后就出现这种问题。

&nbsp;&nbsp;为了使用中文菜单，我只好选择注销之后重新登录或者手动挂起系统然后重新唤醒系统。原因可能是一些锁屏工具看起来有 GUI，但还是遵循了 Unix 哲学而设计。

--------------------------------
> user-dirs.dirs & user-dirs.locales 可能产生的影响……

&nbsp;&nbsp;当我启动 Linux 并使用 lxdm 进入 xfce 会话时，`xdg-settings`自动在我的用户主目录下生成了一系列用户目录并告诉我某些程序要用，然而，因为我的 Linux 用户主目录位于单独的分区上，因此，久而久之，里面有一堆的文件和目录。

&nbsp;&nbsp;我并需要其中的某些用户目录（但让我无奈的是，某些程序说它们需要用来存放数据，然后系统就帮忙创建了它们），我私下里认为假如我要存放一些文档，是不会把它们放到这儿的。因此我自作聪明的将 一些用户目录符号链接到了 windows 分区（在 windows 上可以共享)。不过不幸的是，一些程序还是受到了影响，比如 Thunar，vlc 等程序。它们在直接被打开时（某些从命令行传递 LANG 也不管用），UI 有可能会变作英文。 

我尝试重新设置了用户目录。以下是配置文件内容：

=============== $HOME/.config/user-dirs.dirs ==================

```
# This file is written by xdg-user-dirs-update
# If you want to change or add directories, just edit the line you're
# interested in. All local changes will be retained on the next run
# Format is XDG_xxx_DIR="$HOME/yyy", where yyy is a shell-escaped
# homedir-relative path, or XDG_xxx_DIR="/yyy", where /yyy is an
# absolute path. No other format is supported.
# 
XDG_DESKTOP_DIR="$HOME/Desktop"
XDG_DOWNLOAD_DIR="$HOME/Downloads"
XDG_TEMPLATES_DIR="$HOME/"
XDG_PUBLICSHARE_DIR="/tmp"
XDG_DOCUMENTS_DIR="$HOME/"
XDG_MUSIC_DIR="$HOME/CloudMusic"
XDG_PICTURES_DIR="$HOME/"
XDG_VIDEOS_DIR="$HOME/"
```

=============== $HOME/.config/user-dir.locale =================
```
en_US
```

--------------------------------------------
> Note：不正确设置用户目录可能让应用程序的国际化受到影响。当国际化失败时，可以尝试：

 + 保存会话后注销重新登录
 + 检查用户目录是否正确配置
  
