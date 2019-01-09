#include <stdio.h>
#include <unistd.h>
#include <sys/types.h>

int main()
{
	printf("%s\n",getlogin() ? "true" : "false");
}
