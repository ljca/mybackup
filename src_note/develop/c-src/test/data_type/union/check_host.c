#include <stdio.h>
int check_host()
{
	union check{
		int i;
		char c;
	}check;
	check.i = 1;
	return (check.c == 1);
}
int main()
{
	printf("host is %s",check_host() == 1 ? "little-endian.\n" : "big-endian.\n");
}

