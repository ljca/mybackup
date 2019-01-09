#include <stdio.h>
#define X 3
#define Y (X * 2)
#undef X
#define X 2

int main()
{
	int z = Y;
	printf("z = %d\n",z);
}

