<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# MySQL在Arch Linux上的安装与配置
[TOC]

>虽然 MySQL 已经被 Oracle 收购，但一款向上兼容 MySQL，叫做 MariaDB 的数据库已经开发并稳定下来。MariaDB 是可以直接从系统源中安装的，不过，MySQL 也还没有彻底闭源。

 如果没有从 MySQL 的网站或者系统源中找到适合于自己系统已经编译好的二进制包(二进制包是针对于某一系统且已经编译好的可以直接安装到系统的软件包)，那也许需要 从源码编译安装 MySQL 到系统中了。

## 从源码编译安装 MySQL
1.1 从 MySQL 网站 获取 MySQL 源码
1.2 配置编译参数并尝试编译 MySQL，如果版本不小于 5.6 将使用 cmake 配置。关于 cmake 选项可以从 cmake_option list 取得。

```Bash
tmp=$HOME/.local/mysql\
cmake . -DCMAKE_INSTALL_PREFIX=$tmp -DMYSQL_DATADIR=$tmp/data -DINSTALL_BINDIR=$HOME/bin\
-DDEFAULT_CHARSET=utf8 -DEXTER_CHARSETS=all\
-DDEFAULT_COLLATION=utf8_general_ci\
-DWITH_INNOBSE_STORAGE_ENGINE=1 -DWITH_PARTITION_STORAGE_ENGINE=1\
-DWITH_MYISAM_STORAGE_ENGINE=1 -DWITH_MEMORYY_STORAGE_ENGINE=1\
-DWITH_ARCHIVE_STORAGE_ENGINE=1
make && make install
```

## 配置 MySQL
 2.1 如果 MySQL 是编译安装到了 Linux 分区？创建用户和组(这一组指令都要用根用户权限执行)

```Bash
groupadd mysql
useradd -r -g mysql -s /sbin/nologin -M mysql
chown -R mysql:mysql $basedir
```

### 初始化数据库和用户授权表

cd 到 MySQL 的安装目录($basedir):
```Bash
[ ! -d $HOME/.local/mysql/data ] && mkdir -pv $HOME/.local/mysql/data
scripts/mysql_install_db --user=mysql --basedir=$HOME/.local/mysql
--datadir=$HOME/.local/mysql/data --defaults-file=~/.my.cnf
sudo chown -R root:root $HOME/.local/mysql
sudo chown -R mysql $HOME/.local/mysql/data
```

### 设置 MySQL(可选)
更改 MySQL 密码，删除匿名用户，删除测试数据库，重载授权表
```Bash
bin/mysql_secure_installation
```

2.4 手动更改 MySQL root 账户的密码(可选)
有三种方式可以更改密码：
使用mysqladmin 指令

```Bash
mysqladmin -uroot -p password ""
```

mysql set 语句
```mysql
mysql> set password for user@host = password('');
```

mysql update 语句
```mysql
mysql> use mysql
mysql> update user set Password=password("") where User='root';
```

2.5 使用 MySQL 配置文件中配置 MySQL
如果系统是 Linux？/etc/my.cnf /etc/mysql/my.cnf 或者 ~/.my.cnf
======== ~/.my.cnf Or /etc/my.cnf ========

```Bash
# For advice on how to change settings please see
# http://dev.mysql.com/doc/refman/5.6/en/server-configuration-defaults.html
[client]
port=3306
#prompt="\u&\d> "
[mysql]
default-character-set=utf8

# SERVER SECTION
[mysqld]
port = 3306
# basedir = 
socket = /tmp/mysql.sock
# datadir =  
character-set-server=utf8
default-storage-engine=INNODB
#Enable MySQL generic Logs
#log="I:/Temp/log/mysql/generic/select"
sql_mode=NO_ENGINE_SUBSTITUTION,STRICT_TRANS_TABLES 
# Enable binary logs
# Logs_file location
log-bin="/tmp/mysql-log"

#logs_file has been delete days
expire_logs_day = 30
#Logs_file max_Size
max_binlog_size = 1MB

# Err_log_file location
log_error="/tmp/mysql_err"
max_connections=100

query_cache_size=50M
performance_schema_max_table_instances=200
table_definition_cache=200
table_open_cache=100

[mysqld_safe]
table_cache=256
tmp_table_size=34M
thread_cache_size=8

#  MyISAM Specific options
myisam_max_sort_file_size=50M #50G
myisam_sort_buffer_size=67M
key_buffer_size=49M
read_buffer_size=64K
read_rnd_buffer_size=256K
sort_buffer_size=256K

# INNODB Specific options  
innodb_additional_mem_pool_size=2M
innodb_flush_log_at_trx_commit=1
nnodb_log_buffer_size=1M
innodb_buffer_pool_size=80M
innodb_log_file_size=19M
innodb_thread_concurrency=10
```

如果是 windows？
======== $basedir/my.ini =========
测试 MySQL 服务

如果配置已经初步完成，那么不需要在运行 mysql 服务时再次给出命令行参数。

```Bash
mysqld --console & 
mysql -uroot -p # 如果没有给 MySQL root
用户设定密码，那么此处在询问密码时直接回车。
```

```mysql
mysql> \s /* 查询 mysql 服务器状态 */
mysql> show databases;
```

假如以上命令可以成功执行，那么 MySQL 将可以正常运行。

以下是一些常规性问题，无论是 windows 还是 Linux，都可以

- [x] 使用 ```mysqld --console``` 在控制台启动 mysql 服务查看启动消息或者检查 mysql 数据目录
 
如果 mysql 启动存在错误，则 mysql 服务器会创建一个以主机名打头的 err 文件，在这个文件中详细的列出了启动过程，如果有错误，则只需要检查以 err 开始的行即可很快发现错误(可以通过更改配置文件将这个错误日志文件保存到其它位置，方法是在 mysql 配置文件 my.ini 或者 ~/my.cnf 中的[mysqld]段下面增加节点 log-error

如果忘记了 MySQL root 账户密码？

如果 mysql 服务已经在运行，需要先停止 mysql 服务
```Bash
sudo killall mysqld
```

以 ```--skip-grant-tables```(跳过授权表)选项运行 MySQL 服务 mysqld_safe

如果是 windows？在一个控制台窗口中运行带这个选项的 ```mysqld_safe```，然后重新打开一个控制台窗口

如果是 Linux？保持运行在后台
```Bash
mysqld_safe --skip-grant-tables &
```

使用无密码的方式登录 mysql
```Bash
mysql -uroot -p #提示键入密码时省略密码直接回车
```

然后在 MySQL 客户端执行 update 语句直接更新 mysql.user 表或者执行 set 语句
```mysql
mysql> UPDATE mysql.user SET
Password=PASSWORD('newpassword') WHERE User='root';
```

如果你希望能立即生效，重新载入授权表
```mysql
mysql> flush privisters; # 也可以重启服务后重新登录 mysql。
```

另外一个方法是直接重新安装 MySQL

如果没有将 mysql 安装为服务，则应该使用命令(Ctrl C 当然也可以)```mysqladmin -uroot shutdown -p ``` 来停止关闭服务器

当 mysql 配置文件有语法错误时可能导致 mysql 服务无法开启
指定 basedir 与 datadir 目录时，不能使用反斜杠'\'来作为路径分隔符，而是使用正斜杠'/'来作为目录分隔符

- [x] 启动服务遇到 1067 错误

！配置文件中安装目录和数据目录无法读取或者存在错误，未更新数据目录或者安装目录
！数据目录下的 ib_logifle0 和 ib_logfile1日志文件存在错误
将这两个数据文件备份后删除

- [x] Access demid
！使用 root 用户登录，依然被拒绝登录：用户名或者密码错误，或者未指定密码
检查用户名或者密码

