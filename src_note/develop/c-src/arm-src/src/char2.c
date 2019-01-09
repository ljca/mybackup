#include <stdio.h>
int main(void)
{
	char a='a';
	char A='A';
	char c='c';
	char C='C';
	printf("%c %c %c %c\n",a,A,c,C);
	printf("%d %d %d %d\n",a,A,c,C);
	a>A?printf("%c\n",a):printf("%c\n",A);
	if(a>c) printf("a>c\n");
	else printf("a<c\n");
	return 0;
}
