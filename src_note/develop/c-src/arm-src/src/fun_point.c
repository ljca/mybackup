#include <stdio.h>
void test_fun(void);
void test_fun_2(int (*test_fun3)(int),int);
int test_fun3(int);

int main(void)
{
	void (*test)(void)=test_fun;
	test_fun();
	test();
	test_fun3(10);
	test_fun_2(test_fun3,15);
	return 0;
}

void test_fun(void)
{
	printf("this is test function!\n");
}

void test_fun_2(int (*test_fun3)(int),int a)
{
	printf("this is test fun2:%d\n",a);
}

int test_fun3(int a)
{
	a = 10;
	printf("this is test fun3:%d\n",a);
}
