# Access学习笔记
Access学习笔记


Microsoft Access笔记
Access是一个可视化操作的数据库工具，所有的操作都可以通过点击鼠标来完成。
数据库创建与删除
2010以上版本默认保存格式:accdb
2002-2003格式:mdb
2000格式:mdb
表的创建
直接创建
表设计视图
表的视图：数据表视图和表设计视图
Access支持中文来作为列名

Access数据类型:
整型
自动编号
文本
是/否
.............
表操作：
a.重命名
在Access中要重命名一个表，必须首先关闭打开的表。否则会提示无法重命名。
b.删除
删除表之前，必须要关闭表。
选中一个表，右键删除。

c.关系
关系视图

当表在数据表视图下时，关系视图在：
菜单 -> 数据库工具/表
当表在设计视图时，
菜单 -> 数据库工具/设计
要更改表的设计结构，需要打开表的设计视图
导入/导出：
菜单栏/工具栏/表视图右键
！导入数据时，如果文件名中存在多余的非法字符比如点号，则会使文件导入失败，提示：针对该架构进行的规范XML验证失败，以下XML文档行中存在错误：|。
从文件中导入大量数据，支持(Access,ODBC)数据库导入或者是纯文本/excel/xml/其它(html)
导出数据表中的数据:
格式可以是：纯文本/xml/pdf|xps(此种格式不能用于导入数据)/excel。
当打开的表在设计视图时，不能将表导出成pdf/xps文档。
 vim:set filetype=markdown: 