#include <stdio.h>
int main()
{
	int a __attribute__ ((unused));//
	printf("func: %s\n",__FUNCTION__);
	return 0;
}
