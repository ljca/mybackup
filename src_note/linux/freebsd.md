<link href="../css/style.css" rel="stylesheet" type="text/css" />

# FreeBSD 笔记

## pkg: FreeBSD 10+ 预编译软件包管理

+ install：安装
+ search：查询
+ remove: 移除
+ repo
+ info
+ query
+ rquery
+ ....

## FreeBSD ports 系统
### 同步 ports：pacsnap

+ 解包：`pacsnap extract`
+ 更新：`pacsnap update`

## FreeBSD make

+ 搜索：`make search key/name=`
+ 安装：`make install clean`
+ 卸载：`make deinstall`

## 升级 FreeBSD freebsd-version 

+ `freebsd-version -k`
+ `freebsd-version -u`

+ 小幅度的系统版本升级：`freebsd-update -k RELEASE-10 upgrade` 

## 手动网络配置：ifconfig
### 配置默认 IP 和 路由 `/etc/rc.conf`

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

### 配置默认 DNS `/etc/resolv.conf`

```ini
nameserver="192.168.43.1"
```

+ [freebsd系统之 基础网络配置](https://www.cnblogs.com/gailuo/p/9483958.html)
+ [FreeBSD 网络配置](https://wiki.freebsdchina.org/faq/networking)
+ [FREEBSD手工配置网络_Unix_BSD_操作系统_脚本之家](http://www.jb51.net/os/Unix/1448_all.html)
+ [01]FREEBSD SSH、dns、netmask、gateway 网络配置 - PatrickWong - 博客园
+ FreeBSD设置IP地址、网关、DNS的方法_UnixBSD_操作系统_脚本之家
+ freebsd使用大全手工配置网络（转载）

## 参考：

+ [FreeBSD 的 Ports 系统 FreeBSDChina Wiki](https://wiki.freebsdchina.org/faq/ports#%E6%80%8E%E4%B9%88%E5%AE%89%E8%A3%85_ports_%E7%B3%BB%E7%BB%9F)
+ [FreeBSD 和 Linux 有什么不同？_Linux新闻_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2015-07/120834.htm)
+ [FreeBSD 使用手册](https://www.freebsd.org/doc/zh_CN/books/handbook/book.html#ports-overview)
+ [sudo的使用 FreeBSDChina Wiki](https://wiki.freebsdchina.org/doc/s/sudo_with_sudo)

[^freebsd]: FreeBSD 使用 `OpenRC` 作为系统的 `init`。因此，所有 OpenRC 指令（如 service /etc/rc.d/.. start）都可用。
[^singer_user]: FreeBSD 的单用户模式就在系统引导时的选择序列中。因此，无需对引导或者内核参数进行修改。

# 附

## 安装

FreeBSD 9+ 安装框架 bsdinstall

+ [FreeBSD Mirror list](http://mirrors.ustc.edu.cn/freebsd/releases)

