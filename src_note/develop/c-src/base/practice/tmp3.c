#include<stdio.h>
int main(void)
{
	int i,sum=0,count=0;
	for(i=100;i<=1000;i++)
	{
		if(i%7==0&&i%10==3)
		{
			printf("%d  ",i);
			sum+=i;
			count++;
		}
	}
	printf("\nsum=%d\n",sum);
	printf("count:%d\n",count);
	printf("%f\n",2.4E-5);
	printf("%c\n",'A'+1);
	for(i=0;i<=127;i++)
	{
	  printf("%c\t%p\n",i,i);
	}
	printf("\n");
	return 0;
}
