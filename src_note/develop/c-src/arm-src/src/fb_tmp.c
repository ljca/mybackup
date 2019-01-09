/*
* File Name: fb2.c
* Create Date: 2016年12月06日 星期二 10时04分43秒
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
	//printf("\033[2J");
	unsigned long *p = mmap(NULL,1280*800*4,PROT_READ|PROT_WRITE,MAP_SHARED,fb,0);
	//if(p == (void *)-1){
	if(NULL == p){
		perror("");
		return -1;
	}
	int i=0,j=0;
	for(j=0;j<=800;j++){
		for(i=0;i <= 1280/2;i++){
			p[j*1280+i]=0xff00;
		}
		for(i=1280/2;i <= 1280;i++){
			p[j*1280+i]=0xff0000;
		}
	}
	//for(j=0;j<=800/2;j++){
	//	for(i=0;i<=1280;i++){
	//		p[j*1280+i]=0xfff;
	//	}
	//}

	//for(j=800/2;j<=800;j++){
	//	for(i=0;i<=1280;i++){
	//		p[j*1280+i]=0xff00ff;
	//	}
	//}
	munmap(p,1280*800*4);
	close(fb);
	return 0;
}
