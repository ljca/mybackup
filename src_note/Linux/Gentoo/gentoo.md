<link href="../../css/style.css" rel="stylesheet" type="text/css" />


# Gentoo 笔记：
## 桌面配置
### Install software

+ app-shells/bash-completion
+ app-text/lesspipe
+ vim
+ mc
+ lynx: `USE="ssl" emerge --ask lynx`
+ fbterm

```Bash
emerge --search fbterm
emerge -av app-i18n/fbterm
cp -r .fbtermrc  .config/fontconfig/ ~/
chmod u+s /usr/bin/fbterm 
mkdir .config
mv fontconfig/ .config/
LANG="zh_CN.UTF-8" exec fbterm
```

### X Server & Window Manager & Desktop 

> 选择桌面配置文件 desktop profile: eselect profile set 20

+ x11-base/xorg-server: `echo 'INPUT_DEVICES="keyboard libinput mouse evdev synaptics void" VIDEO_CARDS="i915 intel nvidia fbdev vesa"' >> /etc/portage/make.conf;` `emerge -av xorg-drivers`

> 压缩/解压:

+ `USE="rar" paci p7zip`
+ app-arch/unrar: `emerge -av app-arch/unrar`

> 输入法：

+ fcitx: `USE="gtk2" paci fcitx` `eval "$(dbus-launch --sh-syntax --exit-with-session)"`
+ fcitx-libpinyin

> 解码器，媒体播放器：

+ mocp
+ media-video/ffmpeg: `USE="libav" paci media/ffmpeg`
+ vlc : `emerge --ask --verbose vlc`
+ smplayer: `USE="faac faad fbcon -xscreensaver theora vdpau pulseaudio libmpeg2 twolame rar" paci smplayer`
+ media-video/simplescreenrecorder: `USE="pulseaudio theora" paci media-video/simplescreenrecorder`

> 字体配置：安装或者拷贝中文字体到系统中。搜索并安装字体优化：fontconfig-infinality，fontconfig-ultimate 并启用它们的配置文件： `eselect fontconfig enable <Tab>`

+ media-libs/fontconfig-infinality
+ media-libs/fontconfig-ultimate

+ `merge -av gparted --autounmask-write`

> gentoo-zh:

+ `USE="gpg sqlite squashfs sync-plugin-portage" paci layman`
+ `layman -a gentoo-zh`

## 系统服务：rc-update 
## 软件管理：[emerge](emerge.md)

## Install[^install]

**从 UEFI[^gentoo_uefi]启动 Gentoo 可启动盘，选择一个内核和可选内核参数启动[^kernel_option]，开始安装 Gentoo 前的准备。 set network[^wpa2]. net-set or wpa_supplicant & dhcpcd**

> DISK CONFIGURE 

```Bash
mount -v /dev/disk/by-label/Gentoo /mnt/gentoo
cd /mnt/gentoo
blkid
swapon /dev/sda10
```

> 准备根文件系统: /

+ 获取 stage3: `cd /mnt/gentoo;links https://www.gentoo.org/downloads`
+ 解包 stage3 和 portage 树…… `tar --numric-owner --xattrs-include="*.*" -xvpf stage3*.tar.xz` ; `find . -type f -name ".keep" -exec rm -v '{}' ';'`


### chroot

> 拷贝必须的配置文件到目标系统:

+ /mnt/gentoo/etc/wpa_supplicant/wpa_supplicant.conf 
+ `cp -Libv /etc/resolv.conf /mnt/gentoo/etc`
+ 选择源：`mirrorselect -i >> /mnt/gentoo/etc/portage/make.conf` mirrorlist -i -o >> /mnt/gentoo/etc/portage/make.conf 

> 挂载必须的虚拟文件系统

```Bash
# dev(绑定挂载)
mount -o bind /dev /mnt/gentoo/dev

# (sys)

# proc
mount --types proc /proc /mnt/gentoo/proc #--make-rslave是 systemd 需要的

# dev/shm
test -L /dev/shm && rm /dev/shm && mkdir /dev/shm
mount --types tmpfs --options nosuid,noexec,nodev shm /dev/shm
chmod 1777 /dev/shm

# tmpfs
```

> Chroot: `chroot /mnt/gentoo /bin/bash`

### Config

+ soure /etc/profile
+ export PS1="(chroot) $PS1"
+ export HISTCONTROL="ignoreboth:erasedups"

> /etc/

+ /etc/fstab 
+ echo 'hostname="my-gentoo-pc"' > /etc/conf.d/hostname
+ /etc/hosts
+ /etc/issue
+ /etc/localtime
+ /etc/timezone
+ /etc/env.d/02locale
+ /etc/locale.gen
+ /etc/rc.conf 
+ /etc/conf.d/keymaps 
+ /etc/conf.d/hwclock 
+ /etc/conf.d/net
+ /etc/inittab 

> 同步 snapshot,portage 树：emerge-webrsync或者emerge --sync或者直接解包之前的 snapshot 包。

+ `emerge-webrsync`
+ `emerge --sync --quiet`

> 从列表选择一个默认的 profile

```Bash
eselect list
eselect  profile list
# base 
eselect profile set 16
```

设置 USE 标记配置系统： emerge --info|grep ^USE;  /etc/portage/make.conf: `nano /etc/portage/make.conf`

> 更新 USE 标记: emerge --ask --update --deep --newuse @world


> clock & date 

```Bash
ls /usr/share/zoneinfo/
echo 'Alsa/Shanghai' > /etc/localtime
echo "Asia/Shanghai" > /etc/timezone
emerg --config sys-libs/timezone-data
date -s "19:45"
```

+ languages & locales: /etc/locale.gen /etc/env.d/02locale 

```Bash
locale-gen 
eselect locale list
eselect locale set 3
echo 'LANG="en_US.UTF-8"' > /etc/env.d/02locale 
env-update && source /etc/profile && export PS1="(chroot) $PS1"
```

> news:

+ `eselect news list`
+ `eselect news read`
+ `eselect news purge`

> portage package config

+ package.license
+ package.use
+ package.unmask 
+ package.keywords
+ make.conf

> Install kernel & inintramfs

```Bash
emerge --ask pciutils
echo kernel
emerge --ask sys-kernel/gentoo-sources 
emerge --ask sys-kernel/linux-firmware
emerge --ask sys-kernel/genkernel
cd /usr/src/linux
zcat /proc/config.gz > .config
# make help
# make defconfig
make menuconfig
make -j4 && make modules_install
make install 

genkernel all 
genkernel --install initramfs 
genkernel --lvm --mdadm initramfs 

etc-update && env-update && source /etc/profile && export PS1="(chroot) $PS1"
```


+ Add user: 

```Bash
passwd
mount /dev/disk/by-label/Home /home
useradd -m -d /home/user/Gentoo -g kyzs -G wheel -r -s /bin/bash kyzs && passwd 
```

> 配置网络

```Bash
cd etc/init.d
ln -sv net.lo net.wlp3s0
rc-update add net.wlp3s0 default
```

> network tools: 

+ iw
+ ip 
+ net-wireless/wpa_supplicant
+ dhcpcd & dhcp
+ net-misc/netifrc
+ swig
+ wireless-tools

> System Services: 

+ `emerge --ask app-admin/sysklogd; rc-update add sysklogd default`
+ `app-admin/syslog-ng sys-process/cronie`
+ `emerge  --ask sys-process/cronie; rc-update add cronie default`
+ `emerge  --ask sys-apps/mlocate`
+ `rc-update add sshd default`

> Grub:2

```Bash
mkdir /boot/efi -vp
mount /dev/disk/by-label/ESP /boot/efi
```
> system tools: 

+ e2fsprogs 
+ sys-boot/{grub:2,efibootmgr,os-prober}
+ sys-apps/lsb-release
+ sys-fs/{xfsprogs,jfsutils,dosfstools,btrfs-progs,reiserfsprogs}
+ sys-apps/{pciutils,pcmciautils}
+ sys-fs/dosfstools 
+ emerge --search ntfs
+ emerge -av sys-fs/ntfs3g

> 参考

+ [Configuring the Linux kernel - Gentoo Wiki](https://wiki.gentoo.org/wiki/Handbook:AMD64/Installation/Kernel/zh-cn#.E5.AE.89.E8.A3.85.E6.BA.90.E7.A0.81)
+ [Configuring the network - Gentoo Wiki](https://wiki.gentoo.org/wiki/Handbook:AMD64/Installation/Networking/zh-cn)
+ [Gentoo Linux安装详解--根据官方WiKi整理](http://www.mamicode.com/info-detail-78622.html)
+ [Gentoo Linux 快速安装方法安装_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2011-12/48644.htm)
+ [gentoo wpa_supplicant解决WPA加密的WIFI连接 - 为程序员服务](http://ju.outofmemory.cn/entry/198074)
+ [gentoo安装和使用 - Linux操作系统：Ubuntu_Centos_Debian - 红黑联盟](http://www.2cto.com/os/201210/160411.html)
+ [gentoo使用wpa_supplicant配置无线网卡-Linux教程-爱好Linux技术网](http://www.ahlinux.com/start/base/8257.html)
+ [Gentoo无线网络配置wpa_supplicant - 其他 - 红黑联盟](http://www.2cto.com/os/201501/367153.html)
+ [Gentoo系统安装步骤详解_LINUX_操作系统_脚本之家](http://www.jb51.net/LINUXjishu/393587.html)
+ [Linux-4.4-x86_64 内核配置选项简介](http://www.jinbuguo.com/kernel/longterm-linux-kernel-options.html)
+ [启用systemd的gentoo安装方法 - KlausZL的个人页面 - 开源中国社区](http://my.oschina.net/klauszl/blog/223752)


## FAQ

### Gentoo 中文字体在重新引导系统或者注销之后再次登录到桌面变成了另外一种字体。

检查 fontconfig 以及中文字体，可能是 media-fonts/arphicfonts 在 `emerge --update --deep --ask --verbose --newuse @world` 之后作为依赖被安装到了系统中。

+ `eselect fontconfig list`
+ `eselect fontconfig enable/disable `

> 列出软件包中的文件： `equery files media-fonts/arphicfonts media-fonts/croscorefonts`


[^install]: Install 之前: 准备 Gentoo 可启动盘…… ，可启动`Gentoo`镜像：，stage 3 （可选），portage 树（可选），check md5sums: `gpg --keyserver hkp://keys.gnupg.net --recv-keys 0xBB572E0E2D182910` `gpg --verify install-amd64-minimal-20170810.iso.DIGESTS.asc` `grep -A 1 -i sha512 install-amd64-minimal-20170810.iso.DIGESTS.asc` `sha512sum install-amd64-minimal-20170810.iso`
[^kernel_option]: 按下 F2, F3, F4 分别可以列出选项以及可选择的内核参数。默认选择 gentoo 
[^wpa2]: 无线网络(wpa2加密)wpa_supplicant 和 dhcpcd(也许需要在系统中先停掉这个服务)`wpa_passhare "SSID" "PASSWORD" >> /etc/wpa_supplicant/wpa_supplicant.conf` `wpa_supplicant -i wlp3s0 -c /etc/wpa_supplicant/wpa_supplicant.conf -B && dhcpcd wlp3s0` 检查网络。如果你不熟悉`wpa_supplicant`的配置，记得准备一份以作参考。
[^stage3]: stage3 包含了安装 Gentoo 时，它的根文件系统需要的基本目录层次结构以及那些必须和可能要用到的的工具
[^snapshot]: snapshot 包含了安装 Gentoo 时需要的 portage 树，是可选的一个打包……
[^gentoo_uefi]: 过去的 Gentoo 的启动盘并不支持从 UEFI 启动，2020 以后已经支持了。据称只有少数的 Live DVD 可以。
[^gentoo_systemd]: Gentoo 默认使用的 init 是 OpenRC，
[^paci]: `alias paci="emerge --ask --verbose --autounmask-write"`