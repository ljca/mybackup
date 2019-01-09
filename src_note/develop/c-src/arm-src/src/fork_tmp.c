#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>

int main ()
{
  //int pid = fork();
  //if (pid == 0){
  //    printf("child process is run.....\n");
  //    printf("child pid is %d\n", getpid());
  //    printf("parent's pid %d\n", getppid());
  //    printf("current pid is %d\n", pid);
  //}
  //else if (pid > 0){
  //    printf("child parent process is run.....\n");
  //    printf("parent process is waitting 2 secends....\n");
  //    wait(2);
  //    printf("parent ppid %d\n", getppid());
  //    printf("child parent pid %d\n", getpid());
  //    printf("pid is %d\n", pid);
  //}
  //else{
  //    perror("");
  //    return -1;
  //}
  //system("ls -al");
  //printf("pid is %d\n", pid);
	printf("getpid() is %d\n", getpid());
	printf("getppid() ppid:%d\n", getppid());
	return 0;
}
