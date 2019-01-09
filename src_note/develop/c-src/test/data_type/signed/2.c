/*
 * =====================================================================================
 *
 *       Filename:  2.c
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017/04/30 星期日 21:38:57
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  YOUR NAME (), 
 *   Organization:  
 *
 * =====================================================================================
 */
#include <stdio.h>

int sum(int n)
{
	return (1L + n) * n / 2;
}

int sum1(int n)
{
	int i = 1;
	unsigned long sum = 0;
	for(;i <= n;i++){
		sum += i;
	}
	return sum;
}

int main()
{
	printf("1 + 2 + 3 +..+ 100 = %d\n",sum(100));
	printf("1 + 2 + 3 +..+ 100 = %d\n",sum1(100));
}

