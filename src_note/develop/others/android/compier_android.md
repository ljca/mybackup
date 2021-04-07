<link href="../../../css/style.css" rel="stylesheet" type="text/css" />


# 编译 & 移植 Android
```Bash
# compier_android
在64位的Ubuntu 14.04上编译安卓4.2.2:
Install Sun JDK1.6 with 64

U-BOOT SET:
host exec:
# minicom

minicom execute:
TINY4412# set bootargs console=ttySAC0,115200n8 androidboot.console=ttySAC0 uhost0=n ctp=2 skipcali=n vmalloc=512m lcd=S70 init=/init root=/dev/mmcblock0p1 rootwait rw 
TINY4412# set bootcmd movi read kernel 0 40008000\;movi read rootfs 0 41000000 100000\;bootm 40008000 41000000
```


## Nfs引导的android系统:

> nfs配置: Ubuntu:

```Bash
install nfs-kernel-server
# apt-get install nfs-kernel-server

# /etc/exports

# as root,execute:
service nfs-kernel-server start

# uboot-set:
TINY4412# set bootargs console=ttySAC0,115200n8 androidboot.console=ttySAC0 uhost0=n ctp=2 skipcali=n vmalloc=512m lcd=S70 init=/init root=/dev/mmcblock0p1 rootwait rw 
TINY4412# sset bootcmd movi read kernel 0 40008000\;bootm 40008000 41000000
```

## 编译 Android 

```Bash
sudo apt-get install -y vim
sudo apt-get install -y chromium-browser pepperflashplugin-nonfree  adobe-flashplugin  chromium-browser-l10n 
s vim install-sun-java6.sh 
tar  --strip-components=3 -xf linux_tools.tgz
tar  --strip-components=3 -xvf linux_tools.tgz
sudo tar --strip-components=3 -xvf linux_tools.tgz -C /usr/local/bin
tar --recursive-unlink -xvf linux_tools.tgz 
sudo apt install gperf
pushd /home/external/android/
sudo apt install bison
sudo apt install xsltproc
sudo apt install libcore
sudo apt install g++ dpkg-dev gcc-multilib g++-4.8-multilib
pushd /home/external/android/android-4.2.2_r1/
make -j4
cd /home/external/android/
fastboot flash ramdisk android/android-4.2.2_r1/out/target/product/tiny4412/ramdisk.img 
sudo apt install g++ dpkg-dev gcc-multilib g++-4.8-multilib
pushd /home/external/android/android-4.2.2_r1/
make -j4 
make -j4
```

```Bash
cd /home/external/android/
sudo apt install xfsprogs reiserfsprogs reiser4progs jfsutils kpartx dmraid gpart
showmount -e localhost 
sudo fusermount /mnt/
sudo fusermount -u /mnt/
sudo sshfs -o allow_other ubuntu@localhost:/home/external /mnt
sudo fusermount -u /mnt 
sudo mount -t nfs localhost:/home/external /mnt
sudo umount -v /mnt 
sudo ufw disable 
sudo apt-get remove iptables
sudo service nfs-kernel-server start 
sudo ifconfig eth0 192.168.1.10
sudo apt-get install gstreamer1.0-plugins*
sudo dnw E4412_N.bl1.bin 
sudo dnw bl2.bin 
dnw ../../u-boot.bin 
sudo dnw ../../u-boot.bin 
sudo dnw E4412_tzsw.bin 
sudo -s
tar -xf linux-3.5-20131028.tgz 
cp -f tiny4412_android_defconfig .config 
vim Makefile 
sudo apt install libncursesw5{,-dev}
make menuconfig
make -j3
```

### fastboot：

```Bash
sudo minicom
sudo minicom 
fastboot -w
fastboot flash kernel tiny4412/bunfly/source_code/linux-3.5/arch/arm/boot/zImage 
fastboot flash ramdisk android/android-4.2.2_r1/out/target/product/tiny4412/ramdisk.img 
fastboot flash system android/android-4.2.2_r1/out/target/product/tiny4412/system.img 
mkimage -A arm -O linux -T ramdisk -C none -a 0x40008000 -n "ramdisk" -d ramdisk.img ramdisk-uboot.img
sudo apt-get install uboot-mkimgage
sudo apt-get install uboot-mkimage
sudo apt-get install u-boot-tools
mkimage -A arm -O linux -T ramdisk -C none -a 0x40000000 -n "ramdisk" -d ramdisk.img ramdisk-uboot.img
sudo apt-get install kvm
emulator
sudo minicom 
sudo ifconfig eth0 192.168.1.10
sudo fastboot -w
sudo minicom 
sudo dnw arch/arm/boot/zImage 
sudo ifconfig 192.168.1.10
sudo ifconfig eth0 192.168.1.10
sudo apt-get install android-tools-fsutils -y
sudo apt-get install zlib -y
simg2img system.img system.img.ext4
simg2img old_img/system.img new_img/system.img
simg2img old_img/userdata.img new_img/data.img
cpio -pv ../../android-4.2.2 < ramdisk
sudo mount -o loop system.ext4.img ../../android-4.2.2/system
gunzip -kC -S.img ramdisk.img | cp -iv -
gunzip -kC -S.img ramdisk.img | cpio -iv -
gunzip -kvc -S.img ramdisk.img | cpio -iv -
gunzip -kvc -S.img ramdisk.img | cpio -iv 
sudo mount -o loo data.img ../android-4.2.2/data
sudo mount -o loop data.img ../android-4.2.2/data
sudo mount -o loop cache.ext4.img ../android-4.2.2/cache
sudo minicom 
sudo mount -o loop data.img ../android-4.2.2/data
sudo mount -o loop cache.ext4.img ../android-4.2.2/cache
pushd /home/external/Share/tiny4412/bunfly/source_code/
tar -xf uboot_tiny4412-20130729.tgz 
find . | cpio -ov -H newc | gzip > ../ramdisk-tmp.img
make_ext4fs -s -l 330000000 -a system system-new.img 
make_ext4fs -s -l 330000000 -a system system-new.img system
gunzip -kcv -S.img ../ramdisk.img | cpio -iv
find . | cpio -ov -H newc | gzip > ../ramdisk-uboot.img
mkimage -A arm -O linux -C none -a 0x40800000 -n "ramdisk" -d ramdisk-tmp.img ramdisk-uboot.img
make_ext4fs -s -l 330000000 -a data data.img data
sudo minicom 
sudo dnw E4412_N.bl1.bin 
sudo dnw bl2.bin 
sudo dnw ../../u-boot.bin 
sudo dnw E4412_tzsw.bin 
fastboot -w
sudo fastboot -w
sudo fastboot flash kernel zImage
sudo fastboot flash ramdisk ramdisk-uboot.img
sudo fastboot flash system system-new.img 
pushd /home/external/android-4.2.2
pushd /home/external/Share/tiny4412/bunfly/source_code/linux-3.5
pushd /home/external/Share/android/android-4.2.2_r1/out/target/product/tiny4412
pushd /home/external/Share/android/android-4.2.2_r1
pushd /home/external/Share/tiny4412/
pushd /tmp
sudo minicom 
apt install sysv-rc-conf
sudo apt install sysv-rc-conf -y
sudo apt-get install xubuntu-desktop -y
vim drivers/mmc/core/mmc.c 
sudo minicom
sudo fastboot flash kernel zImage 
sudo minicom 
less /usr/share/doc/bash/examples/startup-files/bashrc 
less /usr/share/doc/bash/examples/startup-files/Bash_aliases 
less /usr/share/doc/bash/examples/complete/bash_completion 
less /usr/share/doc/bash/examples/complete/complete-examples 
sudo ifconfig eth0 192.168.1.10
sudo minicom 
sudo apt-get install lib32z1 lib32ncurses5 lib32bz2-1.0 lib32stdc++6
make -j3 sdk
sudo update-alternatives --install "/usr/bin/javah" "javah" "`pwd`/javah" 1
sudo pkill NetworkManager 
```

## 创建、构建 Android 项目

```Bash
android list
android list target
android list
android list target
android list targetn

LD_LIBRARY_PATH=. java person 
gcc -fPIC -shared -I/home/external/Share/android/tools/jdk6u43/include/{,linux} -o libperson.so person.c
LD_LIBRARY_PATH=. java person 

emulator -kernel $tmp2/kernel-qemu-armv7 -sysdir $tmp -system system.img -data userdata.img -ramdisk ramdisk.img
emulator -kernel $tmp2/kernel-qemu-armv7 -sysdir $tmp -system system.img -data userdata.img -ramdisk $tmp/ramdisk.img
emulator -system system.img -data ./out/target/product/tiny4412/userdata.img -ramdisk ./out/target/product/tiny4412/ramdisk.img
emulator -system system.img -data ./out/target/product/tiny4412/userdata.img -ramdisk ./out/target/product/tiny4412/ramdisk.img

sudo apt-get install exfat-* -y

emulator -help
emulator -shell -sysdir /home/external/Share/android/android-4.2.2_r1/out/target/product/tiny4412 -system system.img -ramdisk /home/external/Share/android/android-4.2.2_r1/out/target/product/tiny4412/ramdisk.img -avd test

android create -n test -t 1 -p . -a TestActivity -k test.android 
android create project -n test -t 1 -p . -a TestActivity -k test.android 
android create project -n test -t 1 -p ./test -a TestActivity -k test.android 

sudo apt-get install libreoffice-l10n-zh-cn unoconv 

find /home/external/Share/android/android-sdk-linux/tools/ -name "mmm"

export ANDROID_PRODUCT_TOP=`pwd`
export ANDROID_PRODUCT_out=`pwd`

mmm /home/external/back/tmp/java/test

android create project -n test -t 1 -p ./test -a Test -k test.android 

mmm /home/external/back/tmp/java/test

android create project -n test -t 1 -p ./test -a Test -k test.android 

mmm /home/external/back/tmp/java/test

sudo vim /etc/udev/rules.d/50-android.rules
sudo chmod a+rx /etc/udev/rules.d/50-android.rules 
sudo service udev restart 

mmm /home/external/back/tmp/java/test
mmm /home/external/back/tmp/java/test
mmm /home/external/back/tmp/java/test2/jni
mmm /home/external/back/tmp/java/test2/jni

sudo apt-get install android-tools-adb
sudo apt-get remove android-tools-adb
sudo vim /etc/udev/rules.d/50-android.rules
sudo chmod a+rx /etc/udev/rules.d/50-android.rules 
sudo service udev restart 

mmm /home/external/back/tmp/java/test
mmm /home/external/back/tmp/java/test

sudo apt-get install android-tools-adb
sudo apt-get remove android-tools-adb

mmm /home/external/back/tmp/java/test2/jni
mmm /home/external/back/tmp/java/test2/test
mmm /home/external/back/tmp/java/test2/jar
mmm /home/external/back/tmp/java/test2
mmm /home/external/back/tmp/java/test2/apk
mmm /home/external/back/tmp/java/test2/jar
sudo apt-get install android-tools-adb
sudo apt-get remove android-tools-adb
mmm /home/external/back/tmp/java/test2
sudo apt-get install android-tools-adb
mmm /home/external/back/tmp/java/test2/apk
mmm /home/external/back/tmp/java/test2/jar
mmm /home/external/back/tmp/java/test2/apk
android create project -n led -k andorid.test -p ./led -a Led 
android create project -t 1 -n led -k andorid.test -p ./led -a Led 
mmm /home/external/back/tmp/java/test2/apk
wget http://prdownloads.sourceforge.net/ctags/ctags-5.6.tar.gz
sudo apt-get install android-tools-adb
mmm /home/external/back/tmp/java/test2/apk
mmm /home/external/back/tmp/java/test2/jar
mmm /home/external/back/tmp/java/test2/apk
android create project -n led -k andorid.test -p ./led -a Led 
android create project -t 1 -n led -k andorid.test -p ./led -a Led 
mmm /home/external/back/tmp/java/test2/apk
mmm /home/external/back/tmp/android/test2/apk
mmm /home/external/back/tmp/android/test2/jar
adb uninstall android.test 
adb install Led.apk 
mmm /home/external/back/tmp/android/led
mmm /home/external/back/tmp/android/test2/apk
adb push ../bin/ledtest /system/xbin
mmm /home/external/back/tmp/android/led/jni
vim led_mod.c 
make ledtest
mmm /home/external/back/tmp/android/led/jni
adb push ../bin/ledtest /system/xbin
vim led_mod.c 
make ledtest
mmm /home/external/back/tmp/android/led/jni
mmm /home/external/back/tmp/android/led
java -jar signapk.jar platform.x509.pem platform.pk8 Led-tmp.apk Led.apk
mmm /home/external/back/tmp/android/led/jni
mmm /home/external/back/tmp/android/led/jni

make ledtest

java -jar signapk.jar platform.x509.pem platform.pk8 Led-tmp.apk Led.apk
w
mmm /home/external/back/tmp/android/checkbox
mmm /home/external/back/tmp/android/led/jni
mmm /home/external/back/tmp/android/led

import android.widget.CompoundButton;
import android.widget.CompoundButton.OnCheckedChangeListener;import android.widget.CompoundButton;

sudo apt-get install ncurses-*
sudo apt-get install ncurses-base ncurses-doc ncurses-examples 
sudo apt install libncurses5-dev
sudo apt install libncursesada2-dev
vim src/led/test/Led.java 
android create project -t 1 -p ./checkbox -a CheckBoxTest -k test.check -n checkbox
mmm /home/external/back/tmp/android/checkbox
cd graphis/ncurses/

sudo apt install libncurses5-dev
sudo apt-get install ncurses-*
sudo apt-get install ncurses-base ncurses-doc ncurses-examples 
sudo apt install libncurses5-dev
sudo apt install libncursesada2-dev

vim src/led/test/Led.java 
android create project -t 1 -p ./checkbox -a CheckBoxTest -k test.check -n checkbox
mmm /home/external/back/tmp/android/checkbox

cd graphis/ncurses/
sudo apt install libncurses5-dev

adb shell rm -f /data/local/ledtest.ko
mmm /home/external/back/misc/android/led/jni
mmm /home/external/back/misc/android/led
adb push ledtest.ko /data/local

# 解包 ramdisk.img 
cpio -ivmd < ../ramdisk.img 
find . | cpio -ov -H newc | gzip > ../ramdisk-uboot.img&&mkimage -A arm -O linux -C none -a 0x40800000 -n "ramdisk" -d ramdisk-tmp.img ramdisk-uboot.img
find . | cpio -ov -H newc | gzip > ../ramdisk-uboot.img&&mkimage -A arm -O linux -C none -a 0x40800000 -n "ramdisk" -d ../ramdisk-tmp.img ramdisk-uboot.img
find . | cpio -ov -H newc | gzip > ../ramdisk-tmp.img&&mkimage -A arm -O linux -C none -a 0x40800000 -n "ramdisk" -d ../ramdisk-tmp.img ramdisk-uboot.img

mmm /home/external/back/misc/android/led/jni
mmm /home/external/back/misc/android/led
make_ext4fs -s -l 330000000 -a system system-new.img system
mmm /home/external/back/misc/android/led

sudo add-apt-repository ppa:maarten-baert/simplescreenrecorder
sudo apt-get install simplescreenrecorder*
```

# 参考

+ Ubuntu12.04下Android4.0.4源码的下载及其编译过程-Android开发环境 -Android开发网
