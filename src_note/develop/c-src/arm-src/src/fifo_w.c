#include <stdio.h>
#include <fcntl.h>
#include <stdlib.h>
#include <sys/stat.h>
#include <unistd.h>

int main()
{
	if(0 != access("1bin",F_OK)) {
		perror("1bin");
		exit(-1);
	}else{
		int ff = open("fifo0",O_WRONLY);
		struct stat st;
		fstat(fd_r,&st);
		int size = st.st_size;
		int fd_w = open("1bin",O_RDONLY);
		char buf[20] = "";
		sprintf(buf,"%d",size);
		write(ff,buf,strlen(buf));
		char b[500] = "";
		while(size){
			memset(b,0,sizeof(b));
			int ret = read(fd_w,b,sizeof(b));
			write(ff,b,ret);
			size -= ret;
		}
		close(fd_w);
		close(ff);
	}
	return 0;
}
