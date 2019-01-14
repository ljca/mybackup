# Gentoo 笔记：
 
# 附

## 安装 

### Install 之前

> 制作 Gentoo 可启动盘……

+ 可启动`Gentoo`镜像：
+ stage 3 （可选）
+ portage 树（可选）

```Bash
gpg --keyserver hkp://keys.gnupg.net --recv-keys 0xBB572E0E2D182910
gpg --verify install-amd64-minimal-20170810.iso.DIGESTS.asc 
grep -A 1 -i sha512 install-amd64-minimal-20170810.iso.DIGESTS.asc 
sha512sum install-amd64-minimal-20170810.iso
```

> 从 BIOS[^bios]启动 Gentoo 可启动盘，选择一个内核和可选内核参数启动[^kernel_option]，开始安装 Gentoo 前的准备。

### 设置网络[^wpa2]。

### 磁盘配置

```Bash
mount -v /dev/disk/by-label/Gentoo /mnt/gentoo
cd /mnt/gentoo

blkid
swapon /dev/sda9

# 配置网络。。。

links https://www.gentoo.org/download

#. 解包 stage3 和 portage 树……
tar --numric-owner --xattrs-include=*.* -xvpf stage3*.tar.bz2 -C mnt/gentoo #tar -xf stage3...tar.gz --xattrs -p --numeric-owner

find / -type f -name ".keep" -exec rm -v '{}' ';'

## Set make.conf设置 MAKEOPTS SYNC GENTOO_MIRRORS CFLAGS....... snapshot，portage 树 

```

### chroot 前要做的工作：

#### 挂载必须的虚拟文件系统
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

#### 拷贝必须的配置文件到目标系统

```Bash
cp /etc/wpa_supplicant/wpa_supplicant.conf /mnt/gentoo/etc
cp -Libv /etc/resolv.conf /mnt/gentoo/etc

mirrorlist -i -o >> /mnt/gentoo/etc/portage/make.conf 

## Chroot
chroot /mnt/gentoo /bin/bash
```

## 配置

```Bash
soure /etc/profile
export PS1="(chroot) $PS1"

设置 USE 标记配置系统：
emerge --info|grep -i '^use'
nano /etc/portage/make.conf

# 更新 USE 标记
emerge --ask --update --deep --newuse @world

# 同步 snapshot,portage 树：emerge-webrsync或者emerge --sync或者直接解包之前的 snapshot 包。
emerge-webrsync 
emerge --sync --quiet

# 从列表选择一个默认的 profile
eselect list
eselect profile list
eselect news list
eselect news read
eselect profile set 3

export HISTCONTROL="ignoreboth:erasedups"

# clock
echo 'Alsa/Shanghai' > /etc/localtime
emerge --config sys-libs/timezone-data

# languages & locales 
nano /etc/locale.gen 
locale-gen 

eselect locale list
eselect locale set 3

env-update && source /etc/profile && export PS1="(chroot) $PS1"

# kernel & initramfs
emerge --ask pciutils

emerge --ask sys-kernel/gentoo-sources
cd /usr/src/linux
zcat /proc/config.gz > .config
# make help
# make defconfig
make menuconfig
make -j4 && make modules_install
make install 

emerge --ask sys-kernel/genkernel
genkernel --install initramfs 
emerge --ask sys-kernel/linux-firmware

mount /dev/disk/by-label/Home /home

groupadd kyzs
useradd -m -d /home/user/Ootneg -g kyzs -G wheel -r -s /bin/bash ootng
passwd ootng
passwd 
su - ootneg
usermod -m -d /home/user/Ootng ootng
```

### Install software

```Bash
emerge --ask swig
emerge --ask iw 
emerge --ask net-wireless/wpa_supplicant
emerge --ask wireless-tools
emerge --ask dhcpcd
emerge --ask ip 

emerge --ask app-editors/vim
emerge --ask app-misc/mc
emerge --ask fbterm

emerge e2fsprogs 

mkdir /boot/efi -vp
mount /dev/disk/by-label/ESP /boot/efi

emerge --ask sys-boot/{grub:2,efibootmgr,os-prober}

emerge --ask bash-completion
emerge --search ntfs
emerge --ask app-admin/syslog-ng sys-process/cronie
emerge --ask sys-apps/lsb-release
emerge --ask sys-fs/{xfsprogs,jfsutils,dosfstools,btrfs-progs,reiserfsprogs}

```

## 参考

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


## GentooUSE标记

> 一些ebuild需要或禁止USE标志的某些组合才能正常工作。 这通过放置在 REQUIRED\_USE，用一组条件来表示。 此条件确保所有功能和依赖性都已完成，并且构建将成功并按预期执行。 如果任何一个不符合，emerge会提醒你，并要求你解决这个问题。

```
下面是REQUIRED_USE的一个例子：
Example 	Description
REQUIRED_USE="foo? ( bar )" 	如果 foo 被设定, 必须设定bar 。
REQUIRED_USE="foo? ( !bar )" 	如果 foo 被设定， 必须设定 bar。
REQUIRED_USE="foo? ( || ( bar baz ) )" 	如果 foo被设定， 必须设定 bar 或baz 。
REQUIRED_USE="^^ ( foo bar baz )" 	foo bar 或baz 必须有一个被设定
REQUIRED_USE="|| ( foo bar baz )" 	至少 foo bar 或 baz 有一个被设定。
REQUIRED_USE="?? ( foo bar baz )" 	foo bar 或 baz中必须同时被设定多个
```

> 参考：

+ [USE Flags](https://www.gentoo.org/support/use-flags/)

# FIQ 
## 当我在Gentoo上安装chromium的时候，遇到了下面的问题

```log
!!! The ebuild selected to satisfy ">=media-video/ffmpeg-3:=" has unmet requirements.
- media-video/ffmpeg-3.2.6::gentoo USE="X alsa bzip2 encode gpl hardcoded-tables iconv mp3 network opengl postproc sdl threads truetype vorbis x264 xcb xvid zlib (-altivec) -amr -amrenc (-armv5te) (-armv6) (-armv6t2) (-armvfp) -bluray -bs2b -cdio -celt -chromaprint -cpudetection -debug -doc -ebur128 -fdk -flite -fontconfig -frei0r -fribidi -gcrypt -gme -gmp -gnutls -gsm -iec61883 -ieee1394 -jack -jpeg2k -kvazaar -ladspa -libass -libcaca -libilbc -librtmp -libsoxr -libv4l -lzma (-mipsdspr1) (-mipsdspr2) (-mipsfpu) (-mmal) -modplug (-neon) -nvenc -openal -openh264 -openssl -opus -oss -pic -pulseaudio -rubberband -samba -schroedinger -snappy -speex -ssh -static-libs -test -theora -twolame -v4l -vaapi -vdpau -vpx -wavpack -webp -x265 -zimg -zvbi" ABI_X86="(64) -32 (-x32)" CPU_FLAGS_X86="mmx sse sse2 -3dnow -3dnowext -aes -avx -avx2 -fma3 -fma4 -mmxext -sse3 -sse4_1 -sse4_2 -ssse3 -xop" FFTOOLS="aviocat cws2fws ffescape ffeval ffhash fourcc2pixfmt graph2dot ismindex pktdumper qt-faststart sidxindex trasher"

  The following REQUIRED_USE flag constraints are unsatisfied:
    cpu_flags_x86_sse? ( cpu_flags_x86_mmxext )

  The above constraints are a subset of the following complete expression:
    libv4l? ( v4l ) fftools_cws2fws? ( zlib ) test? ( encode ) postproc? ( gpl ) frei0r? ( gpl ) cdio? ( gpl ) samba? ( gpl ) encode? ( x264? ( gpl ) x265? ( gpl ) xvid? ( gpl ) X? ( !xcb? ( gpl ) ) ) cpu_flags_x86_avx2? ( cpu_flags_x86_avx ) cpu_flags_x86_fma4? ( cpu_flags_x86_avx ) cpu_flags_x86_fma3? ( cpu_flags_x86_avx ) cpu_flags_x86_xop? ( cpu_flags_x86_avx ) cpu_flags_x86_avx? ( cpu_flags_x86_sse4_2 ) cpu_flags_x86_aes? ( cpu_flags_x86_sse4_2 ) cpu_flags_x86_sse4_2? ( cpu_flags_x86_sse4_1 ) cpu_flags_x86_sse4_1? ( cpu_flags_x86_ssse3 ) cpu_flags_x86_ssse3? ( cpu_flags_x86_sse3 ) cpu_flags_x86_sse3? ( cpu_flags_x86_sse2 ) cpu_flags_x86_sse2? ( cpu_flags_x86_sse ) cpu_flags_x86_sse? ( cpu_flags_x86_mmxext ) cpu_flags_x86_mmxext? ( cpu_flags_x86_mmx ) cpu_flags_x86_3dnowext? ( cpu_flags_x86_3dnow ) cpu_flags_x86_3dnow? ( cpu_flags_x86_mmx )

(dependency required by "www-client/chromium-60.0.3112.78::gentoo[system-ffmpeg]" [ebuild])
(dependency required by "chromium" [argument])
```

然后我尝试：

```Bash
# 自动解决 USE 标记
emerge --autoumask-write --ask www-client/firefox
```

```Bash
# 并更新配置文件
etc-update #
dispatch-conf # 合并 USE 标记
```

[^kernel_option]: 按下 F2, F3, F4 分别可以列出选项以及可选择的内核参数。默认选择 gentoo 

[^wpa2]: 无线网络(wpa2加密)wpa_supplicant 和 dhcpcd(也许需要在系统中先停掉这个服务)`wpa_passhare "SSID" "PASSWORD" >> /etc/wpa_supplicant/wpa_supplicant.conf` `wpa_supplicant -i wlp3s0 -c /etc/wpa_supplicant/wpa_supplicant.conf -B && dhcpcd wlp3s0` 检查网络。如果你不熟悉`wpa_supplicant`的配置，记得准备一份以作参考。

[^stage3]: stage3 包含了安装 Gentoo 时，它的根文件系统需要的基本目录层次结构以及那些必须和可能要用到的的工具

[^snapshot]: snapshot 包含了安装 Gentoo 时需要的 portage 树，是可选的一个打包……

[^bios]: 然而 Gentoo 的启动盘并不支持从 UEFI 启动，据称只有少数的 Live DVD 可以。

[^gentoo_systemd]: Gentoo 默认使用的 init 是 OpenRC，
