<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# JavaScript[^js]：在浏览器客户端执行的脚本

> 网页中使用JS的几种方式：

+ 链接外部js文件，外部js文件不得包含`<script>`标签。链接语法： `<script type="text/javascript" src="路径"></script>`

+ 在html文档中使用`<script>`标签包含：并非所有浏览器都支持javascript。所以，尽可能的将js代码包含在注释标签中<!-- -->。这样，即使浏览器不支持，也会忽略网页中的javascript代码。语法： `<script type="text/javascript"> // 属性type，唯一值:"text/javascript"`

```javascript
<!-- js代码 -->
</script>
<script>标签可以包含在html文档的任何地方
```

+ 包含在html标签中(此方式需要添加前缀javascript:事件之前可省略)

## javaScript常用语法：函数及对象，函数详解语法参阅后续文档

###  变量： 

```javascript
/* 
# 变量的定义及声明
* 变量的定义必须以英文输入法下的英文字母(a-zA-Z)、下划线_、美元符号$开始，严格区分大小写，可以包含数字，但不得是JavaScript的保留字
* JavaScript是一种弱类型语言，不会再编译时检查类型和语法错误，因此
语句结束标记分号，变量定义关键字，以及块分隔符{}不推荐省略
* ps:javascript中不区分数据类型，所有变量都使用var定义和声明
* 全局变量和局部变量，局部变量优先级高于全局变量
* javascript变量声明提前：无论在什么地方声明的变量，在整个js文档都有效
*/

var 变量名 = 变量值;

/* # javaSctript数据类型
* typeof(变量)关键字用于检测变量数据类型
* object：数组，函数,null......
* 所有已经声明但是未赋值的变量或者不存在的对象都属于undefined类型，已经声明并且赋值未null的属于object
*/
String;number;boolean;object;undefined
```

> 逻辑控制语句 

```javascript
if-else
switch-case
for-in
for
while
do-while
```

> switch结构条件表达式和case语句块都没有数据类型限制，可以是任意数据类型 

```javascript
switch(表达式){
  case 值1:
  break;
  .......
  case 值n:
  break;
}
```

> for-in循环。语法：

```javascript
for(var 变量名 in 对象名){
}
```

### DOM对象函数 全局DOM对象

所有全局对象的属性，事件或者函数都可直接以对象名.......形式调用，函数请参阅后续章节 * 属性调用。语法： 对象名.属性名;

事件调用(目前只有window对象和普通按钮可调用) 对象名.事件名 = "javascript:函数名(参数列)",但在其它元素中调用需要添加javaScript:前缀,事件调用可省

#### window对象(全局对象)

window对象 windows对象的函数可直接调用，其它对象的函数必须以对象名.函数名()的形式调用;

1.常用事件:
onload:一个页面或者图像加
onmouseover:鼠标移到某元素之上
onclick:鼠标单击事件
onkeydown:某个键盘按键被按下
onchange:域的内容被改变
2. 常用属性:
history:返回访问过的URL信息
location:返回当前url的信息

#### history对象(全局对象)

* 返回当前页面历史记录的前一个页面:history.back();
* 跳转到当前历史记录页面的下一个页面:history.forward();
* 跳转到到指定页面:go(n);n为历史记录中的n个页面

#### location对象(全局对象)
1. 属性
host:返回当前主机名和端口
hostname:返回当前URL的主机名
href:返回或者设置url，可省略

* 刷新页面,重新加载当前文档:reload();
* 使用指定地址替换当前页面:replace();

#### document对象(全局对象)
1.属性
* document.referrer:返回载入当前页面的地址
* document.URL:返回当前文档的URL

* 输入函数。在当前html文档中弹出一个输入框，提示用户输入。有参|无参函数，此函数允许无参调用。
参数1:提示信息。参数2:文本框默认显示文本 prompt("","")
alert(""),confirm("") 在当前文档中弹出一个警告框，有参|无参函数。
参数:弹出框的显示内容，允许为空 
* 打开一个窗口。有参|无参函数。 open()
* 关闭当前html文档,无参函数。此函数不能被按钮事件调用。close()
* 在指定时间之后执行一个函数。函数名必须包含在双引号中，并且之后的圆括号不能省略，即使这个函数无参。执行时间为毫秒数，不必使用双引
* 这两个函数都能实现定时效果，但setTimeout()只能调用一次函数，而setInterval()则能重复调用，直到窗口被关闭或者。。。。
setTimeout(执行函数，执行时间),setInterval(执行函数，执行时间)
* 根据定时函数返回值清除定时效果
clearTimeout(),clearInterval();

* 所有全局对象的属性，事件或者函数都可直接以对象名.......形式调用。注意：这里的对象名是全局对象名
对象名.函数名();
* 事件调用(目前只有window对象和普通按钮可调用)
对象名.事件名 = "javascript:函数名(参数列)",但在其它元素中调用需要添加javaScript:前缀,事件调用可省

* 通过元素id属性访问网页标签的属性值:getElementById(网页标签元素id)
* 通过元素name属性访问网页标签属性:getElementsByName()，返回带有指定名称的对象的集合
* 通过:getElementByTagName(),返回带有指定标签名的对象的集合
* 向html文档写入代码:write();writeln();

#### Math对象(全局对象)

ceil():向上取整
floor():向下取整
round():四舍五入取值
random():随机返回0~1之间的数

### 非全局DOM对象 

所有非全局对象调用属性前需要实例化 * 属性调用。语法：实例对象名.属性名

所有非全局对象调用函数前需要实例化。函数调用。语法： 实例名.函数名();

#### 数组对象(非全局对象)

var 数组名 = new Array(); | var 数组名 = new Array(数组长度); | var 数组名 = new Array(值1，值2.....值n);var 数组名 = [];
var 数组名 = [值1，值2....值n];
* javascript中的数组长度如果没有指定，可以自由添加元素
属性:length

#### String对象(非全局对象)
* 获取字符串长度:length

#### Date对象

* 实例化日期对象。语法： var 日期实例名 = new Date(参数);

getFullYear()：获取年
getMonth():获取月(0-11)
getDate():获取天
getDay()：获取星期
获取当前系统时间:getHours()；获取当前系统分:getMinutes();
获取当前系统时间秒:getSeconds()；getTime()；

#### String对象

* 检索位于index位置的字母:charAt(index)
* 检索字符位置并返回字符位于字符串中的索引:indexOf(string x)
* 提取字符串:substring(startindex，lastindex) // 提取从startindex开始，lastindex结束的字符串
* 以参数分割字符串:split(string i)

#### Array对象函数

* 连接字符串:join()
* 排序:sort()
* 插入数据:push()

## 函数和方法

函数的调用可以包含参数

### 系统内置函数 调用语法:直接使用函数名调用。

* 检查指定字符串中是否存在数字，如果存在则将它提取为一个整型数，如果不存在，则返回NaN:parseInt()
* 检查指定字符串中小数点后是否存在数字，如果存在则将它提取为一个浮点数(忽略第二个小数点后的数字、字符)，如果不存在，则返回NaN:parseFloat()
* 检查参数是不是数值型数据:isNaN(x),如果此函数参数是数值型，则返回false

### 自定义函数

无论函数是否有返回值，都可直接在函数体中使用return语句返回值

```javascript
/*
* 有参函数定义：参数是不能给变量声明数据类型，调用时可以有参也可以无参
* 注意：函数名可省略，这类函数被称为匿名函数，调用时通常将此类函数的返回值赋值给一个变量
* 匿名函数定义语法：
*/
function(){
//函数体
}
```

> 非匿名函数定义语法：

```javascript
function 函数名(参数列){
函数体
}
```

> 函数调用语法：
ps:使用外部文件需要先导入文件，如何导入请参照前页;
对象名.事件名 = "函数名(参数列)",但在其它元素中调用需要添加javaScript:前缀
JavaScript中函数调用，无论是否有参，一对圆括号都不能被省略。但在jQuery中，如果自定义函数无参，调用时不允许包含圆括号

# JQuery: JavaScript程序库之一

1.配置JQuery

在html文档中使用`<script>`标签导入。语法: `<script src="JQuery程序库文件路径(可以是网络路径)" type="text/javascript"></script>`

## JQuery语法:
$(seleter).action();
* 工厂函数:$(标签、标签元素属性、css样式、对象、函数........),该函数等价于JQuery();
* 当工厂函数选择器是DOM对象时,不需要被双引号包裹
* 选择器:selecter
选择器selecter可以是标签元素、标签元素属性、css标签样式、css类样式、cssID、对象.......。语法:
$(seletcter)

## DOM对象
ps:DOM对象与JQuery对象不能直接调用除自身对象不支持的函数。如果需要调用，请将他们转换之后再调用
* DOM对象转换为JQuery对象:$("DOM对象")
* JQuery对象转换为DOM对象:$().get(index)或者$()[index]
* 节点对象:包含所有标签元素
* 文本对象
* 节点属性对象:包含所有标签元素属性
## JQuery对象
* 变量的定义以$为前缀
var $c = $()
## jQuery选择器
1.基本选择器
标签，类(调用时以点开始)选择器，ID选择器(调用时以#号开始)
交集选择器:
并集选择器:
全局选择器(*)
2.层次选择器
* 后代选择器:多个选择器之间以空格分隔。语法：
$(selecter1 selecter2 ....selectern).action()
子选择器
* '>':获取或者设置父级元素下的子级元素样式。语法：
$(父级元素|类样式、属性....>子级元素|类样式、属性....)
相邻元素选择器
* '+':获取或者设置元素的下一个同级元素的样式。语法：
$(元素|类样式、属性+同级元素|类样式、属性....)
$(selecter+selecter2).action();
同级元素选择器:设置selecter1之后的所有同级selecter2元素
$(selecter1~selecter2).action();
3.属性选择器。语法：
* 属性必须放在括号[]中，可以有多个[]
$("标签[标签属性]").action();
* 选取给定属性等于某个值的元素。语法：
$("[属性=属性值]").action()
* 选取给定属性不等于某个值的元素。语法：
$("[属性!=属性值]").action()
* 选取给定属性以某个值开始的元素。语法：
$("[属性^=属性值]").action()
* 选取给定属性以某个值结尾的元素。语法：
$("[属性$=属性值]").action()
* 选取给定属性包含某些值的元素。语法：
$("[属性*=属性值]").action()
4. 过滤选择器

### 基本过滤选择器
ps:冒号是过滤选择器区别其它选择器的特征，不可省。语法：
selecter:过滤选择器
$("元素或者标签名:过滤选择器名").action();

* 选取第一个元素:first
* 选取最后一个元素:last
* 设置索引从偶数开始的所有元素:even
* 设置索引从奇数开始的所有元素:odd
* 获取索引等于index的元素:eq(index)
* 获取索引不等于index的所有元素:not(selecter)
* 获取索引大于index的元素:gt(index)
* 获取索引小于index的元素:lt(index)
* 获取的元素:header
* 获取获得焦点的元素:focus
* 获取所有隐藏元素:hidden
* 获取所有可见元素:visible
* 获取选定元素的所有子元素:parent

## jQuery事件与动画
1.事件

## 正则表达式
* 正则表达式是一组由两根正斜杠括起来有特殊格式的字符串。正则表达式应该以下列形式定义:
/^\w\W\s\S\d\D.{}*?+[a-zA-Z0-9][]$/
//正则表达式的赋值需要以正斜杠开始和结束。^匹配字符串开始;$匹配字符串结束
\w:匹配一个字母、数字、下划线字符,等价于[a-9a-zA-Z_];\W
\d:匹配一个数字;\D
\s:匹配一个空白符;\S
.:匹配除除点外的所有字符一次
{}:匹配前一个字符至少...
?:匹配前一个字符0次或者多次
*：匹配前一个字符一次或者多次
+:匹配前一个字符0次或者一次
用于正则表达式验证的方法。这些方法必须以正则表达式对象调用
match()
search()
test()
表单验证
表单选择器
表单属性选择器

## jQuery对象函数、方法
* jQuery对象函数调用自定义函数。注意，被调用的自定义函数如果无参，则圆括号不允许使用。语法：
$(selecter).action(自定义函数名)
* 方法的调用必须包含工厂函数$()。调用语法:
$(selecter).action()
一个特性是在jQuery中，可以连续调用多个方法，将它们以空格分隔即可；
$(selecter).action() .action2()..... .actionn();
### jQuery对象常用方法
* 文档加载事件:$(document).ready(function(){})等价于DOM模型window对象的onload事件,此方法可简写为$(function(){});
* this在JQuery对象中，指代当前对象

鼠标事件方法:
click()
mouseover()
mouseout()
mousehover()
blur()
focus()
select()
键盘事件方法:
按下按键时:keydown()
释放按键时:keyup(函数1，函数2)
产生有效字符时:keypress()
鼠标悬停事件:hover(函数1,函数2)
鼠标连续点击事件:toggle("事件1","事件2"....."事件n")
绑定事件：
$().bind(事件名,执行函数|{事件名1,执行函数},....{事件名n,执行函数n});
移除事件:
$().unbind();
2. 动画
参数 speed：效果持续时间，有效值为"slow,normal,fast,毫秒数",如果为毫秒数，则双引号可以省略,callback:返回之后执行的函数
* 元素显示：$().show(speed,callback)；隐藏：$().hide(speed,callback)
### 元素淡入淡出显示
* 元素淡入淡出显示:$(selecter).fadeIn(speed,callback)
* 元素淡入：$(selecter).fadeOut(speed,callback)
* 自动判断元素淡入淡出：$(selecter).fadeToggle(speed,callback)
* 允许为元素指定淡入淡出的不透明度，0~1之间：$(selecter).fadeTo(speed,不透明度:0~1之间(该参数为必选项),callback)
* slideDown(speed,callback);slideUp(speed,callback)
toggle(speed,callback);//自动对选取元素进行动画操作
### 使用jQuery操作DOM
Core DOM,HTML DOM,CSS-DOM
1.样式操作

* 直接添加:$(selecter).style.元素属性 = "值";
* 为给定元素或元素属性添加css样式。语法:
$().css("属性","值")

* 如果要添加多个样式，请使用花引号将它们括起来，属性与值之间用冒号隔开;并且属性与值要用单引或者双引引起来;多个属性使用逗号分隔。语法:
css({"属性1":"值1",....."属性n":"值n"});或者css({属性1:"值1",......属性n:"值n"});
也可以以这种形式调用。语法:
css(属性1:"",值1:"") .css(属性n:"",值n:"");

* 为所选元素添加类样式:addClass("样式名"),此方法会追加样式，已存在的样式不会被覆盖
* 如果要添加多个样式，请将多个样式用空格隔开。语法:

$().addClass("样式1 样式2....样式n"|空);

* 获取选择器或者元素之后紧邻的同级元素:next("元素名")。语法：
.next(选择器:"");
* 移除样式:removeClass("样式1 样式2....样式n")
* 自动添加或者移除样式:toggleClass()
* 获取所有同级元素:sublings("元素名");

2.内容操作

* html():获取或者设置元素文本,无参调用获取内容，有参调用设置元素内容
* text():设置元素内容
* val():获取或者设置元素value属性值

### 节点与属性操作：查找、创建、插入、删除、替换、复制

> 创建一个新元素。语法： $(选择器|DOM对象|html元素)，将创建的新元素添加到html文档，某个元素中

+ 向所选元素内部(之后)添加内容：append("")
+ 把所选元素追加到另一个指定的元素内部集合：appendTo("");
+ 向所选元素内部(之前)添加内容prepend();prependTo()

外部插入

+ 在选定元素节点之后插入内容:after();insertAfter();
+ 在选定元素节点之后插入内容:before();insertBefore()

删除节点

+ 移除节点所有信息:remove();
+ 移除节点,保留事件:datach()
+ 移除节点文本内容，保留元素节点:empty();

查找、遍历节点

+ 获取选中节点之后的元素:next()
+ 获取选中节点之前的元素:prev()
+ 遍历同级元素:each()
+ 寻找元素:find()
+ 获取所有同级元素:parent()
+ 获取同级元素的上上级元素:parents();
+ 获取子级元素:children();
+ 复制节点:clone();
+ 替换节点:replaceWith();replaceAll();

> 参阅：

+ [jQuery Ajax异步处理Json数据详解_jquery_脚本之家](http://www.jb51.net/article/42795.htm)

+ [jQuery使用$.each遍历json数组的简单实现方法_jquery_脚本之家](http://www.jb51.net/article/82576.htm)

[^js]: JavaScript语言，基于对象和事件驱动。由ECMAScript(标准国际通用脚本语言规范),DOM(Document Object Model)文档对象模型，提供了操作Html元素的一些API(对象和方法),BOM(Broser Object Model)浏览器对象模型,提供了和浏览器交互对象* 解释性语言，边解释边执行。一旦某处有语法错误，将不再执行错误处之后的代码
