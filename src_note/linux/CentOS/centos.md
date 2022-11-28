<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# Cent OS 7 笔记：

## yum: RedHat 系软件包管理器。

### 配置 yum 仓库

> base 源：`sudo wget -O /etc/yum.repos.d/CentOS-Base.repo http://mirrors.aliyun.com/repo/Centos-6.repo`

> epel 源：

```Bash
wget -P ~/back  http://mirrors.yun-idc.com/epel/6/i386/epel-release-6-8.noarch.rpm
wget -P ~/back http://download.fedoraproject.org/pub/epel/6/i386/epel-release-6-8.noarch.rpm
sudo wget http://mirrors.aliyun.com/repo/epel-6.repo
```

+ yum install：从软件仓库中安装
+ yum search：从软件仓库中搜索
+ yum remove/purge：从系统中移除
+ ....

# 附

+ [rpm 包管理](rpm.md)
+ [ssh：安全连接到远程主机](cent7_ssh.md)
+ [CentOS7在VirtualBox的安装](centos7在virtualbox的安装.md)
+ [centos 7 配置 nfs & Samba](centos7配置nfs.md)
+ [centos7配置vsftpd服务器](centos7配置vsftpd服务器.md)
+ [SELinux: ](selinux笔记.md)
+ [VirtualBox 笔记](virtualbox.md)
+ [web_server缓存服务](web_server缓存服务.md)
+ [web服务器httpd](web服务器httpd.md)
+ [web服务器ngnix](web服务器ngnix.md)

> 参考：

<div class="dir">

+ [Linux编译安装Apache2](http://www.server110.com/apache/201308/78.html)
+ [Linux搭建SVN 服务器 - LionelShen的个人空间 - 开源中国社区](http://my.oschina.net/lionel45/blog/298305)
+ [linux下安装配置svn独立服务器 - 大徐 - 博客园](http://www.cnblogs.com/b028/configive/2010/07/23/1867311.html)
+ [Linux服务器部署系列之一—Apache篇（上） - Tonyguo De博客【知识改变命运，技术成就梦想】 - 51CTO技术博客](http://blog.51cto.com/tonyguo/168534)
+ [Tomcat在Linux上的安装与配置 - 平凡的世界 - 博客频道 - CSDN](http://blog.csdn.net/gyming/article/details/36060843)
+ [Linux下安装Oracle11gR2 – 放牛哥 _ ](http://www.imfng.com/configives/oracleinstall.html)
+ [Oracle 11gR2 64bit On Linux 安装指导手册—数据库技术（一） - Oracle数据库栏目 - 红黑联盟](http://www.2cto.com/database/201108/99323.html)
+ [Linux运维工程师面试-部分题库：Linux磁盘及软件管理操作-中华考试网](http://www.examw.com/linux/rhce/shiti/225021/)
+ [Linux运维面试题答案版 （二）](https://www.douban.com/note/537167408/?type=like)
+ [Kickstart无人值守批量安装Linux系统](https://www.linuxidc.com/Linux/2012-08/68558.htm)
+ [CENTOS 6.6初始化SHELL脚本centos](http://www.centoscn.com/shell/2016/0224/6791.html)
+ [CentOS 系统下编译安装 gcc4.8.2过程及编译问题详解_Linux_第七城市](http://www.th7.cn/system/lin/201605/166259.shtml)
+ [CentOS在SSH中运行GUI图形界面程序 - 鸿网互联](http://www.68idc.cn/help/server/linux/20150305249529.html)
+ [linux CentOS_redhat 6.5 LVM分区使用详解_LINUX_操作系统_脚本之家](http://www.jb51.net/LINUXjishu/499575.html)
+ Linux-CentOS安装N卡驱动以及解决屏幕亮度不可调问题 - xhz1234的专栏 - 博客频道 - CSDN_NET
+ MonoDevelop 4.0.9 on CentOS 6.3 安装笔记 - 钟少 - 博客园
+ yum升级CentOS内核_百度经验
+ 如何在Ubuntu-CentOS上安装Linux内核4_0_百度知道
+ 折腾一天安装Centos7，以及后面恢复Win7引导的曲折历程 - 其他 - 红黑联盟
+ CentOS7_0  安装nvidia 显卡驱动_丿哥之哀傷_新浪博客
+ centos7_0装搜狗拼音 sougou
+ [配置Web服务器 - T_san的日志 - 网易博客]
+ [CENTOS 6.6初始化SHELL脚本centos](#)
- [CentOS7_0  安装nvidia 显卡驱动_丿哥之哀傷_新浪博客](#)
- [centos7_0装搜狗拼音 sougou](#)
- [CentOS 系统下编译安装 gcc4.8.2过程及编译问题详解_Linux_第七城市](#)
- [CentOS在SSH中运行GUI图形界面程序 - 鸿网互联[68IDC.CN]](#)
- [linux CentOS_redhat 6.5 LVM分区使用详解_LINUX_操作系统_脚本之家](#)
- [Linux-CentOS安装N卡驱动以及解决屏幕亮度不可调问题 - xhz1234的专栏 - 博客频道 - CSDN_NET](#)
- [MonoDevelop 4.0.9 on CentOS 6.3 安装笔记 - 钟少 - 博客园](#)
- [yum升级CentOS内核_百度经验](#)
- [如何在Ubuntu-CentOS上安装Linux内核4_0_百度知道](#)
- [折腾一天安装Centos7，以及后面恢复Win7引导的曲折历程 - 其他 - 红黑联盟](#)

</div>

