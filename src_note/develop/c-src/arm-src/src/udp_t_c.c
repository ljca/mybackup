#include <stdio.h>
#include <stdlib.h>
#include <fcntl.h>
#include <string.h>
#include <netinet/in.h>
#include <sys/socket.h>
#include "my_udp.h"

int main(int argc,char **argv)
{
	if(3 != argc){
		fprintf(stdout,"Useage: %s <ip> <file>\n",argv[0]);
		return -1;
	}

	struct sockaddr_in addr;
	/* socket descripter */
	int sfd = 0;
	bzero(&addr,ADDR_SIZE);
	addr.sin_family=AF_INET;
	addr.sin_addr.s_addr = inet_addr(argv[1]);
	addr.sin_port = htons(UDP_PORT);
	if(-1 == (sfd = socket(AF_INET,SOCK_DGRAM,0))){
		perror("socket init error");
		exit(-1);
	}
	if(0 != access(argv[2],F_OK)){
		//fprintf(stderr,"file error\n");
		perror("access file error");
		exit(-1);
	}

	/* file descripter */
	int fd = 0;
	if(-1 == (fd = open(argv[2],O_RDONLY))){
		perror("open file error");
		exit(-1);
	}


	char buf[BUFSIZE] = "";
	int count = 0;
	while((count = read(fd,buf,104)) > 0){
		//printf("%s\n",buf);
		sendto(sfd,buf,count,0,(struct sockaddr *)&addr,ADDR_SIZE);
		memset(buf,0,BUFSIZE);
	}
	if(-1 == close(sfd)){
		perror("close socket error");
	}
	if(-1 == close(fd)){
		perror("close file error");
	}
	return 0;
}


#if 0
#include <sys/types.h>
#include <sys/stat.h>
	struct stat st;
if (-1 == fstat(fd,&st)){
	printf("GET FILE STAT ERROR,BUF WILL USED DEFAULT SIZE\n");
	perror("get file stat faild");
	//exit(-1);
}
int fize = (st.st_size = 0 ? 1024 : st.st_size);
#endif
