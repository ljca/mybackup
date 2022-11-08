
[^lfs]: LFS(Linux From S...)，源码构建Linux基本系统 

## 构建必备环境
## 工具链 

> 主机必须已经安装以下软件包 `texinfo` 开发软件包 `*-devel` `c/c++库` `libstdcxx` `libstd*` `gcc/g++` `bison`
 
> 具备以下条件 

```
/bin/sh -> /bin/bash 
/usr/bin/awk -> /usr/bin/gawk 
/usr/bin/yacc -> /usr/bin/bison 
/usr/bin/cc -> /usr/bin/gcc 
binutils ldd --version 
glibc ld--version 
gcc --version 
g++ --version 
coreutils chown 
util-linux 
sed 
makeinfo 
find --version 
bzip2 
gzip 
xz
```

第一遍 
binutils-2.25 
gcc4.9.2 
gcc4.9.2-deepends:mpfr,gmp,mpc,isl-0.10|0.11|0.12,cloog-0.17|0.18 
linux3.19头文件 
glibc(C语言库)
第二遍 
binutils-2.25-depends 
需要isl0.10|0.11|0.12,cloog0.17|0.18一同编译 
编译isl需要gmp,找不到gmp.h头文件
gcc-4.9.2
 
coreutils
 
## 工具链调整

## 构建基系统 

gcc-deepens: gmp mprf mpc cloog isl
perl
XML::Pars
kmod-depends 
gtk-doc
python-2.27-{,doc}+ 
docbook-xml 
docbook-xsl-{,doc} 
libffi 
libxml2 
xstl
grub 
systemd

```Bash
sudo mkdir -pv $LFS/sources
sudo chmod -v a+wt $LFS/sources
wget --input-file=wget-list --continue --directory-prefix=$LFS/sources
```

# 附

> 参考：

+ [Lfs Book](https://lctt.github.io/LFS-BOOK) 
+ [LFS-Book-7.7-systemd](https://linux.cn/lfs/LFS-BOOK-7.7-systemd/index.html)
+ [LFS-Book-7.7-systemd-pdf](https://dn-linuxcn.qbox.me/lfs/LFS-BOOK-7.7-systemd.pdf)
+ [systemd](https://lctt.github.io/LFS-BOOK/lfs-systemd/index.html) 
+ [SysV](https://lctt.github.io/LFS-BOOK/lfs-sysv/LFS-BOOK.html) 
+ [Beyond Linux® From Scratch](http://www.linuxfromscratch.org/bdownloads/7.7/BLFS-BOOK-7.7-nochunks.html)
+ [好久没有用Linux了，重新用Debian8编译了一遍LFS-7](http://blog.chinaunix.net/xmlrpc.php?r=blog/article&uid=615510&id=5584643)
+ [分享：LFS7.5中遇到的问题及解决办法-内核源码-ChinaUnix.net](http://bbs.chinaunix.net/thread-4151174-1-1.html)
+ [手把手教你如何建立自己的Linux系统第二版PDF_Linux下载_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2011-08/40705.htm)
+ [LFS、BLFS、ALFS、HLFS的区别](http://www.ha97.com/3927.html)
+ [lfs-support failing to configure Texinfo package](http://lists.linuxfromscratch.org/pipermail/lfs-support/2014-June/047034.html)
+ [LFS与BLFS 7.6版本发布，从头构建自己的Linux系统_Linux新闻_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2014-10/107640.htm)
+ [LFS源码安装fcitx-4.2.9-mmx384-ChinaUnix博客](http://blog.chinaunix.net/xmlrpc.php?r=blog/article&uid=615510&id=5593207)
+ [LFS 中文版手册发布：如何打造自己的 Linux 发行版_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2015-07/119840.htm)
+ [Linux From Scratch](http://www.jinbuguo.com/lfs62/index.html)
+ [零起点构建自己的Linux ( LFS-6.2-5 ＋ BLFS-6.2.0 )](http://www.phpfans.net/ask/fansa1/5203889388.html)
+ [我在BLFS中遇到的一些问题（非求助）](http://www.phpfans.net/ask/fansa1/9994845314.html)
+ [【转】 从LFS到BLFS-compilehacker-ChinaUnix博客](http://blog.chinaunix.net/uid-23219753-id-116154.html)

```Bash

bash --version|head -n1
readlink -f /bin/sh
ld --version|head -n1
dnfi bison
yacc --version
sudo cp -sv /usr/bin/bison /usr/bin/yacc
readlink -f /usr/bin/yacc
yacc --version|head -n1
bzip2 --version 2>&1 < /dev/null|head -n1|cut -d" " -f1,6-
echo -n "Coreutils: ";chown --version|head -n1
diff --version|head -n1
find --version|head -n1
readlink -f /usr/bin/gawk;gawk --version|head -n1
awk --version | head -n1
gcc --version|head -n1
g++ --version|head -n1
ldd --version|head -n1
grep --version|head -n1
gzip --version|head -n1
cat /proc/version 
m4 --version|head -n1
make --version|head -n1
dnfi patch
patch --version|head -n1
perl -V:version
sed --version|head -n1
tar --version|head -n1
makeinfo --version|head -n1
xz --version|head -n1
echo 'main(){}' >dummy.c&&g++ -o dummy dummy.c
if [ -x dummy ] ; then echo "g++ compilation OK";else echo "g++ compilation failed";fi

```

