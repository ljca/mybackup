#include <stdio.h>
#include <stdlib.h>
int main(void)
{
	char *s = "1234";
	int i,sum=0;
	for(i=0;i<=100;i++) sum+=i;
	printf("sum:%d\n",sum);
	printf("%d\n",atoi(s));
	return 0;
}
