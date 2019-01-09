#include <stdio.h>
#include <unistd.h>
#include <fcntl.h>

int main()
{
	int pid = fork();
	if(pid==0){
		printf("child process is run...,pid is %d\n",getpid());
		execl("/bin/ls","ls","-a","-F","-l","--color=tty",NULL);
	}else if(pid>0){
		sleep(1);
		printf("father process is run...,pid is %d\n",getpid());
		execl("/bin/ps","ps",NULL);
		wait(NULL);
	}
	return 0;
}

