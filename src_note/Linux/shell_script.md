# Linux Shell 脚本笔记

> &nbsp;&nbsp;Shell脚本不仅可以完成很多重复而又复杂的系统任务，还可以实现一些很有意思的发明。有人竟用它做了shell 版的俄罗斯方块！如果你希望编写脚本来完成一些日常任务，需要了解掌握一些基本的脚本元素。

## Shell脚本元素：变量 ######

> 脚本中变量的定义是简单的。然而，变量定义有一些细节：

+ 在变量名和变量值之间用于赋值的'='号前后不可以存在空格。否则会被 shell 解释为选项。


## Shell脚本元素：注释 ##########

&nbsp;&nbsp;在 shell 脚本可以使用'#'号来注释单行或者多行，但并没有提供类似于高级编程语言如C,C++,Java等的多行注释，只能用#号一行一行的注释，允许出现的位置是行首或者指令的尾部，如果是在尾部应该使用一个以上的空格隔开。

&nbsp;&nbsp;但在vim中,却提供了一组快捷键可以在多行相同的地方插入相同的字符，可以使用这个来同时注释多行。当然,vim也提供了类似与subtext的多光标编辑(就是同时修改出现在多个地方的相同文本)插件。

> 注：特殊建或者组合建使用尖括号扩起来了。比如`<C-v>`表示Ctrl和v键一起键入。

正常模式下，键入快捷键 `<C-v>I<Esc><Esc>`

+ `<C-v>` 可让 vim 进入块可视，上下或者左右与移动选择多行
+ 键入行首插入命令I(大写的i)
+ 键入需要同时插入的字符（跨越单词插入影响最后结果)
+ 按两次Esc。  

它的作用是在选中的行的相同位置插入相同的字符.

## Shell脚本元素：指令 ##########


### Shell 脚本中的测试指令：test指令 ##########


test命令文件测试，比较选项：

+ -f
+ -e
+ -d
+ -r
+ -w
+ -x
+ -s
+ -S
+ -c
+ -b

字符串测试，比较：

+ -n
+ -z

> 注：字符串测试使用了标准的数学比较运算符，而数学运算使用了字符运算符。=或者与Unix兼容的==

+ !=
+ \>
+ <
+ \>=
+ <=

数字结果比较，测试：

+ -eq
+ -ne
+ -gt
+ -lt
+ -ge
+ -le

### 多条件测试：-a和-o ######

### [和[[：简化的test ########



## Shell脚本元素：控制结构 ##########

### if和if-else分支

```Bash
if command|test expression|[ expression ];then 
	command
[ elif command|test expression|[ expression ];then
	command;
else command; ]
fi
```

### case分支

```Bash
case var in
	mode|mode..)
	command;;
	.....
esac [> file]
```

### select分支与其特殊变量：REPLY变量

```Bash
select 单词 in mode...;do
	command;[break]
done
```

### until 循环

### while 循环

```Bash
while test;do command;done;
```

### for 循环

```Bash
for var in file|cmd;do commands;done
```

## Shell脚本元素：函数(function) ##########

> Note：如果你是在脚本中直接调用函数并传递参数给它，那么可能无法在shell函数中使用除第0个位置参数即$0外的其它位置参数。假如你希望位置参数能正确传递给 shell 函数，你需要在交互式 shell 中使用 shell 函数。


```Bash
# 如果你使用了 function 关键字，那么在函数名后可以不必使用圆括号，反之，如果你在 shell 函数后添加了圆括号，则可以不必添加 function 关键字。
# 由于历史原因：圆括号和花括号之间需要使用一个以上的分隔符分开。
# 

[function] fun_name()
{
  :
}
# 一旦定义了函数，就可以直接在交互式 shell 中使用函数名在 shell 调用并根据需要传递参数。假如你希望它在所有的地方都可以使用，那需要使用`export -f`将它导出。
```


> 参考：

+ [shell脚本中一些特殊符号 - 阿笨猫 - 博客园](http://www.cnblogs.com/xuxm2007/archive/2011/10/20/2218846.html)

