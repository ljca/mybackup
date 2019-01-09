#include <stdio.h>
#include <stdlib.h>
#include <dirent.h>
#include <unistd.h>

int main(int argc,char **argv)
{
	FILE *fp;
	if(argc > 1)	fp = fopen(argv[1],"rb");
	else{
		printf("usage: %s file\n",argv[0]);
		return -1;
	}
	if(fp != NULL) {
		printf("open binary file ok!\n");fclose(fp);
	}else 
		printf("open binary file faild\n");
	int fd;
	if(-1 == (fd =open("/dev/tty1"))){
		perror("open tty1 faild");
		return -1;
	} 
	printf("open file is tty? %d\n",isatty(fd));
	printf("tty is %s\n",ttyname(fd));
	close(fd);
	return 0;
}
