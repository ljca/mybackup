#include <stdio.h>
#include "strToint.h"

int main(void)
{
	printf("%d\n",my_atio("alxl35las02021"));
	int arr[2][3]={{1,6,87},{7,92,12}},tmp_arr[3][2];
	//converse_arr(arr,tmp_arr);
	return 0;
}

int my_atio(char *str)
{
	int num=0;
		//printf("%d\n",*str-'0');
	while(*str){
		if(*str>='0'&&*str<='9')
		{
			num=num*10+(*str-'0');
		}
			str++;
	}
		//	printf("%s\n",str);
	return num; 
}

/**
 * arr 待转置数组地址
 * brr 转置之后的数组地址
 */
void converse_arr(int (*arr)[3],int (*brr)[2]) 
{
	int i,j;
	for(i=0;i<2;i++)
	{
		for(j=0;j<3;j++)
		{
			printf("%d ",arr[i][j]);
		}
	}
	printf("\n");
	for(i=0;i<2;i++)
	{
		for(j=0;j<3;j++)
		{
			brr[j][i]=arr[i][j];
		}
	}
	for(i=0;i<3;i++)
	{
		for(j=0;j<2;j++)
		{
			printf("%d ",brr[i][j]);
		}
	}
	if(1) ;
}
