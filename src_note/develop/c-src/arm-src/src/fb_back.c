/*
* File Name: tmp.c
* Create Date: 2016年12月06日 星期二 11时35分47秒
*/
#include <stdio.h>
#include <sys/stat.h>
#include <sys/types.h>
#include <fcntl.h>
#include <sys/mman.h>

int main(int argc,char *argv[]){
	int fb = open("/dev/fb0",O_RDWR);
	if(fb < 0){
		perror("");
		return -1;
	}
	size_t width=1280/3, hight=800/3;
	//size_t area=1280*800;
	size_t area=hight*width;
	//printf("\033[2J");
	unsigned long *p = mmap(NULL,area,PROT_READ|PROT_WRITE,MAP_SHARED,fb,0);
	//if(p == (void *)-1){
	if(NULL == p){
		perror("");
		return -1;
	}
	int i=0;
	for(i=0;i <= 1280*800/9;i++){
		//perror("");
		p[i]=0xff00;
	}
	munmap(p,area);
	close(fb);
	return 0;
}
