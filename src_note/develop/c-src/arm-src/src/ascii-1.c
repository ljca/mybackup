#include <stdio.h>
int main(void)
{
	char ch[]={'a','b','c','d','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
	char ch2[27]={0};

	 int i=0;
	for(i='A';i<='z';i++)
	{
		printf("%c ",i);
	}
	printf("\n");
	printf("ch[]:");
	for(i=0;i<=26;i++)
	{
		printf("%c ",ch[i]);
	}
	printf("\n");
	return 0;
}
