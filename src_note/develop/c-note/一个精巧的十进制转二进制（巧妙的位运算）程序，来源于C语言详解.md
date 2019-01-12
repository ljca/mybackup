# 一个精巧的十进制转二进制（巧妙的位运算）程序，来源于C语言详解

```c
/* ============ printbit.c =========== */
#include <stdio.h>
#include <stdlib.h>

void printbit(unsigned int num)
{
  unsigned int i = 1;
  unsigned int tmp = 1;
  tmp <<= sizeof(int) * 8 - 1;
  
  for(;i <= sizeof(int) * 8;i++){
    putchar((num & tmp) ? '1' : '0');
    if(i % 4 == 0) putchar(' ');
    tmp >>= 1;
  }
  putchar('\n');
}

int main(int argc,char **argv)
{
  if(argc != 2){
    fprintf(stderr,"Usage: %s <num>\n",*argv);
    return EXIT_FAILURE;
  }
  printbit(atoi(*(argv + 1)));
  printbit(~(atoi(*(argv + 1))));
}
```
