#include <stdio.h>
void arr_reverse(int *int_arr,int arr_length);

int main(void)
{
	int arr[5]={1,2,3,4,5},arr_leng=sizeof(arr)/sizeof(arr[0]);
	arr_reverse(arr,arr_leng);
	return 0;
}

void arr_reverse(int *int_arr,int arr_leng)
{
	if(NULL!=int_arr)
	{
		int i,tmp;
		for(i=0;i<5;i++) printf("%d ",*(int_arr+i));
		printf("\n");
		for(i=0;i < --arr_leng;i++)
		{
			tmp=*(int_arr+i);
			*(int_arr+i)=*(int_arr+arr_leng);
			*(int_arr+arr_leng)=tmp;
		}
		for(i=0;i<5;i++) printf("%d ",*(int_arr+i));
	}
}
