<link href="../css/style.css" rel="stylesheet" type="text/css" />

# C 语言笔记

## 数据类型[^data_type]

[^data_type]: 包括基本数据类型和复杂数据类型。基础数据类型有整型(int/integer)，整型的又分短整型和长整型，浮点型(float/double)，所有数值类型的数据都可分为有符号型和无符号型。字符型(char)。复杂些的有数组、指针、结构、联合等。

### 字符型(char)

[^_^]: 字符数组和字符指针

[^_^]: 在 C 语言中，字符串常量使用字符数组或者字符指针保存。

```c
char *char="";
char char[]="";
```

### 数组[^arr]

[^arr]: 数组是指拥有同一种数据类型的数据集合,属于结合类型。在为数组分配空间时，分配一组连续的内存地址空间，数组名只是保存了整个数组的首地址，即是数组第一个元素的地址。虽然在栈上分配内存时是从上到下(高地址到低地址,堆是反方向的)分配的，但数组里面的元素的的地址却是从下到上依次递增的。除了在数组初始化时可以对数组直接赋值外，其余任何时候都无法对整个数组重新进行赋值。

::: alert-danger

<div class="p">

访问数组的元素可以依次使用数组索引或者下标访问，但因为数组标识符中保存有整个数组在内存空间中的首地址，因此还可以使用解地址的方式来访问数组中的元素。`*(arr+1)等价与arr[1];`。

不幸的是：gcc在编译源文件时默认并不会检查数组下标，访问不存在的元素可能会返回不正确的值。访问非法的内存可能会引起段错误。比如低地址空间中的变量访问高地址中的，或者访问数组下标之外的元素(数组下标越界);

</div>

:::

数组的一般定义形式：

```c
Type 数组名[];
Type 数组名[] = {值列表};
```

::: alert-info

<div class="p">

Type是数组的类型，可以是基本的也可以是结合型的，或者是自定义型的，比如枚举和结构体。方括号中用来指定数组长度(方括号不一定要和数组一起出现)，即数组中允许的数组元素个数,除非在定义数组时初始化了，才允许不给数组指定具体的长度。否则其它任何时候都应该给数组指定具体的长度。

如果省略了值列表，数组定义就成了数组声明，这时编译器并不会为数组分配内存空间。反之,值列表如果有多个值， 多个值需要使用逗号分隔;字符数组有些特殊，允许将多个字符组合为一个字符串，甚至连用来保存值列表的花括号也不是必须的。

因此，以下的字符数组定义是合法的:

</div>

:::

```c
char ch3[]={'a','b','c','d','e'}; <=> char ch1[] = {"abcde"}; <=>  char ch2[] = "abcde";
```

### 二维数组和多维数组

### 指针数组


## 指针[^指针]

[^指针]: 指针希望保存地址的变量。指针加1等于基类的长度。

```c
//指针的声明和定义形式:

基类 *指针标识符 = NULL;
```

### 数组指针：`()[]`;般用来保存二维以上数组的地址。
### 函数指针：函数指针是一个保存了函数首地址的指针。` 类型(*标识符)([形参]);`

## 常量与宏

::: alert-info

宏[^宏]使用 `#define` 定义[^宏定义]。

:::

[^宏]: 
[^宏定义]: 大多数情况下，我们将宏定义和函数声明放在头文件中。

## 枚举

## 函数(function) 

### main 函数[^main函数]

[^main函数]: main函数是程序的入口函数,它在启动代码执行之后调用。原型： `int main(int argc,char **argv)`。程序的真正入口是__start，它是用汇编写成

### 库函数和系统调用的调用[^调用]

::: alert-info

对于库函数和系统调用，只需要在 c 源文件中使用文件包含指令[^include]包含即可进行调用。

:::

[^调用]: 库函数和系统调用无须用户再次声明。因为它们已经在系统提供的头文件中声明过了。

[^include]: 文件包含使用 `#include <filename>/"filename"` 文件名大多使用一对尖括号`<>` 或者半角双引号""包围。对于尖括号，头文件的搜索路径从/usr/include开始。反之，从用户的源文件处开始搜索。

### 用户函数的声明和定义

#### 函数声明

::: alert-info

一般函数声明[^声明]形式:`函数返回值类型|void 函数名称(参数|void);`

:::

[^声明]: 函数定义在主函数之后，要对这个函数进行声明,如果是在主函数之前定义的函数，就不需要对这个函数声明了。函数声明在主函数之前，函数声明没有函数体，函数声明的形参可以没有标识符,但函数定义不可省略。如果函数没有参数，可以省略void关键字，但返回值如果为void，就不能省略，因为系统默认的函数返回值是int型。

    函数返回值之前还可以有 static，extern __init 等关键字，这些关键字有其它用处。

#### 函数定义


```c
返回值类型|void 函数名称(参数|void)
{
	函数体;
}
```

#### 函数调用：

主调函数(调用者)，被调函数(被调用者)

+ 正常调用
+ 作为其它函数的参数被调用。

### 指针函数

### 函数回调[^callback]

[^callback]: 实际上应该称之为回调函数。当用户调用某个函数时，在它的函数声明的形参中发现了函数指针类型的形参时，就表示用户在实际调用这个函数时需要传入一个和函数指针有着相同返回值和形参列表的函数。而这个函数通常需要用户根据这个函数指针的返回值类型以及形参列表进行定义且必须定义在实际调用之前，否则在调用时还要先声明。

### 可变长参数函数：可变长参数意味着可以传递0个或者多个实参给这个函数。

## 结构(struct)和联合()

```c
//typedef可以为
struct Node{ }; 
```

### 结构和联合的位对齐

## 基础数据结构与算法

### 链表

#### 单链表

+ 单链表节点元素的遍历
+ 单链表节点元素的修改
+ 单链表头插法与尾插法
+ 单链表排序

#### 双链表

### 栈

### 队列

### 树

### 图

# 附

## 预处理指令

+ `#include`
+ `#define` 
+ `#progma` 预处理指令能设置内存的对齐方式
+ `#if #else #endif`


## 注释

+ c99风格的单行注释 //
+ 多行注释 /*  */
+ 条件化注释 

```c
#if 0 
#else 
#endif 
```

## 库函数

###  标准库函数：

> printf

::: alert-info

<div class="p">

标准库函数printf的声明位于stdio.h头文件中。

函数的原型声明：` extern int printf (__const char *__restrict __format, ...);`。这个库函数共有两个形参：常量字符串和可变长参数。

其中，常量字符串是一对以双引号引起来的字符串，在其中允许存在格式控制字符，格式控制字符必须以百分号%开始，后面紧跟一个控制字符，在控制字符之前还可以有更精细的格式控制。

控制字符控制着，它可以是：

</div>

+ c:打印单个字符
+ s:打印字符串
+ [num]d:打印整型数字
+ e/E:打印指数
+ [num].[num]f:打印浮点数 
+ #x/X:打印不带前缀的十六进制数
+ p:打印变量地址(大多数时候用来打印内存地址)
+ #o/O:打印不带前缀的八进制数
+ ...

:::


[^]: 库函数的搜索路径

### 字符/字符串函数

+ strlen
+ strstr
+ strcpy
+ strtok
+ strcmp

## 系统调用
### I/O函数

+ fread
+ fwrite
+ read
+ open
+ close
+ getline
+ fseek/rewind
+ fgets


### 文件/目录

+ FILE
+ DIR

### 内存操作

::: alert-danger

> 内存动态分配和释放

+ malloc
+ free

:::

## 其它笔记

## 运算符

::: alert-info

实际上， sizeof 和 typedef 在 C 语言中并非关键字，而是两个运算符。前者用于计算数据所占用的内存字节数，而后者则用于定义用户数据类型。如果圆括号()中存在某种数据类型关键字，则是用于强制类型转换。

:::

> 逻辑运算符,运算规则：

+ &&
+ ||
+ !
+ `>`
+ `<`
+ `>=`
+ `<=`
+ !=
+ ==  如果逻辑运算赋==写成了赋值运算符=，编译器并不会对此进行检查从而顺利通过编译，因此返回的结果可能与逻辑运算符的不一致。

[^]: 逻辑运算符==不等价于赋值运算符=

> 位运算符,运算规则:

+ &:见0即0
+ |:见1即1
+ ^:只有两个数相异，才为1。如果相同，则为0
+ `~`:
+ `<<` 左移运算，向左移动n(n必须是一个正整数)位,高位被移动过来的低位覆盖，空缺的低位补零 n1 `<<` n
+ `>>`:右移运算，向右移动n位(n必须是一个正整数),低位被移动过来的高位覆盖，空缺的高位补零 n1 `>>` n




## c语言运行的几个阶段：

+ 预处理:编译器调用cpp处理源文件中的预处理指令，展开被包含的文件内容到预处理文件中 $ gcc -E -v。编译器预处理时调用cpp命令展开包含的文件内容到源文件中，形成了预处理文件
+ 编译和汇编 $ gcc -v -c -x [-o 目标文] 预处理文件
+ 链接 $ gcc [-g -v] -o 名称 目标文件
+ 运行程序

[^]: 如果当前路径没有在系统的PATH环境变量中，那么要运行位于当前目录中的程序需要使用点./程序名称来运行。它即代表了当前目录，也是一个特殊的shell内置命令(只用于执行脚本,等价于source命令)

```bash
$ ./program
$ ./../program
$ ./../bin/program
export PATH=$PATH:.
```


+ [arm 笔记：嵌入式设备编程笔记](c-note/arm.md)
+ [cxx](c-note/cxx.md)
+ [C十六进制数的疑惑：一个十六进制数的一位如果换成二进制数的话原来是二进制数的4个位](c-note/C十六进制数的疑惑：一个十六进制数的一位如果换成二进制数的话原来是二进制数的4个位.md)
+ [C双重for循环进行冒泡排序在使用gcc时遇到的问题：内层循环循环控制的初始化部分不可省略？](c-note/C双重for循环进行冒泡排序在使用gcc时遇到的问题：内层循环循环控制的初始化部分不可省略？.md)
+ [gcc](c-note/gcc.md)
+ [kernel 笔记：](c-note/kernel.md)
+ [libcall](c-note/libcall.md)
+ [Linux进程的虚拟地址空间中的堆(heap)和栈(stack)缺省是什么样的生长方向？](c-note/Linux进程的虚拟地址空间中的堆(heap)和栈(stack)缺省是什么样的生长方向？.md)
+ [network](c-note/network.md)
+ [operator_priority](c-note/operator_priority.md)
+ [shared_mem](c-note/shared_mem.md)
+ [sort：排序](c-note/sort.md)
+ [strlen_sizeof](c-note/strlen_sizeof.md)
+ [term 函数：](c-note/term.md)
+ [thread](c-note/thread.md)
+ [Unix网络编程](c-note/Unix网络编程.md)
+ [一个精巧的十进制转二进制（巧妙的位运算）程序，来源于C语言详解](c-note/一个精巧的十进制转二进制（巧妙的位运算）程序，来源于C语言详解.md)
+ [使用Ｃ语言获取文件大小](c-note/使用Ｃ语言获取文件大小.md)
+ [函数指针与指针函数](c-note/函数指针与指针函数.md)
+ [常量指针与指向指针的常量](c-note/常量指针与指向指针的常量.md)
+ [数据结构之线性表](c-note/数据结构之线性表.md)
+ [数组指针与指针数组](c-note/数组指针与指针数组.md)
+ [检查主机是网络little-enddle还是big-enddle](c-note/检查主机是网络little-enddle还是big-enddle.md)
+ [让GNU Compier Collections在编译时输出的编译信息带上色彩](c-note/让GNUCompierCollections在编译时输出的编译信息带上色彩.md)
+ [Ｃ语言操作MySQL数据库：从连接到MySQL数据库服务器开始](c-note/Ｃ语言操作MySQL数据库：从连接到MySQL数据库服务器开始.md)
+ [Ｃ语言的结构与联合内存对齐问题：结构或者联合大小取决于？](c-note/Ｃ语言的结构与联合内存对齐问题：结构或者联合大小取决于？.md)
+ [Ｃ源码工具集，其中的大部分来自于Ｃ专家编程作者的推荐](c-note/Ｃ源码工具集，其中的大部分来自于Ｃ专家编程作者的推荐.md)

# 参考：

+ [50个C语言经典小程序和C语言编写的小游戏，带注释和解析_C语言中文网](http://c.biancheng.net/cpp/u/yuanma/)
+ [AUR (en) - gcc47](https://aur.archlinux.org/packages/gcc47/)
+ [C语言main函数详解_C语言中文网](http://c.biancheng.net/cpp/html/725.html)
+ [c语言查询mysql示例 - - ITeye技术网站](http://jimmee.iteye.com/blog/2174717?utm_source=tuicool)
+ [C语言解析lrc文件-编程10000问-电脑编程网](http://biancheng.dnbcw.info/1000wen/390694.html)
+ [C 语言进制之间的转换_C 语言_脚本之家](http://www.jb51.net/article/88714.htm)
+ [C语言实现双向链表_C 语言_脚本之家](http://www.jb51.net/article/62628.htm)
+ [c语言字符数组与字符串的使用详解_C 语言_脚本之家](http://www.jb51.net/article/37456.htm)
+ [C++指针数组、数组指针、数组名及二维数组技巧汇总_C 语言_脚本之家](http://www.jb51.net/article/54220.htm)
+ [GCC 5.3.0 - pass 1 - compilation failed](http://www.linuxquestions.org/questions/linux-from-scratch-13/gcc-5-3-0-pass-1-compilation-failed-4175572316/)
+ [GCC中的内嵌汇编语言 - 编程资料大全 - ITeye技术网站](http://daimajishu.iteye.com/blog/1087668)
+ [GNU编译器套件GCC 6.1发布 默认使用C++14标准_Linux新闻_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2016-04/130788.htm)
+ [Google Translate](https://translate.google.com/translate?hl=en&sl=auto&tl=zh-CN&u=https%3A%2F%2Fgcc.gnu.org%2Fgcc-6%2Fporting_to.html&sandbox=1)
+ [Linux中opendir的函数结构体详解 - yyfwd的博客 - 博客频道 - CSDN.NET](http://blog.csdn.net/yyfwd/article/details/50339721)
+ [N多C语言的面试题（1） - 贵子 - 51CTO技术博客](http://ud1121.blog.51cto.com/228311/199629/)
+ [Porting to GCC 6 - GNU Project - Free Software Foundation (FSF)](https://gcc.gnu.org/gcc-6/porting_to.html)
+ [编程中位运算用法总结 - 大神养成中..... - 博客频道 - CSDN.NET](http://blog.csdn.net/y990041769/article/details/12977271)
+ [编译旧版本gcc_robot_新浪博客](http://blog.sina.com.cn/s/blog_4705f1f3010105us.html)
+ [部分面试题](http://www.fx114.net/qa-70-142998.aspx)
+ [c语言_链表实例讲解两个经典例子](http://www.oschina.net/code/piece_full?code=43706&piece=61014#61014)
+ [-数据结构之栈操作讲解](https://www.oschina.net/code/piece_full?code=58479&piece=87195#87195)
+ [和菜鸟一起学linux之双向链表list head的简单实例 - 东月之神 - 博客频道 - CSDN.NET](http://blog.csdn.net/eastmoon502136/article/details/8082009)
+ [基于Linux C的socket抓包程序和Package分析_Linux编程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2014-11/109330.htm)
+ [基于Linux C的socket抓包程序和Package分析 第2页_Linux编程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2014-11/109330p2.htm)
+ [进制之间的转换_C语言中文网](http://c.biancheng.net/cpp/html/2855.html)
+ [进制转换基础_相关技巧_脚本之家](http://www.jb51.net/article/34132.htm)
+ [进制转换算法原理（二进制 八进制 十进制 十六进制）_相关技巧_脚本之家](http://www.jb51.net/article/23650.htm)
+ [使用 Socket 通信实现 FTP 客户端程序](http://www.ibm.com/developerworks/cn/linux/l-cn-socketftp/)
+ [数据结构之栈操作讲解 - 开源中国社区](https://www.oschina.net/code/snippet_2703963_58479)
+ [位运算简介及实用技巧（三）：进阶篇(2) _ Matrix67_ The Aha Moments](http://www.matrix67.com/blog/archives/266)
+ [文件系统的实现-目录实现和文件实现_操作系统教程](http://c.biancheng.net/cpp/html/2625.html)
+ [优秀程序员不得不知道的20个位运算技巧 - 人在江湖 - 博客频道 - CSDN.NET](http://blog.csdn.net/zmazon/article/details/8262185)
+ [在Ubuntu上编译GCC会到的问题及解决方法_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2012-09/70461.htm)
+ [最大公约数_百度百科](http://baike.baidu.com/link?url=HBoJQ7MlHaGxg1iVA6UB68sXyAfk-rLXb1aadwwQNK_CCl28Udaz50mUmvIXhjS3WzIRhx8FAW8Vd7EM3GseqAViAf63KEOvkqP_kSMMfI4hKJeXaZnuVH9c50OSfbaEgYVOxBCaQwqj3vRtS2Ngfq)
+ [C语言程序设计50例(经典收藏)_C 语言_脚本之家](https://www.jb51.net/article/38051.htm)
+ 介绍一款国产开源C编译器 - ngaut - C++博客
+ C_C++_C#_编程开发_电子书籍 - 脚本之家
+ c语言10个经典小程序_C 语言_脚本之家
+ 50个C语言经典小程序和C语言编写的小游戏，带注释和解析_C语言中文网.html
+ C语言参考手册(原书第五版）中文版_pdf-[电子书]–华为网盘资源共享-文件备份-免费网络硬盘
+ C语言函数sscanf()的用法 - Walter L - 博客园
+ c语言结构体对齐 - renrenhappy的专栏 - 博客频道 - CSDN.NET
+ 详解约瑟夫环问题及其相关的C语言算法实现_C 语言_脚本之家
+ 小说阅读器的编写之智能分章实现 - Excalibur丶 - 博客园
+ C语言字符串操作总结大全(超详细)_C 语言_脚本之家
+ C 语言嵌入汇编

