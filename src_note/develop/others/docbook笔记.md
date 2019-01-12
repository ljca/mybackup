# charpter1
[^docbook]学习笔记

## 第一步：从安装与搭建测试环境开始

`xsltproc` `libxml2` `libxslt` `docbook-xlst` `docbook-xml`

主要工具：`xsltproc`

在 docbook [主页](https://sourceforge.net/projects/docbook/files)可以获得其它版本的 xsl.


```Bash
xsltproc -o docbook.html /usr/share/xml/docbook/xsl-stylesheets-1.79.1/html/docbook.xsl docbook.xml
```

参阅：

+ [csdn_紫馨岚 博客](https://blog.csdn.net/fgh1987168/article/details/6899157)

[^docbook]: 可以看作是一个 以 xml 输入，包含多个输出(html,pdf,rtf,fo...)的写作平台。主要特点是方便维护。
