#include <stdio.h>
#include <string.h>

int main()
{
	char buf[1024] = "hello,udp!\n";
	printf("strlen() %d\n",strlen(buf));
	printf("sizeof() %d\n",sizeof(buf));
	return 0;
}
