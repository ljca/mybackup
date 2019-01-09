#  Oracle
Oracle
★ Oracle数据库安装ERROR:
ERR:未开启系统共享
！停止Server服务，开启C盘和IPC$远程共享
> net stop ....Server
> net share C$=C:/
ERR:
！密码首位指定为数字可能会导致配置数据库失败
？未启动监听服务
！配置数据库(包括创建、更新、删除数据库)时，需要同时开启Oracle的实例和监听服务
......
SQL*Plus: Release 11.2.0.1.0 Production on 星期三 1月 27 11:28:46 2016
Copyright (c) 1982, 2010, Oracle. All rights reserved.
ERROR:
？ORA-12560: TNS: 协议适配器错误 ！未启动OracleService<SID>服务
？使用pl/sql客户端连接数据库时出现ORA-12154: TNS: 无法解析指定的连接标识符
ORA-12514: TNS: 监听程序当前无法识别连接描述符中请求的服务解决
！监听程序未配置完全，配置文件的sid_name名称不对应。
检查$Oracle_HOME\NETWORK\ADMIN\ora启动文件
没有正确配置网络监听服务
sid_name的值修改为创建系统数据库时指定的sid,通常是全局数据库名称
pl/sql不能安装在有特殊字符(比如说圆括号)的目录下
？设置了NLS_DATE_FORMAT系统环境变量后，Oracle不能正常工作
提示：SP2-0642: SQL*Plus 内部错误状态 2021, 上下文 1:1821:0
继续执行将不安全
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
！

？为什么我指定了序列的起始值是1，但在用序列作为插入值时却总是以2开始
！
# Oracle
Oracle
★ Oracle数据库安装ERROR:  
ERR:未开启系统共享  
！停止Server服务，开启C盘和IPC$远程共享  
&gt; net stop ....Server  
&gt; net share C$=C:/
ERR:  
！密码首位指定为数字可能会导致配置数据库失败
？未启动监听服务  
！配置数据库(包括创建、更新、删除数据库)时，需要同时开启Oracle的实例和监听服务  
......  
SQL*Plus: Release 11.2.0.1.0 Production on 星期三 1月 27 11:28:46 2016  
Copyright (c) 1982, 2010, Oracle. All rights reserved.  
ERROR:  
？ORA-12560: TNS: 协议适配器错误 ！未启动OracleService&lt;SID&gt;服务
？使用pl/sql客户端连接数据库时出现ORA-12154: TNS: 无法解析指定的连接标识符  
ORA-12514: TNS: 监听程序当前无法识别连接描述符中请求的服务解决  
！监听程序未配置完全，配置文件的sid_name名称不对应。  
检查$Oracle_HOME\NETWORK\ADMIN\ora启动文件  
没有正确配置网络监听服务  
sid_name的值修改为创建系统数据库时指定的sid,通常是全局数据库名称  
pl/sql不能安装在有特殊字符(比如说圆括号)的目录下
？设置了NLS_DATE_FORMAT系统环境变量后，Oracle不能正常工作  
提示：SP2-0642: SQL*Plus 内部错误状态 2021, 上下文 1:1821:0  
继续执行将不安全  
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
！或许可以尝试使用时间转换函数to_date或者to_char转换之后再插入。
？为什么我指定了序列的起始值是1，而且也没有在dual中查询。然而在使用序列作为插入值时却总是以2开始
！或许是因为数据库版本问题。或许应该喝杯水，然后重启试试？或许可以尝试在创建序列时将start with 和 minvalue都同时设置为0
？使普通用户拥有查询数据字典的方法
！1.使用SYSTEM用户授予SELECT ANY TABLE权限给普通用户
SQL> GRANT SELECT ANY TABLE TO user;
然后执行：
SQL> ALTER SYSTEM SET O7_DICTIONARY_ACCESSIBILITY=TRUE [SCOPE=SPFILE|MEMORY];
如果作用范围在memory则立即会生效
如果是spfile则需要重启Oracle数据库服务才能生效或者
SQL> CONN / AS SYSDBA
SQL> SHUTDOWN IMMEDIATE;
SQL> STARTUP;
2.使用SYSTEM用户授予SELECT ANY DICTIONARY权限给普通用户
SQL> GRANT SELECT ANY DICTIONARY TO user;
3.非生产环境使用SYSTEM用户直接授予dba角色给用户。
SQL> GRANT DBA TO user;
vim:set ft=markdown:
