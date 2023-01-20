/* TCP client.c */
#include <sys/socket.h>
#include <netinet/in.h>
#include <arpa/inet.h>
#include <string.h>
#include <stdlib.h>
#include <stdio.h>
#include <unistd.h>

int main(int argc,char **argv)
{
  if(argc != 2){
    fprintf(stderr,"Usgae: %s <ip/host> \n",argv[0]);
    return -1;
  }
  int sfd;
  if((sfd = socket(AF_INET,SOCK_STREAM,0)) == -1){
    perror("crate socket descripter");
    return -1;
  }
  struct sockaddr_in client;
  bzero(&client,sizeof(client));
  client.sin_family = AF_INET;
  client.sin_port = htons(13);
  if(inet_pton(AF_INET,argv[1],&client.sin_addr) == -1){
    fprintf(stderr,"called inet_pton(%s) error\n",argv[1]);
    perror("called inet_pton error");
  }

  if(connect(sfd,(struct sockaddr *)&client,sizeof(client)) == -1){
    fprintf(stderr,"connect %s timeout\n",argv[1]);
    perror("connect error");
  }

  char buf[BUFSIZ] = {0};
  long n = 0;
  while((n = read(sfd,buf,BUFSIZ)) > 0){
    buf[n] = 0;
    if((fputs(buf,stdout)) == EOF){
    }
  }

  if(n < 0){
    perror("no messages");
  }

  close(sfd);
  exit(0);
}
