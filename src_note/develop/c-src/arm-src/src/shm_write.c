#include <stdio.h>
#include <stdlib.h>
#include <sys/ipc.h>
#include <sys/shm.h>
#include <fcntl.h>

#ifndef BUFSIZE 
#define BUFSIZE 4096
#endif 

#ifndef SHMID
#define SHMID atoi(argv[1])
#endif

int main(int argc,char **argv)
{
	if(argc != 2) return -1;
	//char buf[BUFSIZE] = "";
	char *buf = NULL;
	if ((buf=shmat(SHMID,NULL,0))!= (void *)-1){
		buf = malloc(sizeof(char)*BUFSIZE*100);
		int i = '\0';
		for(i = '\0';i<BUFSIZE*100;i++)
			buf[i] = 0;//'\0';
		int fd = 0;
		if(-1 != (fd=open("test",O_CREAT|O_RDWR,0666))){
			write(fd,buf,BUFSIZE*100);
		}

	}
	//shmdt(buf);
	free(buf);
	return 0;
}
