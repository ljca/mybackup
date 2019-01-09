#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <sys/socket.h>

int main(int argc,char *argv[])
{
	if(argc != 2){
		fprintf(stderr,"Usage: %s <ip|host>",argv[0]);
		return -1;
	}
	struct sockaddr_in servaddr;
	int sfd/* socket descripter */,n = 0;
	char recvline[BUFSIZ + 1]; /* BUF */

	if((sfd = socket(AF_INET,SOCK_STREAM,0) < 0)){
		perror("socket init error.");
		return;
	}
	bzero(&servaddr,sizeof(servaddr));
	servaddr.family = AF_INET;
	servaddr.sin_port = htons(13);
	if(inet_pton(AF_INET,argv[1],&servaddr.sin_addr) <= 0){
		perror("");
		exit(-1);
	}
	if(connect(sfd,(struct sockaddr_in *)&servaddr,sizeof(servaddr)) < 0){
		perror("connect error.");
		return -1;
	}
	while((n = read(sfd,recvline,BUFSIZ)) > 0){
		recvline[n] = 0;
		if(fputs(recvline,stdout) == EOF){
		}
	}
	if(n < 0){
		perror("recev eof");
		return -1;
	}
	return 0;
}

