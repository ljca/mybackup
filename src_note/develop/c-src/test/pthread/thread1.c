#include <stdio.h>
#include <pthread.h>
#include <string.h>
#include <stdlib.h>
#include <unistd.h>

char msg[] = "hello posix thread.";

void *
thread_fun(void *arg)
{
	sleep(1);
	printf("posix thread funciton is running,Argment was \"%s\"\n",(char *)arg);
	printf("pid = %lu\n",(unsigned long)getpid());
	printf("pthead_id = %lu\n",(unsigned long)pthread_self());
	//printf("pthread id is %ld\n",pthread_equal(,pthread_self()));
	//sleep(3);
	strcpy(msg,"Bye!");
	pthread_exit("Thank you for CPU time");
}

int main()
{
	pthread_t tid;
	void *thread_res;
	int res;
	if((res = pthread_create(&tid,NULL,(void *)thread_fun,(void *)msg)) != 0){
		perror("create thread failed.");
		exit(EXIT_FAILURE);
	}
	printf("Wating for thread function to finish...\n");
	if((res = pthread_join(tid,&thread_res)) != 0){
		perror("thread join failed.");
		exit(EXIT_SUCCESS);
	}
	printf("thread joined,returned \"%s\"\n",(char *)thread_res);
	printf("msg is now \"%s\"\n",msg);
  //pthread_join(tid,NULL);
	exit(EXIT_SUCCESS);
}
