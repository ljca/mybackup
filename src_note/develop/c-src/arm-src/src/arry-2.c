#include <stdio.h>
int main(void)
{
	int i,j,num[2][3]={{12,74920,1},{501,79,60}},max,tmp,index_i,index_j;
	/*for()
	{
	}
	*/
	max=num[0][0];
	index_i=0,index_j=0;
	for(i=0;i<2;i++)
	{
		for(j=0;j<3;j++)
		{
			if(num[i][j]>max)
			{
				max=num[i][j];
				index_i=i,index_j=j;
			}
		}
	}
	printf("%d,%d,%d",index_i,index_j,max);
	printf("\n");
	return 0;
}
