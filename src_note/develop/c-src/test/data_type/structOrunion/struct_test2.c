#include <stdio.h>
//#include <stdlib.h>

struct test{
	int *num;
	struct test2 *test_2;
}test;

struct test2{
	char *name;
	int id;
}test2 = {
	.name = "nice",
	.id = 6,
};

int main()
{
	//struct test *test = (struct test *)malloc(sizeof(struct test *));
	test.num = (int *)0x00ffabcd;
	test.test_2 = &test2;
	printf("test.num = %#x\n",test.num);
	printf("test.test_2 = %d\n",test.test_2 == NULL ? 0 : 1);
	printf("test.test_2->name= %s\n",test.test_2->name);
	printf("test.test_2->id = %d\n",test.test_2->id);
	//free(test);
}

