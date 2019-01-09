/*
 * =====================================================================================
 *
 *       Filename:  asm_1.c
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017/01/ 9 星期一  9:47:57
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
	int i = 20,j=10;
	printf("i=%d\t" "j=%d\n",i,j);
	asm volatile ("add %1,%0" :"=r" (j) :"r" (i)/*:"1"*/);

#if 0
#pragram asm
		"movl %0,%1"
		:"=r" (j)
		:"r" (i)
		:"1"
#pragram endasm
#endif
	printf("i=%d\t" "j=%d\n",i,j);
	return 0;
}
