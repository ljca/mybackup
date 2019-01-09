#include <stdio.h>
#include <termios.h>

int main()
{
  struct termios old_term;

  tcgetattr(fileno(stdin),&old_term);

  printf("input sppeed = %lu\n",cfgetispeed(&old_term));
  printf("output sppeed = %lu\n",cfgetospeed(&old_term));
}

