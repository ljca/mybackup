# Fedora 笔记：

## dnf：Fedora 新一代软件包管理器
```Bash
dnf update 
dnf -y update 
dnf -y install bluefish
dnf -y install geany
dnf -y update
dnf clean 
dnf clean all
dnf -y update
dnf -y update
dnf -y update
dnf -y install unrar
dnf -y install unrar
dnf -y update
dnf -y install mysql-server apache2 tomcat7
dnf -y install mysql-server 
dnf search apa*
dnf -y install tomcat httpd.x86_64
dnf -y update
dnf -y install nautilus-open-terminal
dnf install http://repo.fdzh.org/FZUG/free/23/x86_64/fzug-release-23-0.1.noarch.rpm
dnf makecache 
dnf -y kwplayer
dnf -y install kwplayer
dnf -y install sogoupinyin
dnf -y install deepin-music-player deepin-movie
dnf -y install tragtor
dnf -y install pointdownload
dnf -y install xware-desktop
dnf -y update
dnf -y update
dnf makecache 
```

```Bash
dnfi sway
dnfi vlc
dnfi mariadb mariadb-server
dnfi php php-mysql
dnfi phpmyadmin 
dnfi gcc gcc-c++
dnfi gdb
dnfi texinfo
dnfi openssl openssl-devel 
dnfi pcre-devel
dnfi gnome-terminal-nautilus nautilus-open-terminal
dnfi  nautilus-open-terminal
dnfi gstreamer1-plugins-ugly libXScrnSaver qt5-qtmultimedia qt5-qtx11extras
dnfs fcitx
dnfi fcitx-pinyin fcitx-fbterm fcitx  fcitx-qt4  fcitx-qt5  fcitx-gtk*
dnfi vim
dnfi docky
dnfi plank
dnfi mc
dnfu
dnfi gnome-tweak-tool
dnfi fcitx-configtool
dnfi vim
dnfi vim
su -c 'dnf install https://download1.rpmfusion.org/free/fedora/rpmfusion-free-release-$(rpm -E %fedora).noarch.rpm https://download1.rpmfusion.org/nonfree/fedora/rpmfusion-nonfree-release-$(rpm -E %fedora).noarch.rpm'
dnfu
dnf config-manager --add-repo=http://repo.fdzh.org/FZUG/FZUG.repo
dnfi sogoupinyin
dnf makecache 
dnfi gnome-tweak-tool
dnfi yaourt
dnfi mate-themes  dmz-cursor-themes light-gtk3-theme mate-icon-theme-faenza smplayer-themes
dnfi doubanfm-qt simplescreenrecorder deepin-music-player musicbox wiznote youdao-dict freshplayerplugin pointdownloa
dnfi doubanfm-qt simplescreenrecorder deepin-music-player musicbox wiznote youdao-dict freshplayerplugin
dnfi breeze-cursor-theme iconutils
dnfi breeze-cursor-theme icoutils
dnfi nuvola-icon-theme mate-icon-theme-faenza humanity-icon-theme
dnfr nuvola-icon-theme mate-icon-theme-faenza 
dnfr mate-themes
dnfr musicbox
dnfr doubanfm-qt
dnfi netease-cloud-music
dnfi bcloud
dnfu
dnfu
dnfi gcc-c++
dnfi libstdc++ libstdc++-devel libstdc++-static 
dnfi expect
dnf search textinfo
dnfi texinfo
dnfi glic-devel glic-utils glic-static
dnfi glibc-devel glibc-utils glibc-static
dnfi wps-office
dnfi wps-office
dnfi python-xtermcolor
dnfi deluge
dnfi qbittorrent
dnfi aria2
dnfi qutebrowser opera
dnfi qutebrowser opera-stable
dnfr qupzilla
dnfi genisoimg
dnfi genisoimage
dnf -y update
dnf -y update
dnf -y update
dnf -y update
dnf clean packages 
dnf -y update
dnf search 'gvim'
dnf search 'weizi'
dnf search 'note'
dnf search 'note' | mroe 
dnf search 'note' | more
dnf 
dnf reinstall -y wiznote
dnf remove -y wiznote 
dnf search 'music'
dnf search 'music' | more
dnf search 'dock'
dnf search 'dock' | less
dnf -y update
dnf search 'dock' | less
dnf search 'dock' | more
dnf install -y cairo-dock
dnf install -y system-conifg*
dnf install system*
dnf install system-config-*
dnf remove -y cairo-dock
dnf -y update
dnf remove -y google-chrome-stable
dnf -y update
dnf install -y update
```

> 参考：

+ [DNF的命令使用教学_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2015-06/118751.htm)
+ [Fedora - Redhat 软件包管理指南-jqunjian-ChinaUnix博客](https://blog.csdn.net/chen190735341/article/details/43232077)
+ [Fedora && Arch Linux – 最浪漫的事现已发生…_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2015-08/120923.htm)
+ [Linux 包管理基础：apt、yum、dnf 和 pkg](https://linux.cn/article-8782-1.html)
+ [从RPM文件中提取文件(RPM2CPIO, CPIO的使用)--ChinaUnix博客](http://blog.chinaunix.net/uid-26435987-id-3399279.html)

