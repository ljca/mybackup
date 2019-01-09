#include <stdio.h>

int main()
{
	int i = 3;
	int x = (1,2);
	int sub = (++i) + (++i) + (++i);
	printf("++i = %d\n",sub);
}

