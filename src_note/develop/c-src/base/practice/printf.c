/*
 * =====================================================================================
 *
 *       Filename:  printf.c
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2016/12/16 星期五  0:14:51
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  YOUR NAME (), 
 *   Organization:  
 *
 * =====================================================================================
 */

#include <stdio.h>

int main(int argc,char **argv)
{
	printf("%d: %s\n",--argc,*argv);
	printf("%d: %s\n",++argc,*++argv);
	printf("hello,c\b\n");
	return 0;
}
