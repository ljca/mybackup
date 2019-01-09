/*
 * =====================================================================================
 *
 *       Filename:  test1.c
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017年04月13日 10时57分58秒
 *       Revision:  none
 *       Compiler:  gcc
 *       Description: 指向常量的指针,常量指针
 *
 *         Author:  YOUR NAME (), 
 *   Organization:  
 *
 * =====================================================================================
 */
#include <stdio.h>
int main()
{
	int num = 10;
	/* 保护指针指向的内存(即保护常量值不被改变，但可以间接改变，即改变num变量的值来改变),允许指针指向别的地方，但不允许指针指向的内存的值被改变 */
	const int *pnum = &num;
	pnum = (int *)0x1ff02;//OK
	*pnum = 0x112fa;//Error

	/* 保护指针指向的内存(即保护常量值不被改变，但可以间接改变，即改变num变量的值来改变),允许指针指向别的地方，但不允许指针指向的内存的值被改变 */
	int const *pnum1 = &num; <==> const int *pnum = &num;
	pnum1 = (int *)0x1ff02;//OK
	*pnum1 = 0x1ff02;//Error

	/*  保护指针,不允许指针再指向别的地方,但允许修改指针指向的内存中的值 */
	int *const pnum2 = &num;
	pnum2 = (int *)0x1ff02; //Error
	*pnum2 = 0x1ff02; //OK

	/* 保护指针和指针指向的内存 */
	const int *const pnum3 = &num;
	pnum3 = (int *)0x1ff02;//Error
	*pnum3 = 0x1ff02;//Error
	return 0;
}

