# Linux 命令行[^com]艺术：管道、重定向 & shell 扩展

## §. 命令行艺术：管道

### §. 无名管道 `|`

**&nbsp;&nbsp;虽然说我们可以使用多种连接符（这些连接符可以是 ; && || | ……）连接多个指令，但严格意义上说，只有无名管道才属于真正意义上的单行命令。其它连接符连接的指令实际上只是在逻辑上处于同一行上而已。不仅如此，管道更加符合 [Unix 哲学](tmp/Linux和Unix.md)。**

**&nbsp;&nbsp;`Linux`和其它`Unix`变体都继承了`Unix`古老的`shell`文化。无名管道由内核创建、维护，管道的一端指令输出成为管道另一端指令的输入（相当于对一条或者一组指令执行成功后的输出的多次处理），有点像是工序和流水线上的多级处理。**

```Bash
# 比如下面的废指令……
:|:|:|:;

$(`:`)|:;
```

### §. 有名管道

&nbsp;&nbsp;虽然有名管道不像无名管道那么常用，但实际上，有时候无名管道是没法替代的……

```Bash
# 创建有名管道的指令是`mkfifo`。
mkfifo fifo;cat fifo

script -f fifo
```

## §. 命令行艺术：shell中的文件描述符 & I/O 重定向
### 1. 文件描述符
> 文件描述符是一次性的。0,1,2 分别代表了 stdin,stdout,stderr 

#### 1.1 我们使用 `exec` 来对文件描述符进行重定义/自定义

```Bash
# 首先，需要为文件分配文件描述符：
# 重定向符 > 和文件描述符之间不可以存在空格，否则 shell 会误会你的意思。。。。
exec 4> tmp.c

# 以截断方式写入数据：
echo 'int main(){}' >&4

# 查看文件数据：
cat tmp.c
```

### 2. I/O 流重定向

> 常用重定向符: `<`、`<<`、`<<<`、`>`、`>>`、`<>`、`>|`、`&>`、`>&`，常用重定向：

#### 2.1 输入重定向：
+ `<`： 它只是让指令认为自己的输入来自于文件而不是 I/O 流，实际上，很多时候，我们在用它时都是直接省略的。

把 `.bashrc` 的内容复制到系统剪贴板里：`xclip -sel clip < ~/.bashrc` 统计 `.bashrc` 行： `wc -l < .bashrc`

`xclip -sel clip <(du -sh *)`

+ `<<`：here文档 
*** 我们经常用它来定义结束输入时用的符号 ***

```Bash
# 在没有编辑器的 Linux 系统里，我们常常得这样子来编辑并创建文件（来源于 LFS）。
cat >> test.txt << EOF

EOF

cat << EOF >> test.txt

EOF

wc -l << EOF

EOF


# 执行多条 MySQL sql 查询.
mysql -umysql -p << EOF
use mysql;
select User,Host from user;
show privileges for 'mysql'@'localhost';
show privileges for 'root'@'localhost';
help show privileges;

EOF

```

+ `<<<`：立即字符串

*** &nbsp;&nbsp;这个由三个`<`连接的符号串虽然看着很漂亮而又神秘，实际上它在 `shell` 里有一个很 `low` 的学名，它叫做立即字符串。多数情况下，我们用它代替一些交互式程序的诸如 -e, -c 什么的参数来传递一些需要交互式运行的程序（很多，比如 mail，bc，mysql，python，）的命令行参数[^php_warn]，并将它和一组在交互式程序中才能正确执行的指令连接在一起。目的仅仅只是为了在那种交互式运行的程序中执行一组或者一条指令然后就立即退出这个程序并返回到 shell。或者仅仅给那些需要交互式运行的程序传一些参数什么的进去。就像下面那样子。***

[^php_warn]: 或者，用它代替管道，但遗憾的是：并非所有交互式运行程序都支持这种方式。

`mysql -p <<< "select User,Host from mysql.user;"`
`bc <<< "scale=.2;2.5 * 5.6" <==========> echo "scale=.2;2.5 * 5.6" | bc`
`mail -s "邮件主题" testmp@yeah.net <<< "邮件内容"` <=====> `echo "邮件内容" | mail -s "邮件主题" tmpeslwo@yeah.net`
`bash -c "" ====> bash <<< ""`
`sh -c "" ====> sh <<< ""`

+ `<>`：这个奇怪的重定向符与文件描述符有关，它打开文件是为了可能的读和写。


#### 2.2 输出重定向：
+ `>`
+ `>>`
+ `>|`：强制重定向符
+ tee：同步输出

```Bash
# 将命令输出或者文件显示到标准输出设备的同时也保存到一个或者多个文件
command ... [|tee file_name] [file_name2] [file_name3]}
```

#### 2.3  错误重定向
 + `&>`
 + `>.. 2>&1`
 + `>&`

错误与文件流或者是命令输出重定向到同一个文件

```Bash
command > filename  2>&1 # ==>
command &> filename # ==>
command >& filename
```

#### 2.4 进程替换
+ `< <(subcmd)`
+ `<(subcmd)`
+ `>(subcmd)`
+ `(< cmd)`


## §. 命令行艺术：Shell 扩展
### §. 花括号扩展

### §. 波浪号扩展
#### 1. 用户目录扩展

**&nbsp;&nbsp;单一的 `~` 代表的就是用户自己的主目录，如果在后紧跟一个用户名则是代表这个用户的主目录，当然，只有根用户才有随意使用其它用户主目录的权限。 **

#### 2. 目录栈扩展：如果波浪号后有数字，数字前可能还有 + 或者 - 前缀，则 shell 会对其扩展为目录栈中的字符串……

** &nbsp;&nbsp;据称，目录栈是为了解决经常需要在多个目录或者多个路径很深的目录中来回切换的问题。如果你在 shell 中使用目录栈这个东西，那么这个波浪号可以扩展目录栈的功能那就非常实用了。为了使用目录栈，你需要使用 shell 内建指令 `pushd` 将多个目录压入其中，然后就可以直接从一个目录切换另一个另一个目录中，如果不需要了，可以直接使用 `popd` 弹出某个不常使用的路径，但是： ，**

**&nbsp;&nbsp;如果我想将目录栈中某个路径里面的东西拷贝或者是移动到目录栈中的另外一个路径下，难道要不可忍受的再次键入路径吗？好在，shell 可以对波浪号进行扩展成目录栈解决了这个问题。**

### §. 变量扩展（Bash 手册把它称之为参数扩展），dispatch(分隔符)可以是：

> &nbsp;&nbsp;Bash 的变量扩展需要使用花括号和分隔符。如果没有指定分隔符，就要在冒号后指定偏移量。变量扩展的格式是：`${var:dispatch替代值}`

+ `:-`：假如变量赋值失败或者没有赋值，则扩展为'-'之后指定的值.`${tmp:-$(pwd)}` 
+ `:?`：与'-'相反。
+ `:+`
+ `:%`：单次截断（最后一个字符到截断字符止）等价于 `basename`，比如 `tmp=test.sh ;echo ${tmp:%.*}; ===> test`
+ `:%%`
+ `:#`：单次截断字符（首个字符到截断字符止），比如 `tmp=test.sh;echo ${tmp:#*.} =====> sh`
+ `:##`
+ …… 

### §. 算数扩展 `$(())` & `$[]`

## §. Bash 的组合命令和命令替换 

### 1. (),{}：将命令放入一组执行

+ () 在子 shell 中执行一组指令……

+ {} 在当前 shell 中执行一组指令。由于历史等原因，花括号是 shell 保留关键字，因此位于 '{}' 中的一组指令中的最后一条指令和块命令定界符 '}' 要有一个换行符或者分号…… shell 脚本中同样可以使用管道和重定向，但将程序放入后台执行的 & 并不常用。

### 2. $(),` `` `： 执行命令替换

&nbsp;&nbsp;尽管`Unix`风格的命令替换 ` `` ` 和`GNU`风格的命令替换 $() 都可以用来执行命令替换，也允许嵌套使用。然而，在`Unix`风格的命令替换中，嵌套使用 \` 需要使用 \\ 转义 ……


## §. 工作在 Emacs 模式下的 Bash 快捷键列表

> 所有的键映射可以通过`bind`查看和设置……

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


> Ctrl+X 模式：

**&nbsp;&nbsp;当 Bash 处于 emacs 模式下并且需要在终端键入一个长长的带很多参数的命令时，可以按下 Ctrl+X  Ctrl+E 启动一个文本编辑器(这个编辑器可以由 EDITOR 环境变量来指定)来编辑这个或者这一组命令，保存退出之后即可执行。**

## §. 正则表达式

### 1. 元字符列表

+ /
+ \
+ ^
+ \$

### 2. 匹配模式

+ \w | \W
+ \s | \S
+ ……
+ \*
+ ? 
+ \.
+ \+
+ []
+ {}

[^com]: 以下所有的解释不确定是否对除 `Bash` 之外的 Shell 解释器有效。

> 参考：

+ Bash 4.0 中文手册
