#include <stdio.h>
//#include <string.h>
char *my_strcat(char *dest_str,char *str);
void tmp();

int main()
{
	char str[25] = "hello";
	char str1[10] = "bunfly";
	printf("%s\n",my_strcat(str,str1));
	return 0;
}

char *my_strcat(char *dest_str,char *str)
{
	char *p = dest_str;
//	p=dest_str+strlen(dest_str);
	while(*p!='\0')
	{
		p++;
	}
	
	while(*str != '\0')
	{
		*p = *str;
		p++;
		str++;
	}
	*p = '\0';
	return dest_str;
}

void tmp(char *dest_str,char *str)
{
	int i = 0,j=0;
	for(i = 0;i<25;i++)
	{
		str[i+strlen(str)]=str1[i];
	}

	for(i=0;i<sizeof(str);i++)
	{
		for(j=0;j<sizeof(str1);j++)
		{
			str[i+strlen(str)] = str1[j];
		}
	} 
	str[strlen(str)+1]='\0';
	//printf("%s\n",str);
}
