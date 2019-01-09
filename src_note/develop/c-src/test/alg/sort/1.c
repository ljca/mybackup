#include <stdio.h>

int main()/* input 3 numbers,sort them by more and more laters........ and print  */
{
	printf("input 3 numbers,use space split...\n");
	int num1 = 0,num2 = 0,num3 = 0;
	scanf("%d %d %d",&num1,&num2,&num3);
	printf("-------sort before------ \n%d %d %d\n",num1,num2,num3);
	int tmp = 0;
	if(num1 > num3){ //70 20 10 <==> 10 20 70
		tmp = num1;
		num1 = num3;
		num3 = tmp;
	}
	if(num1 > num2){
		tmp = num1;
		num1 = num2;
		num2 = tmp;
	}
	if(num2 > num3){
		tmp = num2;
		num3 = num2;
		num2 = tmp;
	}
	printf("------sort after------ \n%d %d %d\n",num1,num2,num3);
}
