#include <stdio.h>
int main(void)
{
	int i=0;
	int arr[5] = {10,20,30,40};
	printf("arr[0]=%d\n",arr[0]);
	printf("arr[0]=%p\n",&(arr[0]));
	printf("arr-length:%d\n",sizeof(arr)/sizeof(arr[1]));
	printf("sizeof(arr)=%d\n",sizeof(arr));
	for(i=0;i<5;i++)
	{
		printf("arr[%d]=%d  ",i,arr[i]);
		//printf("arr[%d]=%d\n",i,*(arr+i));
		printf("arr[%d]=%p\n",i,arr+i);
	}
	return 0;
}	
