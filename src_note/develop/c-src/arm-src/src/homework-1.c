#include <stdio.h>
int main(void)
{
	char str[5][7]={
		{"China"},{"UKhelp"},{"UShelp"},{"JPhelp"},{"Mhelp"}};
	/*
	char (*p)[10]=str;
	printf("%p\n",str);
	printf("%p\n",*str);
	printf("%p\n",*str+4);
	printf("*str+6=%p\n",*str+6);
	printf("%p\n",&str[1][0]);
	printf("%p\n",p);
	printf("%c\n",*(*p+4));
	//printf("%c\n");
	int i;
	*/
	/*
	printf("&str=%p\n",&str);
	printf("&str=%p\n",str);
	printf("&str=%p\n",str+1);
	printf("*(str+1)=%c\n",*(*(str+2)+1));
	printf("&str[0]=%p\n",*str);
	printf("&str[1]=%c\n",*str[1]);
	printf("&str[2]=%c\n",*str[2]);
	printf("&str[3]=%c\n",*str[3]);
	printf("&str[4]=%c\n",*str[4]);
	*/
	int i;
	for(i=0;i<5;i++)
	{
		printf("str[%d]=%p\n",i,str+i);
	}
printf("\n");
	return 0;
}
