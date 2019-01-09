/*
* File Name: mmap_write.c
* Create Date: 2016年12月05日 星期一 16时09分27秒
*/
#include <stdio.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <sys/mman.h>
#include <fcntl.h>
#include <string.h>

int main(int argc,char *argv[])
{
	if(1==argc) return;
	int fd = open(argv[1],O_CREAT|O_RDWR,0777);
	printf("%d",fd);
	if(fd>=0){
		struct stat st;
		fstat(fd,&st);
		char *p = mmap(NULL,20,PROT_READ|PROT_WRITE,MAP_SHARED,fd,0);
		if(NULL != p)
		{
			//perror("");
			strcpy(p,"this is test text2!this is test text3!");
			//sleep(10);
			munmap(p,20);
		}
		close(fd);
	}else{
		perror("");
		return -1;
	}

	return 0;
}
