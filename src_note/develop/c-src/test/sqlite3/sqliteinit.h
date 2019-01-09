/*
 * =====================================================================================
 *
 *       Filename:  sqlite_init.h
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017年06月23日 17时18分50秒
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  YOUR NAME (), 
 *   Organization:  
 *
 * =====================================================================================
 */
#include <sqlite3.h>

#ifndef __SQLITEINIT_H_
#define __SQLITEINIT_H_

extern char *err_msg;
extern sqlite3 *sqlite_db;

/* genary database name */
extern const char *db_name;

/* create table sqlite3 in sqltie3 test database. */
extern const char *cre_table;

extern const char *insert_sql;

extern const char *select_sql;

static int
callback(void *data,int rows,char **col_data,char **col_name);

void open_sqlite(const char *db);
void close_sqlite();
void sqlite_init();
void sqlite_select(const char *sql);

#endif

