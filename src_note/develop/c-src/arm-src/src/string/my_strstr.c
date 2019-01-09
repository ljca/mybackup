#include <stdio.h>
#include <string.h>
char *my_strstr(char *,char *);

int main()
{
	char str[50] = "zh cn en us uk,hk Jp";
	printf("my_strstr=%s\n",my_strstr(str,","));
	printf("strstr=%s\n",strstr("hel ls,xsl","ls,"));
	return 0;
}

char *my_strstr(char *str1,char *str2)
{
	if(NULL != str1 && NULL != str2)
	{
		while(*str1)
		{
			if(*str1++ == *str2)
			{
				return --str1;
			}
		}
	}
	return NULL;
}

