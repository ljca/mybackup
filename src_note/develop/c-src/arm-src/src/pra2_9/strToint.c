#include <stdio.h>
int my_strlen(char *str);
int my_atoi(char *str);
char *my_strcat(char *dest_str,char *str);
int my_strcmp(char *dest_str,char *str);
char *my_strcpy(char *dest_str,char *str);
char *my_strstr(char *dest_str,char *str);
char *my_strtok(char *dest_str,char *str);

int main()
{
	printf("size %d\n",my_strlen("ll llsz la;pw soxl !"));
	my_atoi("lxsls x 10200.02x");
	//printf("%s\n");
			my_strcat("hello,","bunfly");
	return 0;
}

int my_strlen(char *str)
{
	if(NULL!=str)
	{
		int count = 0;
		while(*str++)
		{
			++count;
		}
		return count;
	}
	return 0;
}

int my_atoi(char *str)
{
	if(NULL != str)
	{
		int result=0;
		while(*str)
		{
			if('0'<= *str && '9' >= *str)
			{
				result	= result*10+(*str-'0');
			}
			str++;
		}
		printf("%d\n",result);
		return result;
	}
	return 0;
}

char *my_strcat(char *dest_str,char *str)
{
	if(NULL != str)
	{
		return p;
	}
	return NULL;
}

int my_strcmp(char *dest_str,char *str)
{
}

char *my_strcpy(char *dest_str,char *str)
{
}

char *my_strstr(char *dest_str,char *str)
{
}

char *my_strtok(char *dest_str,char *str)
{
}

