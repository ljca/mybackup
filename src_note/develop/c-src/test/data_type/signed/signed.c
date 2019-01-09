/*
 * =====================================================================================
 *
 *       Filename:  signed.c
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017/04/30 星期日 18:17:30
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

int main()
{
	char a[1000];
	int i;
	for(i=0; i<1000; i++){
		a[i] = -1-i;
	}
	printf("%d",strlen(a));
	return 0;
}
