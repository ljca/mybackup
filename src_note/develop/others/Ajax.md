#  Ajax
Ajax:(A.. JavaScript And XML)：异步JavaScript和XML可扩展语言
Ajax:(Async.. JavaScript And XML)：异步JavaScript和XML可扩展语言
Ajax其实不是一种新技术，根据相关文献，它来源于MS公司。为了解决
一些浏览器厂商纷纷对它提供了支持。
它是多种技术的集合，它包含了JavaScript、XML、CSS、等对象集合
核心对象:XMLHttpRequest对象
为了在浏览器异步发送请求，为用户提供连续的请求，然而，不同的浏览器使用了不同的方式来创建
其中，MS公司旧版本浏览器和新版本浏览器创建XMLHttpRequest对象语法不同，Firefox等浏览器创建语法也不相同。

核心对象：XMLHTTPRequest
实例化XMLHTTPRequest对象
调用open()
方法原型:open("处理事件的servlet?参数?/
-00-",true|false);
处理onreadstatechange事件

responseText:响应字符串
responseXML
json:一种数据传输格式，类似于xml
* 如果只为字符串，则必须使用双引号将它引起来。
格式为：{"属性一":值一,....,"属性n":值n}
重写toString方法

 vim:set filetype=markdown: 
