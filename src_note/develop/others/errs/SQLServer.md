#  SQLServer
SQLServer问题日志
SQLSever分组查询
* 如果select查询语句中没有包含聚合函数,则应将被查询的列包含在group by字句中
* 以下语句将有语法错误
....
select 列名1,列名2 from 表名 //不存在聚合函数的调用
where字句.....
group by 列名1 //列名2应该被包含在group by子句中
go

？子查询
* 将where子句查询的结果传递给上一级查询,在一个查询中将结果传给另一个查询，子查询必须放在一组圆括号中

select * from 表名 where columns in (select columns from 表名)

？使用top关键字限定返回记录数
select top x cloumns from tables where ?  // top关键字必须位于要查询列之前

？使用in和not in
如果在查询时使用了in关键字，则select语句会根据in所列出的范围匹配然后返回多条记录

？索引类型
聚集索引和非聚集索引的区别
全文索引

？赋值语句
* SQLServer不能使用true或者false作为if或者while结构的条件判断
* 不能使用双等号作为if结构的比较运算符

？存储过程的调用语法
* 不带参数的存储过程可以省略关键字exec或者execute调用，无论是系统还是自定义的，带参数的必须使用关键字调用

？即使事务已经回滚，之后的语句仍要被执行

？创建视图
* 视图中不能使用临时表，如果使用了order by子句，则必须和top语句一起使用；也不能使用into关键字

vim:set ft=markdown:
