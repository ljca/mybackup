#include <stdio.h>

int (my_strcmp)(char *src,char *dest)
{
	for(;*src == *dest;++src,++dest)
		if(*src == '\0') return 0;
	return *((unsigned char *)src) < *((unsigned char *)dest) ? -1 : 0;
}

int main()
{
	printf("my_strcmmp('"",""') =  %d\n",my_strcmp("tlxs?","ls?"));
}
