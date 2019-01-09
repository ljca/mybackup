#include <stdio.h>
#include <mysql/mysql.h>
#include <stdlib.h>

int main()
{
	MYSQL mysql;
	/* 初始化MySQL连接 */
	if(NULL == mysql_init(&mysql)){
		perror("init mysql");
		exit(-1);
	}
	//MYSQL *conn = NULL;
	/* 尝试连接MySQL */
	if(mysql_real_connect(&mysql,"localhost","root",NULL,"stu",0,NULL,0)){
		printf("mysql connect sucess!\n");
		//int res = 0;
		char *sql = "select s.id,s.name,r.score from stu_info s inner join result r on s.rid = r.id";
		if(!mysql_query(&mysql,sql)){
			MYSQL_RES *mysql_res = NULL;
			if(NULL == (mysql_res = mysql_store_result(&mysql))){
				perror("mysql_store_result function");
				return -1;
			}
		printf("sql select is total %d results....\n",mysql_num_rows(mysql_res));
		printf("sql select column is total count: %d\n",mysql_res->field_count);

		MYSQL_FIELD *field = NULL;
		while(field=mysql_fetch_field(mysql_res)){
			//printf("db:%s  table:%s\n",field->db,field->table);
			printf("%s\t",field->name);
		}
		printf("\n");
		MYSQL_ROW row;
		int i=0;
		while(row=mysql_fetch_row(mysql_res)){
			for(i=0;i<mysql_res->field_count;i++) printf("%s\t",row[i]);
			printf("\n");
		}

		mysql_free_result(mysql_res);
		mysql_close(&mysql);
		}else{
			perror("mysql_query");
			return -1;
		}
	}else{
		perror("connect MySQL error");
		exit(-1);
	}
	return 0;
}
