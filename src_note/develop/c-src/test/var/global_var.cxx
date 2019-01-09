/*
 * =====================================================================================
 *
 *       Filename:  global_var.cxx
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017/05/ 3 星期三 20:22:55
 *       Revision:  none
 *       Compiler:  g++
 *
 *         Author:  YOUR NAME (), 
 *   Organization:  
 *
 * =====================================================================================
 */

//#include <stdio.h>
#include <iostream>

int num;

int main()
{
	int num = 10;
	//printf("local var num values: %d,global var num values: %d\n",num,::num);
	std::cout << "local var num values: " << num << ",global var num values: " << ::num << std::endl;
}
