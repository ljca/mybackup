/*
 * =====================================================================================
 *
 *       Filename:  array_insert.c
 *
 *    Description: 插入一个数到一个排好序的数组并保证数组的数保持顺序不乱 
 *
 *        Version:  1.0
 *        Created:  2017年03月30日 18时04分59秒
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
	int num[10] = {30,45,57,68,79,88,99,100};
	int i;
	int index = 0,tmp_num = num[index];
		printf("Input insert numbers: ");
		scanf("%d",&tmp_num);
	for(i = 0;i<(int)(sizeof(num)/sizeof(num[0]));i++){
		printf("num[%d] = %d\n",i,num[i]);
		/* 检索数组中空位置索引 */
		if(num[i] != 0) index++;
		/* 遍历比较排序插入 */
	} 
	num[index] = tmp_num;
		printf("index = %d\tnum[%d] = %d\n",index,index,num[index]);

	return 0;
}
