#include <stdio.h>
#include <unistd.h>

int main(int argc,char **argv)
{
	if(argc <= 2) { printf("useage: %s file_name file_name\n",argv[0]);return;} 
	int pid = fork();
	char *argvp[] = {NULL};
	if(0==pid){
		*(argvp) = ".";
		*(argvp+1)= "/";
		*(argvp+2)= NULL;
		execvp(argv[1],argvp);
	}else if(pid >0){
		wait(1);
		execvp(argv[2],argvp);
		wait(NULL);
	}
	return 0;
}
