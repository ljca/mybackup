#include <stdio.h>

int main()
{
	puts("输入三个整数。");

	printf("整数1: ");
	int num1;
	scanf("%d",&num1);

	printf("整数2: ");
	int num2;
	scanf("%d",&num2);

	printf("整数3: ");
	int num3;
	scanf("%d",&num3);
	
	int sum = num1 + num2 + num3;
	printf("它们的和是%d。\n",sum);
}
