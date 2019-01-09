#include <stdio.h>
#include <netinet/in.h>
#include <sys/socket.h>
#include <sys/types.h>
#include <stdlib.h>
#include "multi_ip.h"
#include <string.h>

int main()
{
	struct ip_mreq cmd;
	struct hostent *server_host_name = NULL;
	char *host_name = "224.0.0.1";
	if((server_host_name = gethostbyname(host_name)) == 0){
		perror("get host name error");
		exit(-1);
	}
	struct sockaddr_in addr;
	bzero(&addr,sizeof(addr));
	addr.sin_family=AF_INET;
	addr.sin_addr.s_addr = htonl(INADDR_ANY);
	addr.sin_port = htons(PORT);
	int sfd;
	if((sfd = socket(PF_INET,SOCK_DGRAM,0)) == -1){
		perror("init sock error");
		exit(-1);
	}
	int loop = 1;
	if(-1 == setsockopt(sfd,SOL_SOCKET,SO_REUSEADDR,&loop,sizeof(loop))){
		perror("set sock opt error");
	}
	if(-1 == bind(sfd,(struct sockaddr *)&addr,sizeof(addr))){
		perror("bind error");
	}
	loop = 1;
	if(-1 == setsockopt(sfd,IPPROTO_IP,IP_MULTICAST_LOOP,&loop,sizeof(loop))){
		perror("set sock opt error");
	}
	cmd.imr_multiaddr.s_addr = inet_addr("224.0.0.1");
	cmd.imr_interface.s_addr = htonl(INADDR_ANY);
	if(cmd.imr_multiaddr.s_addr == -1){
		perror("multiaddr 224.0.0.1 error");
		exit(-1);
	}
	if(-1 == setsockopt(sfd,IPPROTO_IP,IP_ADD_MEMBERSHIP,&cmd,sizeof(cmd))){
		perror("set sock opt error");
	}
	int i = 0;
	char buf[BUFSIZE] = "";
	int addr_len;
	//printf("................");
	for(i=1;i<=10;i++){
		addr_len = sizeof(addr);
		if(recvfrom(sfd,buf,sizeof(buf),0,(struct sockaddr *)&addr,&addr_len) == -1){
			perror("recv data error");
		}
		printf("response #%d, messages: %s\n",i,buf);
		sleep(2);
	}
	if(-1 == setsockopt(sfd,IPPROTO_IP,IP_DROP_MEMBERSHIP,&cmd,sizeof(cmd))){
		perror("set sock opt error");
	}
	if(-1 == close(sfd)){
		perror("close sock error");
	}
	return 0;
}
