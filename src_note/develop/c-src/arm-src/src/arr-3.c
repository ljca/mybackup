#include <stdio.h>
int main(void)
{
	int arr[3][4]={0};
	int *p=(int *)arr;
	printf("arr=%p\n",arr);
	printf("arr[0]=%p\n",*arr);
	printf("p=%p",p);
	return 0;
}
