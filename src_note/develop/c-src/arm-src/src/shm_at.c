#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <sys/shm.h>
#include <sys/ipc.h>
#ifndef SHMID
#define SHMID atoi(argv[1])
#endif

int main(int argc,char **argv)
{
//#if argc==2 
	if(argc!=2) return -1;
	//printf("shmid %d\n",SHMID);
		char *buf = shmat(SHMID,NULL,0);
		if(buf != (void *)-1){
			strcpy(buf,"Shared memory read/write test..........");
			system("ipcs -m|tail -n4");
			printf("%s\n",buf);
			if(-1 == shmdt(buf)) perror("");
		}else{
			perror("");
			exit(-1);
		}
	return 0;
}

//#endif
