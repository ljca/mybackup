#include <stdio.h>
#define PI 3.14159265
void operate(int num);
//int operate2(int num);
int main()
{
  int num;
  printf("Please input a nuber:\n");
  scanf("%d",&num);
  printf("%p\n",num);
  operate(num);
  operate2(num);
  return 0;
}      

void operate(int num)
{
  printf("num：%p\n",&num);
}

int operate2(int num)
{
  printf("num：%p\n",&num);
}
