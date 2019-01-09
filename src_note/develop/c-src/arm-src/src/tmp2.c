#include <stdio.h>
int main()
{
	int i;
	int count = 0;
	for(i=100;i<=2000;i++)
	{
		if(i%2==1&&i%3==1&&i%5==1)
		{
			printf("%d ",i);
			count++;
			if(count==10) {break;}
			//else continue;
		}
	}
	printf("count:%d\n",count);
	return 0;
}	
