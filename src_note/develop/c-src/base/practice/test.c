#include <stdio.h>
#include "test.h"
int main(void)
{
  test();
	printf("%c%c\n",255,255);
  return 0;
}

void test(void)
{
  printf("test text\n");
}
