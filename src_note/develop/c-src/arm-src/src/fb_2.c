#include <stdio.h>
#include <sys/mman.h>
#include <fcntl.h>
void draw(unsigned long *p,int x1,int y1,int x2,int y2,int color);

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
	//int i = 0,j = 0;
	//for(i=0;i<800/3;i++){
	//	for(j=0;j<=1280/3;j++){
	//		p[i*1280+j]=0xffffff;
	//	}
	//}

	//for(i=0;i<800/3;i++){
	//	for(j=1280/3;j<=1280-1280/3;j++){
	//		p[i*1280+j]=0xff;
	//	}
	//}

	//for(i=0;i<800/3;i++){
	//	for(j=1280-1280/3;j<=1280;j++){
	//		p[i*1280+j]=0xff0000;
	//	}
	//}

	//draw(p,0,0,100,100,0xff00);
	//draw(p,100,0,200,100,0xff0000);
	//draw(p,200,0,300,100,0x0000ff);
	//draw(p,300,0,400,100,0xff00);
	//draw(p,400,0,500,100,0x0000ff);
	//draw(p,500,0,600,100,0xffffff);
	//draw(p,600,0,700,100,0xff0000);
	//draw(p,700,0,800,100,0xff00);
	int x1=1280/3;
	int x2=1280-1280/3;
	int y1=800/3;
	int y2=800-800/3;

	draw(p,0,0,x1,y1,0xff00);
	draw(p,x1,0,x2,y1,0xffffff);
	draw(p,x2,0,1280,y1,0xff0000);

	draw(p,0,y1,426,y2,0xffff00);
	draw(p,x1,y1,x2,y2,0xff00ff);
	draw(p,x2,y1,1280,y2,0xffaa00);

	draw(p,0,y2,x1,800,0x00ffaa);
	draw(p,x1,y2,x2,800,0xaabb00);
	draw(p,x2,y2,1280,800,0xffaabb);

	munmap(p,1280*800*4);
	close(fd);
	return 0;
}

void draw(unsigned long *p,int x1,int y1,int x2,int y2,int color)
{
	int y=0,x=0;
	for(y=y1;y<y2;y++){
		for(x=x1;x<x2;x++){
			p[y*1280+x]=color;
		}
	}
}
