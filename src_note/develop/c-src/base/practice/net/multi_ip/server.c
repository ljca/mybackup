#include <stdio.h>
#include <netinet/in.h>
#include <sys/socket.h>
#include <sys/types.h>
#include <stdlib.h>
#include <string.h>
#include "multi_ip.h"

int main()
{
	int sfd;
	if((sfd = socket(AF_INET,SOCK_DGRAM,0)) == -1){
		perror("sock init error");
		exit(-1);
	}
	struct sockaddr_in addr;
	memset(&addr,0,sizeof(addr));
	addr.sin_family = AF_INET;
	addr.sin_addr.s_addr = inet_addr("224.0.0.1");
	addr.sin_port = htons(PORT);
	while(1){
		if(0 > sendto(sfd,"test from broad",sizeof("test from broad"),0,(struct sockaddr *)&addr,sizeof(addr))){
			perror("send messages error");
			exit(-1);
		}
		sleep(2);
	}
	return 0;
}


/* memset() */
