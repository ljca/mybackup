/*
* File Name: read_test.c
*/
#include <stdio.h>
#include <string.h>
void write_file(char *);

int main(int argc,char *argv[])
{
	switch(argc)
	{
		case 1:
			break;
		case 2:
			write_file(argv[1]);
			break;
		case 3:
			break;
		case 4:
			break;
		default:
			break;
	}
	return 0;
}

void write_file(char *path)
{
	FILE *fp = NULL; 
	fp = fopen(path,"w");
	//char buf[50] = "";
	if(NULL != fp)
	{
		char *str="this is test string";
		fwrite(str,strlen(str),1,fp);
		fclose(fp);
	}else{
		perror("");
		return -1;
	}
}
