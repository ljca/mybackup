/*
 * =====================================================================================
 *
 *       Filename:  sscanf.c
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017年03月30日 16时50分24秒
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
	char *buf,*str = "12345678!";
	if(sscanf(str,"%4s",buf) < 0) return -1;
	printf(buf);
	return 0;
}
