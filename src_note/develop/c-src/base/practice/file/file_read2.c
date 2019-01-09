/*
* File Name: file_read2.c
* Create Date: 2016年12月01日 星期四 17时07分29秒
*/
#include <stdio.h>
#include <stdlib.h>
//#include <string.h>
void open_file(char *);

struct Tmp{
	char *name;
	int count;
	struct Tmp *next;
};

int main(int argc,char *argv[])
{
	if(1 == argc) return -1;
	open_file(argv[1]);
	return 0;
}

void open_file(char *path)
{
	FILE *fp = NULL;
	fp = fopen(path,"r+");
	if(NULL != fp)
	{
		char *p = NULL;
		int n = 0;
		//while(0 != feof(fp))
		//{
		getline(&p,&n,fp);
		//perror("");
		printf("%s",p);
		//}
		//fseek
		//rewind(fp);
		getline(&p,&n,fp);
		printf("%s",p);

		//rewind(fp);
		getline(&p,&n,fp);
		printf("%s",p);

		//rewind(fp);
		getline(&p,&n,fp);
		printf("%s",p);

		fclose(fp);
		free(p);
	}else{
		perror("");
	}
}
