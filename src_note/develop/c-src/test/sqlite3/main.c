#include <stdio.h>
#include <stdlib.h>
#include <sqlite3.h>
#include <sys/errno.h>
#include <errno.h>
#include "sqliteinit.h"

int main()
{
  //if(argc != 2){
  //  fprintf(stderr,"Usage: %s <query_sql>\n",argv[0]);
  //  //exit(EXIT_FAILURE);
  //}
  //extern const char *db_name;
  //extern const char *select_sql;
  open_sqlite(db_name);
  //sqlite_init();
  sqlite_select(select_sql);
  close_sqlite();
  exit(EXIT_SUCCESS);
}

#if 0
#include <sqlite3.h>
/*  Open sqlite3 db */
SQLITE_API int sqlite3_open(
  const char *filename,   /* Database filename (UTF-8) */
  sqlite3 **ppDb          /* OUT: SQLite db handle */
);

SQLITE_API int sqlite3_open16(
  const void *filename,   /* Database filename (UTF-16) */
  sqlite3 **ppDb          /* OUT: SQLite db handle */
);

SQLITE_API int sqlite3_open_v2(
  const char *filename,   /* Database filename (UTF-8) */
  sqlite3 **ppDb,         /* OUT: SQLite db handle */
  int flags,              /* Flags */
  const char *zVfs        /* Name of VFS module to use */
);

SQLITE_API int sqlite3_exec(
  sqlite3 *,                                  /* An open database */
  const char *sql,                           /* SQL to be evaluated */
  int (*callback)(void *,int,char **,char **),  /* Callback function */
  void *,                                    /* 1st argument to callback */
  char **errmsg                              /* Error msg written here */
);

#endif

/*  vim:set expandtab shifttab=2 softtab=2 */
