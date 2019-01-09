/*
 * =====================================================================================
 *
 *       Filename:  test_struct.c
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017年03月25日 16时19分32秒
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  YOUR NAME (), 
 *   Organization:  
 *
 * =====================================================================================
 */
#include <stdio.h>

typedef struct _test{
	int id;
	char str;
	char num[5];
}Test;

int main()
{
	Test test;
	printf("sizeof(test): %d\n",sizeof(test));
}
