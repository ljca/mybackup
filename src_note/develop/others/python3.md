# Python 3 笔记：基础语法

> ***~~以下所有在脚本在 Linux 上测试完成。Python 版本为 3.6。~~***

## 基本数据类型
数值类数据和字符串都提供了其对应的转换方法。

数据类型 | 常用释义
:-----: | :-----:
Number | 组 
int、float、bool，bool 取值 True 和 False | str、tuple，list，有序列表；set、key-value，无序集合。
不可变 | 可变
int、float、bool、str、tuple | list、set、key-value


> 布尔(bool)

True,False


### 组：序列，序列可以通过索引访问和进行切片运算。

> ***&nbsp;&nbsp;所有 Number 、str、tuple 都是一旦定义就不可变了。***

> 字符串(str)

**&nbsp;&nbsp;我们可以在 Python 中使用单引号和双引号来定义一个字符串，如果需要，可以使用三个引号来定义。可以对 Python 中的字符串进行多种特殊运算。**

&nbsp;&nbsp;基于某些情况（比如我们想用一个字符串来表示 windows 下的路径时），如果不想解释器解释转义字符时，我们需要将字符串定义为`原始字符串`，方法就是在字符串之前加上一个 r 或者 R。

***~~&nbsp;&nbsp;我们可以使用 + 来连接（即拼接）两个或者以上的字符串。使用 * 来对一组或者一个字符串复制。使用 [索引:[步长]] 的方式来获取字符串中的某个或者某些字符。 索引从0 开始，或者 -1 。~~***

```python
"""
替换字符串
"""
string=
string.replace(part,repel)
```


> 列表(list)：[]

&nbsp;&nbsp;使用'[]'定义：所有元素包含在一对方括号中，由多个元素组成。元素之间用逗号分隔。python 中的列表元素可以是不同的数据类型，并且可以嵌套。还可以使用那些对字符串使用的特殊运算。

```python
[1,2,3,4,6]

['',2,True,2.3,[2,5.2,'int']]

[1,2,3,4,6] + ['',2,True,2.3,[2,5.2,'int']]

[1,2,3,4,6][1]
[1,2,3,4,6][1:3]
[1,2,3,4,6][1:]
[1,2,3,4,6][-1:]
['',2,True,2.3,[2,5.2,'int']]
```

> 元组(tuple)：()

### 无序的列表：集合，不允许存在相同的元素或者键。

> 集合(set)：{}
不可以使用切片。

> 键：值对，字典(dict)：`{key:value,...}`
通过键访问值。
键的定义是有限制的：

+ 键必须是不可变的数据类型。并且不允许重复。

## Python 脚本的执行

&nbsp;&nbsp;由于 Python 是一种解释行脚本语言，所以可以由解释器直接执行而无需编译，当然，脚本中的错误会导致解释器立即停止解释脚本。

&nbsp;&nbsp;在 Linux 上，我们可以使用多种方式来解释 Python 脚本。

+ 用解释器去解释执行。`python xxx.py`
+ 让脚本自己调用解释器解释、执行自己。即 `./xxx.py`，需要可执行位，参见 `chmod`。

Python 方法：

```python
def words():
   pass
```
## Python 程序的组织方式：模块以及`import`关键字
### import 关键字
&nbsp;&nbsp;import 关键字用于导入某个模块。as 关键字可给导入的模块取一个别名。如果要从某个包或者类中导入，则需要和 `from` 搭配使用。Python的 `import` 存在多种使用方式。

`from package.class import object`
`from package import class`

import 不仅可以用来导入某个模块，也可用来导入某个类或者导入某个类中的成员。

`__init__` 序列属性：控制 import * 导入的行为和对象

大多数情况下，模块名即文件名或者某个类名

包的定义方式：除非在目录下存在 `__init__.py` 文件，否则 Python 并不会将这个目录视为一个包。

闭包方法:
在函数内部定义函数

```python
def xxx():
   l = 20
   def xxxs(x):
   return x * x
return xxxs
```



## 面向对象
### 包、类、实例

### 类：

```python
class Class():
    pass

__class__
__dict__
```


### 类方法和实例方法、静态方法
Python 类的带参构造：`__init__(型参列表,....)`

***&nbsp;&nbsp;如果一个方法第一个参数是 self（实际调用时不必传入），那么这个函数就是属于实例对象的（__init__构造除外）。如果是 cls，它就是属于类的方法（当然，这需要搭配`@classmethod`装饰器）或者使用转换。***

```python
staticmethod()
classmethod()
```


### python 装饰器：
```python
@staticmethod
@classmethod

@name.property
@name.setter
```

words = Class(实参)

私有属性：`__words`

# 附

## 常用函数

### 数值函数

函数 | 调用 
:------: | :------: 
hex() | 将数值转换为十六进制后输出，以 0x 打头
oct() | 将数值转换为八进制后输出，以 0o 打头
int() | 将数值转换为十进制进制后输出
bin() | 将数值转换为二进制进制后输出 ，以 0b 打头

### 系统函数

函数 | 调用 
:------: | :------: 
print() | 
type() | 
isinstance() | 


## 运算符优先级

*** 单目运算(~,) > 算术运算符 > 位运算 > 关系 > 赋值 >  身份 > 成员 ***

序列 | 运算符 | 解释
:--:|:--:|:--:
1 | `**` | 指数运算
2 |  `~、+、-` | 按位取反
3 | `*、/、%、**、//` | 四则运算乘除
4 | `+ -` | 四则运算加减
5 | `>>、<<` | 移位运算
6 | `&` | 按位与
7 | `^，|` | 异或，按位或 
8 | `< > >= <=` | 关系运算
8 |  `==，!=，<> ` | 关系运算
6 | `and or not` | 逻辑运算
7 | `=、+=、-=、*=、/=、**=、//=、%=` |  赋值运算
7 | `is` `is not` | 身份运算
8 | `in` `not in` | 成员运算

> 对象操作运算符：

```python
"""
" +：连接字符串
" *：复制对象 num 次，num 是一个正整数
" []：索引访问
" [num:num:step]：访问从...开始到..结束的对象，即切片，step 和 num 都是可选的
"""
```

ord()

## 正则表达式

### 元字符列表

> 元字符匹配模式：

+ `+`：匹配前一个字符1次或者多次
+ `?`：匹配前一个字符1次
+ `*`：匹配前一个字符0次或者多次
+ `.`：匹配特殊字符 .
+ `.`：匹配可打印字符一次。等价于 [a-zA-Z0-9.,]
+ `{num[,num]}[?]`：固定次数匹配。匹配前一个字符或者字符集 num 次、至少 num 次，匹配 num 到 num 次

贪婪与非贪婪莫模式仅对区间次数匹配有效。默认是贪婪匹配的，即次数是大于 num 次的，非贪婪模式仅仅只匹配 num 次。

> 括号匹配模式：

+ []：匹配括号中的字符
+ [!]：匹配不在括号中的字符

> 字符匹配模式

+ `\w`：匹配一个字母等价于 [a-zA-Z]
+ `\W`：匹配除字母之外的不可打印字符
+ `\d`：匹配一个数字，等价于[0-9]
+ `\D`：匹配除数字外的字符
+ `\s`：匹配一个空格，等价于[ ]
+ `\S`：匹配一个空格
+ .....


> 边界匹配模式：
+ ^：从指定的字符开始匹配
+ $：匹配到指定的字符结束

```python
"""
" python 3，re 模块包含了操作正则表达式的方法和属性。
" findall 方法检索用正则表达式匹配到的所有字符串到一个序列中
" partian 是一个正则表达式，
" string 是一个要被检索的字符串，
" flag 是可选的，用于控制某些选项。flag = {re.I|re.S} ；re.I 用于在匹配时忽略大小写
"""
```
原型：`findall(partian,string,flag)`

```python
"""
" sub 方法从指定字符串中多次检索并替换字符串
" part 和 string 参数等效与 findall 方法.
" count 是可选的，如果省略则使用正则表达式检索替换掉所有匹配到的字符串
" flag 也是可选的。

"""
" 但是，我们可以通过重新定义 covert(value) 这个方法来自定义替换规则。
" 并将 convert方法作为字符串传递给 sub 方法，它的定义需要在 sub 方法调用之前
"""

def convert(value):
   reuturn value
"""
```

原型为：`sub(par,repl,string,count,flag)`


