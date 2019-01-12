# ★ Oracle的基本操作 DML:CUID
## 实例
！安装Oracle过程中，如果配置了数据库，则

Oracle的对象并不放在数据库中，而是放在一个被称为表空间的逻辑结构中。一个数据库对应于一个实例，一个实例对应一个 service，创建多个数据库就会创建多个实例，这样会增大系统开销


## 表空间(TABLESPACE)

！表空间是Oracle数据库即实例下用来存放对象的一个逻辑结构

> SQL：查询表空间，查看当前用户的表空间名

```sql
SELECT tablespace_name FROM user_tablespaces;
```

创建用户自己的表空间，至少要以SYSTEM用户登录数据库

* DATAFILE:数据文件是个以DBF(不一定必须是)为扩展的物理文件，创建表空间需要明确指定数据文件的物理路径和文件名,包含数据文件名的路径需要使用单引号''来指定。可以同时指定多个数据文件(!这些数据文件可以在不同的磁盘或者分区上)，但需要使用逗号分隔它们和为每个数据文件指定大小，
！AUTOEXTEND可选项可以声明在所有数据文件之后。
* SIZE:数据文件大小，以M或者K...为单位
* AUTOEXTEND:启用或者禁用数据文件的自动扩展，如果设为ON，则表空间使用完后可以自动扩展，否则无法继续添加数据。
* NEXT:自增长大小,MAXSIZE:最大值，这两个选项必须在AUTOEXTEND选项设为on时才能使用。
* extent management 设置表空间的管理方式，dictionary为数据字典管理方式,local为本地管理
* segment 指定段空间的管理方式，设为manual时为手动

> SQL:创建用户自己的表空间

```sql
CREATE TABLESPACE tablespace_name
datafile 
path&filename1 [size ..k|m] [reuse]
[autoextend off|on [next .. k|m maxsize unlimited|..k|m]]
[online|offline //online 立即可用，offline 创建的表空间不可用
logging|nologging 
extent management dictionary | local autoallocate | unform size k|m 
segment space management auto|manual,] 

....

[path&filenamen [size ..k|m] [reuse]
[autoextend off|on [next .. k|m maxsize unlimited|..k|m]]
online|offline 
logging|nologging
extent management dictionary| local autoallocate|unform size k|m 
segment space management auto|manual; 
]
```

> SQL 修改表空间 为表空间增加数据文件

```sql
alter tablespace tablespace_name add datafile options
```

> SQL 修改数据文件大小

```sql
alter database datafile path&fileNmae resize ..K|M autoextend on|off ...;
```

> SQL 修改数据文件状态 ONLINE|OFFILINE|OFFLINE 

```sql
alter database datafile path&fileName options;
```

> SQL 修改表空间状态

```sql
alter tablespace tablespace_name ONLINE|OFFLINE|READ ONLY|READ WRITE;
```

> SQL 删除表空间 DROP

```sql
drop tablespace tablespace_name
[including contents [and datafiles]];
```

## 用户管理
> SQL:创建用户

```sql
CREATE USER 用户名 
IDENTIFIED BY password
[DEFAULT TABLESPACE 标识符]
[DEFAULT TEMPTABLESPACE 标识符]
```

为新建用户授权
！通常将角色授给用户而不是直接授予权限给用户

> 常用角色:

+ DAB:dba角色具有系统中的所有权限，不要轻易授予用户这个角色。
+ CONNECT:使用户可以连接到数据库上默认的表空间
+ RESOURCE:使用户具有DDL权限
+ SESSION:

> SQL:授权/移除用户权限/角色

```sql
GRANT 权限/角色 [ON V$..] TO USER
GRANT SELECT|UPDATE|INSERT|*|ALL ON OBJECT_NAME TO USER
REVOKE 权限/角色 FROM USER
```

DROP
！DROP语句无法删除拥有模式对象的用户，如果确实要删除，则可以添加CASCADE选项

## 表

！使用DDL语句时，如果要创建的对象名与系统关键字冲突，则可以使用双引号将对象名引起来，但这样一来，在之后引用对象时，也必须使用双引号引用对象名。因此，在DDL语句中，最好不要随便将标识符使用双引号引起来。
！如果对象名和系统关键字冲突但又确实要用这个名称，则可以使用双引号将对象名称引起来，但这样一来，之后在引用这个对象名称时，也必须使用双引号来引用这个对象名称。
* 列级约束也可以单独放在constraint子句之后，如果使用了constraint关键字，则添加约束时需要指定约束名,否则不需要指定约束名。

> SQL:创建/删除表

```sql
CREATE TABLE [Scheme].table_name 
[tablespace tablespace_name]
(
column_name column_data [列级约束],
...
column_name column_data [列级约束][,
[primary key(column_name),]
constraint
约束名 约束类型...具体约束|条件或者值,
....
约束名 约束类型...具体约束|条件或者值]
)
[tablespace tablespace_name]
[......]
;
```

删除表使用DROP子句 `DROP TABLE table_name [CASCADE|RESTICT];`

> SQL:修改表 增加列,如果要增加多列，使用圆括号将它们包围。

```sql
ALTER TABLE ADD [cloumn] cloumn_name data_type [列级约束];
```

> SQL 删除列

```sql
ALTER TABLE table_name DROP [COLUMN] column_name;
```

> SQL 修改列

```sql
ALTER TABLE table_name MODIFY column_names new_data...;
```

> SQL:向表中添加/删除/修改约束

```sql
ALTER TABLE table_name ADD CONSTRANINT 约束名 约束具体
ALTER TABLE table_name DROP CONSTRANINT 约束名
```

## 序列(Sequence)
！Oracle没有自增列的概念，但这可以通过创建序列的方式来实现。语法：

> 创建序列，可选项

* START WITH:指定生成的第一个序列号
* INCREMENT BY :指定序列号之间的间隔，默认为1
* MAXVALUE|NOMAXVALUE:序列的最大值|没有最大值
* MINVALUE|NOMINVALUE:序列的最小值|没有最小值，必须小于等于START WITH的值，小于MAXVALUE的值
* CYCLE|NOCYCLE:允许序列在达到最大值或者最小值后，继续从头生成值
* CACHE|NOCACHE:数据缓存，允许预分配一组序列号驻留在内存中来加快访问速度

> SQL:创建序列

```sql
CREATE SEQUENCE 标识符
start with integer
increment by integer
maxvalue Integer|nomaxvalue
minvalue Integer|nominvalue
cycle|nocycle
cache|nocache
```

> 以下创建一个名为user_for_id的序列。

```sql
create sequence user_for_id start with 7 increment by 1 maxvalue 200 nocycle nocache
```

> 访问、更改、删除序列

访问序列通过伪列nextval和currval来访问序列
访问序列
* 通过伪列nextval和currval来访问序列
序列名.nextval
序列名.currval

更改序列通过ALTER SEQUENCE 语句来实现,不能通过start with选项修改序列的开始值。

> SQL：更该序列

```sql
alter sequence sequence_name 
increment by Integer
.....
;
```

删除序列使用DROP语句删除序列。语法:
> SQL 使用DROP语句删除序列

```sql
drop sequence sequence_name;
```

## 索引
## 分区表

```sql
partition by range ()
(
partition 标识符 values less than .....
....
partition 标识符 values less than (maxvalue)..
);
```


## 同义词

同义词可以减少一些操作或者隐藏掉系统数库的真实名称。可以防止不相干的人随意猜测数据库表的内部结构。主要包括公有和私有同义词。

创建同义词需要用户具有create...的权限，如果是自己创建的用户，可以使用授权语句授予用户可创建同义词的权限。语法。 `grant create public |s.. to user;`
简单的同义词创建可以使用以下语法： `create [public] ... ... from ..;`

## 查询
模糊查询
_单个字符匹配


# PL/SQL编程

## 变量

declare
varabale_name data_type[(size)] [:=value]
begin
....
end

## 基本选择结构

```plsql
if
if then
...
end if;

if-else
if ... then
 sql
else 
sql
end if;

if then
sql
...
elsif  then
sql
...
else sql
end if;

case-when-then-end case;

case [条件表达式]
 when ... then
sql..
 when ...then
sql...
....
else sql...
end case;
```

## 循环结构

```plsql
loop、while-loop-endloop & while-loop-end loop & for-in-loop-endloop
loop
sql..
exit when ... 
end loop;


while ... loop
sql...
end loop;


for 计数器 in [reverse] 下限 ... 上限 loop
sql...
end loop;
```

## 顺序结构 null、goto


## 异常处理 预定义异常&用户自定义异常

### 预定义异常

ACCESS_INFO_NULL:
CASE_NOT_FOUND:
COLLECTION_IS_NULL:

NO_DATA_FOUND:

STORAGE_ERROR:
TOO_MANY_ROWS:
VALUE_ERROR:
ZERO_DIVIDE:以零为被除数

### 用户自定义异常

```plsql
... exception
```

###  抛出异常

```plsql
raise ..
begin
....
exception 
when ... then
....
when others then
...
end
```

## 游标

```plsql
cursor 标识符 [parameters]
[return return_type] is sql...

OPEN cursor_name..

fetch cursor_name into varables..

close cursor_name
```

## 存储过程

# 附

## 安装 
## 配置
### 配置数据库
net config
### 服务端监听程序配置
### 客户端配置
PL/SQL Developer(64位Oracle需要配置32位的客户端)
32位客户端下载>解压>pl/sqldeveloper工具-首选项-连接
指定Oracle主目录为32位客户端目录>指定oci库为32位客户端下的oci.dll>重启Oracle服务和pl/sqldevedoper
在客户端network\admin目录下建立listener.ora启动文件，可以直接复制服务端的监听配置文件
SQL Developer


### 字符集配置

```batch
 setx NLS_LANG "SIMPLIFIED CHINESE_CHINA.ZHS16GBK"
```

> 简体中文编码 Chinese (simplified)

+ zh_CN.GB18030 SIMPLIFIED 
+ CHINESE_CHINA.ZHS32GB18030
+ zh_CN.GBK SIMPLIFIED CHINESE_CHINA.ZHS16GBK
+ zh_CN.UTF-8 SIMPLIFIED CHINESE_CHINA.AL32UTF8


## ★ 使用sqlplus

### 连接Oracle

```batch
sqlplus [[/nolog][user[/password]][@service] [@sql]
conn[ection] [username|username/password] | [/ as sysdba] --连接指定用户，命令语法如上
disc[onnection] -- 断开连接
```

### SQL缓冲区

SQL缓冲区可以保存上一次执行成功以分号结尾的一条或者一组DML、DDL、TCC、DQL语句。

### 系统控制台缓冲区

windows下已经执行的sqlplus命令或者通过host执行的系统主机命令可以通过键盘上的F7功能键查询(F8只会根据输入的数字来执行一个命令)，此功能键会弹出一个小窗口，里面是已经执行过的系统命令，通过更改控制台窗口的缓冲区大小来记录更多的命令，一旦退出控制台，则命令历史记录会被清空

### sqlplus 指令集
+ l[ist]
+ ed[it] 编辑存储在缓冲区的语句
+ d[elete] n --删除缓存区的指定行，如果省略则删除当前行
+ save path&filename [create|append|replace] --保存缓存区的SQL到磁盘文件，如果省略文件名和路径则使用默认名称保存到当前路径(host cd命令可查看当前路径)
+ / 或者run 运行存储在缓冲区的语句
+ a[ppend]
+ r[eplace]
+ host [command]--如果没有指定命令，则会临时退出oracle环境返回主机环境，否则执行cmd命令
+ start|@ 执行一个sql脚本

```batch
sqlplus username[/password][@networkname]|[nolog][as sysdba]
sqlplus / as sysdba
select instance_name from v$instance;
shutdown immediate;
startup nomount;
alter database mount;
alter database open;
```

```batch
col[umn] for[mat] a长度 --格式化列的显示
column column_name heading "列的别名" [format options]|clear --列名必须已经存在缓冲区中，否则Oracle会提示列名无效
clear columns;
```

BTITLE/TTITLE:创建报表

Oracle启动时，允许使用初始化登录脚本login.sql，它通常位于$ORACLEHOME的sqlplus目录下。
但是Oracle也允许创建一个环境变量SQLPATH来指定执行登录脚本的位置

在登录脚本中，可以设置一些初始化设置命令

```batch
set pause [on|off|text] --设置查询分页显示文本，回车显示下一页
set head [on|off] 
set time [on|off] --在命令提示符前显示或者关闭系统时间
set timing [on|off] --显示sql执行时间
set linesize 长度 --设置列的长度，和pagesize同时使用生效 
set pagesize 长度--设置页面大小，和linesize同时使用生效
set newpage --设置是否在新行终止显示
```

# 附 1：PL/SQL 
## Oracle函数：
系统函数
分析函数:
日期函数
转换函数
TO_CHAR()
TO_DATE()
聚合函数
求和转换
nvl(column,number);
max()
min()

## Oracle数据库 PL/SQL 数据类型

* p:控制精度 s:控制范围
NUMBER(p,s):
CHAR:VARCHAR2:NCHAR:NVARCHAR2
DATE:
TIMESTAM:
LOB:"大对象"数据
CLOB:(Char LOB),字符型大对象数据
BLOB(Binary LOB):可存储二进制的数据
BFILE(二进制文件):
NCLOB():存储大的NCHAR字符数据。

# 附 2
## 模式(Scheme)

### 模式对象

## Oracle启动过程......
1.从默认位置查找服务器初始化参数文件(二进制初始化参数文件(SPFILE<Oracle_sid>.ora)和文本初始化参数文件(INIT<Oracle_sid>.ora)
Oracle_11g_r2 64位在windows初始化参数的位置：
<Oracle_HOME>/product/dbhome_1/DataBase
二进制初始化参数文件：SPFILE_<ORACLE_SID>.ora
文本初始化参数文件：INIT<ORACLE_SID>.ora
Oralce详细启动日志位于:
<Oralce_HOME>\diag\rdbms\orcl\orcl\trace\alert_<ORCLE_SID>.log


## 伪列
ROWID
ROWNM

## 数据字典（Data Dictionary），虚拟表，伪表:dual

Oracle数据字典也叫系统表，它保存了大多数的Oracle信息，主要分为静态和动态数据视图
以dba_为前缀的表示此为系统视图或者表，必须拥有dba权限或者对此授予了查询权限的用户才具有权限浏览

用户级数据字典视图:user_tablespaces;
系统级:dba_tablespaces;
数据文件所在系统视图:dba_data_files;

用户级数据字典视图:user_users;
系统数据字典视图:dba_users;

用户级:user_tables;
系统级:dba_tables;

用户级序列数据字典user_sequences;

用户级约束数据字典:user_constraints;


dba_users:保存了所有用户信息。
dba_data_files:保存了系统所有数据文件的信息。
dba_tablespaces:保存了所有表空间的信息。
dba_tables:保存了所有表的信息。

以user_为前缀的表示当前用户可操作

user_tables
user_tablespaces
user_users


用户权限数据字典：
dba_sys_privs
dba_role_privs
user_role_privs
role_role_privs

以all_为前缀的视图，动态视图以`$`结尾：`包括V$,GV$,X$...`。动态视图包含特殊字符$,这只有在已经运行时并且需要有dba权限或者已经授予用户select权限才能查询。

`v$instance`视图:如果没有授权给其它用户，则只有在数据库中拥有dba权限的用户可以查看这个动态视图。

# 附3
## ★ FIQ:
ERR:未开启系统共享
！停止Server服务，开启C盘和IPC$远程共享

```batch
net stop ....Server
net share C$=C:/
```

ERR:
！密码首位指定为数字可能会导致配置数据库失败

？未启动监听服务
！配置数据库(包括创建、更新、删除数据库)时，需要同时开启Oracle的实例和监听服务

```
SQL*Plus: Release 11.2.0.1.0 Production on 星期三 1月 27 11:28:46 2016
Copyright (c) 1982, 2010, Oracle. All rights reserved.
```

ERROR:

？ORA-12560: TNS: 协议适配器错误 
！未启动OracleService<SID>服务

？使用pl/sql客户端连接数据库时出现ORA-12154: TNS: 无法解析指定的连接标识符
ORA-12514: TNS: 监听程序当前无法识别连接描述符中请求的服务解决
！监听程序未配置完全，配置文件的sid_name名称不对应。 检查$Oracle_HOME\NETWORK\ADMIN\ora启动文件 没有正确配置网络监听服务 sid_name的值修改为创建系统数据库时指定的sid,通常是全局数据库名称 pl/sql不能安装在有特殊字符(比如说圆括号)的目录下

？设置了NLS_DATE_FORMAT系统环境变量后，Oracle不能正常工作
提示：SP2-0642: SQL*Plus 内部错误状态 2021, 上下文 1:1821:0 继续执行将不安全
SP2-1503: 无法初始化 Oracle 调用界面
SP2-0152: ORACLE 不能正常工作

！nls_date_format环境变量区分大小写，变量名称不能大写。

？查询数据时提示
！未打开unicode支持

？PL/SQL 插入数据记录改变时失去响应
！连接未固定，或者连接自动断开、丢失。或者因为其它用户正在修改表但尚未提交或者回滚事务，从而使表被Oracle自动添加了事务锁。可以尝试在PL/SQL中

勾选自动检查连接来解决这个问题。
？连接服务器失败，可能是Oracle Net管理错误
！

？插入时间类型数据时，ORA-01843 无效的月份  
！或许可以尝试使用时间转换函数to_date或者to_char转换之后再插入。

？为什么我指定了序列的起始值是1，而且也没有在dual中查询。然而在使用序列作为插入值时却总是以2开始
！或许是因为数据库版本问题。或许应该喝杯水，然后重启试试？或许可以尝试在创建序列时将start with 和 minvalue都同时设置为0

？使普通用户拥有查询数据字典的方法
！1.使用SYSTEM用户授予SELECT ANY TABLE权限给普通用户

```sql
GRANT SELECT ANY TABLE TO user;
-- 然后执行： 
ALTER SYSTEM SET O7_DICTIONARY_ACCESSIBILITY=TRUE [SCOPE=SPFILE|MEMORY];
-- 如果作用范围在memory则立即会生效
-- 如果是spfile则需要重启Oracle数据库服务才能生效或者
```

```batch
CONN / AS SYSDBA
SHUTDOWN IMMEDIATE;
STARTUP;
```

```sql
-- 2.使用SYSTEM用户授予SELECT ANY DICTIONARY权限给普通用户
 GRANT SELECT ANY DICTIONARY TO user;

-- 3.非生产环境使用SYSTEM用户直接授予dba角色给用户。
 GRANT DBA TO user;
```

> 参阅： 

+ [Oracle 表的创建 及相关参数_数据库技术_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2014-05/101947.htm)

+ [Oracle几种常见启动方式比较_数据库技术_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2011-11/46924.htm)

+ [造成ORA-01843 无效的月份 的一些原因 - 一江水 - 博客园](http://www.cnblogs.com/rootq/archive/2009/05/16/1458090.html)

+ [sql plus 与Oracle交互常用令与sql plus语句完整页_西西软件资讯](http://www.cr173.com/html/6302_all.html)

+ [PLSQL 经常自动断开失去连接的解决过程_数据库技术_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2015-09/123286.htm)


[^tcl]: TCL:事务控制语言:COMMIT(提交),SAVAPOINT(保存点),ROLLBACK(回滚);
