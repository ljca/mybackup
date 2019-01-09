#include <stdio.h>
#include <fcntl.h>
#include <stdlib.h>
#include <sys/stat.h>
#include <unistd.h>

int main()
{
	if(0 != access("fifo0",F_OK)) {
		//unlink("fifo0");
		mkfifo("fifo0",0666);
	}
	int ff = open("fifo0",O_RDONLY);
	int fd_r = open("2bin",O_CREAT | O_RDWR,0666);
	char buf[20] = "";
	read(ff,buf,sizeof(buf));
	int size = atoi(buf);
	printf("file size: %d\n",size);

	char b[500] = "";
	while(size){
		memset(b,0,sizeof(b));
		int ret = read(ff,b,sizeof(b));
		write(fd_w,buf,size);
		size -= ret;
	}
	close(fd_r);
	close(ff);
	return 0;
}
