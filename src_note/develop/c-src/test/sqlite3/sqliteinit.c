/*
 * =====================================================================================
 *
 *       Filename:  sqliteinit.c
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017年06月23日 17时24分42秒
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  YOUR NAME (), 
 *   Organization:  
 *
 * =====================================================================================
 */
#include "sqliteinit.h"
#include <stdio.h>
#include <stdlib.h>

sqlite3 *sqlite_db;

/* genary database name */
const char *db_name = "test.db";

/* create table sqlite3 in sqltie3 test database. */
const char * cre_table = "create table sqlite3(\
                          id INTEGER PRRIMARY KEY,\
                          name TEXT NOT NULL)\
                          ";

const char *insert_sql = 
  "insert into sqlite3(id,name) values(1,'sqlite');"
  "insert into sqlite3(id,name) values(2,'sqlite2');"
  "insert into sqlite3(id,name) values(3,'sqlite3');"
  "insert into sqlite3(id,name) values(4,'DB2');"
  "insert into sqlite3(id,name) values(5,'SQL Server');"
  "insert into sqlite3(id,name) values(6,'Oracle');"
  "insert into sqlite3(id,name) values(7,'PostgreSQL');"
  "insert into sqlite3(id,name) values(8,'SyBase');";

const char *select_sql = "select * from sqlite3";

char *err_msg = {0};

void open_sqlite(const char *db)
{
  if(sqlite3_open_v2(db,&sqlite_db,SQLITE_OPEN_CREATE|SQLITE_OPEN_READWRITE,NULL) != 0){ //if(sqlite3_open(db_name,&sqlite_db) != 0)
    fprintf(stderr,"errno :%d，%s\n",sqlite3_errcode(sqlite_db),sqlite3_errmsg(sqlite_db));
    fprintf(stdout,"errstr: %s\n",sqlite3_errstr(sqlite3_errcode(sqlite_db)));
    exit(SQLITE_ERROR);
  }
  puts("open sqlite3 db success");
}

void close_sqlite()
{
  if(sqlite3_close(sqlite_db) != 0) 
    fprintf(stderr,"execute sql error，%d %s\n",sqlite3_errcode(sqlite_db),sqlite3_errmsg(sqlite_db));
  sqlite_db = NULL;
}

void sqlite_init()
{
  int res;
  open_sqlite(db_name);
  if((res = sqlite3_exec(sqlite_db,cre_table,NULL,NULL,&err_msg)) != SQLITE_OK){
    fprintf(stderr,"execute sql error，%d %s\n",sqlite3_errcode(sqlite_db),sqlite3_errmsg(sqlite_db));
  }
  puts("create table success.");

  if((res = sqlite3_exec(sqlite_db,insert_sql,callback,NULL,&err_msg)) != SQLITE_OK){
    fprintf(stderr,"%s",err_msg);
    sqlite3_free(err_msg);
    fprintf(stderr,"execute sql error，%d %s\n",sqlite3_errcode(sqlite_db),sqlite3_errmsg(sqlite_db));
  }
  close_sqlite();
}

void sqlite_select(const char *sql)
{
  int res;
  if((res = sqlite3_exec(sqlite_db,sql,callback,NULL,&err_msg)) != SQLITE_OK){
    fprintf(stderr,"execute sql error，%d %s\n",sqlite3_errcode(sqlite_db),sqlite3_errmsg(sqlite_db));
  }
}

static int 
callback(void *data,int rows,char **col_data,char **col_name)
{
  //fprintf(stdout,"%s\n",(const char *)data);
  int i = 0;
  for(;i < rows;i++){
    fprintf(stderr,"%s = %s,",col_name[i],col_data[i]);
  }
  puts("");
  return 0;
}

