#include <stdio.h>
void swap_num(int a,int b);

int main(void)
{
	printf("Input two numbers example 2 3: ");
	int a=0,b=0;
	scanf("%d %d",&a,&b);
	//swap_num(3,5);
	swap_num(a,b);
	printf("%d,%d\n",a,b);
	return 0;
}

void swap_num(int x,int y)
{
	printf("%d,%d\n",x,y);
	int tmp=x;
	x=y;
	y=tmp;
	printf("%d,%d\n",x,y);
}

