#include <stdio.h>
int main()
{
	void *ptmp = "void *";
#pragma message("ptmp is void * point")
	printf("%c\n",*((char *)ptmp++));
}
