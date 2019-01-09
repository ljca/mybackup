#include <stdio.h>
#include <stdlib.h>
#include <fcntl.h>
#include <string.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include "my_udp.h"


int main(int argc,char **argv)
{
	if(2 != argc){
		fprintf(stderr,"%s <file>\n",argv[0]);
		exit(-1);
	}
	/* init file */
	int fd = 0;
	if(-1 == (fd = open(argv[1],O_WRONLY|O_CREAT))){
		perror("open file error");
		exit(-1);
	}

	/* init socket */
	struct sockaddr_in addr;
	int sfd = 0;
	bzero(&addr,ADDR_SIZE);
	addr.sin_family=AF_INET;
	addr.sin_addr.s_addr = htonl(IADDR_ANY);
	addr.sin_port = htons(UDP_PORT);
	if(-1 == (sfd = socket(AF_INET,SOCK_DGRAM,0))){
		perror("socket init error");
		exit(-1);
	}
	if(-1 == bind(sfd,(struct sockaddr *)&addr,ADDR_SIZE)){
		perror("udp bind error");
		exit(-1);
	}
	//while(1){
		//recvfrom();
	//}
	char buf[BUFSIZE] = "";
	while(-1 != recvfrom(sfd,buf,BUFSIZE,0,(struct sockaddr *)&addr,&ADDR_SIZE)){
		printf("%s\n",buf);
		write(fd,(void *)buf,104);
		memset(buf,0,BUFSIZE);
	}
	
	if(-1 == close(fd)){
		perror("close file error");
	}
	if(-1 == close(sfd)){
		perror("close sock error");
		//exit(-1);
	}
	return 0;
}
