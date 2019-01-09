/*
 * =====================================================================================
 *
 *       Filename:  struct_test.c
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017年03月30日 20时08分46秒
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  YOUR NAME (), 
 *   Organization:  
 *
 * =====================================================================================
 */
#include <stdio.h>
#include <string.h>

typedef struct _test{
	int age;
	char name[];
}Test;

int main()
{
	Test test = {
		.age = 10,
	};
		strcpy(test.name,"Bob");
		printf("%s is %d olds the year\n",test.name,test.age);
	return 0;
}
