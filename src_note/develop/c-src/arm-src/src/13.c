#include <stdio.h>
int main(void)
{
  int i=0,n=0,n2=0,sum=0,count=0;
  printf("Please Input a number:\n");
  scanf("%d",&n);
  for(i=1;i<=5;i++)
  {
    //sum=i;
//sum=i+(i*10+i)+(i+10*10+i*10+i)+...+(i+10*...+i*10+i)
    for(n2=1;n2<=n;n2++)
    {
      n2=n2+(n2*10+i);
      sum+=i;
      count++;
      if(count==n) break;
    }
    printf("1+11+111.....+11111=%d\n",sum);
  }
}
