<link href="../../css/style.css" rel="stylesheet" type="text/css" />


# Ｃ语言操作MySQL数据库：从连接到MySQL数据库服务器开始
Ｃ语言连接 MySQL 以及显示错误日志的 API，下面是 mysql.h 里关于它们的声明：

```C
/*
* mysql_init 函数初始化 MYSQL 数据库服务器环境并返回一个 MYSQL 句柄，如果初始化失败返回 NULL.
* 有两种方式初始化 MYSQL 并获得一个 MYSQL 句柄：
* 1.声明在堆上的指针,初始化时传递 NULL 给 mysql_init 函数。
* 2.另外一种方式声明在堆上，然后传递一个 MYSQL 实例或者说是句柄给 mysql_init 函数。
* 但不管怎样，都会返回一个 MYSQL 句柄，如果 mysql_init 函数执行成功了的话。
* 至于那个 STDCALL 是个什么玩意儿，我也不知道……
*/ 
MYSQL *   STDCALL mysql_init(MYSQL *mysql);

/* 连接MySQL服务器 */
MYSQL *   STDCALL mysql_real_connect(
  MYSQL *mysql, /* 句柄 */
  const char *host, /* 主机名或者 ip,如果是本地测试可以直接是 localhost 或者 NULL */
  const char *user, /* 用户名 */
  const char *passwd, /* 用户名对应的密码，如果没有置为 NULL */
  const char *db, /* 数据库名,允许指定为 NULL */
  unsigned int port, /* 端口号，如果不是默认的 3306 才需要手动指定，否则应该为 0 */
  const char *unix_socket, /* 套接字文件，如果使用默认的置为 NULL */
  unsigned long clientflag /* 客户端标志，一般没有，设为 0 */
);

/* 根据传入的 MYSQL 句柄关闭数据库连接 */
void STDCALL mysql_close(MYSQL *sock);

/* 根据传入的 MYSQL 句柄返回的 MySQL 服务器错误码 */
unsigned int STDCALL mysql_errno(MYSQL *mysql);

/* 根据传入的 MYSQL 句柄,由服务端返回给客户端的具体错误消息 */
const char * STDCALL mysql_error(MYSQL *mysql);
```

一个简单的测试 MySQL 数据库连接的Ｃ实现

========= mysql_con.c ===========

```C
#include <stdio.h>
#include <mysql/mysql.h>

int main()
{
  MYSQL *mysql /* 声明在栈上也行：MYSQL mysql,但要使用 mysql_init(&mysql) 的方式初始化 */;
  if(!(mysql = mysql_init(NULL))){
    perror("init mysql error");
    return -1;
  }
  if(!mysql_real_connect(mysql,NULL,"mysql","mysql?",NULL,0,"/tmp/mysql.sock",0)){
    //perror("connenct mysql error");
    fprintf(stderr,"errno: %d,%s\n",mysql_errno(mysql),mysql_error(mysql));
    return -1;
  }
  printf("connect mysql sucecess!\n");
  mysql_close(mysql);
}
```

Makefile

```make
tmp-dir=/home/external/usr/develop/Java_Web/Web/Server/MySQL5.6
c_flags=-I$(tmp-dir)/include -L$(tmp-dir)/lib -lmysqlclient
default:
	cc -o bin/mysql_con $(c_flags) mysql_con.c
.PHONY:test
test:
	bin/mysql_con
```

直接运行 make 会生成可执行文件。然后可以直接执行 make test 来测试 MySQL 数据库连接(这可能需要先开启 MySQL 数据库服务)。
