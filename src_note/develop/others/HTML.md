#  HTML
﻿超文本标记语言html(Hyper Text Markup Language)
版本
html -> html4.01 -> html5 -> xhtml1.0
这些规范同时存在不同的版本
struct
transitional
Frameset
对于xhtml1.0 struct，必须在文档起始行指定xml声明，它主要用于声明文档版本/字符编码等信息
如果使用的是xhtml1.0 struct,则还需要指定html标签的xmls属性
* xml声明必须位于文档第一行，如果需要其它声明，则应将其它声明放在xml声明之后
* 以下是xml声明的格式和语法
<?xml version="" encoding=""?>

# 元素和标签以及属性
* 超文本标记语言有标签和属性组成
* 必须在超文本标记语言的第一行声明文档类型
* 标签名，属性和值必须小写
* 标签：由一组尖括号以及尖括号中的字母组成
* 元素：包括标签和和标签中的文本和对象
属性：
常见的提供三个属性组
核心属性:id,class,title
国际化属性:lang,xml:lang,dir
UI事件属性
核心属性和国际化属性被统称为通用属性，大多数标签都支持它们
# 文档声明语法:<!DOCTYPE HTML>
* 网页标签是一组由尖括号'<>'包裹的特殊标记
* 大多数标签都存在起始标签和结束标签，这意味着这些标签都需要被正常闭合，而少数标签并不存在结束标签，但按照w3c标准，闭合标签的形式是在右尖括号之前插入一个左斜杠'/'作为标签的结束标记
* 除文档声明外的所有标签都必须包含在<html>标签中
* 一个网页的简单定义如下：
<!DOCTYPE HTML> * 此处为声明文档类型为HTML文档
<html>
<head>
<!--指定网页编码-->
<meta http-equiv="Content-Type" content="type=text/html;charset=utf-8" />
<title>网页标题</title>
</head>
<body>
<p></P>
</body>(对于框架网页而言，不需要<body>标签，而需要<framset>标签)
</html>
* 在<meta>标签中指定cahrset属性文档编码可有效防止网页乱码
# <meta>标签:
属性name
属性content
<meta http-equiv="Content-Type" content="text/html; charset=" />
基本的标签元素：
块级元素独占、铺满一块区域，如果没有重设它的内外边距，则浏览器在显示时会存在内外边距；同级元素会各自铺满自身的一块区域
可以直接使用属性指定高度和宽度
内联元素没有内外边距，多个同级元素之间如果没有使用css重设属性，则不会存在空隙，直到延伸到浏览器边界
无法直接使用属性指定高度和宽度
* 块级元素和内联元素也只是相对而言，需要时只需在css中重设元素的display属性即可实现它们之间的转换
# 块级元素(block)：同时具有有开始和闭合标签
标题
<h1~h6>
* 排版标签<div>段落标签<p>;
列表标签:无序列表<ul>-<li>
有序列表<ol>-<li>;定义列表<dl>-<dt>-<dd>
可选属性
type:circle、
* 定义表格标签<table>-<th><tbody><tr></td></table>。可选元素<th><tbody>
<table 属性...>
<th></th> --列头,可选
<tbody> --可选
<tr> --定义行
<td></td> --定义列
</tr>
....
</tbody>
</table>
可选属性：
colspan:跨列、rowspan:跨行
width:表格宽度、height:表格高度
border:边框粗细、bordercolor:边框颜色、aligh:对齐方式、text-align:文本对齐方式
cellppding:表格行之间的间距、cellspacing:表格列之间的间距
* 段落标签:<p></p>
内联元素(inline)：
换行标签<br />;水平线标签:<hr />
<span></span>
* 超链接标签<a href=链接地址:"" title="鼠标悬停显示信息" target=打开方式:"" name="">链接文本</a>;
可选属性:
herf:title:target:name:
* 图像标签<img src=图像路径:"" title="鼠标悬停显示信息" alt="图片加载失败时现实的文本" border="边框粗细" height="图片高度(以像素为单位)" width="图片宽度" />;
可选属性:
src:alt:border:height:width:title:
背景音乐标签；<bgsound />

* 排版<span>;<strong>;<em>
# 表单及框架
1.1 如何定义表单？
* 定义表单使用<form>-<input>标签。语法：
<form methd="post|get" action="" enctype="muilpart/form-data">
<input type="" name="" value="" size="" ......./>
.........
</form>
* 它的几个重要属性如下：
type：指定表单控件类型
name：此属性指定表单名称，此名称用于标识个控件，以便系统识别；注意:一组单选按钮或者复选框必须具有相同的name值
value:对于单选按钮，此项必须指定(如果使用<lable>标注表单元素，则可以不需要此项)
size:指定控件初始长度(对于文本或者密码框，以字符数为单位，其它的以像素为单位)
maxlength:指定最大输入字符数(对于文本或者密码框)
checked:默认是否被选中(只对单选按钮和复选框有效)，唯一值:checked
desable:控件是否被禁用;唯一值:desable;
readonly:是否允许在控件中写入数据;唯一值:readonly
* type属性主要包含以下值:
text(文本框);password(密码框);radio(单选按钮);checkbox(复选框);
file(文件域,如果是文件域,则必须指定form元素的属性enctype为muilpart/form-data);
buttom(普通按钮);submit(提交按钮);reset(重置按钮)
一个比较特殊的值为image,html允许控件为图像按钮,如果指定了image的src;
hide:如果指定值为hide,浏览器会解释它，但并不会将它显示在经过解释后的页面上。也许它不会对浏览网页的用户有什么用处，但它对编程人员和服务器却极为有用,在html文档中，它有一个专业术语：隐藏域
多行文本框:<textarea></textarea>标签
下拉框选项定义:<select>-<option>标签
<select>
<option value="" name="" selected="selected">值</option>
</select>
下拉项属性
value:
name:
selected:默认选中,只允许一项
隐藏域
语义化表单:
域:将表单元素放到<fieldset>标签中，浏览器会以特殊方式显示它们，被语义化的表单通常有特殊的边界
域标签<fieldset></fieldset>
如果需要给域设置标题，则需在域标签中添加<legend></legend>标签
表单元素的标注:
如何在单击单选按钮或者复选框旁边的文字就能选中这个它？
这个需要将表单元素使用<lable for="表单元素的id值"></lable>标签进行标注

1.2 如何在网页中定义框架？
* 定义框架使用<frameset>或者<iframe>标签,前者属于整个页面都用框架布局的网页，后者适用于网页中少量框架布局
* 如果网页中使用了<frameset>标签，在html文档中则不能包含<body>标签
<frameset>-<freme>
常用属性:
是否允许框架窗口有边框？frameborder="" //值:[0|1|yes|no] 0为默认
bordercolor:
是否允许调整框架窗口大小？noresize="" //值：[noresize]
name:
链接网页打开方式？target="" //值：[_blank|_self|_parent|_top|也可以是<frame>已经指定了name属性的框架窗口名]
框架网页布局方式:
<html>
.....
<head></head>
<frameset>
<frame 属性集合>
...
</frameset>
</html>

# 层叠样式表(css)
1. css的声明包括选择器和声明
* 选择器包括标签、类、ID选择器
* css规定:所有声明必须包含在一对花括号中{}，声明包含属性和值，属性和值以冒号分割,以分号结尾；一对花括号中可以包含多条声明语句，但必须以分号分隔。
* 类选择器的声明必须以英文圆点开始，在html文档中应用前需要设置标签的class属性;......必须以#开始.........id属性。语法:
选择器{属性1:值1;......属性n:值n;(按照w3c标准,此处分号不可省)}
# 复合选择器：
交集选择器
并集选择器
后代选择器
# 内部样式表:
在使用css进行设置样式时，尽可能的将css包含在一对注释标签中，这样，即使浏览器不支持css，那么浏览器也会自动忽略css代码。语法：
<style 类型:type=唯一值:"text/css">
<!--
css代码
-->
</style>
# 外部样式表:
将css代码(不得存在<style>标签)写在一个单独的文件中，使用时需要在html文档的<head>标签中使用<link/>标签引入。语法:
<link href=css文件路径:"" type="text/css" rel="stylesheet" />
# 行内样式表:
指定元素的style属性
<元素 style="" />
# 文本类
字体设置：
color:(字体颜色)
font-size:字体大小(以像素为单位)
font-family:设置字体(对于中文字体，应该使用双引号将它们括起来，并且最好在中文字体之前先设置英文字体)
font-style:设置字体风格(italic|normal...)
font-weight:设置字体粗细(normal|light|lighter|bold|bolder)
word-spacing:设置字间距
# 格式设置：
background:
background-image:
text-align:
text-indent:
line-height:
text-decoration:
# 列表设置：
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
 vim:set filetype=markdown: 
