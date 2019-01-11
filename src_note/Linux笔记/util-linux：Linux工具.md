#  util-linux：Linux工具
addpart：

agetty：

blkdiscard：

blkid：

blockdev：

cal：

cfdisk：

chcpu：

chfn：

chrt：

chsh：

col：

colcrt：

colrm：

column：

ctrlaltdel：

delpart：

dmesg：

eject：

fallocate：

fdformat：

fdisk：

findfs：

findmnt：

flock：

fsck：

fsck.cramfs：

fsck.minix：

fsfreeze：

fstrim：

getopt：

hexdump：

hwclock：

i386：

ionice：

ipcmk：

ipcrm：

ipcs：

isosize：

kill：

last：

lastb：

ldattach：

linux32：

linux64：

logger：

login：

look：

losetup：

lsblk：

lscpu：

lsipc：

lslocks：

lslogins：

lsns：

mcookie：

mesg：

mkfs：

mkfs.bfs：

mkfs.cramfs：

mkfs.minix：

mkswap：

more：

## [mount][mount]

mountpoint：

namei：

newgrp：

nologin：

nsenter：

partx：

pivot_root：

prlimit：

raw：

readprofile：

rename：

renice：

resizepart：

rev：

rtcwake：

runuser：

## [script][script]
## [scriptreplay][script]


setarch：

setsid：

setterm：

sfdisk：

su：

sulogin：

swaplabel：

swapoff：

swapon：

switch_root：

taskset：

ul：

## [umount][mount]

uname26：

unshare：

utmpdump：

uuidd：

uuidgen：

vigr：

vipw：

wall：

wdctl：

## whereis：指令定位工具

wipefs：

write：

x86\_64：

zramctl：

[mount]: util-linux/mount.md
[script]: util-linux/script.md

# other_tools

## erase/rm
## erase
## file/stat
## more/less
## dump
## sudo
## ps
## kill
## skill
## nice
## killall
## bg/fg
## jobs
## useradd/userdel
## groupadd/groupdel
## passwd/gpasswd
## usermod/groupmod

## iconv：文件编码转换工具
iconv -f 源文件编码(输入文件编码) -t 目的编码 要转换的文件(即源文件或者输入文件) -o 输出文件名

参数解释：
-f
-t 
-o 指定输出文件名(如果输出文件和源文件同名，那么将会覆盖源文件内容。如果不带-o选项则会将转换编码后的文件内容输出到控制台)

## shutdown/halt/poweroff/reboot
## crontab/at
## tzselect
## hwclock
## locale
