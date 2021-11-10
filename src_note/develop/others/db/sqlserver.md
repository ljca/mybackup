<link href="../../../css/style.css" rel="stylesheet" type="text/css" />

# SQL Server 笔记：
## ★ 使用SQL创建数据库

如果数据库名与系统的某个数据库同名引起冲突，则可以使用方括号将数据库名括起来避免这个问题；通常，在创建数据库之前应先检测数据库是否已经存在；每个文件参数之间以逗号分隔;数据文件参数，带方括号的表示可选项 ！主数据文件mdf只能声明一个，而从数据文件ndf可以有一个或者多个

> 参数

* NAME 指定数据库文件的逻辑文件名
* FILENAME 指定数据库的物理文件名及路径,路径必须真实存在
* FILEGROWTH 指定增长率，可为百分比,也可为具体的增长值
* SIZE 指定大小,以MB或者KB为单位。
* MAXSIZE 指定文件的最大值
* [PRIMARY] 文件组

> SQL：删除数据库：

```sql
-- 检查数据库的存在性,如果已经存在此数据库，则删除此数据库
USE [MASTER]
GO
IF NOT EXISTS( SELECT name FROM sys.databases WHERE name='要删除的数据库名')

drop database 要删除的数据库名
go
```

> SQL ：创建数据库

```sql
 -> CREATE DATABASE [数据库名]
ON [PRIMARY]
(NAME=,FILENAME=,SIZE=KB|MB,MAXSIZE=KB|MB,FILEGROWTH=%|),
....,
[FILEGROUP filegourp_name]
(NAME=,FILENAME=,SIZE=KB|MB,MAXSIZE=KB|MB,FILEGROWTH=%|)
(
<从数据文件参数> [,....]
)]
LOG ON
(NAME=,FILENAME=,SIZE=KB|MB,MAXSIZE=KB|MB,FILEGROWTH=%|),
....,
(NAME=,FILENAME=,SIZE=KB|MB,MAXSIZE=KB|MB,FILEGROWTH=%|);
END
GO
```

* 查询所有已经存在的数据库在系统数据库[master]的[sys.databases]视图

```sql
USE [master]
GO
 -> SELECT * FROM [sys.databases] WHERE name='db_name'
go
```

## 数据库分离/附加/收缩/备份：

使用存储过程来分离/附加数据库： `sp_attach_db|sp_detach_db`；使用 `CREATE DATABASE .... ATTACH` 语句附加数据库

```sql
CREATE DATABASE 
ON
(FILENAME=''),(FILENAME='')
FOR ATTACH | FOR ATTACH_LOG
```

## ALTER DATABASE语句

```sql
ALTER DATABASE db_name
[ADD FILE special....[TO FILEGROUP group_name]]| [ADD FILEGROUP filegroup_name];
MODIFY FILE special......
[REMOVE FILE file_name] | [REMOVE FILEGROUP filegroup_name];
[SET special......] 
--  ..............
```

！如果数据库正在使用，那么将数据库更改到单用户模式

```sql
ALTER DATABASE database_name 
SET SINGLE_USER 
[WITH ROLLBACK IMMEDIATE];
```

## ★ 创建数据库表

为了避免引起同名或者关键字冲突，尽量使用方括号将方括号括起来，多个列之间以逗号分隔，最后一列无分号；列的各项以空格分隔,可以在创建表的时候就建立约束；同理，在数据库中创建表时，也应该检查表的存在性 

* [IDENTITY(标识种子,增量)]　指定是否为标识列，标识种子，增量应该都为INT型的
* [CHECK(约束)] 是否检查约束
* [PRIMARY KEY] 是否为主键
* [NOT NULL | NULL] 是否允许为空
* [DEFAULT 默认值] 设定默认值

> SQL 在已经的存在的数据库中删除已经存在的表

```sql
 IF EXISTS( SELECT * FROM SYS.DATABASES WHERE NAME='数据库名')
 USE [数据库名]
 -> IF EXISTS(SELECT * FROM SYS.OBJECTS WHERE NAME='表名')
 DROP TABLE 要删除的表名
 -> CREATE TABLE 表名
([列名1] 数据类型 [IDENTITY(标识种子,增量)] [PRIMARY KEY] [列级约束]，
.......
([列名N] 数据类型 [列级约束]
[CONSTRAINT 约束]
)
ON [PRIMARY]
```

## ALTER TABLE语句:

```sql
ALTER TABLE table_name
ADD [COLUMN] column_name column_speci...
ADD CONSTRAINT contraint_name constraint_type constraint_defeil
MODIFY COLUMN
DELETE COLUMN
DROP CONSTRAINT constraint_name
DROP INDEX index_name
```

## ★ 使用SQL插入数据

* 如果在一个表中存在外键，也会影响数据的插入，无论单行插入还是多行插入，都先要在主键表中插入数据
* 假设主键表和外键表已经建立了主外键关系，则在向外键表中插入数据时必须先插入数据到主键表
1.单行插入
* INTO关键字可省略，如果省略表名之后的列名，则在插入数据时必须根据定义列时的顺序依次插入

```sql
 -> INSERT [INTO] 表名 [(列名1,...列名N)] VALUES (值1,....值N)
```

### 2.多行插入
* INSERT 语句不仅可以单行插入数据，同样可以使用行构造器完成多行插入
* 行构造器使用逗号将多组用圆括号括起来的值分开，圆括号中的多列值之间也要使用逗号分开。

！所谓的行构造器是指在插入数据时使用逗号将多组用圆括号括起来的值分开，一对圆括号中的值对应一条数据表的记录，所以也要遵守单行插入语句的语法,末尾的分号以为这插入语句结束。

```sql
 -> INSERT [INTO] 表名 [(列名1,...列名N)] 
VALUES
 (值1,....值N),
....,
 (值1,....值N)
GO
```

* 向不存在的表中插入多行数据
* 原表必须存在

```sql
 -> SELECT [表名1.列名1],....[表名N.列名N] // 查询指定表中的指定列插入到新表
INTO [新表名]
FROM [原表名]
```

* 从已存在的表中查询数据添加到想要添加的数据表中
* 要插入记录的表和原表都必须存在

```sql
 -> INSERT INTO [要插入记录的表](列名1,...列名N)
SELECT 列名1,...列名N
FROM [原表名]
```

另外一种多行插入语句的方法：
* 最后一行插入语句不允许有关键字UNION
* 表必须在数据库中已经存在
* 通过关键字UNION向已存在的表中插入多行数据，最后一行不需要关键字UNION

```sql
 -> INSERT [INTO] 表名 [(列名1,...列名N)]
SELECT 值1,....值N UNION
.......
SELECT 值N,....,值N;
```

其它的多行插入方式：
* 向不存在的表中插入多行数据
* 原表必须存在

```sql
-> SELECT [tb_name.col1],....[tb_nameN.colN] // 查询指定表中的指定列插入到新表
INTO new_tb_name
FROM [原表名]
* 从已存在的表中查询数据添加到想要添加的数据表中
* 要插入记录的表和原表都必须存在
```

```sql
-> INSERT [INTO] tb_name(列名1,...列名N)
SELECT 列名1,...列名N
FROM [原表名]
```

3.插入标识列

```sql
 -> SELECT IDENTITY(种子,增量) AS 列名
INTO 新表
FROM 原表
```

## ★ 使用SQL向表中添加约束

1.添加约束
* 添加约束之前，可以检查约束是否已经存在,如果存在则删除

```sql
-> IF EXISTS(SELECT * FROM sysobjects WHERE name='约束名')
ALTER TABLE 表名 DROP COSNTRAINT 约束名
```

> SQL语法：

```sql
-> ALTER TABLE 表名 
ADD [CONSTRAINT 约束名] 约束类型 具体的约束说明
ADD [CONSTRAINT 约束名] PRIMARY KEY(列名)
ADD [CONSTRAINT 约束名] CHECK(约束) 
ADD [CONSTRAINT 约束名] UNIQUE(列名)
ADD [CONSTRAINT 约束名] DEFAULT 默认值 FOR 列名
ADD [CONSTRAINT 约束名] FOREIGN KEY(主键列名) REFERENCES 外键表名(外键列名)
| DROP CONSTRAINT constraint_name;
```

2.删除约束参见DROP CONSTRAINT语句。
DBCC DATABASE语句：

1.添加约束
* 添加约束之前，可以检查约束是否已经存在,如果存在则删除
 -> if exists(select * from sysobjects where name='约束名')
 ALTER TABLE 表名 DROP COSNTRAINT 约束名
语法：
 -> ALTER TABLE 表名 ADD CONSTRAINT 约束名 约束类型 具体的约束说明
* 添加主键约束 
 -> ALTER TABLE 表名 ADD CONSTRAINT 约束名 PRIMARY KEY(列名)

* 添加检查约束
 -> ALTER TABLE  表名 ADD CONSTRAINT 约束名 CHECK(约束) 

* 添加唯一约束
 -> ALTER TABLE 表名 ADD CONSTRAINT 约束名 UNIQUE(列名)

* 添加默认约束
 -> ALTER TABLE  表名 ADD CONSTRAINT 约束名 DEFAULT 默认值 FOR 列名

* 添加外键约束
 -> ALTER TABLE 表名 ADD CONSTRAINT 约束名 FOREIGN KEY(主键列名) REFERENCES 外键表名(外键列名)

2.删除约束
* 检查约束是否存在,如果存在则删除
 -> ALTER TABLE 表名 DROP COSNTRAINT 约束名

### 四、删除数据
* DELETE:删除表数据，但表结构还在
* DROP:删除表数据的同时也删除表结构

```sql
 -> DELETE [表名]
```

另外一种清空表：TRUNCATE,这种方式可以很快的将一个表的数据清空，还可以让自增列重新编号，但无法清空正在被其它表引用的表。

```sql
-- 清空表数据
TRUNCATE TABLE tb_name
-- 如果要删除表，使用DROP语句
DROP TABLE tb_name [CASCADE]|[RESTRICT]
WHERE 条件列表

-- 如果要删除表，请使用DROP语句
DROP TABLE [表名] 
```

### 五、更新数据

```sql
 -> UPDATE 表名 
SET 列名1 = 值1,...[列名N = 值N]
WHERE 条件列表
```

## ★ SQL查询
### 1.基础查询
* SELECT语句可以查询多个列或者多个表。它们之间以逗号分隔,不同的列可以在不同的表中(此种方式可能需要使用联表查询)
* 使用AS或者等号或者空格指定列的别名
* WHERE 指定条件和值，多个条件以AND连接
* ORDER BY子句，排序查询结果
* GROUP BY子句，对查询结果分组
* 语法：

```sql
-> SELECT [列名1 AS 列1的别名,...列名N AS 列N的别名] | *
FROM [表名1 AS 表1的别名,....表名N AS 表N的别名]
[WHERE 条件列表]
[ORDER BY 列名 ASC|DESC]
[GROUP BY 列名]
[HAVING字句]
```

### 2.分组查询
* 如果要使用分组查询，则必须将SELECT语句中查询的列包含在GROUP子句中或者聚合函数中

```sql
-> SELECT...WHERE.... GROUP 列1,...列N
```

### 3.模糊查询
* 模糊查询位于WHERE子句之后，可以是LIKE,IN,NOT IN,BETWEEN..AND..
* %匹配任意长度字符
* -匹配单个字符
* [^]
* [|]
* TOP必须位于SELECT关键字之后且位于所有列之前

> 常见的几种模糊查询

+ LIKE 
+ BETWEEN...AND...
+ IN(值1,...值N) ....
+ SELECT TOP 值 [PERSENT]|TOP 记录数 .....

### 4.联表查询

#### 4.1 内连接查询
* 多个列或者多个表以逗号分隔,不同的列可以在不同的表中
表的内连接查询可以使用两种方式来实现：
WHERE 条件列表
使用where子句：
 1.WHERE 条件列表

```sql
 -> SELECT 列1,..列N FORM [表名1,...表名N]
WHERE t1.column = t2.column;
```

 2.`INNER JOIN 表名2 AS 别名2 ON(条件列) `
 
> SQL：使用inner join子句：

```sql
-> SELECT t1.列1,..,t2.列N FORM table_1 t1
INNER JOIN 表名2 AS 别名2 ON(条件列表),
......
INNER JOIN 表N [AS] 别名 ON(条件列表)
WHERE 条件列表
[group by column..]
[having子句]
[order by column...]
```

#### 4.2 外连接查询
！外连接和内连接查询最大的不同就是返回的结果集不同。
内连接仅返回同时满足多个表条件的记录，而外连接一个有一个主表和从表。但不管怎样，外连接总会返回主表的所有记录，如果从表中没有找到与之对应的记录，
那么所对应的列将会用NULL来代替。

#### 4.2.1 左外连接
！当使用左外连接时，位于left [outer] join左边的表为左表即主表，而它右边的表为从表。

```sql
SELECT t1.column1,...,t2.column_n
FROM tb_1 [AS] t1
LEFT OUTER JOIN tb_2 [AS] tb2
WHERE
```

#### 4.2.2 右外连接
！当使用right [outer] join子句，右表为主表，左表为从表了。
！如果给表指定了别名，那么必须使用别名.列名的形式来使用列名

```sql
SELECT t1.column,...,t2.column_n
FROM table_1 t1
RIGHT [OUTER] JOIN 
table_2 t2 ON()
....
```

#### 4.2.3 全连接查询

！全外连接查询会检索出主从表的所有记录，没有的记录则用NULL代替。

## 5.高级查询
### 5.1 子查询
* 子查询是将WHERE子句后的一对圆括号中返回的值与运算符前的值进行条件判断 
* 子查询必须放在一对圆括号中，允许出现在任何表达式中，如果使用比较运算符，不允许子查询的结果返回多条记录
* 如果想返回多条记录，则应使用IN关键字代替比较运算符
！子查询返回一条或者多条记录中的某列，但不能是所有的，它返回的值一般会作为WHERE字句的比较操作。

> 子查询的语法如下：

```sql
-> SELECT [TOP 记录数] 列... FROM 表名 
 WHERE 列 比较运算符 (子查询)
IN子查询，返回多条记录的查询
NOT IN子查询 //查询不再IN匹配范围内的其它记录
SELECT 列 FROM 表 
WHERE 列 IN|NOT IN (子查询)

EXISTS子查询，一般用于IF语句的存在性检测，语法
...
SELECT 语句 WHERE语句 EXISTS(子查询)
....
```

```sql
-> SELECT [TOP 记录数] 列... FROM 表名 
WHERE 列 比较运算符 (子查询)
IN子查询，返回多条记录的查询|NOT IN子查询 //查询不再IN匹配范围内的其它记录
EXISTS子查询 | NOT EXISTS，一般用于IF语句的存在性检测，语法
...
SELECT 列 FROM 表 
WHERE 列 
IN|NOT IN (子查询)
EXISTS(子查询)|NOT EXISTS(子查询)
```

### 6.联合查询 UNION
* 将多个表的查询结果联合在一起，这并不会将有空值的记录输出。语法

```sql
查询1
UNION
查询2
```

* 不忽略有空值的记录，语法类似于UNION查询 `UNION ALL`

# ★ SQL Server进阶
使用存储过程、事务、试图、索引

## 1.存储过程
存储过程是一组预编译的sql，使用存储过程能加快查询速度。可分为系统和用户自定义存储过程 ；不带参数的存储过程不必要求以关键字exec或者execute调用，带参数的则必须使用关键字进行调用

### 1.1 系统存储过程
系统存储过程以'sp_'开始，存储在系统数据库resource中

+ sp_help
+ sp_databases
+ sp_helpdb -- 显示数据库信息
+ sp_helplogins
+ sp_helpsrvrolemember
+ sp_tableswc
+ sp_renamedb [数据库名] [新数据库名] -- 重命名数据库
+ sp_tables -- 查询表信息
+ sp_columns [表名] --查询列信息
+ sp_helpconstranint [对象名] //查询约束
+ sp_helptext 
+ sp_stored_procedures
+ sp_lock

### dbcc

dbcc inputbuffer()

```sql
/* 
*从dbf文件附加数据库的存储过程，参数一dbname指定数据库名称，filename1指定mdf主数据文件在物理磁盘上的全路径。
*filename2依次指定数据文件
*/

sp_attach_db @dbname nvarchar(10),@filename1 nvarchar(...),@filename2 nvarchar(..),.....,@filename16 nvarchar(..);

/* 
*从数据库分离数据库文件，使它可以被拷贝或者移动，如果数据库已经在使用中，那么必须使用alter database set语句将数据库更改到单用户 
*参数dbname指定要分离的数据库，skipchecs指定是否需要检查，keppfulltextindexfile指定是否需要保存全文索引文件元数据。
*/
```

```sql
sp_detach_db @dbname nvarchar(10),@skipchecks='TRUE|FALSE',@keepfulltextindexfile='TRUE|FALSE';
execute sp_who 'active'
set statistics time on
set statistics io on
set showplan_all on
set nocount on --执行sql查询时不显示受影响行数的提示
......
USE [master]
GO
CREATE LOGIN [sa] WITH PASSWORD=N'?<6PG?=i??,`?????g0?t?¤i°?>f%', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[简体中文], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [sa] DISABLE
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [sa]
GO
use [数据库名]
go
```

```sql
exec sp_msforeachtable 'sp_changeobjectowner "?","dbo"'
exec sp_addlogin @loginame='',@passwd='',@defdb= '',@sid=,@deflanguage=null;
exec sp_adduser @loginame= ''
exec sp_grantdbaccess 
exec sp_helpdb
exec sp_change_users_login @Action = null,@LoginName= '',@Password= ''
go
use master
go
create login qq with password='1234',default_database=QQ
go
create user qq for login qq with default_schema = dbo
go
exec sp_addrolemember '',''
go

exec sp_msforeachtable 'sp_changeobjectowner "?","dbo"' //更改数据库或者表的所有者为dbo
exec sp_addlogin @loginame,@passwd,@defdb,@deflanguage,@sid //更改登录信息
exec sp_adduser @username //添加用户
grant ALL on .. to @tables //授权
grant update,insert,delete,SELECT on dbo to databasename
exec sp_addrolemember @ower,@dbname //
```

### 1.2 扩展存储过程

```sql
xp_msver
-- 允许系统高级配置
-- sp_configure 'show advanced options',1
sp_configure 'recovery interval',1
-- 开启xp_cmdshell
sp_configure 'xp_cmdshell',1
go
-- 重新配置xp_cmdshell
reconfigure
go

/* -- 关闭xp_cmdshell为开启xp_cmdshell的反过程 */

sp_configure 'xp_cmdshell',0
reconfigure 
sp_configure 'show advanced options',0
reconfigure 
go
```

* 查询数据库中存在的对象
* 类型 [U] 表,[S] 视图,[P],[PK]主键约束,[FN]
* [SQ],[IT],[F] 外键约束,[UQ] 唯一约束
USE [数据库名]
GO
 -> SELECT * FROM sysobjects WHERE xtype='类型'
go

### 1.3 自定义存储过程及go关键字

创建之前最好检查一下存在性，否则创建存储过程可能会失败，也可以使用alter修改存储过程。

> SQL：

```sql
-- 如果在创建存储过程是使用了输出参数output,则在调用时也要加上output关键字;如果省略output则为输入参数，实际调用时需要传入一个实际类型的参数
-- 创建好一个存储过程后，不要忘了使用go进行提交，否则会递归调用
...检测存在性
create proc 存储过程名
@变量1 数据类型 [OUTPUT],
...
@变量n 数据类型 [OUTPUT]
AS
sql语句列
GO
```

执行存储过程，没有输出参数的存储过程，调用时允许不加execute或者exec关键字；如果在创建存储过程指定了输入参数，则在调用存储过程时必须使用exec或者execute关键字调用

```sql
EXEC 存储过程名 参数列
```

## 事务、视图、索引
### 1.事务
事务分为显式，隐式，自动提交式，包含一组数据库操作指令，如果某条sql指令执行失败，则整组语句将不会继续执行；事务是一系列操作的集合包含的操作时不可在分的,事务是整体向数据库系统中提交，要么都成功，要么都失败；事务具有以下特性：原子性，一致性，隔离性，持久性

+ 原子性：事务是一个不可分隔的整体，如果一条命令执行失败，那么整组命令都不会提交
+ 一致性：事务执行前和执行后数据保持一致
+ 隔离性：不同事务之间不会相互影响
+ 持久性:一旦事务提交成功，数据将永久保存，事务可互相嵌套

> SQL：创建显式事务

```sql
-- 开始事务，之后的语句都将被视为一个整体
begin transaction
sql语句

-- 回滚事务，清除操作，回滚到事务开始前，释放所有已占用资源 rollback transaction

-- 提交事务，标志事务结束，释放所有已占用资源
commit transaction
```

### 2.视图：

视图是一种虚拟表，视图中的数据不能被修改删除，一是出于安全，二是为了需要。一般被用来执行查询；删除视图不会删除表中的数据

> as子句视图中不能包含以下子句

* order by子句，除非指定了top子句
* into 关键字
* 临时表或者变量

> SQL：使用sql语句创建视图

```sql
create view 视图名
as SQL语句
```

执行视图，既然视图被认为是虚拟表，那么则可以用查询语句来查询视图中的内容

> SQL：删除视图

```sql
检测存在性，之后使用drop子句删除即可
.....
drop view 视图名
```

### 3.索引
* 索引可以加快数据库查询数据的速度
索引类型
全文索引
复合索引:将多个列组合为一个索引
聚集索引和非聚集索引

> SQL：使用sql创建索引

```sql
create [unique][clustered | nonclustered] index 索引名 
on 表名 列名1，[...列名n]
with fillfactor=x
```

+ unique 指定唯一索引
+ clustered、nonclustered 指定是聚集索引还是非聚集索引
+ fillfactor 指定填充因子x取值1-100

> SQL：删除索引

```sql
drop index 表名.索引名
```

## ★ SQL编程初步
### SQLServer变量的定义及声明
#### 局部变量

```sql
-- 局部变量以标记 @ 开始后跟变量名及数据类型
-- 全局变量只能被调用，不能再被重新赋值。调用时以标记 @@ 开始后跟变量名
-- 允许在一行声明多个变量,多个变量之间用逗号隔开
```

> SQL：声明变量

```sql
declare 变量1名 数据类型,变量2 数据类型,....,变量n 数据类型
```

> SQL：变量的赋值

```sql
set @变量名 = 值
或者 SELECT @变量名 = 值
SELECT与set的不同之处
SELECT 支持给多个变量赋值 set 不支持
```

#### 全局变量，以标记 @@ 开始

+ error 返回上一个T-SQL语句执行的错误码
+ identity 执行insert语句后标识列的值
+ language 返回数据库使用语言
+ version 返回数据库版本信息
+ max_connections 返回数据库允许的最大连接数
+ rowcount 返回上一次执行SQL的影响行数
+ servername 返回数据库服务器的名字
+ servicename 返回SQL在本地系统上使用的服务名

### 输出语句
 * 使用重载运算符'+'连接两个以下的表达式要求数据类型必须一致，如果是其他类型，则需要进行数据转换
 + 之前和之后的表达式或者变量要求数据类型一致

`print 表达式 [+convert(数据类型[(长度)],变量|表达式)]` //这同样可以使用cast函数来转换数据类型

SELECT 语句 [+....]

```sql
SELECT convert(varchar(30),login_time,120) FROM Students
print 10+10+''+''
```

### SQL编程中逻辑控制语句

#### if-else块：主要用于条件判断

> SQL：if-else

```sql
-- 以begin开始 end结束，所有相关语句都应写在begin-end块之间,单条语句可省略
if(条件)
begin 
语句块
end 
else 
begin
语句块(如果有else块则不可省略)
end
```

#### while块
* 主要用于执行某些循环操作

```sql
-- 以begin开始 end结束，所有相关语句都应写在begin-end块之间,单条语句可省略，语法：
while(条件)
begin
语句块
[break] | [continue]
end
```

#### case-end块，语法：

```sql
-- 以case开始end结束
SELECT语句
case 
when 条件1 then 结果1
......
when 条件n then 结果n
else 其它结果
end
```

# 附
## ★ 设计数据库
收集信息>标识实体(一般对应一个表中的某行记录，实际开发中一般对应某个表)>标识实体属性(对应表中的列)>标识实体之间的关系
需求分析
概要设计
绘制E-R(Entity-Relationship)实体关系图
用矩形表示实体
椭圆表示属性
菱形表示实体属性之间的关系
绘制数据库关系图
详细设计
设计需求规格说明书

优化数据库设计
使用三大范式对数据库进行优化
第一范式：确保列的原子性。列不能再被细分。
第二范式：在满足第一范式的基础上，确保每一列都和主键间接相关，即一个表只描述一件事情，如果有不相关的列，则应放到其他表中
第三范式：在满足第一、第二范式的基础上，确保每一列和主键直接相关

## ★ 在控制台使用命令行连接SQLServer
* 控制台的SQLServer程序sqlcmd，默认使用windows集成验证方式，如果需要以用户的形式访问数据库则需要指定-u和-p参数
可选项、参数 [-u] [-p] []...
-u:指定用户名，-p:指定密码
* 连接之前需要打开数据库访问存取服务MSSQLSERVER(默认)
 > net start MSSQLSERVER && sqlcmd
如果连接成功，命令提示符会变成
1>
* 前面的数字代表行号，其它的都和图形界面基本相同
* 查询等语句要在新行使用GO提交
* GO命令必须在新行键入执行，与SQL查询等语句位于同行的批处理命令GO不做处理

## ★ SQLServer函数列表
调用形式:
* SELECT语句不仅可以用来执行查询，还可以出现在多行插入的SELECT子句，也可以调用系统函数和执行输出，还可以使用SELECT为局部变量赋值
SELECT 函数名(参数列表)
也可出现在复杂的表达式中，以参数的形式出现

### 1.聚合函数
统计数据库表的记录数 count(columns_name | * | 1) --这个函数不会统计列的值为空的记录
不统计重复的记录 distinct()
返回最大值 max()
返回最小值 min()
计算表达式的总和 sum()
计算平均值 avg()

### 2.数学函数
### 3.系统函数
返回表达式的长度 datalength()
返回登录名 host_name()
返回当前登录用户名 system_user()
返回当前用户名 user_name()
转换数据类型 convert()
返回当前用户名 current_user()
### 4.时间函数
获取当前系统时间 getdate()
将指定的值 dateadd(日期参数,增长值,'日期')
datediff()
datename() 返回日期或者时间
datepart()

### 字符串函数
寻找指定字符串在另一个字符串的起始位置 charindex('','',开始位置)
求取字符串长度 len('')
转换大写 upper()
转换小写 lower()
ltrim
rtrim
取出字符串两边空格 trim()
right()
stuff()
替换字符 replace()
### 转换函数
cast(表达式|变量 as 数据类型)
convert(数据类型[(长度)],表达式|变量)

## SQLServer运算符
算术运算

## SQLServer FIQ：

```log
&amp;&amp;,||,!
<>,!= //不支持双等号==运算符
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
```

## 参阅：
+ SQL Server 2005 启用 xp_cmdshell 使用T-SQL语句导出数据到文件
+ SQL SERVER常用系统存储过程 - CSDN博客
+ SQL Server创建存储过程 - lenotang的专栏 - 博客频道 - CSDN_NET
+ sql server创建数据库用户语句
+ SQL Server 存储过程 - hoojo - 博客园
+ SQL Server存储过程多角度介绍 - roucheng - 博客园
+ SQL Server数据库用户创建的方法（使用SQL语句）(1) - 51CTO_COM
+ SQL Server数据库用户创建的方法（使用SQL语句）(2) - 51CTO_COM
+ Sql Server用户名和登录名的关系总结_完美世界-Dandelion_百度空间
+ sql server中利用sql语句创建用户和角色 - CSDN博客
+ SQL存储过程
+ sql存储过程教程
+ SQL数据库对象名无效的解决方法_只要生命还在，就没有绝望
+ SQL数据库恢复后出现对象名无效(实际是存在的)与网上同,更全 - mathew的专栏 - 博客频道 - CSDN_NET
+ SQL语句大全 - 百度百科
+ SQL语句如何增加列
+ 给SQL Server 2012创建一个登录名_爱-梦想_百度空间
+ 关于SQL Server创建登录名，用户，角色方面的
+ 使用SQL语句创建存储过程
+ 数据库基本----SQL语句大全

## 安装：

> Arch Linux 

由于 aur 上已经提供了 SQL Server 的 PKGBUILD，因此可以直接使用 aur 工具安装 SQL Server。可参考[Linux 上的 SQL Server 的安装指南](https://docs.microsoft.com/zh-cn/sql/?view=sql-server-ver15)。

```bash
# 搜索、安装
pacaur -S mssql-server
# 配置
sudo /opt/mssql/bin/mssql-conf setup
```

> 以下是配置日志：

```log
(2021-03-20 19:14:44:652490): [sss_cache] [confdb_get_enabled_domain_list] (0x0040): Failed to get [domains] from [sssd], error [2] (No such file or directory)
(2021-03-20 19:14:44:652638): [sss_cache] [init_domains] (0x0020): Could not initialize domains
(2021-03-20 19:14:44:663376): [sss_cache] [confdb_get_enabled_domain_list] (0x0040): Failed to get [domains] from [sssd], error [2] (No such file or directory)
(2021-03-20 19:14:44:663447): [sss_cache] [init_domains] (0x0020): Could not initialize domains
(2021-03-20 19:14:44:917789): [sss_cache] [confdb_get_enabled_domain_list] (0x0040): Failed to get [domains] from [sssd], error [2] (No such file or directory)
(2021-03-20 19:14:44:917865): [sss_cache] [init_domains] (0x0020): Could not initialize domains
(2021-03-20 19:14:44:926464): [sss_cache] [confdb_get_enabled_domain_list] (0x0040): Failed to get [domains] from [sssd], error [2] (No such file or directory)
(2021-03-20 19:14:44:926528): [sss_cache] [init_domains] (0x0020): Could not initialize domains
选择 SQL Server 的一个版本:
  1) Evaluation (免费，无生产许可，180 天限制)
  2) Developer (免费，无生产许可)
  3) Express (免费)
  4) Web (付费版)
  5) Standard (付费版)
  6) Enterprise (付费版) - CPU 核心利用率限制为 20 个物理/40 个超线程
  7) Enterprise Core (付费版) - CPU 核心利用率达到操作系统最大值
  8) 我通过零售渠道购买了许可证并具有要输入的产品密钥。

可在以下位置找到有关版本的详细信息:
https://go.microsoft.com/fwlink/?LinkId=2109348&clcid=0x804

使用此软件的付费版本需要通过以下途径获取单独授权
Microsoft 批量许可计划。
选择付费版本即表示你具有适用的
要安装和运行此软件的就地许可证数量。

输入版本(1-8): 2
可以在以下位置找到此产品的许可条款:
/usr/share/doc/mssql-server 或从以下位置下载:
https://go.microsoft.com/fwlink/?LinkId=2104294&clcid=0x804

可以从以下位置查看隐私声明:
https://go.microsoft.com/fwlink/?LinkId=853010&clcid=0x804

接受此许可条款吗? [Yes/No]:yes

选择 SQL Server 的语言:
(1) English
(2) Deutsch
(3) Español
(4) Français
(5) Italiano
(6) 日本語
(7) 한국어
(8) Português
(9) Русский
(10) 中文 – 简体
(11) 中文 （繁体）
输入选项 1-11:10
输入 SQL Server 系统管理员密码: 
确认 SQL Server 系统管理员密码: 
正在配置 SQL Server...

ForceFlush is enabled for this instance. 
ForceFlush feature is enabled for log durability.
Created symlink /etc/systemd/system/multi-user.target.wants/mssql-server.service → /usr/lib/systemd/system/mssql-server.service.
安装程序已成功完成。SQL Server 正在启动。
```
> Tips：

+ 启动 mssql-server 服务：`sudo systemctl start mssql-server.service`
+ 停止 mssql-server 服务：`sudo systemctl stop mssql-server.service`
+ 在 Linux 上可以使用 [(Azure Data Studio)](https://docs.microsoft.com/zh-cn/sql/azure-data-studio/quickstart-sql-server?view=sql-server-ver15) 连接 SQL Server。

