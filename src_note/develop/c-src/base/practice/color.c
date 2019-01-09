
#include <stdio.h>

int main(void)
{
  printf("\x1b[0;%dmhello world 30: 黑 \n\x1b[0m", 30);
  printf("\x1b[0;%dmhello world 31: 红 \n\x1b[0m", 31);
  printf("\x1b[0;%dmhello world 32: 绿 \n\x1b[0m", 32);
  printf("\x1b[0;%dmhello world 33: 黄 \n\x1b[0m", 33);
  printf("\x1b[0;%dmhello world 34: 蓝 \n\x1b[0m", 34);
  printf("\x1b[0;%dmhello world 35: 紫 \n\x1b[0m", 35);
  printf("\x1b[0;%dmhello world 36: 深绿 \n\x1b[0m", 36);
  printf("\x1b[0;%dmhello world 37: 白色 \n\x1b[0m", 37);

  printf("\x1b[%d;%dmhello world \x1b[0m 47: 白色 30: 黑 \n", 47,30);
  printf("\x1b[%d;%dmhello world \x1b[0m 46: 深绿 31: 红 \n", 46,31);
  printf("\x1b[%d;%dmhello world \x1b[0m 45: 紫   32: 绿 \n", 45,32);
  printf("\x1b[%d;%dmhello world \x1b[0m 44: 蓝   33: 黄 \n", 44,33);
  printf("\x1b[%d;%dmhello world \x1b[0m 43: 黄   34: 蓝 \n", 43,34);
  printf("\x1b[%d;%dmhello world \x1b[0m 42: 绿   35: 紫 \n", 42,35);
  printf("\x1b[%d;%dmhello world \x1b[0m 41: 红   36: 深绿 \n", 41,36);
  printf("\x1b[%d;%dmhello world \x1b[0m 40: 黑   37: 白色 \n", 40,37);

}

