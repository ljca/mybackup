/*
* File Name: vt.c
* Create Date: 2016年12月05日 星期一 09时58分47秒
*/
#include <stdio.h>
int main()
{

	//printf("\033[s");
	//printf("\033[U");
	printf("\033[?25l");
	//printf("\033[K");
	printf("\033[40;1;33m                     \033[0m\n");
	printf("\033[2J");
	printf("\033[0;0H");
	//printf("\033[u");
	printf("\033[?25h");
	return 0;
}
