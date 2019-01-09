#include <stdio.h>

int main()
{
	int arr[5] = {80,60,10,72,20};
	int i = 0,j = 0,tmp = 0;
	printf("---------sorting before--------\n");
	for(;i < 5;i++) printf("arr[%d] = %d\n",i,arr[i]);

	printf("---------sorting afters--------\n");
	for(i = 0;i < 5 - 1;i++){
		for(j = 5 - 1;j > i;j--){
			printf("i = %d, j = %d\n",i,j);
			if(arr[j] < arr[j-1]){
				tmp = arr[j-1];
				arr[j-1] = arr[j];
				arr[j] = tmp;
			}
		}
	}
	for(i = 0;i < 5;i++) printf("arr[%d] = %d\n",i,arr[i]);
}
