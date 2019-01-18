# sed [^sed] 笔记

[^sed]: sed 是 Linux 以及 Unix 变体上的 I/O 流编辑器。

+ options:
 + -i：对文件直接应用
 + -n：取消自动打印模式空间
 + -r：启用扩展正则表达式
 + -e：启用多个表达式支持
 + -f：指定 sed 脚本

## sed 的模式空间[^model_space]命令

[^model_space]: 

+ s：替换

> 除了 s(替换) 指令可以使用除'/'外的字符分隔表达式外，其余指令指定的表达式不能使用除左斜杠'/'外的字符分隔表达式。

> 在 sed 表达式中要启用诸如\n之类的转义需要多次转义或者添加 -r 选项到命令行中。使用 sed 在对流进行替换时，指定的表达式和替换表达式需遵循： 指定的表达式中所包含的特殊字符（元字符）需要被转义，而与之对应的：替换表达式中的元字符不需要转义……

```Bash
sed 's/MA/Massachusetts/' list 
sed 's/MA/, Massachusetts/' list 
sed 's/ MA/, Massachusetts/' list 
sed 's/ MA/,Massachusetts/' list 
sed 's/ MA/, Massachusetts/' list 
sed 's/ MA/,Massachusetts/' list 

# sed -e 's/ MA/,Massach/' -e 's/ PA/,Pennsyl/' list <==> sed 's/ MA/,Massach/;s/ PA/,Pennsyl/' list

```

{} 对表达式应用一组 sed 指令。

```Bash
sed '/^##/{s/^##//;n;G}' file
```

```Bash
## 删除多余空行，会同时移除行首的空行，但会保留尾部空行
sed '/./,/^$/!d' file|I/O
```


+ d：删除模式空间里的行

```Bash
'/expression/d' # 或者 '/expression/'d

# 或者
'N[,M]d' # 删除第 N 或者第 N 到 M 行
/^$/d # 删除空行
'N[,M]!d' 保留第 N 或者第 N 到 M 行

/expression/,+Nd # 删除匹配表达式的行到其后的N行
/expression/,$d # 删除匹配表达式的行到末行

# 隔行删除
N~Md # 从第 N 行开始，隔 N-M 行删除
```
+ p
+ n (next)
+ i  在之前插入行

```Bash
sed 'n[,m]i ' file | I/O
sed '1i\ ' file | I/O
sed 1i"`date`" file | I/O
```

+ a 在之后插入行
+ c
+ r/w

```Bash
'/reg/r file' [file | I/O]
'/reg/w file' [file | I/O]
```

## sed 多行模式空间指令
+ N
+ D
+ P

## sed 保持空间

+ g/G：复制 / 追加保持空间的到模式空间

```Bash
sed G lynx_bookmarks.html 
sed 'G;G' lynx_bookmarks.html 
sed '/^$/d;G' lynx_bookmarks.html 
```

+ h/H：复制 / 追加模式空间到保持空间
+ x：交换

### 分支，测试
+ :
+ b
+ t

# 附
## 正则表达式
## 元字符
+ `.`：
+ `^`：
+ `$`：
+ `[]` | `[^]`
+ `*`：
+ `\{\}`：用于具体次数匹配

## 扩展元字符
+ `\+`：
+ `\{\}`：
+ `\(\)`：匹配字串
+ `\?`：
+ `\|`：
+ `&`：匹配表达式
 
 不幸的是，很多元字符和扩展元字符会被 sed 直接解释，除了 ^ $ [] * 等元字符，大多数的元字符都需要转义。就连 . 也需要转义。


> 参考：

+ 《sed & awk 指南》
+ [SED（Unix 流 编辑器）单行脚本快速参考中文版](http://sed.sourceforge.net/sed1line_zh-CN.html)
+ [Linux sed 命令操作详解](https://www.linuxidc.com/Linux/2017-05/144214.htm)
+ [linux零基础学习之Linux sed 命令常用操作详解](http://blog.51cto.com/12306609/2060245)
+ [sed系列:行或者模式匹配删除特定行](http://www.cnblogs.com/eustoma/p/5452794.html)
+ [sed命令_Linux sed 命令用法详解：功能强大的流式文本编辑器](http://man.linuxde.net/sed#%E8%BF%BD%E5%8A%A0%EF%BC%88%E8%A1%8C%E4%B8%8B%EF%BC%89%EF%BC%9Aa\%E5%91%BD%E4%BB%A4)
+ [学习 Linux，101_ 文本流和过滤器](http://www.ibm.com/developerworks/cn/linux/l-lpic1-103-2/index.html)
+ [某行的前一行或后一行添加内容 _ 旺旺知识库](http://www.toxingwang.com/linux-unix/linux-basic/2721.html)
+ sed系列:行或者模式匹配删除特定行
