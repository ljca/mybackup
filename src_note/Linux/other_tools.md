# Other Linux Tools
## erase/rm
## erase
## file/stat
## more/less
## dump
## sudo
## ps
## skill
## nice
## killall
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


## [cv](https://github.com/Xfennec/progress) 显示`cp`、`mv`、等指令在工作时的进度。

```Bash
# 编译安装……
# pushd progress
make && make install
# popd

# 简单使用方式：
# 在一个窗口中执行一个耗时指令（仅限 Linux 核心工具里的某些工具）……
# cp/mv……

# 然后尝试打开一个新的窗口运行
progress 

# 如果你希望显示实式进度，使用`watch`打开`progress`。
watch progress -w

```

## [lsp](https://github.com/dborzov/lsp)

如果你的系统还没有安装`go`，需要先安装`go`。

```Bash
# Install go

# Install lsp

go get github.com/dborzov/lsp

# set PATH
export PATH="$GOPATH/bin:$PATH" # GOPATH 默认在 $HOME/go
```


## [powertop](https://github.com/fenrus75/powertop)

```Bash
# 编译 poertop
./autogen.sh

./configure --prefix=$HOME/.local --bindir=$HOME/bin 
make && make install 
```

## ncdu

## htop | atop

## man2html：`man ls | man2html`

## htmltext（python-html2text）：`html2text <(man ls|man2html) > ls.txt`

`html2text [options] file|url [encoding]`

可以是一个本地文件或者url路径,其后的编码项是可选的

> 选项:

--ignore-links
--ignore-images

```Bash
for i in *.html;do html2text2 --ignore-images $i > `echo $i|cut -d. -f1`.logs && mv $i bk;done
```

## dos2unix

## MySQL | MariaDB: mycli

## python: bpython | ipython

## docx2txt

> 参考：

+ [11个让你吃惊的 Linux 终端命令 - 51CTO.COM](http://os.51cto.com/art/201505/476564.htm)
+ [12款最佳Linux命令行终端工具 - 生死看淡，不服就干！ - 博客频道 - CSDN.NET](https://blog.csdn.net/u013634961/article/details/39534521)
+ [Autojump：一个可以在 Linux 文件系统快速导航的高级 cd 命令_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2015-08/121421.htm)
+ [shell常用操作命令系列：服务操作 _ 旺旺知识库](http://www.toxingwang.com/linux-unix/linux-basic/2758.html)
+ [shell常用操作命令系列：网络操作 _ 旺旺知识库](http://www.toxingwang.com/linux-unix/linux-basic/2760.html)
+ [使用Linux终端快捷操作提升工作效率_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2016-04/129852.htm)
+ [快速掌握炫酷的 Linux 命令行_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2016-09/135358.htm)
+ [每位新人必须掌握的五大Linux终端命令_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2016-11/137179.htm)
+ [如何在Bash Shell脚本中显示对话框_Linux编程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2015-06/118301.htm)
+ [Linux下分割合并文件 - Linux操作系统：Ubuntu_Centos_Debian - 红黑联盟](http://www.2cto.com/os/201203/124813.html)
+ [Linux中10个你不知道的命令补齐技巧_LINUX_操作系统_脚本之家](http://www.jb51.net/LINUXjishu/150302.html)
+ [Linux中10个有用的命令行补齐命令](http://www.geekfan.net/8169/)
+ [【转linuxmkisofs命令参数及用法详解---linux制作ISO启动盘命令-Linux新手园地-ChinaUnix](http://bbs.chinaunix.net/thread-3565814-1-1.html)
+ [linux 高速下载工具 aria2 的用法_chris_新浪博客](http://blog.sina.com.cn/s/blog_8cf0057a01017nun.html)
+ [Linux 下载工具 - 开源软件库 - 开源中国社区](http://www.oschina.net/project/tag/97/download-tools?lang=37&sort=view)

