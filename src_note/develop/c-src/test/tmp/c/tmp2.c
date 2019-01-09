/*
 * =====================================================================================
 *
 *       Filename:  mul_tab.c
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017/01/10 星期二 21:06:56
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  YOUR NAME (), 
 *   Organization:  
 *
 * =====================================================================================
 */

#include <stdio.h>
#include <stdlib.h>

int main(int argc,char **argv)
{
	//argc != 2 ? return 1:1;
	if(argc != 2) {
		printf("usage: %s <number> \n",argv[0]);
		return 1;
	}
	int i,j;
	for(i=1;i<atoi(argv[1]);i++){
		for(j=1;j<=i;j++){
			printf("*");
		}
		printf("\n");
	}
	return 0;
}
