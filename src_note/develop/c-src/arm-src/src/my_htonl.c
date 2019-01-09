#include <stdio.h>
int my_htonl(int);

int main()
{
	int x = 0x11223344;
	my_htonl(x);
	return 0;
}


int my_htonl(int n)
{
	int result = 0;
	//result = 0x11223344;
	result = n >> 24;
	result |= (n & 0xff0000) >> 8;
	result |= (n & 0xff00) << 8;
	result |= n << 24;
	printf("%#x\n",result);
	return 0;
}
