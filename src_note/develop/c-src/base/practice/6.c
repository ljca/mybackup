#include <stdio.h>
int main(void)
{
	int i,tmp_num;
	/*
	int num = i/100;
	int num1 = (i%100)/10;
	int num2=i%100%10;
	*/
	int num = 1,num2=1,num3=1;
	for(i=999;i>=100;i--)
	{
		//i!=1*..*(i-1)*i
		//printf("%d  ",i);
		for(tmp_num=1;tmp_num<=(i/100);tmp_num++)
		{
			printf("%d\n",tmp_num);
			num*=tmp_num;
		}
		for(tmp_num=1;tmp_num<=((i%100)/10);tmp_num++)
		{
			num2*=tmp_num;
		}
		for(tmp_num=1;tmp_num<=(i%100%10);tmp_num++)
		{
			num3*=tmp_num;
		}
		if(i==(num+num2+num3))
		{
			printf("%d ",i);
		}
	}
	return 0;
}
