#include <stdio.h>
//#pragma pack(1)
typedef struct Struct{
  // x86_64
  int id; // 4 bytes ==> + 补齐 4 bytes = 8 bytes
  char *name; // 8 bytes ==> 16 bytes
  long long l_num; // 8 bytes ==> 24 bytes +　补齐 8 bytes = 32 bytes
  long double l_num_f; // 16 bytes ==> 48 bytes
} __attribute__ ((aligned(1),packed)) Struct; //sizeof(Struct) =  48 % 16 == 0 ? 48 : 48 + n //补齐 n 个字节数，直到变成 16 的倍数

typedef union Union{
  // x86_64
  char ch; // 1 bytes
  char *name; // 8 bytes
  int id; // 4 bytes
  double area; // 8 bytes
  long double l_num; // 16 bytes
  Struct instant1; // 48 bytes
  long ll_num[10]; // 10 * 8 bytes = 80 bytes
}Union; // x86_64 sizeof(Union) = 内存占用最多成员 = 80？

int main()
{
  int test  __attribute__ ((unused)) = 2;
  int num __attribute__ ((aligned(2),unused)) = 2;
  printf("sizeof(struct Struct) = %ld\n",sizeof(Struct));
  printf("sizeof(union Union) = %ld\n",sizeof(Union));
}
