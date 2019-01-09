#include <stdio.h>
void pra_11();

int main(void)
{
	pra_11();
	return 0;
}

void pra_11()
{
	//int R=3,G=3,B=3;
	int i=0,j=0,k=0,count=0;
	for(i=0;i<=3;i++)
	{
		for(j=0;j<=3;j++)
		{
			k=6-i-j;
			if(k>=0&&k<=3)
			{
				printf("R = %d G = %d B = %d\n",i,j,k);
				count++;
			}
		}
	}
	printf("count = %d\n",count);
}
