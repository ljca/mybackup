#include <stdio.h>

int main()
{
  printf("%1.E\n",1e-6);
  printf("%1.E\n",1e6);
  printf("char = %u\n",(1U << (sizeof(char) * 8)) - 1);
  printf("unsigned char = %d\n",(1 >> (sizeof(unsigned char) * 8)) - 1);
  printf("short = %d\n",(1U >> (sizeof(short int) * 8)) - 1);
  printf("short = %d\n",((short int)1 >> (sizeof(short int) * 8)));
  printf("unsigned short = %u\n",(1U << (sizeof(unsigned short int) * 8)) - 1);
  printf("unsigned int = %u\n",(1U << (sizeof(unsigned int) * 8)) - 1U);
  printf("unsigned long = %lu\n",(1UL << (sizeof(unsigned long) * 8)) - 1U);
}

