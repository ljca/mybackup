/*
 *摄氏度转换为华氏度的小程序！
 *
 *Date 2016/7/15
 *author kyzs
 *1C = 5/9 * (F - 32)
 * (F -32) * 5/9 = 1C
 * 32 + 1 * (5/9) 
 */
#include <stdio.h>
int main()
{
  float lower = 0,upper = 43;
  float fahr,celsius = lower;
  printf("摄氏度  华氏度\n");
  while(celsius<=upper)
  { 
    fahr = 32 + celsius * (9.0 / 5.0);
    printf("%3.0f  %6.1f\n",celsius,fahr);
    celsius++;
  }
return 0;
}






