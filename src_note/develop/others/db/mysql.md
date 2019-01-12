# MySQL[^sql]笔记

## show 指令

+ 列出所有存在的数据库：`SHOW databases;`
+ 列出当前数据库下所有表和视图：`SHOW tables;` `show view`
+ 查询表xx下的所有字段信息：`SHOW CLOUMNS FROM xx;` 或者使用 `DESC 表名;` 或者 `DESCRIBE 表名;` 或者 `mysql> SHOW COLUMNS FROM table_name;`
+ 显示字符集： `SHOW variables LIKE 'character%'; ` 使用命令 `set names gbk;` 来临时支持控制台中文显示;
+ `show privileges [for user@host]`：显示用户权限

```sql
-- 用MySql之前确保已经开启了服务或者启动了服务器
USE 数据库名 IF EXISTS db;
-- 使用test数据库。
USE test;
```

## `CREATE 语句`
### `CREATE DATABASE语句 创建数据库`

```sql
mysql> CREATE database [if not exists] 数据库名;
```

### CREATE TABLE

```sql
-- 必须确保创建表之前应该使用 USE 引用数据库。否则就要使用 `db.table` 的形式。
CREATE TABLE [if not exists] table_name
(
-- 约束集合是可选的，它们之间使用空格来分隔
-- 标准SQL允许在所有列之后创建约束
`列1` 数据类型 [约束集合], 
...
`列n` 数据类型 [约束集合],
[约束集合....]
)
)[default charset 默认字符集],[auto_increment=num],[engine=.....];
```

> 约束集合  MySql不对check检查约束使用太严格的检查

+ NULL|NOT NULL:列值是否允许为空
+ AUTO_INCREMENT(..):设置自增列，自增列必须设置为PRIMARY KEY
+ PRIMARY KEY:该列是否是主键，一个表只允许存在一个主键，但这个主键可以包含多个列
+ UNIQE:为字段创建唯一约束
+ DEFAULT:指定默认值
+ COMMENT：为字段设置注释消息
+ ....
+ CONSTRANT 约束类型 约束名 约束具体...,
+ ....
+ CONSTRANT 约束类型 约束名 约束具体...

### `CREATE VIEW`
### `CREATE INDEX：`
### `CREATE TRIGGER`
### `CREATE PROCEDURE`
### `CREATE FUNCTION`
### CREATE USER：用户管理 

***新安装的mysql允许匿名用户直接登录 root用户默认没有设置密码**

```sql
--新建用户
-- 新建用户默认没有任何权限，需要使用GRANT语句为新建用户授权
-- GRANT语句除了可以为新建用户显示授权，也可以使用GRANT语句新建用户并直接授予权限或者增加、删除密码。

/* 如果需要，用户名和主机名需要使用单引号引起来，防止特殊符号被mysql服务器解释；主机名可以是一个ip地址或者主机名，这将只允许在此主机上登录，如果设置为localhost或者127.0.0.1，则只允许在本机上登录；如果将主机名设置为一个%，则会允许这个用户通过所有主机连接到mysql服务器。
*/
mysql>  CREATE USER user_name@host|address password by [PASSWORD] '';
```

## GRANT与REVOKE语句

GRANT语句不仅可以用来给新用户授予权限，还可以直接创建用户并授予权限或者修改用户密码。

```sql
-- GRANT语句除了可以为新建用户显示授权，也可以使用GRANT语句新建用户并直接授予权限或者增加、删除密码。
-- PRIVILEGES包括CREATE,DROP,RELOAD,SELECT,UPDATE,DELETE......,多个权限之间使用逗号分隔。
GRANT ALL|PRIVILEGES ON OBJECT_NAME TO USER@HOST IDENTIFIED BY '';
```

## LOAD DATA语句：从文件中载入数据

```sql
LOADDATA [LOCAL] INFILE 'file_name' INTOTABLEtb_name
[COLUMNS|FIELDS
[TERMINATEDBY 'string']
[ESCAPEBY 'string']
]
[LINES
[TERMINATEDBY 'string']
[ESCAPEBY 'string']
]
```

## INSERT语句

> 多行插入： 

```mysql
insert into test (descs) values ('真诚'),('诚实'),('勇敢'),('善良'),('美好'),('美丽'),('无辜');
```

## UPDATE语句
## DELETE语句

如果只是想清空表数据而保留表的结构，则可以使用不带条件的DELETE语句
！如果设置了自增列，则直接删除所有数据并不能让自增列重新开始。如果要想自增列从新开始，则应该使用truncate table语句，但这必须确保要truncate的表没有被其它表引用。


## `ALTER TABLE` 语句：修改表、视图。。。

```sql
-- 删除、新增主键
ALTER TABLE table_name ADD PRIMARY KEY(column_name1[,..,columnN]);
--删除主键
mysql> .... DROP PRIMARY KEY;

--设置编码
ALTER TABLE table_name DEFAULT CHARACTER SET '编码';
ALTER TABLE ... CHANGE.... CHARACTER SET 'utf8';

-- 重命名表
mysql> ALTER TABLE old_table_name RENNAME [TO] new_table_name;
```

-- 重定义列

```sql
有时需要对表做出一些修改，这些修改包括修改某一列的数据类型，或者想要给某一列添加某个约束，又或者添加或者删除列
--如果确实需要在表中增加列，可以使用以下方式来新增列
！如果只有一列，则可以省略括号
mysql> ALTER TABLE table_name CHANGE oldcolumn_name newcolumn_name [data_type] [约束集合];
```

> 约束集合以空格分开，包括：

```sql
....
ALTER TABLE table_name ADD COLUMN 
(
cloumn_name1 data_type [约束集合],
...
cloumn_nameN data_type [约束集合]
);
```


```sql
--修改列定义，包括数据类型，约束，描述等
ALTER TABLE table_name modify cloumn_name new_data_type [约束集合];
```

```sql
--调整列 如果对列的顺序不是很满意，还可以使用MODIFY来修改列的顺序

/*
关键字FIRST可以将指定的列调整为数据表的第一列，使用FIRST关键字不要指定列2;
关键字AFTER用于将指定的列1调整到列2的后面，列1必须指定数据类型，但数据类型可以保持不变，列2不需要指定数据类型；
*/
ALTER TABLE table_name
MODIFY <column_name1> <data_type> ALTER|FIRST column_name2;
```

```sql
--删除、新增主键
ALTER TABLE table_name ADD PRIMARY KEY(column_name1[,..,columnN]);
```

## DROP语句： 
### DORP INDEX
### DROP USER：

### DROP DATABASE
### DROP TABLE：删除表

```sql
/*
* 如果还有使用到它的时候，则可以将所有数据导出到一个sql脚本或者直接备份数据库或者表
* CASCADE|RESTRICT选项指定删除方式，默认为CASCADE，删除表及所有约束
* 如果在表中存在约束且没有删掉约束，在DROP语句中还使用了RESTRICT选项，则系统会拒绝删除表
*/
mysql> DROP TABLE [IF EXISTS ] table_name [CASCADE|RESTRICT];
```

如果只是想清空表数据而保留表的结构，则可以使用不带条件的DELETE语句，如果设置了自增列，则直接清空一个表数据并不能让自增列重新开始。`truncate`  `DELETE FROM table_name;`

## `SELECT` 语句：基本查询(simple query)

```sql
-- SELECT语句 将查询保存到文件中
SELECT ...FROM tb_name INTO OUTFILE 'file_name';
```

### group by：分组查询
### iner join：连接查询
### 内连接查询
### 外连接查询(左，右，全)
### subway select：子查询

# 附

## 安装

### windows
windows下安装、配置MySQL
下载MySql的安装程序或者免安装版
如果是安装程序？
Tpct... //
Custem.. //自定义安装
Comptelet....//完全安装

* 如果是使用安装程序完成MySQL的安装，则随时可以使用安装目录下的图形界面配置工具MySqlInstance来重新配置MySql
Recongigur....//重新配置
Remove....//移除配置

Detailed....//详细配置
Standard...//标准配置

Developere.. //开发者模式
Server.. //服务器模式
Dedircted.... //独占模式

Multifuco.... //
Transactional... //
Non-Transactional... //


Manual S.... //自定义
Decision... //标准连接
Online.... //使用在线连接...

Enable Tcp/IP.... //启用Ip连接
Add firewall... //允许端口进出防火墙
Enable Strict.... //启用严格模式


Stadard....//标准字符编码集
Best...
Manual Sewle..... //设置编码集

Install As.... //安装windows服务
Launch the... automatically... //随window启动而启动
Include Bin...Path//包含到windows环境变量Path中
设置root用户的密码
Enable root access from ....//允许root用户从网络上连接
Create ..An...Account //启用匿名用户连接
如果是免安装版？则应该配置MySql目录下的ini配置文件。

### Linux
#### 从源码编译安装 MySQL

> 现今 MySQL 已经被 Oracle 收购，但一款向上兼容 MySQL，叫做 Maridb 的数据库已经开发并稳定下来。Maridb 是可以直接从系统源中安装的，不过，MySQL 也还没有彻底闭源。

&nbsp;&nbsp;如果没有从 MySQL 的网站或者系统源中找到适合于自己系统已经编译好的二进制包(二进制包是针对于某一系统且已经编译好的可以直接安装到系统的软件包)，那也许需要 [从源码编译安装 MySQL]() 到系统中了。

1.1 从 [MySQL 网站]() 获取 MySQL 源码
1.2 配置编译参数并尝试编译 MySQL，5.6 以上版本 使用 cmake 编译。

```Bash
cmake . -DCMAKE_INSTALL_PREFIX= -DMYSQL_DATADIR=\
-DDEFAULT_CHARSET=utf8 -DEXTER_CHARSETS=all\
-DDEFAULT_COLLATION=utf8_general_ci\
-DWITH_INNOBSE_STORAGE_ENGINE=1 -DWITH_PARTITION_STORAGE_ENGINE=1\
-DWITH_MYISAM_STORAGE_ENGINE=1 -DWITH_MEMORYY_STORAGE_ENGINE=1\
-DWITH_ARCHIVE_STORAGE_ENGINE=1
make && make install
```

标准MySQL默认只提供了命令行工具(mysql mysqld mysqladmin mysqldump mysqlshow)；MySQL也提供了多个图形界面管理器，但是有中文界面的只用Navicat for MySql、SQLYog和php..。还有 WEB 界面的 phpmyadmin等。

#### 配置 MySQL
 2.1 创建用户和组(这一组指令都要用根用户权限执行)
```
groupadd mysql
useradd -r -g mysql -s /sbin/nologin -M mysql
chown -R mysql:mysql $basedir
```
##### 初始化数据库和用户授权表
cd 到 MySQL 的安装目录($basedir):
```
scripts/install_db --user=mysql --basedir= --datadir=
sudo chown root:root $basedir
sudo chown -R mysql $basedir/data
```
##### 设置 MySQL(可选)
更改 MySQL 密码，删除匿名用户，删除测试数据库，重载授权表
```
bin/mysql_secure_installation
```
##### 手动更改 MySQL root 账户的密码(可选)

> 有三种方式可以更改密码：

+ mysql set 语句 `set password for user@host = password('');`
+ mysql update 语句 `update mysql.user set Password=password("") where user='root';`
+  使用mysqladmin 指令 `mysqladmin -uroot -p password ""`

&nbsp;&nbsp;`mysqladmin -uroot [-p旧密码] password 新密码;`修改root用户的密码，注意：这必须已经打开了mysql服务。
"如果root用户一开始就没有密码，则不需要指定-p选项。执行这条命令会给root用户添加一个新的密码。新密码如果包含特殊字符则需要使用单引号将密码引起来，如果省略，则会在控制台提示输入新密码


## MySQL 配置文件

MySQL目录下存在多个配置文件，但如果只是用于一般性测试或者学习所需，则只需配置my.ini配置文件，免安装版的可能不存在my.ini这个配置文件，而是存在my-default.ini，这时，可以配置这个文件，也可以新建一个my.ini作为mysql的配置文件。 ~/.my.cnf   Or   [/etc/my.cnf](my.cnf) mysql.ini $basedir/my.ini

```ini
[mysqld]
;服务端字符集
character-set-server=..
;！配置MySql安装目录和数据目录时，在windows平台上，最好不要使用反斜杠'\'作为路径分隔符(如果确实要用反斜杠来作为路径分隔符，则必须使用双反斜杠)，而是要使用正斜杠'/'作为路径分隔符，否则无法启动服务。如果已经使用，则可以修改my.ini配置文件，如果目录存在特殊字符或者空格，确保使用双引号将它们引起来，防止目录名被作为命令或者命令选项解释
basedir=.. 

;数据目录
datadir=..

[Client]
;客户端字符集
loose-default-character-set=..
;MySql的端口号
port=3306
user=
socket=
pid=

[WinMysqlAdmin]
;启动服务的命令行
;Server=.. 
;.....
```

## 启动 / 停止 MySQL 服务

### 以服务（守护进程）方式运行的 MySQL

+ 如果没有将 mysql 安装为服务，则应该使用命令(Ctrl C 当然也可以)`mysqladmin -uroot shutdown -p`来停止关闭服务器

&nbsp;&nbsp;MySQL 默认只提供了命令行界面，在 Windows 上，用于启动 MySQL 的命令类似于： ` net start MySql` 或者 `sc start MySql` 。如果不喜欢，可以使用图形界面的服务管理器services.msc模块启动mysql服务。 连接MySql必须先开启MySql服务或者使用命令行运行 MySQL 服务器。

### 命令行启动（非守护进程，服务式） MySQL 

&nbsp;&nbsp;如果没有将 MySQL 注册为系统服务，则需要在控制台启动mysql服务器，如果没有将mysql添加到系统的PATH环境变量中,则需要使用mysql服务器的全路径来启动mysqld，在 Windows 上，非服务启动方式的指令类似 `mysqld --console`，在 Linux 上，使用 `mysqld_safe` 启动。

## mysql 客户端指令集：

&nbsp;&nbsp; -u 选项指定用户root,-h选项用来指定主机，如果是本地登录，则可以省略此项。database_name用来指定连接的数据库，它并不是必须的。-p选项指定要用密码来连接root用户。如果连接成功则显示提示符,在此提示符下的所有语句都要用英文中的分号结尾，切换数据库上下文时可以省略。数据库中的每一种语言...都可以在之前使用help命令获取帮助。-e 用来执行一条或者一组 SQL，如果使用的 Shell 是 Bash，该选项还可以使用立即字符串 `<<<` 代替。

> 如果你希望某些选项成为默认值而不必每次输入，你需要自行在 MySQL 配置文件中的 client 段配置这些选项。

+ 在客户端连接 MySQL 服务器：`mysql  -uroot -hlocalhost -p [database_name]`
+ status|\s:显示数据库状态信息
+ \G:垂直显示查询结果，不需要在结尾再添加分号，命令或者语句前也不要添加空格
+ system|\!:执行一个shell命令或者脚本，此命令只在Linux/Unix中有效
+ pager|nopager:设置分页程序，此命令只在Linux/Unix中有效
+ prompt：mysql 客户端提示符
+ source|\. 执行一个sql脚本
+ tee|\T `tee I:\Temp\log\mysql\test.log`：将所有结果集通过管道定向到外部文件中。使用exit命令退出mysql客户端时，会将输出流写入到指定的外部文件中。

## MySQL的数据类型
除了支持ISO SQL-92定义的标准数据类型，也支持ANSI SQL-92定义的所有数据类型
MySQL使用了utf8来作为默认字符集，因此它不将汉字视为两个字节，而是使用一个字节来保存汉字
DateTime实际上是Date的同义词
int实际上是Integer的同义词，默认长度为11
numeric实际上是 `Dec[imal](num,num)` 的同义词,默认精度为10,0
nvarchar实际上是varchar的同义词

## MySQL函数

### 数学函数
### 字符串函数
### 时间/日期函数
### 系统信息函数
### 其它函数
### 加密/解密函数

## 问题：

1. 忘记 MySQL 密码
&nbsp;&nbsp;假如你忘记了 MySQL root 账户密码？你可以在命令提示符或者命令解释器上以 `--skip-grant-tables` 选项运行 MySQL 服务器。**如果 mysql 服务已经在运行，需要先停止 mysql 服务 `sudo killall mysqld`**。

   1. 这时，就可以在客户端上直接连接 MySQL 了。如果是 windows？在一个控制台窗口中运行带这个选项的 `mysqld --console --skip-grant-tables`，然后重新打开一个控制台窗口；如果是 Linux？保持运行在后台 `mysqld_safe --skip-grant-tables &`。
   2. 接着：使用无密码的方式登录 mysql，`mysql -uroot -p` 提示键入密码时省略密码直接回车 然后执行 update 语句直接更新 mysql.user 表或者执行 set 语句 `UPDATE mysql.user SET password=PASSWORD('newpassword') WHERE user='root';`。如果想要立即生效，则需要重新载入授权表 `flush privileges;`。也可以重启服务后重新登录 mysql。

2. 如果你的 MySQL 服务启动错误：
***&nbsp;&nbsp;在 Windows，你可以在命令提示符上使用 mysqld --console 启动 mysql 服务器并能看到 MySQL 服务器的详细启动消息或者检查 mysql 服务器的启动日志文件，如果 mysql 启动存在错误，则 mysql 服务器会创建一个以主机名打头的 err 文件，在这个文件中详细的列出了启动过程，如果有错误，则只需要检查以 err 开始的行即可很快发现错误(可以通过更改配置文件将这个错误日志文件保存到其它位置，方法是在 mysql 配置文件 my.ini 或者 ~/my.cnf 中的[mysqld]段下面增加节点 log-error***


3. 当 mysql 配置文件有语法错误时可能导致 mysql 服务无法开启
指定 basedir 与 datadir 目录时，不能使用反斜杠'\'来作为路径分隔符，而是使用正斜杠'/'来作为目录分隔符

4. 启动服务遇到 1067 错误
配置文件中安装目录和数据目录无法读取或者存在错误，未更新数据目录或者安装目录；数据目录下的 ib_logifle0 和 ib_logfile1日志文件存在错误；将这两个数据文件备份后删除

5. Access demid
使用 root 用户登录，依然被拒绝登录：用户名或者密码错误，或者未指定密码
检查用户名或者密码

6. MySQL5.6_x86_64列级约束无法使用constraint指定约束名称  

7. SQLyong使用本地账户无法执行SQL中的create、update语句  
图形界面的MySQL前端连接被视为远程连接，只具有本地权限用户没有create update grant权限  

8. ERROR 1064 (42000): You have an error in your SQL syntax;  check the manual that corresponds to your MySQL server version for the right syntax to use near 'dorp table record' at line 1  
drop table或者delete table语句不能删除已经或者正在被引用的表中的数据。  

9. SQL关键字或者语法错误 ERROR 1217 (23000): Cannot delete or update a parent row: a foreign key constraint fails 
表A引用表B

10. ERROR 1701 (42000):  Cannot truncate a table referenced in a `foreign key constraint (`netbar`.`record`, CONSTRAINT `computer_record_fk` FOREIGN KEY (`computerId`) REFERENCES `netbar`.`computer` (`computerId`))`
如果一个表正在被其它表所引用，那么在没有删除引用或者删除引用它的其它表之前不能对它执行delete或者truncate语句。

delete [from] table语句后如果没有where字句则会清空表。但在那些支持自增列的数据库中不会使得自增列从1开始 

11. MySQL客户端怎么会解释已经被--注释掉的语句  
双中划线--风格的注释要求被注释掉的语句之前--之后至少有一个以上的空格/tab，否则会被MySQL服务器解释  

12. ERROR 1064 (42000): You have an error in your SQL syntax;  check the manual that corresponds to your MySQL server version for the right syntax to use near '--truncate table computer' at line 1  
truncate table语句会清空表并且不会记录日志，还会让那些支持自增列的数据库的列从头开始重新计数。但是它不能清空已经或者正在被引用的表。

13. #号风格的注释可有可无
  
14. MySQL脚本中的可执行注释  /!* */

[^sql]: MySQL 是一种关系型数据库。SQL(Struct Query Language)是结构化查询语言的简称。结构化查询语言包括：TCC():事务控制语句，包括 COMMIT，SAVEPOINT，ROLLBACK 等语句；DML(Data Manipulation Language)：数据操作，包括 INSERT、UPDATE、DELETE....语句； DDL(Data Definition Language)：数据定义，包括 CREATE、DROP、ALTER 等语句，以及 DQL(Data Query Language)：数据查询，包括SELECT 语句和 DCL(Data Control Language)：数据控制，包括 GRANT、REMOKE 等语句。

> 参阅：

+ [mysql load操作 - ggjucheng - 博客园](http://www.cnblogs.com/ggjucheng/archive/2012/11/05/2755683.html)
+ [MySQL优化配置文件my.ini(discuz论坛)_Mysql_脚本之家](http://www.jb51.net/article/26471.htm)
+ [数据库常见操作_zhouhuaooo_新浪博客](http://blog.sina.com.cn/s/blog_57f325fb0100gt2j.html)
+ 通过SQL语句使用什么命令创建数据库_神马都知道
+ [1.5.2 如何在创建表时指定约束 - 51CTO.COM](http://book.51cto.com/art/201008/219884.htm)
