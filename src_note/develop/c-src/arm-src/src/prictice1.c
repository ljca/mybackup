#include <stdio.h>

int main(void)
{
	int i = 20;
	int j = 3;
	int *i1 = &i;
	int *j1 = &j;
	printf("i addr is:%p\n",&i);
	printf("j addr is:%p\n",&j);
	printf("i+j= %d\n",*i1+*j1);
	printf("j-i=%d\n",*j1-*i1);
	return 0;
}
