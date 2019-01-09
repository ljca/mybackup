#include <stdio.h>
#include <unistd.h>

int main()
{
  printf("%d\n",isatty(fileno(stdin)));
  printf("%d\n",isatty(fileno(fopen("/dev/tty","r"))));
}

