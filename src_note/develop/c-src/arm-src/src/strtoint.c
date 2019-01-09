#include <stdio.h>
int main()
{
	printf("input string: ");
	char s[50] = "";
	scanf("%s",&s);
	int num=0,i=0;
	while(*s){
		if('0'<=*s && '9'>=*s){
			num = num*10+(*s-'0');
		}
		i++;
		*s=*(s+i);
	}
	printf("%d\n",num);
	return 0;
}

