#include <stdio.h>

void swap(a,b)
int *a,*b;
{
  *a ^= *b ^= *a ^= *b;
}

int main()
{
  int a = 123,b = 7654;
  printf("a = %d,b = %d\n",a,b);
  swap(&a,&b);
  printf("a = %d,b = %d\n",a,b);
}
