/*
 * =====================================================================================
 *
 *       Filename:  tmp.c
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017/04/29 星期六 16:23:34
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  YOUR NAME (), 
 *   Organization:  
 *
 * =====================================================================================
 */
#include <stdio.h>

int main()
{
	int a = 1,b = 6;
	printf("a = %d,b = %d\n",a,b);
	printf("a = %d,b = %d\n",a ^= b,b); /* a = a ^ b */
	printf("b = %d,a = %d\n",b ^= a,a); /* b = b ^ a */
	printf("a = %d,b = %d\n",a ^= b,b); /* a = a ^ b */
	printf("a = %d,b = %d\n",a,b);
	return 0;
}
