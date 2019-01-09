#include <stdio.h>
int main()
{
  float fahr,celsius;
  float lower,upper,step;
  lower = 0;
  upper = 300;
  step = 20;
  fahr = lower;
  printf("################华氏度与摄氏度转换###########\n");
  printf("华氏度  摄氏度\n");
  
  while(fahr <= upper){
   celsius = (5.0/9.0) * (fahr-32.0);
   printf("%4.0f %6.1f\n",fahr,celsius);
   fahr = fahr+step;
  }

  return 0;
}







