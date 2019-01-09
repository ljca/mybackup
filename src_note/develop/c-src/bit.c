#include <stdio.h>


int main()
{
  int a = 0xE;
  printf("a = %x\n",a);
  a = a | (1 << 1);
  printf("a = %x\n",a);
  return 0;
}
