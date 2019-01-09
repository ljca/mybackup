#include <stdio.h>
int main(void)
{
	int i = 100;
	printf("i = %d\n",i);
	printf("i%p\n",&i);
	printf("i=%d\n",*(&i));
	printf("i addr is:%p\n",&(*(&i)));
	return 0;

}
