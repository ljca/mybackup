# Linux Shell[^shell]笔记

## sh：波恩 Shell 

##  Bash

BASH 
BASH_ALIASES 
BASH_ARGC 
BASH_ARGV 
BASH_CMDS 
BASH_COMMAND 
BASH_COMPLETION_VERSINFO 
BASH_LINENO 
BASHOPTS 
BASHPID 
BASH_SOURCE 
BASH_SUBSHELL 
BASH_VERSINFO 
BASH_VERSION

### SHELL环境变量

+ HISTSIZE
+ HISTFILE
+ HISTFILESIZE
+ HISTCONTROL
+ HISTIGNORE
+ PS1...PS4
+ HOSTNAME
+ UID

###  Bash内建：

+ job_spec
+ (())
+ .
+ :
+ []
+ [[]]
+ alias
+ bg
+ bind：Bash 键绑定
+ break
+ builtin
+ caller
+ case
+ cd
-P
-L

+ command
+ compgen
+ complete
命令行可编程的补全
-c
-W
-F

+ compopt
+ continue
+ coproc
+ declare
+ dirs
+ disown
+ echo
+ enable
+ eval
+ exec
+ exit
+ export
+ false
+ fc
+ fg
+ for
+ function
+ getopts
+ hash
+ help
+ history
+ if
+ jobs
+ kill
+ let
+ local
+ logout
+ mapfile
+ popd
+ printf
+ pushd
+ pwd
+ read
+ readarray
+ readonly
+ return
+ select
+ set
+ shift
+ shopt
+ source
+ suspend
+ test
+ time
+ times
+ trap
+ true
+ type(Bash内建)：指令识别……

> Note：

+ 如果是`shell`函数定义，还会显示函数定义

```Bash
# Usage:
type [-a] command 
```

> options：

-a 识别命令在系统中的所有可能出处（包括命令别名定义，函数定义，二进制，shell 脚本）

+ typeset
+ ulimit
+ mask
+ unalias
+ unset
+ until
+ variables
+ wait 
+  while
+  { ;}

## §. 工作在 Emacs 模式下的 Bash 快捷键列表，所有的键映射可以通过`bind`查看和设置……

+ Ctrl+A 行首
+ Ctrl+B/Alt+B 字符/单词前移动
+ Ctrl+C 中断程序。
+ Ctrl+D/Alt+D 流结束符，退出 shell/单词后檫除
+ Ctrl+E 行尾
+ Ctrl+F/Alt+F 字符/单词后移动
+ Ctrl+G 结束搜索模式
+ Ctrl+H 字符檫除
+ Ctrl+I 等同制表符
+ Ctrl+J 回车
+ Ctrl+K 檫除光标之后所有字符并将文本移入删除环
+ Ctlr+L 清屏/Alt+L 大小写转换
+ Ctrl+M 换行
+ Ctrl+N 下一条历史记录
+ Ctrl+O 上下文补全
+ Ctrl+P 上一条历史
+ Ctrl+Q 解锁
+ Alt+R/Ctrl+R 撤销更改/正向搜索,取消
+ Ctrl+S 挂起终端
+ Ctrl+T/Alt+T 反转字符/单词
+ Alt+U/Ctrl+U 单词大写/檫除光标之前所有字符并将文本移入删除环
+ Ctrl+V 控制字符的输入方法
+ Ctrl+W 前
+ ……
+ Ctrl+Y/Alt+Y 在删除环循环
+ Ctrl+Z 程序后台运行
+ Alt+\>/Alt+<
+ Ctrl O：遍历补全文件名：menu-complete
+ Ctrl G：中止 Ctrl R
+ Alt #：注释指令
+ Alt *：将所有文件名作为放入参数放入命令行参数列表
+ Alt !：子命令补全
+ Alt @：主机名补全
+ Alt $：变量补全
+ Alt ~：用户名补全
+ `Ctrl _`：撤销键入

> Ctrl+X 模式：

**&nbsp;&nbsp;当 Bash 处于 emacs 模式下并且需要在终端键入一个长长的带很多参数的命令时，可以按下 Ctrl+X  Ctrl+E 启动一个文本编辑器(这个编辑器可以由 EDITOR 环境变量来指定)来编辑这个或者这一组命令，保存退出之后即可执行。**

+ `Ctrl R`：重载 Readline init file，~/.inputrc，/etc/inputrc
+ `Ctrl v`：打印 Bash 版本



> 参考：

+ [第 14 章 命令系统 Bash](https://i.linuxtoy.org/docs/guide/ch14s05.html)
+ [开源世界旅行手册](https://i.linuxtoy.org/docs/guide/index.html)

## Zsh

> 参考：

+ [Zsh (简体中文) - ArchWiki][zsh]

[zsh]: https://wiki.archlinux.org/index.php/Zsh_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)


## Tcsh

## Csh

## Ksh

[^shell]:  

