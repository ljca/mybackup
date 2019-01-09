#include <stdio.h>
int my_strcmp(char *,char *);

int main()
{
	printf("%d\n",my_strcmp("hello","he"));
	return 0;
}

int my_strcmp(char *str1,char *str2)
{
	if(NULL != str1 && NULL != str2)
	{
		while(*str1++ || *str2++)
		{
			if(*str1 > *str2)
			{
				return 1;
			}
			else 
			{
				return 0;
			}
		}
	}
	return -1;
}
