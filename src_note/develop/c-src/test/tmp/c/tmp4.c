/*
 * =====================================================================================
 *
 *       Filename:  tmp4.c
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017/01/10 星期二 21:26:49
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
	if(argc!=2){
		//system("ls -al");
		printf("usage: %s <number>\n",*argv);
		return 1;
	}
	int i,j,n=atoi(argv[1]);
	for(i=0;i<n;i++){
		for(j=0;j<n-i;j++)	printf(" ");
		for(j=0;j<i*2+1;j++) printf("*");
		printf("\n");
	}
	return 0;
}
