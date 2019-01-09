#include <stdio.h>
void pra12();

int main()
{
	pra12();
	return 0;
}

void pra12()
{
	int x = 1,y=1,j=1;
	for(y=1;y<=25;y++)
	{
		for(x=3;x<=100;x+=3)
		{
			x = 100 - y;
			if(x+y==100 && x*3+y/3==100)
			{
				printf("%d,%d\n",x,y);
			}
		}
	}
}
