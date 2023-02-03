<link href="../css/style.css" rel="stylesheet" type="text/css" />

# FreeBSD 笔记

## 软件包管理

### pkg: FreeBSD 10+ 预编译软件包管理

+ install：安装
+ search：查询
+ remove: 移除
+ repo
+ info
+ query
+ rquery
+ ....

### FreeBSD ports 系统

- 同步 ports：pacsnap
+ 解包：`pacsnap extract`
+ 更新：`pacsnap update`

 > FreeBSD make

+ 搜索：`make search key/name=`
+ 安装：`make install clean`
+ 卸载：`make deinstall`
- 升级 FreeBSD freebsd-version + `freebsd-version -k` `freebsd-version -u` 小幅度的系统版本升级：`freebsd-update -k RELEASE-10 upgrade` 

## 网络配置

### 自动分配 IP： `/etc/rc.conf`

+ [FreeBSD 无线网络设置](https://www.bilibili.com/read/cv18330894)

### 手动网络配置：ifconfig

> 配置默认 IP 和 路由 `/etc/rc.conf`


```ini
# ifconfig em0 192.168.43.119/24 netmask 255.255.255.0
ifconfig_em0="192.168.43.111/24 netmask 255.255.255.0" 
# route add default 192.168.43.1
defaultrouter="192.168.43.1" 
sshd_enable="YES"
```

[^net_ini]: 如果不是手动使用 ifconfig 给网卡添加 ip ，那么通常需要重启 `netif` 和 `routing` 服务。

+ 删除网卡地址：`ifconfig em0 delete`
+ 查看路由表 `netstat -rn`

> 配置默认 DNS `/etc/resolv.conf`

```ini
nameserver="192.168.43.1"
```



> 参考：

+ [freebsd系统之 基础网络配置](https://www.cnblogs.com/gailuo/p/9483958.html)
+ [FreeBSD 网络配置](https://wiki.freebsdchina.org/faq/networking)
+ [FREEBSD手工配置网络_Unix_BSD_操作系统_脚本之家](http://www.jb51.net/os/Unix/1448_all.html)
+ [01]FREEBSD SSH、dns、netmask、gateway 网络配置 - PatrickWong - 博客园
+ FreeBSD设置IP地址、网关、DNS的方法_UnixBSD_操作系统_脚本之家
+ freebsd使用大全手工配置网络（转载）



## 磁盘管理

- 查看磁盘信息：`diskinfo`

> GPT 分区表磁盘使用 gpart[^gpart] 进行管理。

[^gpart]: gpart 可以对 GPT 磁盘进行操作，包括增加（add），删除（），调整（），显示（show）分区信息。

+ 增加：gpart add 
+ 创建文件系统：newfs[^create]

[^create]: newfs 默认只能创建 freebsd-ufs。freebsd-zfs 文件系统需要使用 zfs 配置工具重新配置。同时，zfs 文件系统也需要更多的配置。另外，如果要访问 Linux Ext 系列的文件系统、Windows  NTFS 文件系统，需要在在内核中启用对它们的支持的选项后并重新编译内核以及搜索安装对它们操作的用户级驱动软件。

### UFS

### ZFS  文件系统

> zfs 管理、配置工具 `zpool` `zfs`

- 数据池
- 数据集

> 参考：

- [使用ZFS的十条理由 - ZFS特性介绍](https://blog.csdn.net/laoeyu/article/details/921133?utm_medium=distribute.pc_relevant.none-task-blog-2~default~baidujs_baidulandingword~default-4-921133-blog-114218992.pc_relevant_landingrelevant&spm=1001.2101.3001.4242.3&utm_relevant_index=7)
- [第九章 FreeBSD之磁盘分区](https://blog.csdn.net/pyf987337461/article/details/116564897)

## 服务管理 service



## 内核模块管理：载入(kldload)

## 内核参数调整、配置工具：sysctl

## /etc/rc.conf 调整、配置工具：sysrc


> 参考：

+ [FreeBSD 的 Ports 系统 FreeBSDChina Wiki](https://wiki.freebsdchina.org/faq/ports#%E6%80%8E%E4%B9%88%E5%AE%89%E8%A3%85_ports_%E7%B3%BB%E7%BB%9F)
+ [FreeBSD 和 Linux 有什么不同？_Linux新闻_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2015-07/120834.htm)
+ [FreeBSD 使用手册](https://www.freebsd.org/doc/zh_CN/books/handbook/book.html#ports-overview)
+ [sudo的使用 FreeBSDChina Wiki](https://wiki.freebsdchina.org/doc/s/sudo_with_sudo)

[^freebsd]: FreeBSD 使用 `OpenRC` 作为系统的 `init`。因此，所有 OpenRC 指令（如 service /etc/rc.d/.. start）都可用。
[^singer_user]: FreeBSD 的单用户模式就在系统引导时的选择序列中。因此，无需对引导或者内核参数进行修改。

# 附

## 安装

<!--

FreeBSD 9+ 安装框架 bsdinstall

-->

- [FreeBSD 中文手册页](https://docs.freebsd.org/zh-cn/books/handbook/)
- [FreeBSD 简体中文手册页](https://handbook.bsdcn.org/freebsd-shou-ce.html)
- [开源镜像站](https://mirrors.aliyun.com/freebsd/releases/ISO-IMAGES/13.1/)
- [FreeBSD Mirror list](http://mirrors.ustc.edu.cn/freebsd/releases)
- [GRUB2引导FreeBSD(GPT+UEFI)](https://www.bilibili.com/read/cv14215466)
- [安装FreeBSD 13.1系统及配置xfce桌面](https://blog.csdn.net/weixin_56596536/article/details/126993719?spm=1001.2101.3001.6650.4&utm_medium=distribute.pc_relevant.none-task-blog-2~default~YuanLiJiHua~Position-4-126993719-blog-77744795.pc_relevant_aa&depth_1-utm_source=distribute.pc_relevant.none-task-blog-2~default~YuanLiJiHua~Position-4-126993719-blog-77744795.pc_relevant_aa&utm_relevant_index=9)
- [FreeBSD 配置经验](https://blog.csdn.net/u011152627/article/details/77744795/)
- [Windows10 和 ZFS 文件系统 FreeBSD UEFI 引导 双系统安装](https://blog.csdn.net/VOlsenBerg/article/details/114218992?spm=1001.2101.3001.6650.3&utm_medium=distribute.pc_relevant.none-task-blog-2%7Edefault%7EBlogCommendFromBaidu%7ERate-3-114218992-blog-82068125.pc_relevant_landingrelevant&depth_1-utm_source=distribute.pc_relevant.none-task-blog-2%7Edefault%7EBlogCommendFromBaidu%7ERate-3-114218992-blog-82068125.pc_relevant_landingrelevant&utm_relevant_index=5)
- [基于GPT和ZFS的FreeBSD安装](https://blog.csdn.net/iteye_16868/article/details/82068125?spm=1001.2101.3001.6650.4&utm_medium=distribute.pc_relevant.none-task-blog-2%7Edefault%7EESLANDING%7Edefault-4-82068125-blog-101428570.pc_relevant_landingrelevant&depth_1-utm_source=distribute.pc_relevant.none-task-blog-2%7Edefault%7EESLANDING%7Edefault-4-82068125-blog-101428570.pc_relevant_landingrelevant&utm_relevant_index=9)

