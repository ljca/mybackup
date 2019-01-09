#include <stdio.h>

int main()
{
	puts("输入两个整数。");
	printf("整数1：");
	int num1;
	scanf("%d",&num1);
	printf("整数2：");
	int num2;
	scanf("%d",&num2);
	int mul = num1 * num2;
	printf("它们的乘积是%d。\n",mul);
}

