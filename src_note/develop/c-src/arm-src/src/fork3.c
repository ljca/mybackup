#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>

int main()
{
	printf("vfock function test...\n");
	int count = 0;
	int pid = vfork();
	if(0 == pid){
		count++;
		printf("this pid %d\n",pid);
		printf("pid %d\n",getpid());
		printf("ppid %d\n",getppid());
		printf("count %d\n",count);
		exit(0);
	}else if(pid < 0){
		perror("");
		exit(-1);
	}else if(pid > 0){
		count++;
		printf("this pid %d\n",pid);
		printf("prarent pid %d\n",getpid());
		printf("prarent ppid %d\n",getppid());
		printf("prarent count %d\n",count);
	}
	return 0;
}
