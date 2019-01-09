#include <stdio.h>
int main(int argc,char *str[])
{
	printf("main argc:%d\n",argc);
	if(1!=argc)
	{
		printf("hex=%#x\n",*str[1]);
	}
	return 0;
}

int toDec(char *p)
{
}

int binToHex(int *num)
{
}
