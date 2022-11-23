<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# 文件系统笔记

## Windows 
dos7.1

win1.0/win3.1/windows95/windows97/windows98/windows2000  
win95 fat16/fat32
可移动磁盘支持的文件系统  

### FAT12/16/32

#### Exfat

理论上，windowsNT以上的内核仅能识别所有fat系列(fan16...fat32,exfat)的文件系统和ntfs文件系统，
由于文件系统的限制，fat系列的文件系统不能存放超过4G的文件，但exfat是个例外，它也属于fat系列的文件系统，但它可以存放超过4G的文件。  
4.8的磁盘精灵(DiskGenius)也不能已经识别exfat文件系统，它会将已经格式化为exfat文件系统的分区识别为未格式化的扩展文件系统

### NTFS
NT4.0/NT5.0/NT6.0  
windowsXP/windows2003/windowsVista/windows7/windows8/windows8.1/windows10  
ntfs

## Unix 及 Unix 变体

### Linux 

#### Ext2/3/4
要识别Mac和Linux的文件系统，  
需要安装能识别二者文件系统的软件或者说是驱动程序，但以我目前的知识仅仅知道能识别Mac的HFS+,Linux的扩展文件系统(ext2,ext3,ext4)

对于较新的文件系统btrfs,resizefs,jfs等以及Unix世界的文件系统

  

#### Xfs

#### RreiserFS

#### BtrFS

### BSD 伯克利
#### Ufs
#### Vfs

### Mac 
#### Hfs+

### IBM
#### Jfs
