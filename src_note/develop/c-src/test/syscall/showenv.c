#include <stdio.h>
#include <stdlib.h>

int main()
{
	extern char **environ;
	char **env = environ;
	while(*env){
		printf("%s\n",*env);
		env++;
	}
	printf("for\n");
	for(env = NULL,env = environ;*env;env++) printf("%s\n",*env);
	
}
