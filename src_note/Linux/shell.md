# Linux Shell[^shell]笔记

## sh：波恩 Shell 

##  Bash

> 一些重要的 SHELL 环境变量

+ HISTSIZE
+ HISTFILE
+ HISTFILESIZE
+ HISTCONTROL
+ HISTIGNORE
+ PS1...PS4
+ HOSTNAME
+ UID
+ .....

> Bash 内建：

+ job_spec
+ (())：执行算术运算。
+ . 等同于 `source`
+ :
+ []: 执行算术运算。
+ [[]]：字符串条件测试
+ alias（定义 shell 别名），`alias name="command options"`
+ bg：将作业放入后台
+ bind：Bash 键绑定
+ break
+ builtin
+ caller
+ case
+ cd[^cd]: 
+ command: 不使用任何定义的别名，函数来运行指令。
+ compgen
+ complete 命令行可编程的补全 -c -W -F
+ compopt
+ continue：shell 函数中的循环中有效。
+ coproc
+ declare：定义或者声明数组，一般用于 shell 脚本。
+ dirs（显示目录栈中的目录项）：`dirs -v`
+ disown
+ echo
+ enable（启用/禁用一个内建指令）：
+ eval
+ exec：
+ exit（退出当前 shell）
+ export（导出一个定义的变量为全局系统变量，也可使用 -f 选项将一个 shell 函数导出为全局）
+ false
+ fc
+ fg：将^Z挂起的作业放入前台继续执行。
+ for
+ function
+ getopts
+ hash
+ help
+ history：显示或者编辑命令历史记录[^history]
+ if
+ jobs：列出后台作业
+ kill：根据给出的命令进程号和选项对进程发送信号，默认是杀死
+ let：算术计算
+ local：仅在 function 中定义和生效的变量。
+ logout：注销系统
+ mapfile
+ popd：从目录栈中移除一个目录项
+ printf：根据指定的格式打印
+ pushd：将一个目录加入/压入目录栈中。
+ pwd：显示当前工作目录。
+ read
+ readarray
+ readonly
+ return：在 function 中返回值给 shell 
+ select
+ set: 设置 shell 选项[^set]或者显示当前 shell 中的环境变量和函数。
+ shift
+ shopt：设置 Shell 选项[^shell_opt]
+ source：在当前 shell 中读取并执行一个 shell 脚本。
+ suspend
+ test[^test]：执行条件测试。
+ time: 
+ times
+ trap
+ true
+ type(指令识别[^type])：`type command `
+ typeset
+ ulimit
+ mask
+ unalias：取消定义一个别名
+ unset：取消定义函数或者变量
+ until
+ variables
+ wait 
+  while
+  { ;}：将一组指令放入当前 shell 执行。

> 工作在 Emacs 模式下的 Bash 快捷键列表，所有的键映射可以通过`bind`查看和设置……

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
+ [_etc_profile、_etc_bashrc、~_](http://blog.chinaunix.net/uid-26435987-id-3400127.html)

## Tcsh
## Csh

> Csh 内建

+ setenv: 设置环境变量，`setenv name value`
+ alias: 定义别名，`alias name command & options`

## Ksh

## Zsh

> 参考：

+ [Zsh (简体中文) - ArchWiki][zsh]

[zsh]: https://wiki.archlinux.org/index.php/Zsh_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)


[^shell]:  

[^type]:  -a 识别命令在系统中的所有可能出处（包括命令别名定义，函数定义，二进制，shell 脚本），如果是`shell`函数定义，还会显示函数定义。 

[^shell_opt]: 

[^set]:  Bash 的位置参数（命令行参数）也可以用 set 设置。

[^test]: 大多数情况下，我们在进行条件测试时可能更喜欢使用 `[`。

[^cd]: `-P -L`
