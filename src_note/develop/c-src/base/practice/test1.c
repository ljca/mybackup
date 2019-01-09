#include <stdio.h>
int main(void)
{
	int x=0x80,y=0x7f;

	printf("0x7f+1=%p\n",0x7f+1);
	return x>y?1:0;
}
