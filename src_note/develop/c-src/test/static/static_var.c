/*
 * =====================================================================================
 *
 *       Filename:  static_var.c
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017/04/30 星期日 17:43:23
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  YOUR NAME (), 
 *   Organization:  
 *
 * =====================================================================================
 */
#include <stdio.h>

static int i;
int static_i()
{
	i++;
	return i;
}

void static_j()
{
	static int j;
	printf("%d  ",j++);
}

int main()
{
	int k = 0;
	for(;k < 10;k++){
		static_i();
		static_j();
	}
	printf("i = %d\n",i);
	int *p;
	int a[100];
	printf("sizeof(int) = %lu\n",sizeof(int));
	printf("sizeof(*p) = %lu\n",sizeof(*p));
	printf("sizeof(p) = %lu\n",sizeof(p));

	printf("sizeof(a) = %lu\n",sizeof(a));
	printf("sizeof(a[100]) = %lu\n",sizeof(a[100]));
	printf("sizeof(*(&a)) = %lu\n",sizeof(*(&a)));
	printf("sizeof(*(&a[0])) = %lu\n",sizeof(*(&a[0])));
	printf("sizeof(&a[1]) = %lu\n",sizeof(&a[1]));

}

