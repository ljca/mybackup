#  css笔记

## 选择器
嵌套/后代选择器: body p body.p 
分组选择器: body,p 
子元素选择器: body>p 
id 选择器: #id
类选择器：.class

样式表优先级：
行内 > 内部 > 外部 > 浏览器自定义

style 属性：
```css
<p style="color:red;background:white;"></p>
```

```css
<style>
<!--

-->
</style>
```

外部样式表引入：
```css
<link type='text/css' rel='stylesheet' href='' />;
```


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