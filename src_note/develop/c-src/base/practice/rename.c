/*
 * =====================================================================================
 *
 *       Filename:  rename.c
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2016/12/13 星期二 19:40:25
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  YOUR NAME (), 
 *   Organization:  
 *
 * =====================================================================================
 */

#include <stdio.h>

int main(int argc,char **argv)
{
	if(argc != 3 ) {
    printf("Usege: %s <file> <new-file>\n",argv[0]);
    return 0;
  }
	rename(argv[1],argv[2]);
	return 0;
}
