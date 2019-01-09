#include <stdio.h>
int main()
{
	int tmp=0,i=0,days[12]={31,29,31,30,31,30,31,31,30,31,30,31};
	for(i=0;i<12;i++)
	{
		if(tmp==150)
		{
			printf("%d\n",i);
			break;
		}
		tmp+=days[i];
	}
	return 0;
}
