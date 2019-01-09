#include <stdio.h>
#include <stdlib.h>
#include <mysql/mysql.h>

MYSQL *
mysql_con(char dbname[])
{
	MYSQL *mysql;
	//MYSQL *mysql /* 声明在栈上也行：MYSQL mysql,但要使用mysql_init(&mysql)的方式初始化 */;
	if(!(mysql = mysql_init(NULL))){
		perror("init mysql error");
		exit(-1);
	}
	if(!mysql_real_connect(mysql,NULL,"mysql","mysql?",dbname,0,"/tmp/mysql.sock",0)){
		//perror("connenct mysql error");
		fprintf(stderr,"errno: %d,%s\n",mysql_errno(mysql),mysql_error(mysql));
		exit(-1);
	}
	printf("connect mysql sucecess!\n");
	return mysql;
}

void mysql_clo(MYSQL *mysql)
{
	mysql_close(mysql);
}

