#include <stdio.h>
int find_reverse_n(void);

int main(void)
{
	find_reverse_n();
	return 0;
}

int find_reverse_n(void)
{
	int num=0,N=0;
	int num_1=0,num_2=0,num_3=0,num_4=0;
	for(num=1001;num<=9999;num++)
	{
		if(0!=num%10)
		{
			num_1 = num / 1000;
			num_2 = (num % 1000) / 100;
			num_3 = (num % 100) / 10;
			num_4 = num % 10;
			N = num_4 * 1000 + num_3 * 100 + num_2 * 10 + num_1;
			if(num*9 == N) 
			{
				//	printf("num=%d,num_1=%d,num_2=%d,num_3=%d,num_4=%d\n",num,num_1,num_2,num_3,num_4);
				printf("num = %d,N = %d\n",num,N);
			}
		}
	}
}

