#include <stdio.h>
int main()
{
	char str[2][8]={"str0","str1"};
	int *p = (int *)str;
	char *p1 =(char *)str;
	printf("str+0=%s\n",str+0);
	printf("str+1=%s\n",str+1);
	printf("str[0]=%s\n",str[0]);
	printf("%str[1]=s\n",str[1]);
	printf("*str=%s\n",*str);
	printf("*(str+1)=%s\n",*(str+1));
	printf("&str[0]+1=%s\n",&str[0]+1);
	printf("p=%s\n",p);
	printf("p+2=%s\n",p+2);
	printf("p1=%s\n",p1);
	printf("p1+8=%s\n",p1+8);
	return 0;
}
