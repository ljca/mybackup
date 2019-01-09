#include <stdio.h>
int xm = 10;
int main(void)
{
	for(char ch='!';ch <= '}';++ch) printf("%c,%p\n",ch,&ch);
	printf("global variable xm value: %p\n",&xm);puts("function puts()\n");
	int *xm_ = &xm;
	int *test_ =&xm;
	int **test__ = 20;
	printf("%d\t",*xm_);
	printf("%d\n",*test_);
	printf("%d\n",test__);
	printf("%p\n",&test__);
	printf("char:%d\n",sizeof(char));
	printf("short:%d\n",sizeof(short));
	printf("int:%d\n",sizeof(int));
	printf("long:%d\n",sizeof(long));
	printf("long long:%d\n",sizeof(long long));
	printf("float:%d\n",sizeof(float));
	printf("double:%d\n",sizeof(double));
	printf("double:10.234占%d位\n",sizeof(10.234));
	return -1;
}
