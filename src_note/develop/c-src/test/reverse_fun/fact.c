/*
 * =====================================================================================
 *
 *       Filename:  fact.c
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017/06/18 星期日 16:20:04
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  YOUR NAME (), 
 *   Organization:  
 *
 * =====================================================================================
 */
#include <stdio.h>

int fact(int num)
{
  if(num == 0 || num == 1)
    return 1;
  return (fact(num - 1) * num);
}

int main()
{
  printf("input a number: ");
  int num;
  scanf("%d",&num);
  printf("fact(%d) = %ld\n",num,fact(num));
}
