/*
 * =====================================================================================
 *
 *       Filename:  1.c
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017/04/30 星期日 20:27:23
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  YOUR NAME (), 
 *   Organization:  
 *
 * =====================================================================================
 */
#include <stdio.h>
#define EPSINON 1e-6

int main()
{
	printf("(1 << 7) - 1 = %d\n",(1 << 7) - 1);
	printf("(1 << 8) - 1 = %d\n",(1 << 8) - 1);
	printf("(1 << 32) - 1 = %u\n",(1 << 32) - 1);
	int i = -20;
	unsigned j = 10;
	printf("%u\n",i + j);
	//for(j = 9;j >= 0;j--) printf("%u\n",j);
	float fval = 1.0;
	if(fval >= -EPSINON && fval <= EPSINON){
	}
	printf("1e-6 = %f\n",1e-6);
}
