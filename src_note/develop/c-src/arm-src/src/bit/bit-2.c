#include <stdio.h>
int gitbits(int value,int n1,int n2);
int main(void)
{
	int x=5;
	printf("x=%#x\n",~x);	
	printf("x=%d\n",~x);	
	int num = 0xa89be7f1;
	//1010 1000 1001 1011 1110 0111 1111 0001
	printf("%#x\n",num&0xfffffff0);//0xa89be7f1&0xfffffff0
	printf("%#x\n",num|0x00000002);//0xa89be7f1|0x00000002
	printf("%#x\n",num|0x00000008);//0xa89be7f1|0x00000008
	printf("%#x\n",num&0xffffffef);//0xa89be7f1&0xffffffef
	printf("%#x\n",num&0xffffff0f);//0xa89be7f1&0xffffff0f
	printf("%#x\n",num|0x00001e00);//0xa89be7f1|0x00001e00
	printf("%#x\n",num|0x03fb8000);//0xa89be7f1|0x03fb8000
	printf("%#x\n",num|0x03f00000);//0xa89be7f1|0x03f00000
	return 0;
}

int gitbits(int val,int n1,int n2)
{
	return 0;
}
