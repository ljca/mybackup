#include <stdio.h>

int main()
{
	puts("输入两个数，输出计算的百分比。");
	printf("整数A: ");
	int integer1 = 0;
	scanf("%d",&integer1);

	printf("整数B: ");
	int integer2 = 0;
	scanf("%d",&integer2);
	int res = integer1 * 100 / integer2;
	printf("A的值是B的%d%%。",res);
}
