#include <stdio.h>
int main(void)
{
	int num = 0xbf83f4;	
	//int num = 0xbf83f4;
	//1011 1111 1000 0011 1111 0100 ^ 1ff0
	//1011 1111	1001 1100 0000 0100
	//1011 1111 1000 0011 1111 >>4 => bf83f
	//0000 0000 1011 1111 1000 0011 1111 0100 
	//1111 1000 0111 0100 ==> f874
	printf("%x\n",num^0x1ff0);
	printf("%x",num>>4);
	return 0;
}
