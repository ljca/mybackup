#include <stdio.h>

struct struct_sz{
  // x86_64
  char ch; // 1 bytes  ==> 1 + 1
  short s_num; // 2 bytes ==> 4
  int num; // 4 bytes ==> 8
  long l_num; // 8 bytes ==> 16
  long long ll_num; // 8 bytes ==> 24 
  float ff_num; // 4 bytes ==> 28 + 4 ==> 32
  double f_num; // 8 bytes ==> 40 + 8 ==> 48
  long double lf_num; // 16 bytes ==> 64
}; // sizeof(struct size) = 64 % 16 == 0 ? 64 : 64 + n

int main()
{
  printf("sizeof(long) = %lu\n",sizeof(long));
  printf("sizeof(long long) = %lu\n",sizeof(long long));
  printf("sizeof(float) = %lu\n",sizeof(float));
  printf("sizeof(double) = %lu\n",sizeof(double));
  printf("sizeof(long double) = %lu\n",sizeof(long double));
  printf("sizeof(struct size) = %lu\n",sizeof(struct struct_sz));
}

