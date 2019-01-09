#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>

int main()
{
  pid_t cpid;
  if((cpid = fork()) == -1){
      perror("");
      return EXIT_FAILURE;
  }
  if(cpid == (pid_t)0){
    puts("child process executable....");
    execl("/bin/ls","ls","-lAF --color=always");
  }else{
  }
}

