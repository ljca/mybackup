#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <string.h>

int main()
{
  int fd[2];
  if(pipe(fd) == -1){
    perror("create pipe error");
    return EXIT_FAILURE;
  }
  char rbuf[BUFSIZ + 1] = {0};
  char data[] = "linux pipe data read success.";

  if(write(fd[1],data,strlen(data)) == -1){
    perror("write data to pipe error");
  }

  if(read(fd[0],rbuf,sizeof(rbuf)) == -1){
    perror("read data from pipe error");
  }
  puts(rbuf);
  return EXIT_SUCCESS;
}

