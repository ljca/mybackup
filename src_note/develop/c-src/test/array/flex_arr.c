/*
 * =====================================================================================
 *
 *       Filename:  flex_arr.c
 *
 *    Description:  柔性数组：结构体中的可变长数组
 *
 *        Version:  1.0
 *        Created:  2017/05/ 3 星期三 23:32:54
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

typedef struct flex_array_st{
	int i;
	char name[];
}flex_arr;

flex_arr flex_array = {
	.i = 1,
	.name = "",
};

int main()
{
	printf("sizeof(flex_array_st) = %d\n",sizeof(flex_arr));
	flex_arr *parr = (flex_arr *)malloc(sizeof(flex_arr) + 100 * sizeof(int));
	printf("sizeof(parr) = %d\n",sizeof(parr));
	printf("sizeof(*parr) = %d\n",sizeof(*parr));
	free(parr);
	parr = NULL;
}

