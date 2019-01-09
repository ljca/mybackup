#include <stdio.h>
int main()
{
	int i = 1,sum=0;
loop:
	sum+=i;
	i++;
	if(i<=100) goto loop;
	else goto exit;
exit:
	printf("sum:%d\n",sum); return 0;
	return -1;
}
