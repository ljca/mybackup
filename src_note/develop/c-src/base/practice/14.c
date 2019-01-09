#include <stdio.h>
#ifndef MAX
#define MAX 999
#endif
int main(void)
{
  int i=100,num1=0,num2=0,num3=0;
  for(i=100;i<=MAX;i++)
  {
    //if(i%100==0) continue;
      num1=i/100;num2=i%100/10;num3=i%10;
      //i/100+i%100/10+i%10
      if(num1*num1*num1+num2*num2*num2+num3*num3*num3==i)
      {
        printf("%d ",i);
      }
  }
  return 0;
}
