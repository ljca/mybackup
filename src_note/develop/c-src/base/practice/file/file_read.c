/*
* File Name: file.c
*/
#include <stdio.h>
void open_file(char *);

int main(int argc,char *argv[])
{
	switch(argc){
		case 1:
			break;
		case 2:
			open_file(*(++argv));
			break;
		case 3:
			break;
	}
	//printf("stdin: %d\n",stdin->_fileno);
	//printf("stdout: %d\n",stdout->_fileno);
	//printf("stderr: %d\n",stderr->_fileno);
	return 0;
}


void open_file(char *path)
{
	FILE *fp = NULL;
	fp = fopen(path,"r");
	char str[500] = "";
	if(NULL == fp){
		perror("read file tests error");
		//return; 
	}else{
		while(0 != feof(fp))
		{
			perror("");
		}
		//printf("feof = %d\n",feof(fp));
		fread(str,1,500,fp);
		perror("");
		printf("%s\n",str);
		fclose(fp);
	}
}
