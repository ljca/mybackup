#include <stdio.h>
#include <mysql/mysql.h>

MYSQL mysql;
int main()
{
	char *sql = "delete from stu_info where id = 9";
	if(NULL == mysql_init(&mysql)){
		perror("mysql_init error");
		return -1;
	}
	if(NULL == mysql_real_connect(&mysql,NULL,"root",NULL,"stu",0,NULL,0)){
		perror("mysql_connect error");
		return -1;
	}
	if(0 != mysql_query(&mysql,sql)){
		perror("delete error");
	}
	if(mysql_affected_rows(&mysql) != 1){
		perror("change table error");
	}
	close(&mysql);
	return 0;
}
