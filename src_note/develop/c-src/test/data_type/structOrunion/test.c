#include <stdio.h>

struct Test1{
	int a;
	struct Test2{
		int b;
	}test2;
}test1;

int main()
{
	printf("sizeof(struct Test1) = %ld\n",sizeof(struct Test1));
	printf("sizeof(struct Test2) = %ld\n",sizeof(test1.test2));
	printf("sizeof(test1.test2.b) = %ld\n",sizeof(test1.test2.b));
	return 0;
}
