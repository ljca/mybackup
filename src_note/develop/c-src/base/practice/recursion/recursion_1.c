#include <stdio.h>
int add(int n);
int febo(int num);

int main(void)
{
	printf("1+2+..+100=%d\n",add(100));
	printf("febo(10)=%d\n",febo(10));
	return 0;
}

int add(int n)
{
	if(1==n||0==n){
		return 1;
	}
	return n+add(n-1);
}

int febo(int num)
{
	if(1==num) return 1;
	else if(0==num) return 0;
	return febo(num-1)+febo(num-2);
}
