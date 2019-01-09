#include <stdio.h>
int main(void)
{
	int x=5;
	printf("x=%#x\n",~x);	
	printf("x=%d\n",~x);	
	int num = 0xa89be7f1;
	//1010 1000 1001 1011 1110 0111 1111 0001
	printf("%#x\n",num&0xfffffff0);//0xa89be7f1&0xffffff0
	return 0;
}
