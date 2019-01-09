#include<stdio.h>
int main(void)
{
	int num=1;
	for(int i=1;i<=9;i++)
	{
		printf("%d  ",i);
		num*=i;	
	}
	printf("\n");
	/*
	for(int i=9;i>=1;i--)
	{
		printf("%d ",i);
	}
	*/
	printf("%d\n",num);
	return 0;
}
