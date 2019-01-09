#  compier_android
在64位的Ubuntu 14.04上编译安卓4.2.2:
Install Sun JDK1.6 with 64

U-BOOT SET:
host exec:
# minicom

minicom execute:
TINY4412# set bootargs console=ttySAC0,115200n8 androidboot.console=ttySAC0 uhost0=n ctp=2 skipcali=n vmalloc=512m lcd=S70 init=/init root=/dev/mmcblock0p1 rootwait rw 
TINY4412# set bootcmd movi read kernel 0 40008000\;movi read rootfs 0 41000000 100000\;bootm 40008000 41000000


Nfs引导的android系统:
nfs配置:
Ubuntu:
install nfs-kernel-server
# apt-get install nfs-kernel-server

edit /etc/exports
# vim /etc/exports

as root,execute:
# service nfs-kernel-server start

uboot-set:
TINY4412# set bootargs console=ttySAC0,115200n8 androidboot.console=ttySAC0 uhost0=n ctp=2 skipcali=n vmalloc=512m lcd=S70 init=/init root=/dev/mmcblock0p1 rootwait rw 
TINY4412# sset bootcmd movi read kernel 0 40008000\;bootm 40008000 41000000

