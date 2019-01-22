# Fedora 23 笔记：

## dnf[^dnf]：Fedora 新一代的软件包管理器

> Usage: `dnf option command subcommand`，Option List：

+ -y 所有的询问都回答 yes

>  Command List：

+ dnf install：从软件仓库中安装软件包
+ dnf remove | purge：从系统中移除软件包

```Bash
dnf remove -y cairo-dock
dnf remove -y google-chrome-stable
```

+ update：更新系统
+ search：从软件仓库中根据软件包名搜索
+ search all：从软件仓库中根据软件包描述搜索
+ clean：清除下载缓存
+ clean all：清除所有缓存
+ makecache：创建 repo 缓存
+ config-manager：配置软件仓库

```Bash
dnf config-manager --add-repo=http://repo.fdzh.org/FZUG/FZUG.repo # 等效于 dnf install http://repo.fdzh.org/FZUG/free/23/x86_64/fzug-release-23-0.1.noarch.rpm
```

> 参考：

+ [DNF的命令使用教学_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2015-06/118751.htm)
+ [Fedora - Redhat 软件包管理指南-jqunjian-ChinaUnix博客](https://blog.csdn.net/chen190735341/article/details/43232077)
+ [Fedora && Arch Linux – 最浪漫的事现已发生…_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2015-08/120923.htm)
+ [Linux 包管理基础：apt、yum、dnf 和 pkg](https://linux.cn/article-8782-1.html)
+ [从RPM文件中提取文件(RPM2CPIO, CPIO的使用)--ChinaUnix博客](http://blog.chinaunix.net/uid-26435987-id-3399279.html)

[^dnf]: 

# 附
## [Fedora Xfce 23 安装 & 配置](install_fedora23_xfce.md)
## [yum 软件包管理系统](../CentOS/centos.md)
## [rpm 软件包管理系统](../CentOS/rpm.md)
