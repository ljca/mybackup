#include <stdio.h>

union UNION
{
	int n; // size(n) = 4;
	int m; // size(m) = 4;
	char c; // size(c) = 1;
	//char arr[10]; // size(arr) = 10;
}num; // sizeof(num)=?:12
int main()
{
	printf("num.n = %d\n",num.n = 4);
	printf("num.m = %d\n",num.m = 6);
	printf("num.n = %d\n",num.n);
	printf("num.m = %d\n",num.m);
	//printf("num.n + num.m = %d\n",(num.n = 4)+(num.m = 6));
	//printf("num.c = %c\n",num.c = 'c');
	printf("&num.n = %p\n",&num.n);
	printf("&num.m = %p\n",&num.m);
	printf("&num.c = %p\n",&num.c);
	//printf("num.arr = %p\n",num.arr);
	printf("sizeof(num) %d\n",sizeof(num));
	return 0;
}
