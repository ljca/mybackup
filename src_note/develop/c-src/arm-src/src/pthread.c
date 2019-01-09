#include <stdio.h>
#include <pthread.h>
#include <stdlib.h>

pthread_t trda,trdb;

//pthread_mutex_t ptx;

/* thread A */
void *apth(void *p)
{
	printf("thread A is run.....\n");
	system("echo -en pthread.c;wc < pthread.c");
	printf("thread A create sucess.....\n");
}

/* thread B */
void *bpth(void *p)
{
	sleep(1);
	printf("thread B is run.....\n");
	system("echo -en passwd;wc < /etc/passwd");
	printf("thread B create sucess.....\n");
}

int main()
{
	system("ps aux|tail -n5");
	printf("main function is run.....\n");
	int ret = 0;
	if((ret = pthread_create(&trda,NULL,apth,NULL)) != 0){
		perror("thread A");
		exit(-1);
	}
	if((ret = pthread_create(&trdb,NULL,bpth,NULL)) != 0){
		perror("thread B");
		exit(-1);
	}
	//pthread_mutex_init(&ptx,NULL);
	int retl = 0;
	if((retl = pthread_join(trda,NULL)) != 0 
			|| (retl=pthread_join(trdb,NULL))!= 0){
		perror("pthread_join");
	}else{
		pthread_exit((void *)retl);
	}
	return 0;
}
