#include<stdio.h>
#define MAX 1000
int main(void)
{
  //
  int i=0,j=0,tmp=0;

#if 0
  printf("数%d的因子数是:",j);
  for(i=1;i<=j;i++)
  {
    if(j%i==0&&i!=j)
    {
      printf("%d ",i);
      tmp+=i;
      if(tmp==j)
      {

      }
    }
  }
#endif
#ifdef MAX
  for(i=1;i<=MAX;i++)
  {
    tmp=0;
    for(j=1;j<=i;j++)
    {
      if(i%j==0&&i!=j)
      {
        tmp+=j;
        if(tmp==i)
        {
          printf("数%d is ok!",i);
          printf("%d：Its factors are ",i);
          int x=1;
          for(x=1;x<=i;x++)
          {
            if(i%x==0&&i!=x) printf("%d,",x);
          }
          printf("\n");
        }
      }
    }
  }
#endif
  return 0;
 }
