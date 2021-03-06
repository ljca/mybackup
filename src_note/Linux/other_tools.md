# Other Linux Tools

+ erase
+ file：获取文件类型
+ stat：显示文件统计信息
+ dump
+ sudo
+ ps
+ skill
+ nice
+ killall：根据进程名
+ pkill: 根据进程名杀死进程
+ useradd/userdel
+ groupadd/groupdel
+ passwd/gpasswd
+ usermod/groupmod
+ <a href="#screen" name="screen">screen：Linux 终端多会话</a>
+ [tmux：终端上的多会话](otools/tmux.md)
+ bc：数学计算[^bc]，`echo "15**2"|bc` `bc <<< "15**2"`

```Bash
# 0X2BF 进制转换：16 -> 2
bc <<< "ibase=16;obase=2;0X2BF"
```

+ iconv：文件编码转换工具 `iconv -f 源文件编码(输入文件编码) -t 目的编码 要转换的文件(即源文件或者输入文件) -o 输出文件名`
+ shutdown/halt/poweroff/reboot：关机，重新引导系统
+ crontab/at
+ tzselect：时区选择
+ locale：字符集配置
+ [cv](https://github.com/Xfennec/progress) 显示`cp`、`mv`、等指令在工作时的进度。

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

+ most: 一个分页器，类似 less 或者 more
+ [lsp](https://github.com/dborzov/lsp)

如果你的系统还没有安装`go`，需要先安装`go`。

```Bash
# Install go

# Install lsp

go get github.com/dborzov/lsp

# set PATH
export PATH="$GOPATH/bin:$PATH" # GOPATH 默认在 $HOME/go
```

+ [powertop](https://github.com/fenrus75/powertop)

```Bash
# 编译 poertop
./autogen.sh

./configure --prefix=$HOME/.local --bindir=$HOME/bin 
make && make install 
```

+ ncdu：一个 du 的更好实现
+ htop | atop：一个 top 的更好实现
+ man2html：`man ls | man2html`
+ html2text（python-html2text）：`html2text <(man ls|man2html) > ls.txt` `html2text [options] file|url [encoding]`

+ dos2unix
+ docx2txt
+ MySQL | MariaDB Client: mycli
+ python: bpython | ipython

# 附

+ [asciinema：高级的终端会话记录和回放工具](otools/asciinema.md)
+ [在 Linux 上读取、转换、分隔多媒体格式的多媒体工具集](otools/convert-format.md)
+ [cscope&ctags](otools/cscope-ctags.md)
+ [pandoc](otools/pandoc.md)
+ [xclip：Linux X 下的命令行剪贴板工具](otools/xclip.md)
+ [gvfs-google & gvfs-mtp：让Linux的文件管理器可以自动挂载Android设备的外部和内部存储卡](otools/gvfs_mtp.md)
+ [instant-markdown-d：在浏览器中预览 markdown](otools/instant-markdown-d.md)
+ [我见过的一些终端下很有意思的命令和脚本](otools/intestresting-command.md)

> 参考：

+ 
+ [使用 Synergy 共享你的鼠标和键盘](http://easwy.com/blog/archives/share-your-keyboard-and-mouse-by-synergy/)
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

## tools：

+ [gptfdisk-code](https://git.code.sf.net/p/gptfdisk/code)
+ [afterstep-devel](https://github.com/sashavasko/afterstep-devel)
+ [playall](https://github.com/bedekelly/playall)
+ [leiningen](https://github.com/technomancy/leiningen)
+ [code-prettify](https://github.com/google/code-prettify)
+ [chinese-copywriting-guidelines](https://github.com/mzlogin/chinese-copywriting-guidelines)


[^iconv]:  参数解释： -f 源文件编码，-t 目标文件编码，-o 输出文件名(如果输出文件和源文件同名，那么将会覆盖源文件内容。如果不带-o选项则会将转换编码后的文件内容输出到控制台)，-l 列出所有编码

[^html2text]: 可以是一个本地文件或者url路径,其后的编码项是可选的。选项: --ignore-links --ignore-images `Bash for i in *.html;do html2text2 --ignore-images $i > `echo $i|cut -d. -f1`.logs && mv $i bk;done`

[^bc]: 多个选项使用分号分隔。obase：输出进制，ibase：输入进制，scale：浮点运算时精度控制
