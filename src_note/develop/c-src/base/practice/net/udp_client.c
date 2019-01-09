#include <stdio.h>
#include <sys/socket.h>
#include <stdlib.h>
#include <string.h>
#include <netinet/in.h>

#ifndef UDP_PORT
#define UDP_PORT 5792
#endif

int main(int argc,char **argv)
{
	if(2 != argc){
		printf("Usege: ./%s \"IP|HOSTNAME\" \"messages\" \n",argv[0]);
		return 1;
	}
	struct in_addr adr;
	struct sockaddr_in udp_client;
	bzero(&udp_client,sizeof(udp_client));
	udp_client.sin_addr.s_addr = inet_addr(argv[1]);
	//udp_client.sin_addr.s_addr = inet_aton(argv[1],&adr);
	udp_client.sin_family=AF_INET;
	udp_client.sin_port=htons(UDP_PORT);
	int sock_id = 0;
	if((sock_id = socket(AF_INET,SOCK_DGRAM,0)) < 0){
		perror("client socket error");
		//printf("%s",stderr);
		exit(-1);
	}
	char mes[80] = ""; 
	int i = 0;
	for(i = 0;i<20;i++){
		sprintf(mes,"connection id %d",i);
		sendto(sock_id,(void*)mes,strlen(mes),0,(struct sockaddr *)&udp_client,sizeof(udp_client));
	}
	sprintf(mes,"stop\n");
	sendto(sock_id,(void*)mes,sizeof(mes),0,(struct sockaddr *)(&udp_client),sizeof(udp_client));
	close(sock_id);
	printf("send message complite!\n");
	return 0;
}
/* [X][X][X][X] */
