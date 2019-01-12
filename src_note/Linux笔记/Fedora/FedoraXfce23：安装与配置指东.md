# Fedora Xfce 23：安装与配置指东
## 安装 ##
### grub2配置 ###
> 从iso启动的Linux Live系统的所在文件系统不能在Linux Live环境中被再次挂载(如果一定要挂载，可以传递--bind参数以绑定挂载的方式)
> 安装时也手动配置了这个分区，安装程序在应用更改时会失败并导致安装程序中断faild
> iso文件所在home分区已经以只读方式被挂载到Fedora live环境中,再次自动挂载到安装环境会失败

--------
## 配置 ##
### 源配置: ###
+ 备份系统源
  ``` Bash
  cd /etc/yum.repos.d
  mkdir bk
  mv *.repo bk
	```

+ 添加 Fedora 国内(163,ali,ustc)源:
+ 添加 rpmflusion 源:
fedora 21 及以上版本启用 rpmflusion 源
``` Bash
sudo dnf install https://download1.rpmfusion.org/free/fedora/rpmfusion-free-release-$(rpm -E %fedora).noarch.rpm https://download1.rpmfusion.org/nonfree/fedora/rpmfusion-nonfree-release-$(rpm -E %fedora).noarch.rpm
su -c 'dnf install https://download1.rpmfusion.org/free/fedora/rpmfusion-free-release-$(rpm -E %fedora).noarch.rpm https://download1.rpmfusion.org/nonfree/fedora/rpmfusion-nonfree-release-$(rpm -E %fedora).noarch.rpm'
```


+ [Fedora 中文社区软件源](https://repo.fdzh.org)致力于为 Fedora 中文用户提供丰富实用的软件，[Fedora 中文社区成员](https://github.com/FZUG/members)
``` Bash
dnf config-manager --add-repo=http://repo.fdzh.org/FZUG/FZUG.repo
dnf install http://repo.fdzh.org/FZUG/free/23/x86_64/fzug-release-23-0.1.noarch.rpm
wget http://repo.fdzh.org/FZUG/FZUG.repo -P /etc/yum.repos.d/
```

![Fedora 项目维基二维码](https://repo.fdzh.org/blog/api/v1.0/qrcode?url=https://fedoraproject.org/wiki/Fedora_Project_Wiki/zh-cn&box_size=6&border=1&version=2)

+ 刷新软件源，建立源元数据，源缓存，更新系统
``` Bash
dnf clean all
dnf makecache
dnf update -y
```

+ 软件

+ 安装 vim
> 已知 vim 和系统 vim-minimal 有冲突,并且在卸载 vim-minimal 时会同时卸载 sudo，因此

-----
``` Bash
sudo -s
dnf erase vim-minimal
dnf install vim sudo
```

+ 主题
 - gtk-thems：mate-themes
 - iocn 主题： humanity-icon-theme|numix-icon-theme
 - xfwm4-themes
 - emerald-themes
 - emerald-themes-extra
 - bluebird-metacity-theme
 - light-gtk2-theme
 - light-gtk3-theme
 - light-theme-gnome
 - light-metacity-theme
 - echo-icon-theme
 - mono-icon-theme
 - nimbus-icon-theme
 - fusion-icon
 - fusion-icon-gtk
 - humanity-icon-theme
 - numix-icon-theme
 - gtk-update-icon-cache
 - numix-icon-theme-circle
 - elementary-icon-theme
 - elementary-xfce-icon-theme
 - monochrome-icon-theme
 - emerald-themes-extra
 - emerald-themes


 - cursor 主题 [Arch Linux xcursor-themes 软件包](https://)

 ``` Bash
 tar -xf xcursor-themes.tar.pkg.xz
 cp -r usr/share/icon/* /usr/share/icon/
 cp -r usr/share/license /usr/share/license/
 ``` 

+ 窗口管理器
 - compiz-xfce
 - libcompizconfig
 - compiz-plugins-unsupported
 - compiz-plugins-experimental
 - compiz-plugins-extra
 - compiz-plugins-main
 - compiz-manager
 - compizconfig-python
 - compiz
 - simple-ccsm
 - ccsm

+ 字体配置
``` Bash
git clone https://github.com/FZUG/repo.wiki.git
dnf config-manager --add-repo=http://repo.fdzh.org/FZUG/FZUG.repo
dnfi freetype-infinality fontconfig-infinality cairo-infinality-tools cairo-infinality
dnfi --allowerasing freetype-infinality fontconfig-infinality cairo-infinality-tools cairo-infinality
sudo cp /usr/share/doc/freetype-infinality/infinality-settings-generic /etc/profile.d/infinality-settings-generic.sh
sudo cp /usr/share/doc/freetype-infinality/infinality-settings.sh /etc/X11/xinit/xinitrc.d/ -v
sudo chmod a+x /etc/X11/xinit/xinitrc.d/infinality-settings.sh 
```

> 多媒体解码器都包含在 rpm-flusion 源中，正确配置 rpm-flusion 源必不可少

--------
+ 多媒体及解码器:
 - `gstreamer1-plugins*`
 - `gstreamer-plugins-bad-free*  gstreamer1-plugins-base*`
 - `gstreamer-plugins-bad-free*  gstreamer1-plugins-base*  gstreamer-plugins-bad-nonfree`
 - `gstreamer-plugins-bad-free*  gstreamer1-plugins-base*  gstreamer-plugins-bad-nonfree`
 - `gstreamer-plugins-bad gstreamer-plugins-bad-free-extras gstreamer-plugins-ugly gstreamer-ffmpeg gstreamer1-libav gstreamer1-plugins-bad-free-extras gstreamer1-plugins-bad-freeworld gstreamer-plugins-base-tools gstreamer1-plugins-good-extras gstreamer1-plugins-ugly gstreamer1-plugins-bad-free gstreamer1-plugins-good gstreamer1-plugins-base gstreamer1`
 - `gstreamer-plugins*`
 - `flac h264enc x265 x265-libs x264 vo-aacenc mencoder vo-amrwbenc mppenc`
 - `lame lame-libs lame-mp3x`
 - `libogg liboggz`
 - `libvorbis`
 - `xvidcore xvid4conf`
 - `libdca`
 - `faad2 faad2-libs`
 - `audacious-plugins-freeworld-ffaudio`

```
dnf list | grep gstre|grep docs|cut -f1|cut -d. -f1|xargs)
```

+ 多媒体播放器
 - mpv
 - mpv-devel libmpv
 - mplayer mplayer-gui mplayer-tools 
 - `smplayer{,-themes}`
 - vlc vlc-extras vlc-plugin-jack 
 - moc
 - kwplayer netease-cloud-music [Fedora 中文源]()
 - [RhythmCat]() [编译]
 - easytag
 - osdlyrics
 - simplescreenrecorder

+ 词典
	- `stardict{,-*}`

+ 浏览器
 - lynx
 - elinks
 - links
 - opera
 - firefox 
 - [chromium 浏览器](https://repos.fedorapeople.org/repos/spot/chromium/fedora-chromium-stable.repo) 注：这个源似乎不能正常访问
``` Bash
wget https://repos.fedorapeople.org/repos/spot/chromium/fedora-chromium-stable.repo -P /etc/yum.repos.d/
dnf makecache
dnf install chromium
```

+ Develop Envraoment
 - bash-completion
 - gcc
 - gcc-c++
 - `libstdc++{,-devel}`
 - ctags

+ System Server
 - openssh-server openssh-clients  fuse-sshfs  
 - screenfetch
 - dnf-plugins-core fedora-repos-rawhide

+ FileSystem
 - ntfs-3g ntfsprogs
 - exfat-utils fuse-exfat

 - VirtualBox

+ Shell
 - csh
 - tcsh
 - zsh
  + Zsh 插件
  * autojump-zsh
  * gromacs-zsh
  * zsh-html
  * herbstluftwm-zsh
  * docker-zsh-completion
  * vim-syntastic-zsh
 - ksh

 - git git-gui subversion git-svn 
 - qconf
 - python-pyside 
 - git git-gui subversion git-svn 
 - qt3 qt3-config qt
 - npm
 - [mode-html-to-text](https://github.com/werk85/node-html-to-text.git) Install：`npm  install html-to-text -g`

+ Game
 - gnome-chess
 - lolcat[git](https://github.com/busyloop/lolcat) Install: `npm install lolcat`
 - pv
 - fortune
 - fortune-mod fortune-firefly
 - figlet
 - cowsay cowsay-beefymiracle xcowsay

+ Terminal
 - fbterm
 - fbterm-udevrules
 - terminology 
 - tmux
 - tilda
 - guake-terminal

+  工具
+ System's Tool
 - udev-browse
 - system-config-printer-udev
 - umockdev

+ Picture's Tool
 - feh
 - ImageMagick rubygem-rmagick  ImageMagick-libs 

+ Iconv Tools
 - emerald
 - driconf
 - volumeicon
 - uniconvertor
 - gtrayicon
 - icoutils
 - kiconedit

+ 桌面组件
 - docky
 - mc
 - gnome-epub-thumbnailer
 - axel 
 - evince&amp;evince-browser-plugin 
 - [tumbler]() [编译]
 - tumbler-extras
 - gnome-epub-thumbnailer

+ 输入法
 - fcitx fcitx-fbterm `fcitx-gtk* fcitx-qt*`
 - imsettings-info 
 - sogoupinyin
 - bsdtar

+ TextEditor
 - monodevelop
 - bluefish
 - retext
 - mousepad
 - leafpad
 - texstudio
 - lmms 
 - [medit](https://) [编译]

+ Android
 - android-tools

+ Fedora 上的 yaourt
> 安装 yaourt 注：yaourt 在 Arch Linux fr 源，但是在 Arch Linux 中文源中也有。因为系统架构类似,现在也被移植到了 Fedora 系统中，包含在了 Fedora 中文源中
 
--------
``` Bash
dnf install -y yaourt
```

+ 配置 pacman `/etc/pacman.conf` &amp; yaourt `/etc/pacman.d/mirrorlist`

+ 刷新软件源:
``` Bash
pacman -Syy
```


> 参考：

+ [Fedora 项目维基](https://fedoraproject.org/wiki/Fedora_Project_Wiki)。
+ [c++g++errorNothatfileanddirectory-StackOverflow](http://stackoverflow.com/questions/34624428/g-error-usr-lib-rpm-redhat-redhat-hardened-cc1-no-that-file-and-directory)

+ [fc11下fcitx安装小记-changyongID-ChinaUnix博客](http://blog.chinaunix.net/uid-20799298-id-99676.html)

+ [Fedora-20 uefi U盘安装 - lzshlzsh的专栏 - 博客频道 - CSDN_NET](https://blog.csdn.net/lzshlzsh/article/details/18862549)

+ [Fedora 20 安装搜狗拼音输入法_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2015-01/112020.htm)

+ [Fedora 20下 MySQL 的安装_数据库技术_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2014-02/96392.htm)

+ [Fedora 22安装以后的优化和配置_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2015-05/118149.htm)

+ [Fedora22添加国内软件源和本地软件源 - Linux系统教程](http://www.linuxdiyf.com/linux/13417.html)

+ [fedora 22下成功安装nvidia驱动 - Linux系统教程](http://www.linuxdiyf.com/linux/12361.html)

+ [fedora23安装配置记录_fedora吧_百度贴吧](http://tieba.baidu.com/p/4160404033)

+ [Fedora 24 Linux 环境下实现 Infinality 字体渲染增强及 Java 字体渲染改善的方法（修订） - 小侠猫猫球 - 博客园](http://www.cnblogs.com/cyberniuniu/archive/2016/10/03/5928963.html)

+ [Fedora 24 如何安装 Nvidia 显卡驱动_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2016-06/132768.htm)

+ [Fedora 23 中文显示优化, 超美_桑树湾_新浪博客](http://blog.sina.com.cn/s/blog_4d3e77770102wb9g.html)

+ [linux 编译安装php选项](http://www.mamicode.com/info-detail-523214.html)

+ [Linux系统入门学习：教你在VirtualBox 安装 Fedora 22_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2015-08/121808.htm)

+ [mkisofs命令_Linux mkisofs 命令用法详解：建立ISO 9660映像文件](http://man.linuxde.net/mkisofs)

+ [安装Fedora 23工作站后，必须要做的24件事_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2015-11/125200.htm)

+ [记录一下fedora20安装后，需要安装的一些必备的软件包 - 其他 - 红黑联盟](http://www.2cto.com/os/201404/291375.html)

+ [深入理解Linux引导过程-服务配置-fedora中文站](http://www.fedora.hk/linux/fuwu/show_13.html)

+ [使用yaourtFZUG_repoWikiGitHub](https://github.com/FZUG/repo/wiki/%E4%BD%BF%E7%94%A8-yaourt)

+ [Fedora23安装以后要做的优化配置-软件教程-51新闻网](http://www.51xw.net/tech/2015/11/7771.html)

+ [Sogou Pinyin 常见问题 · FZUGrepo Wiki · GitHub](https://github.com/FZUG/repo/wiki/Sogou-Pinyin-%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98)

+ [配置 Infinality 字体渲染增强 · FZUGrepo Wiki · GitHub](https://github.com/FZUG/repo/wiki/%E9%85%8D%E7%BD%AE-Infinality-%E5%AD%97%E4%BD%93%E6%B8%B2%E6%9F%93%E5%A2%9E%E5%BC%BA)
