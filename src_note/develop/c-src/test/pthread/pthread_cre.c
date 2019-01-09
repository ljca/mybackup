/*
 * =====================================================================================
 *
 *       Filename:  pthread_cre.c
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017/06/14 星期三 22:07:37
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  YOUR NAME (), 
 *   Organization:  
 *
 * =====================================================================================
 */
#include <stdio.h>
#include <pthread.h>
#include <stdlib.h>

void *
pthread_fun(void)
{
  int i = 0;
  for(;i < 3;i++){
    printf("this is a thread.\n");
  }
  printf("a thread finish.\n");
}

int main()
{
  pthread_t tid;
  if(pthread_create(&tid,NULL,(void *)pthread_fun,NULL) != 0){
    perror("create posix thread error");
    pthread_exit(NULL);
  }
  pthread_join(tid,NULL);
  int i = 0;
  for(;i < 3;i++) printf("this is main thread.\n");
  system("ls -AFh --color=tty");
  printf("main thread finish.\n");
  return 0;
}

