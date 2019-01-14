# Linux Shell[^shell]笔记

## sh：波恩 Shell 

##  Bash

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
+ bind
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

## Zsh

> 参考：

+ [Zsh (简体中文) - ArchWiki][zsh]

[zsh]: https://wiki.archlinux.org/index.php/Zsh_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)


## Tcsh

## Csh

## Ksh


[^shell]:  