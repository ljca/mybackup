#include <stdio.h>
int main()
{
	int year=0;
	for(year=1900;year<=2000;year++)
	{
		if(year%4==0&&year%100!=0) printf("%d\t",year);
	}
	printf("\n");
	return 0;
}
