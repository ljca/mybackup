#include <stdio.h>
#include <sqlite3.h>
#include <stdlib.h>

int main(int argc,char **argv)
{
	sqlite3 *db;
	if(sqlite3_open("test.db",&db)){
		fprintf(stdout,"Can't the database: %s.\n",sqlite3_errmsg(db));
		exit(-1);
	}else{
		fprintf(stdout,"Open database successfully!\n");
	}
	sqlite3_close(db);
	return 0;
}
