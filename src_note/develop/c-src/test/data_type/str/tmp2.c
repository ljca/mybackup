#include "stdio.h"
int main()
{
	int i,j;
	printf("\1\1\n");/**/
	for(i=1;i<25;i++){
		for(j=1;j<=i;j++) printf("%c%c",219,219);
		printf("\n");
	}
}

