<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# CSS：层叠样式表

1. css的声明包括选择器和声明
* 选择器包括标签、类、ID选择器
* css规定:所有声明必须包含在一对花括号中{}，声明包含属性和值，属性和值以冒号分割,以分号结尾；一对花括号中可以包含多条声明语句，但必须以分号分隔。
* 类选择器的声明必须以英文圆点开始，在html文档中应用前需要设置标签的class属性;......必须以#开始.........id属性。语法:
选择器{属性1:值1;......属性n:值n;(按照w3c标准,此处分号不可省)}

样式表优先级：
行内 > 内部 > 外部 > 浏览器自定义

> style 属性：

```html
<元素 style="" />
<p style="color:red;background:white;"></p>
```

> 内部样式表，行内样式表: 指定元素的style属性

在使用css进行设置样式时，尽可能的将css包含在一对注释标签中，这样，即使浏览器不支持css，那么浏览器也会自动忽略css代码。语法：

```html
<style type="text/css">
<!--
css代码
-->
</style>
```

> 外部样式表:

将css代码(不得存在`<style>`标签)写在一个单独的文件中，使用时需要在html文档的`<head>`标签中使用`<link/>`标签引入。外部样式表引入，语法:

```html
```

## 选择器 复合选择器：

嵌套/后代选择器: body p body.p 
分组选择器: body,p 
子元素选择器: body>p 
id 选择器: #id
类选择器：.class

交集选择器
并集选择器
后代选择器

## 文本类
字体设置：
color:(字体颜色)
font-size:字体大小(以像素为单位)
font-family:设置字体(对于中文字体，应该使用双引号将它们括起来，并且最好在中文字体之前先设置英文字体)
font-style:设置字体风格(italic|normal...)
font-weight:设置字体粗细(normal|light|lighter|bold|bolder)
word-spacing:设置字间距
### 格式设置：
background:
background-image:
text-align:
text-indent:
line-height:
text-decoration:

## 列表：
list-style:
list-top-style:

4.超链接伪类
a:link
a:visited
a:hover
a:active
5.盒子模型
border-style:
border-top-style:
border-butoom-style:
border:

6.浮动
float:
clear:
overflow:
7.定位

font <=========> font-family,font-size,font-weight,font-color

文字水平对其方式：text-align

表格：table

合并边框：border-collapse:"collapse";

填充：padding <====> padding-buttom,padding-top,padding-left,padding-right

列表：ul
circle
square

盒子模型：

外边距：margin <======> margin-top,margin-bttom,margin-left,margin-right

内边距：padding <=====> padding-top,padding-buttom,padding-left,padding-buutom

***~~如果设置的宽度和高度不能完全显示内容，则根据设定的 `overflow` 规则是否显示除滚动条。~~***

+ auto
+ scroll
+ visible
+ inherit：根据父元素
+ hidden

+ overflow-x：水平方向，默认
+ overflow-y：垂直方向

border <====> border-width,border-style,border-color

- border-left <====> border-left-width,border-left-style,border-left-color
- border-right <====> border-right-width,border-right-style,border-right-color
- border-top <====> border-top-width,border-top-style,border-top-color
- border-buttom <====> border-buttom-width,border-buttom-style,border-buttom-color

outline:外边框样式

position:static|fixed|relative|absolute

- fixed：固定元素位置

z-index：堆叠时时放在哪一层，一般在 absolute 时配合使用
clip：裁剪绝对定位的元素。

cursor:pointer|help|...

## 附

+ [RGB颜色查询对照表](https://www.114la.com/other/rgb.htm)
+ 你知道hover、active这四个伪类为什么要按顺序写吗 - 推酷