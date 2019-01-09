#include <stdio.h>

union union_leng
{
	char ch[9];
	int n;
	double m;
}union_length;
int main()
{
	printf("sizeof(union_length) %d\n",sizeof(union_length));
	return 0;
}
