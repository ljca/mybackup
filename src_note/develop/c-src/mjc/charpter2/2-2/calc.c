#include <stdio.h>

int main()
{
	puts("请输入两个整数。");
	printf("整数A: ");
	int num1 = 0;
	scanf("%d",&num1);

	printf("整数B: ");
	int num2 = 0;
	scanf("%d",&num2);

	printf("它们的和是%d，它们的积是%d\n",num1 + num2,num1 * num2);

}
