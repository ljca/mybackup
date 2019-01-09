#include <stdio.h>
#include <mysql/mysql.h>

MYSQL mysql;
int main()
{
	char *sql = "insert into stu_info(rid,sex,name) values(8,'M','怯弱')";
	if(NULL == mysql_init(&mysql)){
		perror("mysql_init error");
		return -1;
	}
	if(NULL == mysql_real_connect(&mysql,NULL,"root",NULL,"stu",0,NULL,0)){
		perror("mysql_connect error");
		return -1;
	}
	if(!mysql_query(&mysql,sql)){
		perror("insert error");
	}
	if(mysql_affected_rows(&mysql) <= 0){
		perror("change table error");
	}
	close(&mysql);
	return 0;
}
