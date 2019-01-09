/*
 * =====================================================================================
 *
 *       Filename:  fgets_test.c
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017/06/18 星期日 11:31:44
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
  char s[80];
  fputs(fgets(s,sizeof(s),stdin),stdout);
}
