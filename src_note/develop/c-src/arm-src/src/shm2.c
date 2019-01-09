#include <stdlib.h>
#include <stdio.h>
#include <sys/ipc.h>
#include <sys/shm.h>
#include <sys/types.h>

int main()
{
	int shmid ;
	if((shmid = shmget(IPC_PRIVATE,4096,0666)) < 0){
		perror("");
		return -1;
	}
	system("ipcs -m");
	printf("shmid is %d\n",shmid);
	return 0;
}
