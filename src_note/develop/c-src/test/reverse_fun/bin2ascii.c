#include <stdio.h>

void bin2ascii(unsigned int num)
{
  unsigned int quotient;
  quotient = num / 10;
  if(quotient != 0)
    bin2ascii(quotient);
  putchar(quotient % 10 + '0');
  printf("\n");
}

int main()
{
  bin2ascii(579220);
}
