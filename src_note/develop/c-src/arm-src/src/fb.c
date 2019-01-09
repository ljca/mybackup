/*
* File Name: fb.c
* Create Date: 2016年12月06日 星期二 10时04分43秒
*/
#include <stdio.h>
#include <sys/stat.h>
#include <sys/types.h>
#include <fcntl.h>
#include <sys/mman.h>

int main(){
	int fb = open("/dev/fb0",O_RDWR);
	if(fb < 0){
		perror("");
		return -1;
	}
	unsigned long *p = mmap(NULL,1280*800*4,PROT_READ|PROT_WRITE,MAP_SHARED,fb,0);
	//if(p == (void *)-1){
	if(NULL == p){
		perror("");
		return -1;
	}
	int i=0;
	for(i=0;i <= 1280*800;i++){
		p[i]=0xff00;
	}
	munmap(p,1280*800*4);
	close(fb);
	return 0;
}
