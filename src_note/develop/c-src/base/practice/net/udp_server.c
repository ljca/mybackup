#include <stdio.h>
#include <sys/socket.h>
#include <stdlib.h>
#include <netinet/in.h>
#include <string.h>

//#ifndef sockaddr
typedef struct sockaddr SOCKADDR;
//#endif

#ifndef UDP_PORT
#define UDP_PORT 5792
#endif

#ifndef BUFSIZE
#define BUFSIZE 1024
#endif


int main()
{
	struct sockaddr_in udp_server;
	struct sockaddr_in udp_client;
	int sock_fd = 0;
	if((sock_fd=socket(AF_INET,SOCK_DGRAM,0)) < 0){
		perror("open udp_sock error");
		return -1;
	}
	bzero(&udp_server,sizeof(udp_server));
	udp_server.sin_port=htons(UDP_PORT);
	udp_server.sin_family=AF_INET;
	udp_server.sin_addr.s_addr=INADDR_ANY;
	char buf[BUFSIZE] = "";
	if(0 > bind(sock_fd,(SOCKADDR*)(&udp_server),sizeof(udp_server))){
		perror("server bind error");
		exit(-1);
	}
	int len = sizeof(udp_client);
	while(1){
		//if(0>recvfrom(sock_fd,buf,BUFSIZE,0,(struct sockaddr *)(&udp_client),&len)){
		//	perror("recive message error");
		//	return -1;
		//}
		recvfrom(sock_fd,buf,BUFSIZE,0,(struct sockaddr *)(&udp_client),&len);
	printf("%s\n",buf);
	if(strncmp(buf,"stop",4) == 0){
		printf("disconnection!\n");
		break;
	}
	}
	return 0;
}
/* [X][X][X][X] */
