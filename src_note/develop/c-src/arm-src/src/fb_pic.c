#include <stdio.h>
#include <sys/mman.h>
#include <fcntl.h>
#include <unistd.h>

int main()
{
	int fd = open("/dev/fb0",O_RDWR);
	if(fd<0){
		perror("");
		return -1;
	}
	unsigned long *p = mmap(NULL,1280*800*4,PROT_READ | PROT_WRITE,MAP_SHARED,fd,0);
	if(NULL == p){
		perror("");
		return -1;
	}
	int fd1= open("1bin",O_RDWR);
	read(fd1,p,1280*800*4);
	//int i = 0,j=0;
	//for(i=0;i<=352;i++){
	//	for(j=0;j<=220;j++){
	//		p[i*1280+j]=0xff00;
	//	}
	//}
	munmap(p,1280*800*4);
	close(fd);
	close(fd1);
	return 0;
}
