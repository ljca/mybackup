#  MySQL
# MySQL
Server:MySQL5.6
  
MySQL5.6_x86_64列级约束无法使用constraint指定约束名称  
！
SQLyong使用本地账户无法执行SQL中的create、update语句  
图形界面的MySQL前端连接被视为远程连接，只具有本地权限用户没有create update grant权限  
！
ERROR 1064 (42000): You have an error in your SQL syntax;  
check the manual that corresponds to your MySQL server version for the right
syntax to use near 'dorp table record' at line 1  
！SQL关键字或者语法错误
ERROR 1217 (23000): Cannot delete or update a parent row: a foreign key
constraint fails  
！drop table或者delete table语句不能删除已经或者正在被引用的表中的数据。  
如果一个表正在被其它表所引用，那么在没有删除引用或者删除引用它的其它表之前不能对它执行delete或者truncate语句。
表A引用表B，
ERROR 1701 (42000):  
Cannot truncate a table referenced in a foreign key constraint
(`netbar`.`record`, CONSTRAINT `computer_record_fk` FOREIGN KEY (`computerId`)
REFERENCES `netbar`.`computer` (`computerId`))  
！truncate table语句会清空表并且不会记录日志，还会让那些支持自增列的数据库的列从头开始重新计数。但是它不能清空已经或者正在被引用的表。
计算机表  
table computer
！delete [from] table语句后如果没有where字句则会清空表。但在那些支持自增列的数据库中不会使得自增列从1开始
MySQL客户端怎么会解释已经被--注释掉的语句  
ERROR 1064 (42000): You have an error in your SQL syntax;  
check the manual that corresponds to your MySQL server version for the right
syntax to use near '--truncate table computer' at line 1  
！双中划线--风格的注释要求被注释掉的语句之前--之后至少有一个以上的空格/tab，否则会被MySQL服务器解释  
！#号风格的注释可有可无
  
MySQL脚本中的可执行注释  
/!* */
vim:set ft=markdown:
