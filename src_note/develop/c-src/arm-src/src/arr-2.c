#include <stdio.h>
int main(void)
{
	int i=0,arr[10]={0},arr_length=sizeof(arr)/sizeof(int);
	for(i=0;i<arr_length;i++)
	{
		printf("Input a number:");
		scanf("%d",&arr[i]);
	}
	printf("\n");
	printf("未排序之前的数组元素:\n");
	for(i=0;i<arr_length;i++)
	{
		printf("arr[%d]=%d ",i,arr[i]);
	}
	printf("\n");
	int j=0,tmp=0;
	for(i=0;i<arr_length;i++)
	{
		for(j=0;j<arr_length-1;j++)
		{
			if(arr[j] > arr[j + 1]) 
			{
				tmp=arr[j];
				arr[j]=arr[j+1];
				arr[j + 1] = tmp;
			}
		}
	}
	printf("排序之后的数组元素:\n");
	for(i=0;i<arr_length;i++)
	{
		printf("arr[%d]=%d ",i,arr[i]);
	}
	printf("\n");
	return 0;
}
