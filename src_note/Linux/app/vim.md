# vim安装与配置笔记
## 安装

已知某些系统源中的vim会和gvim冲突，二者只能有一个存在系统中。

### 从源码安装 vim

同时安装vim和gvim可以尝试手动编译安装，以下的configure选项允许VIM80支持所有特性,包括图形界面:

```Bash
./configure \
		--with-features=huge \
		--enable-luainterp \
		--enable-perlinterp \
		--enable-cscope \
		--enable-multibyte \
		--enable-pythoninterp \
		--enable-python3interp \
		--enable-rubyinterp \
		--enable-xim \
		--disable-selinux \
		--enable-gui=yes \
		--prefix=/usr

sudo make -j8 VIMRUNTIMEDIR=/usr/share/vim/vim80

sudo make install
```

## vim基本配置
windows上的vim/gvim可能使用了和Linux上不同位置不同名称的vim启动文件
windows gvim启动文件 $VIM\_vimrc $VIM\gvimrc %userprofile%\.vimrc

> Linux vim启动文件:

+ /etc/vim/vimrc
+ ~/.vimrc
+ ~/.vim/vimrc

### vim/gvim插件配置
### pathogen：管理插件的插件 
git地址:https://git.com/tpope/vim-pathogen
Windows下的VIM(Vi Impls...)插件默认安装到$VIMRUNTIME和$VIM/vimfiles/或者~/vim/vimfiles下的一些特殊的目录中，所有插件都以一个可执行的vim或者vmp文件出现
这些目录中的插件在vim/gvim启动时会被自动载入，当然，这需要正确配置了vim/gvim启动文件
插件目录

+ autoload
+ ftplugin(filetypeplugin)
+ plugin
+ syntax
+ colors
+ doc
+ .....

可能需要花费很多的时间的到各个目录中查找vim脚本文件。而且也不便于管理
pathogen插件由to...编写，这个插件使用了另外一种方式来管理插件

每个插件都位于自身的目录下，而这些目录又都位于用户主目录的.vim/bundle目录下
vim/gvim在启动时，如果正确配置了pathogen插件，这个插件会自动递归查找~/.vim/bundle目录下(插件目录)的所有的用户插件并载入它

### [Vunble](https://github.com/gmarik/vundle.git)(Vim Bundle)

Vunble插件的安装并不难，但之后的vim插件安装则需要git|curl工具的支持
Vundle bundle插件安装位置：
%userprofile%\.vim\bundle

使用Vundle bundle安装插件默认安装位置: $VIM/vimfiles/bundle
使用Vundle bundle安装插件默认安装位置: ~/.vim/bundle

BundleInstall
BundleUninstall 
BundleList

[插件地址](https://github.com/ervandew/eclim/releases/)

## vim键盘映射

造成vim不易使用的几个可能原因是vim不仅存在多种工作模式，键盘映射(快捷键)也和大多数的文本编辑器不同，功能繁杂多样，不过vim提供了重新映射快捷键的方法。

### vim工作模式：

n[ore]map(正常模式,当vim不以任何参数或者特殊参数启动或者打开一个文件时或者在插入、替换、可视模式下键入Esc键之后)

i[nsert]map(插入模式,当在正常模式键入i/I,c/C,s/S,o/O……键之后)

v[isual]n[ore]map(可视模式,当正常模式下键入v或者V)


r[eplay]map(替换模式,当在正常模式之下键入R之后)
可视行，可视，可视块
词替换，字母替换，行替换

搜索模式：当在正常模式下键入半角字符问号(?)或者正斜杠(/)

末行(命令)模式：当在正常模式下键入半角字符冒号(:)时

### vim键映射

+ 正常模式键映射:

  + 插入：i/I,o/O,a/A,c/C,s/S
  + 替换插入 R
  + 替换:r
  + 删除 x/X d/D
  + 删除并进入插入模式 s/S c/C
  + 复制/剪切/粘贴 yy/p `v/V/<C-v>`
  + 移动 j,k,l,h <===> ↓,↑,→,←
  + 行定位 w/W,e/E,b/B,`0/$,<C-u>/<C-b>,<C-d>/<C-f>`
  + 定位 J,K,L,M,H,f/F
  + 撤销和undo u/U `<C-r>`
  + 宏录制 q
  + 块编辑 `<C-o>` `<C-v>I/C/A<Esc><Esc>`

末行(命令)模式键映射:

+ 取得光标处的单词 `<C-r><C-w>`

+ 插入模式下键映射:

+ 选择一个剪贴板粘贴 `<C-r>`

+ 可视模式键映射:

+ 替换模式键映射:

## vim插件语法
vim插件元素：vim变量(variable)：vim变量、控制结构、函数等主要用于vim插件和vim脚本的编写。

&nbsp;&nbsp;经过自由配置之后，vim甚至可以具有所有IDE具有的功能，甚至比某些IDE功能更强，然而,即使加载的插件足够多，却仍是不占用操作系统多少内存和处理器资源的.因为vim插件是以文本文件形式存在的!只要有懂得足够的知识，甚至可以自己编写插件。

变量声明定义的一般语法：
let [g:] vari_name = 
！g:前缀表示该变量是全局的.

> 系统变量和vim自定义变量

+ $VIIMRUNTIME
+ $VIM
+ &filename
+ &filetype

vim插件元素：vim控制结构

if结构语法：

```
if expression 
....
elseif expression 
....
else 
....
endif
```

vim同样也有循环结构，

```
for expression
.....
endfor

while expression
....
endwhile

....

```

## vim 脚本中的变量和函数

! 和大多数编程语言相同，vim函数也分vim已经定义好的和用户自定义的 ! 因此，在定义用户函数时需要将函数名大写或者添加s:前缀来覆盖替换掉已经定义好的函数,否则是无法正常调用的。
函数的调用和定义顺序并没有严格规定,
vim函数的一般定义语法:

```
func[tion][!] [s:]fun_name
......
endfunc[tion]
```

> vim已经定义的函数：

+ echo
+ has()
+ expand()
+ line()
+ append()
+ setline()

> 特殊符号

+ %号在vim中表示文件名
+ %< 没有后缀的文件名

# 附
## windows不在Vundle中管理的插件备份

+ ..\plugin\a.vim
+ ..\plugin\bufexplorer.vim
+ ..\plugin\genutils.vim
+ ..\plugin\grep.vim
+ ..\plugin\jsbeautify.vim
+ ..\plugin\lookupfile.vim
+ ..\plugin\minibufexpl.vim
+ ..\plugin\taglist.vim
+ ..\plugin\vimcdoc.vim
+ ..\plugin\visualmark.vim
+ ..\plugin\vulkan1.0.vim
+ ..\plugin\winfileexplorer.vim
+ ..\plugin\winmanager.vim
+ ..\plugin\wintagexplorer.vim
+ ..\syntax\help_cn.vim


粘贴缩进错乱：
+ 粘贴前先在 vim 中启用粘贴模式 `set paste`再执行粘贴操作

然后粘贴完可选的取消这种状态 `set nopaste`

## YCM：一个很厉害的VIM代码补全插件
vim version must support python：

```
$ vim --version

:version
:echo has('python') || has('python3')

```

> Quike Installation

```Bash
install.py --clang-completer ~/vim/bundles/YouCompleteMe ~/third_party/ycmd/clang_archives/clang+llvm-3.9.0-x86_64-opensuse13.2.tar.xz
```


> Full Installation
```
mkdir ~/{ycm_build,ycm_tmp}

tar -xf clang+llvm-3.9.0-x86_64-opensuse13.2.tar.xz -C ~/ycm_tmp

pushd ~/ycm_build;

cmake -G "Unix Makefiles" -DPATH_TO_LLVM_ROOT=~/ycm_tmp/clang+llvm-3.9.0-x86_64-opensuse13.2 . ~/.vim/bundle/YouCompleteMe/third_party/ycmd/cpp

cmake --build . --target ycm_core --config Release
 
cp ~/.vim/bundle/YouCompleteMe/third_party/ycmd/cpp/ycm/.ycm_extra_conf.py ~/.vim
```

> Configure，Edit User vimrc，add flowing this lines:

====== ~/.vim/vimrc =====

```
let g:ycm_global_ycm_extra_conf = '~/.vim/.ycm_extra_conf.py'
```


##  参考：

+ [CENTOS6.5中VIM插件配置，重点记录YouCompleteMe的安装 2015-7 - bboxhe的专栏 - 博客频道 - CSDN.NET](http://blog.csdn.net/bboxhe/article/details/46849167)
+ [GitHub - edkolev_promptline.vim_ Generate a fast shell prompt with powerline symbols and airline colors](https://github.com/edkolev/promptline.vim)
+ [GitHub - edkolev_tmuxline.vim_ Simple tmux statusline generator with support for powerline symbols and statusline _ airline _ lightline integration](https://github.com/edkolev/tmuxline.vim)
+ [GitHub - humiaozuzu_dot-vimrc_ Maple's vim config files](https://github.com/humiaozuzu/dot-vimrc)
+ [GitHub - itchyny_lightline.vim_ A light and configurable statusline_tabline for Vim](https://github.com/itchyny/lightline.vim)
+ [GitHub - spf13_spf13-vim_ The ultimate vim distribution](https://github.com/spf13/spf13-vim)
+ [GitHub - vim-airline_vim-airline_ lean & mean status_tabline for vim that's light as air](https://github.com/vim-airline/vim-airline)
+ [Vim插件简单介绍_开发工具_酷勤网](http://www.kuqin.com/shuoit/20140814/341684.html)
+ [Vim插件简单介绍 - 推酷](http://www.tuicool.com/articles/ZvAniqM)
+ [VIM多行编辑插件：vim multiple cursors - OPEN 开发经验库](http://www.open-open.com/lib/view/open1366183098984.html)
+ [Vim交换CapsLock和Esc](http://www.dutor.net/index.php/2010/05/vim-swap-capslock-esc/comment-page-1/)
+ [Vim配置、插件和使用技巧 - 简书](http://www.jianshu.com/p/a0b452f8f720)
+ [vim配置及插件安装管理（超级详细） - namecyf的专栏 - 博客频道 - CSDN.NET](http://blog.csdn.net/namecyf/article/details/7787479)
+ [Vim 配置文件===_etc_vimrc - myswirl的日志 - 网易博客](http://myswirl.blog.163.com/blog/static/513186422011484148767/)
+ [Vim学习指南 - 技术翻译 - 开源中国社区](http://www.oschina.net/translate/learn-vim-progressively)
+ [Vim与Python真乃天作之合：打造强大的Python开发环境 - 编程派 _ Coding Python - SegmentFault](https://segmentfault.com/a/1190000003962806)
+ [vi_vim使用进阶_ vimrc初步 - Augusdi的专栏 - 博客频道 - CSDN.NET](http://blog.csdn.net/augusdi/article/details/39969083)
+ [Vundle首页、文档和下载 - 使用git来管理vim插件 - 开源中国社区](http://www.oschina.net/p/vundle)
+ [搭建gVim+Eclim开发Android应用程序_Linux编程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2011-08/41342.htm)
+ [分享一下个人的Vim配置文件 - Ricky.K - 推酷](http://www.tuicool.com/articles/FRVri2b)
+ [高效vim插件 - Lee-Jane的个人页面 - 开源中国社区](http://my.oschina.net/swuly302/blog/156784)
+ [将Vim改造为强大的IDE—Vim集成Ctags_Taglist_Cscope_Winmanager - 枯藤舍 - 开源中国社区.html](https://my.oschina.net/kutengshe/blog/423497)
+ [将你的Vim 打造成轻巧强大的IDE - OPEN 开发经验库](http://www.open-open.com/lib/view/open1429884437588.html)
+ [将你的Vim 打造成轻巧强大的IDE - 乐正](http://yuez.me/jiang-ni-de-vim-da-zao-cheng-qing-qiao-qiang-da-de-ide/)
+ [配置.vimrc，打造自己的vi - bill_chuang的专栏 - 博客频道 - CSDN.NET](http://blog.csdn.net/bill_chuang/article/details/18219009)
+ [手把手教你把Vim改装成一个IDE编程环境(图文) - 吴垠的专栏 - 博客频道 - CSDN.NET](http://blog.csdn.net/wooin/article/details/1858917)
+ [提高 Vim 使用效率的 12 个技巧 - 文章 - 伯乐在线](http://blog.jobbole.com/87481/)
+ [为Bash和VIM配置一个美观奢华的状态提示栏-技术 ◆ 学习_Linux.中国-开源社区](https://linux.cn/article-5249-1.html)
+ [像 IDE 一样使用 Vim - 推酷](http://www.tuicool.com/articles/f6feae)
+ [转,最佳vim技巧 - napoleon_liu - 博客园](http://www.cnblogs.com/napoleon_liu/articles/1988535.html)
+ [最佳vim技巧 - RichardYSteven的专栏 - 博客频道 - CSDN.NET](http://blog.csdn.net/RichardYSteven/article/details/5833097)
+ [最佳vim技巧 - - 博客频道 - CSDN.NET](http://blog.csdn.net/ubuntu_hao/article/details/14100939)
+ vim之tags_C语言_第七城市.html
+ [YCM YouCompleteMe安装完全指南 - 推酷](http://www.tuicool.com/articles/M3a6Vn2)
+ [YCM的安装与配置 - Linux系统教程](http://www.linuxdiyf.com/linux/16064.html)
+ [Vim 自动补全插件 YouCompleteMe 安装与配置 - 推酷](http://www.tuicool.com/articles/QBnAr2)
+ [Vim自动补全神器：YouCompleteMe - 文章 - 伯乐在线](http://blog.jobbole.com/58978/)
+ [Linux中源码安装编译Vim_Linux教程_Linux公社-Linux系统门户网站](https://www.linuxidc.com/Linux/2014-04/99717.htm)
+ [Vim自动补全插件----YouCompleteMe安装与配置](https://www.linuxidc.com/Linux/2014-04/99719.htm)
+ [一步一步带你安装史上最难安装的 vim 插件 —— YouCompleteMe - 简书](http://www.jianshu.com/p/d908ce81017a?nomobile=yes)
+ VIM补全插件YouCompleteMe编译安装详细步骤 - vcbin的博客 - 博客频道 - CSDN.NET
+ [YCM的安装与配置_微科社区](http://www.java123.net/994294.html)
+ [Ubuntu 15.04下为Vim安装YouCompleteMe插件_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2015-07/120352.htm)
+ [Vim使用YouCompleteMe达到类似IDE的代码提示、补全，以及其他实用设置-布布扣-bubuko.com](http://www.bubuko.com/infodetail-446364.html)
+ [Vim安装youcompleteme自动补全插件_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2016-11/137665.htm)
+ [Vim自动补全插件----YouCompleteMe安装与配置_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2014-04/99719.htm)
+ [vim下使用YouCompleteMe实现代码提示、补全以及跳转设置 - 阳台 - 博客园](http://www.cnblogs.com/chris-cp/p/4589249.html)
+ [Vim 自动补全插件 YouCompleteMe 安装与配置 _ 净土](http://howiefh.github.io/2015/05/22/vim-install-youcompleteme-plugin/?utm_source=tuicool&utm_medium=referral#%E5%AE%8C%E5%85%A8%E5%AE%89%E8%A3%85)