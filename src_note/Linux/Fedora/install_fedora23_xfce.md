<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# Fedora Xfce 23：安装与配置指东
## 安装

### grub2[^grub-faild]配置

--------

## 配置

### 源（软件仓库）配置:

+ 备份系统源

  ```Bash
  cd /etc/yum.repos.d
  mkdir bk
  mv *.repo bk
	```

+ Fedora 国内（[163](), ali, ustc）源:
+ rpm-flusion[^rpm-flusion] 源:

> fedora 21 及以上版本启用 rpm-flusion 源

```Bash
sudo dnf install https://download1.rpmfusion.org/free/fedora/rpmfusion-free-release-$(rpm -E %fedora).noarch.rpm https://download1.rpmfusion.org/nonfree/fedora/rpmfusion-nonfree-release-$(rpm -E %fedora).noarch.rpm
su -c 'dnf install https://download1.rpmfusion.org/free/fedora/rpmfusion-free-release-$(rpm -E %fedora).noarch.rpm https://download1.rpmfusion.org/nonfree/fedora/rpmfusion-nonfree-release-$(rpm -E %fedora).noarch.rpm'
```

```Bash
su -c 'dnf install https://download1.rpmfusion.org/free/fedora/rpmfusion-free-release-$(rpm -E %fedora).noarch.rpm https://download1.rpmfusion.org/nonfree/fedora/rpmfusion-nonfree-release-$(rpm -E %fedora).noarch.rpm'
```

+ [Fedora 中文社区软件源](https://repo.fdzh.org)致力于为 Fedora 中文用户提供丰富实用的软件，[Fedora 中文社区成员](https://github.com/FZUG/members)
``` Bash
dnf config-manager --add-repo=http://repo.fdzh.org/FZUG/FZUG.repo
dnf install http://repo.fdzh.org/FZUG/free/23/x86_64/fzug-release-23-0.1.noarch.rpm
wget http://repo.fdzh.org/FZUG/FZUG.repo -P /etc/yum.repos.d/
```

![Fedora 项目维基二维码](https://repo.fdzh.org/blog/api/v1.0/qrcode?url=https://fedoraproject.org/wiki/Fedora_Project_Wiki/zh-cn&box_size=6&border=1&version=2)

+ Fedora 23 设置本地 repo 源（仓库），在 /etc/yum.repos.d 目录下创建 dnf 需要的 repo 文件 `/etc/yum.repos.d/local.repo `

```ini
[local]
name=Local Repo
baseurl=file:///media/Others/Temp/sr/
skip_if_unavailable=True
metadata_expire=1d
gpgcheck=0
enabled=1
```

+ 安装 repo 元数据创建工具 `createrepo`
`sudo dnf install -y createrepo`

+ 创建本地 repo 源数据

```Bash
pushd /media/Others/Temp
createrepo -v sr/lin
```

+ 清除所有缓存 `sudo dnf clean all`

+ 创建 repo 缓存 `sudo dnf makecache`

+ 刷新软件源，建立源元数据，源缓存，更新系统
``` Bash
dnf clean all
dnf makecache
dnf update -y
```

### 桌面配置

- docky  cairo-dock  mc  evince&amp;evince-browser-plugin 
- [tumbler]() [编译] - tumbler-extras
- gnome-epub-thumbnailer gnome-terminal-nautilus nautilus-open-terminal sway 
+ 词典 `stardict{,-*}`
+ 浏览器: lynx - elinks - links qutebrowser opera-stable - firefox - [chromium 浏览器](https://repos.fedorapeople.org/repos/spot/chromium/fedora-chromium-stable.repo) 注：这个源似乎不能正常访问 

``` Bash
wget https://repos.fedorapeople.org/repos/spot/chromium/fedora-chromium-stable.repo -P /etc/yum.repos.d/
dnf makecache
dnf install chromium
```

 - vim： 已知 vim 和系统 vim-minimal 有冲突,并且在卸载 vim-minimal 时会同时卸载 sudo，因此

``` Bash
sudo -s
dnf erase vim-minimal
dnf install vim sudo
```

- VNote
- mousepad | leafpad
- [medit](https://) [编译]

+ p7zip unrar
+  输入法: fcitx fcitx-fbterm `fcitx-gtk* fcitx-qt*` - imsettings-info - sogoupinyin fcitx-pinyin fcitx-fbterm fcitx  fcitx-qt4  fcitx-qt5  fcitx-gtk* fcitx-configtool
+ gtk-thems：mate-themes 
+ cursor 主题 [Arch Linux xcursor-themes 软件包](https://)

```Bash
tar -xf xcursor-themes.tar.pkg.xz
cp -r usr/share/icon/* /usr/share/icon/
cp -r usr/share/license /usr/share/license/
``` 

- iocn 主题： humanity-icon-theme|numix-icon-theme
+ 媒体播放器 - mpv - mplayer mplayer-gui mplayer-tools - vlc vlc-extras vlc-plugin-jack - `smplayer{,-themes}`
- moc （kwplayer deepin-music-player netease-cloud-music  musicbox doubanfm-qt） [Fedora 中文源]()， [RhythmCat]() [编译]
 - easytag - osdlyrics
 - simplescreenrecorder

+ FileSystem: ntfs-3g ntfsprogs - exfat-utils fuse-exfat
+ Terminal: fbterm - fbterm-udevrules - terminology - tmux - tilda - guake
+ Game: gnome-chess - pv - fortune - fortune-mod fortune-firefly - figlet - cowsay cowsay-beefymiracle xcowsay  lolcat[git](https://github.com/busyloop/lolcat) Install: `npm install lolcat`
+ Download: deluge qbittorrent aria2 uget bcloud

--------------

#### 字体优化[^warn]

[^warn]: 因为那些预编译的软件包在Fedora中文源中，所以这需要正确配置了Fedora中文源。

```Bash
git clone https://github.com/FZUG/repo.wiki.git
dnfi freetype-infinality fontconfig-infinality cairo-infinality-tools cairo-infinality
dnfi --allowerasing freetype-infinality fontconfig-infinality cairo-infinality-tools cairo-infinality
sudo cp /usr/share/doc/freetype-infinality/infinality-settings-generic /etc/profile.d/infinality-settings-generic.sh
sudo cp /usr/share/doc/freetype-infinality/infinality-settings.sh /etc/X11/xinit/xinitrc.d/ -v
sudo chmod a+x /etc/X11/xinit/xinitrc.d/infinality-settings.sh 
```

#### 多媒体编、解码器[^rpm-flusion]

> 多媒体编码器

- `flac h264enc x265 x264 vo-aacenc mencoder vo-amrwbenc mppenc`
- `lame lame-libs lame-mp3x`
- `faad2 faad2-libs`
- `xvidcore xvid4conf`
- `audacious-plugins-freeworld-ffaudio`

> 解码器

- `libdca`
- `libvorbis`
- liblame
- libmad
- `libogg liboggz`

#### [Fedora Xfce 23 software List](fedora23_soft_list.md)

# 附
## Fedora 23 install chromium55

> chromium x86_64:

+ [chromium-54](http://dl.fedoraproject.org/pub/fedora/linux/updates/23/x86_64/c/chromium-54.0.2840.90-3.fc23.x86_64.rpm)
+ [chromium-55](http://dl.fedoraproject.org/pub/fedora/linux/updates/testing/23/x86_64/c/chromium-55.0.2883.87-1.fc23.x86_64.rpm)

chromium依赖： chromium-libs chromium-libs-media u2f-hidraw-policy

> chromium-libs-54 x86_64:

+ [chromium-55-libs](http://dl.fedoraproject.org/pub/fedora/linux/updates/23/x86_64/c/chromium-libs-54.0.2840.90-3.fc23.x86_64.rpm)
+ [chromium-libs-media-54](http://dl.fedoraproject.org/pub/fedora/linux/updates/23/x86_64/c/chromium-libs-media-54.0.2840.90-3.fc23.x86_64.rpm)

> chromium-libs-55 x86_64:

+ [chromium-libs-55-fc23](http://dl.fedoraproject.org/pub/fedora/linux/updates/testing/23/x86_64/c/chromium-libs-55.0.2883.87-1.fc23.x86_64.rpm)
+ [chromium-libs-media-55-fc23](http://dl.fedoraproject.org/pub/fedora/linux/updates/testing/23/x86_64/c/chromium-libs-media-55.0.2883.87-1.fc23.x86_64.rpm)
+ [chromium 54/55以上 x86_64](http://dl.fedoraproject.org/pub/fedora/linux/updates/23/x86_64/u/u2f-hidraw-policy-1.0.2-1.fc23.x86_64.rpm)

## Fedora 23 install lovewallpapers

1. install 必须依赖 python-pyside ：`dnf install python-pyside`
如果没有安装这个软件包,会提示载入模块Pyside.QtCore失败
安装好lovewallpaper的依赖软件包之后,直接使用LoveWallpaper提供给Fedora的rpm包 `rpm -ivh LoveWallpaper4LinuxFedora.rpm`

.tar.gz包安装: `tar -xf LoveWallpaper4Linux.tar.gz`

修改安装脚本 INSTALL.sh和data/LoveWallpaper.desktop文件为正确的路径,并以根用户权限执行安装脚本.

为了方便安装和卸载,将安装脚本修改为makefile,然后使用make来直接安装或者卸载 ：`mv INSTALL.sh makefile && make install`

# FAQ
## wps for linux 启动错误:

```log
wps: error while loading shared libraries: libpng12.so.0: cannot open shared object file: No such file or directory
```

这是意味系统缺少 png12 库，只需 `dnf install -y libpng12`

## [Fedora Xfce 23 thunar 显不出文件缩略图却不知为那般？](thunar_no_thumblers.md)

## 参考：

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

[^grub-faild]: 从iso启动的Linux Live系统的所在文件系统不能在Linux Live环境中被再次挂载(如果一定要挂载，可以传递--bind参数以绑定挂载的方式)，安装时也手动配置了这个分区，安装程序在应用更改时会失败并导致安装程序中断faild；iso文件所在home分区已经以只读方式被挂载到Fedora live环境中,再次自动挂载到安装环境会失败

[^rpm-flusion]: Fedora 多媒体编、解码器以及媒体播放器在 rpm-flusion 源中，如果要安装多媒体编解码器以及多媒体工具，那么正确配置 rpm-flusion 源必不可少
