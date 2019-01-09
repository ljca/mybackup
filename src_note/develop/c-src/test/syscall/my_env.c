#include <stdio.h>
#include <stdlib.h>

int main(int argc,char *argv[])
{
	if(argc != 2){
		fprintf(stderr,"Usage: %s <ENV>\n",argv[0]);
		return -1;
	}
	printf("%s=%s\n",argv[1],getenv(argv[1]));
}
