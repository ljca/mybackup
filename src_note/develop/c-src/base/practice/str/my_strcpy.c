#include <stdio.h>
#include <string.h>
char *strupr(char *);
char *my_strcpy(char *,char *);

int main()
{
	char *str = "this is test text";
	char str2[50] = "this is test string";
	printf("%s\n",strupr(str2));
	printf("%s\n",my_strcpy(str2,str));
	return 0;
}

char *strupr(char *str)
{
	char *p=str;
	while(*p)
	{
		if(*p >= 'a' && *p <= 'z')
		{
			*p -= 32;
		}
		p++;
	}
	return str;
}

char *my_strcpy(char *str,char *str2)
{
	if(NULL != str && NULL != str2)
	{
		char *p = str;
		while(*p)
		{
			*p = *str2;
			p++;
			str2++;
		}
		return str;
	}
	return NULL;
}

