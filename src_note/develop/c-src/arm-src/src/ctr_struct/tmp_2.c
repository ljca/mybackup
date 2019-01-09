#include <stdio.h>
int main(void)
{
	int num[2][5][5]={0};
	int (*p)[5][5]=num;
	printf("sizeof(num):%d\n",sizeof(num));
	printf("sizeof(p):%d\n",sizeof(p));
	printf("sizeof(p[0]):%d\n",sizeof(p[0]));
	printf("sizeof(p[0][0]):%d\n",sizeof(p[0][0]));
	printf("sizeof(p[0][0][0]):%d\n",sizeof(p[0][0][0]));
	return 0;
}
