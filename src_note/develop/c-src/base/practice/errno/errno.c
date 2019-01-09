/*
* File Name: errno.c
* Create Date: 2016年12月31日 星期六 12时30分06秒
*/
#include <stdio.h>
#include <fcntl.h>
#include <errno.h>
#include <string.h>

int main(int argc,char *argv[])
{
	int fd;
	if((fd = open("type.h",O_RDWR))==-1){
		perror("open file type.h error");
		printf("error= %s\n",strerror(errno));
	}
	return 0;
}
