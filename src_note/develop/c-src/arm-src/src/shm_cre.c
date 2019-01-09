#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <sys/shm.h>
#include <sys/ipc.h>

int main()
{
	int shmid = 0;
	if((shmid = shmget(IPC_PRIVATE,4096,0666)) != -1){
		char *buf = shmat(shmid,NULL,0);
		if(buf != (void *)-1){
			//strcpy(buf,"Shared memory read/write test..........");
			//system("ipcs -m");
			//printf("%s\n",buf);
			printf("shmid is %d\n",shmid);
			//return shmid;
			//if(-1 == shmdt(buf)) perror("");
		}
	}
	return 0;
}
