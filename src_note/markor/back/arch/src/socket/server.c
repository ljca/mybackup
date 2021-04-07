/* TCP server.c */
#include <stdio.h>
#include <netinet/in.h>
#include <string.h>
#include <stdlib.h>
#include <sys/socket.h>
#include <arpa/inet.h>
#include <unistd.h>
#include <time.h>

int main()
{
  int connsfd, sfd;
  if((sfd = socket(AF_INET,SOCK_STREAM,0)) == -1){
    perror("create socket descripter error");
    exit(-1);
  }

  struct sockaddr_in server,client;
  bzero(&server,sizeof(server));
  server.sin_family = AF_INET;
  server.sin_port = htons(13);
  server.sin_addr.s_addr = htonl(INADDR_ANY);

  if(bind(sfd,(struct sockaddr *)&server,sizeof(server)) == -1){
    perror("bind socket error");
  }

  if(listen(sfd,5) == -1){
    perror("listen socket error");
  }
  char buf[BUFSIZ] = {0};
  socklen_t len;
  time_t ticks;

  for(;;){
    //connsfd = accept(sfd,(struct sockaddr *)NULL,NULL);
    len = sizeof(client);
    connsfd = accept(sfd,(struct sockaddr *)&client,&len);
   printf("connect from %s，port %d\n",inet_ntop(AF_INET,&client.sin_addr,buf,sizeof(buf)),ntohs(client.sin_port));
    ticks = time(NULL);
    sprintf(buf,"%.24s\r\n",ctime(&ticks));
    write(connsfd,buf,strlen(buf));
    close(connsfd);
  }
}

