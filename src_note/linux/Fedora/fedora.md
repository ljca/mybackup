<link href="../../css/style.css" rel="stylesheet" type="text/css" />

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

> Fedora 配置参考：

<div class="dir">

- [c++g++errorNothatfileanddirectory-StackOverflow](#)
- [DNF的命令使用教学_Linux教程_Linux公社-Linux系统门户网站](#)
- [DNF的命令使用教学 第2页_Linux教程_Linux公社-Linux系统门户网站](#)
- [DNF的命令使用教学 第3页_Linux教程_Linux公社-Linux系统门户网站](#)
- [fc11下fcitx安装小记-changyongID-ChinaUnix博客](#)
- [Fedora-20 uefi U盘安装 - lzshlzsh的专栏 - 博客频道 - CSDN_NET](#)
- [Fedora 20 安装搜狗拼音输入法_Linux教程_Linux公社-Linux系统门户网站](#)
- [Fedora 20下 MySQL 的安装_数据库技术_Linux公社-Linux系统门户网站](#)
- [Fedora 22安装以后的优化和配置_Linux教程_Linux公社-Linux系统门户网站](#)
- [Fedora22添加国内软件源和本地软件源 - Linux系统教程](#)
- [fedora 22下成功安装nvidia驱动 - Linux系统教程](#)
- [fedora23安装配置记录_fedora吧_百度贴吧](#)
- [Fedora 24 Linux 环境下实现 Infinality 字体渲染增强及 Java 字体渲染改善的方法（修订） - 小侠猫猫球 - 博客园](#)
- [Fedora 24 如何安装 Nvidia 显卡驱动_Linux教程_Linux公社-Linux系统门户网站](#)
- [Fedora && Arch Linux – 最浪漫的事现已发生…_Linux教程_Linux公社-Linux系统门户网站](#)
- [Fedora - Redhat 软件包管理指南-jqunjian-ChinaUnix博客](#)
- [Fedora 23 中文显示优化, 超美_桑树湾_新浪博客](#)
- [linux 编译安装php选项](#)
- [Linux系统入门学习：教你在VirtualBox 安装 Fedora 22_Linux教程_Linux公社-Linux系统门户网站](#)
- [mkisofs命令_Linux mkisofs 命令用法详解：建立ISO 9660映像文件](#)
- [安装Fedora 23工作站后，必须要做的24件事_Linux教程_Linux公社-Linux系统门户网站](#)
- [安装Fedora 23工作站后，必须要做的24件事 第2页_Linux教程_Linux公社-Linux系统门户网站](#)
- [安装Fedora 23工作站后，必须要做的24件事 第3页_Linux教程_Linux公社-Linux系统门户网站](#)
- [从RPM文件中提取文件(RPM2CPIO, CPIO的使用)--ChinaUnix博客](#)
- [记录一下fedora20安装后，需要安装的一些必备的软件包 - 其他 - 红黑联盟](#)
- [深入理解Linux引导过程-服务配置-fedora中文站](#)
- [使用yaourtFZUG_repoWikiGitHub](#)
- [Fedora23安装以后要做的优化配置-软件教程-51新闻网](#)
- [Sogou Pinyin 常见问题 · FZUGrepo Wiki · GitHub](#)
- [配置 Infinality 字体渲染增强 · FZUGrepo Wiki · GitHub](#)

</div>

