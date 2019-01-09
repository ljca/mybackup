#include <stdio.h>
#include <stdlib.h>

typedef unsigned long u_long;
u_long inet_addr(char *);

int main(int argc,char **argv)
{
	if(argc !=2){
		printf("Useage: %s ip\n",argv[0]);
		return 1;
	}
	char *tmp;
	//printf("inet_addr() %ld\n",strtoul(argv[1],(char **)&tmp,10));
	inet_addr(argv[1]);
	return 0;
}

u_long inet_addr(char *ip)
{
	char *p = ip,*p2;
	u_long i = 0;
	//while(*p){
	//	if(*p == '.') continue;
	//	i = *p * 10+*p - '0';
	//	i<<8;
	//	p++;
	//}
	//p = ip;
	while(p2 = strtok(p,".")){
		i = i<<8+atoi(p2);
		p = NULL;
	}
	printf("i %ld\n",i);
	return i;
}
