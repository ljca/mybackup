#include <stdio.h>
int main()
{
	int num[10] = {79,572,65,1,12,152,69,87,42,59};
	int i = 0,j = 0;//tmp=0,max=num[0];
	for(;i < 10;i++) printf("%d  ",num[i]);
	printf("\n");
	for(i = 0;i < 10 - 1;i++){
		for(j = 10 - 1;j > i;j--){
			if(num[j] < num[j - 1]){
				num[j - 1] = num[j - 1] ^ num[j];
				num[j] = num[j] ^ num[j - 1];
				num[j - 1] = num[j - 1] ^ num[j];
			}
		}
	}
	for(i = 0;i < 10;i++) printf("%d  ",num[i]);
	printf("\n");
	return 0;
}

/*
for(j=0;j<9-i;j++){
 if(num[j]>num[j+1]){
	 tmp=num[j];
	 num[j]=num[j+1];
	 num[j+1]=tmp;	
 }
}
 */
