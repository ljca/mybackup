#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>

int main(int argc,char *argv[])
{
	int pid = fork();
	char *arg[] = {"ls","-a","-F","--color=tty",NULL};
	if(0 == pid){
		//arg = {"ls","-a","-F","--color=tty",NULL};
		execv("/bin/ls",arg);
	}else if(pid > 0){
		wait(1);
		*arg = "ps";
		*(arg+1) = NULL;
		execv("/bin/ps",arg);
		//system("ls");
		wait(NULL);
	}
	return 0;
}
