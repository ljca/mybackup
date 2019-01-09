#include <stdio.h>
#include <string.h>
char *str_reverse(char *str);

int main()
{
	char arr[50] = "this is test string";
	str_reverse(arr);
	return 0;
}

char *str_reverse(char *str)
{
	char *p = str;//p=str
	char *p1 = str;//p1=str
	char *p2 = str;//p2=str
	//printf("%s\n",p1);
	p1 = strstr(p2," "); //p1=" is test string" str=p=p2="this is test string"
	p = strtok(p2," ");//"str=p=p2="this" p1=" is test string" 
	printf("%s\n",p);
	p2 = ++p1;//p2=p1="is test string" str=p="this"
	p1 = strstr(p2," "); //p1=" test string" p2="is test string" str=p="this"
	p = strtok(p2," ");//str=p=p2="is" p1=" test string"
	printf("%s\n",p);
	p2 = ++p1;//p2=p1="test string" p="is"
	p1 = strstr(p2," ");//p1=" string" p2=p="is"
	//printf("%s\n",p1);
	p = strtok(p2," ");//str=p=p2="test" p1=" string"
	printf("%s\n",p);
	p2 = ++p1;//p2=p1="string" p="test"
	p = strtok(p2," ");//str=p=p2="string" p1="string"
	printf("%s\n",p);
	return p;
}
