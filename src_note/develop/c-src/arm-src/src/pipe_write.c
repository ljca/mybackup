#include <stdio.h>
#include <string.h>
#include <unistd.h>
#include <fcntl.h>

int main()
{
	int fd = open("fifo0",O_RDWR);
	if(fd < 0){
		perror("");
		return -1;
	}
	char *str = "TEST TEXT";
	write(fd,str,strlen(str));
	return 0;
}
