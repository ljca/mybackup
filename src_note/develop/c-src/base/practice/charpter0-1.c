#include <stdio.h>
int main(void)
{
  int x = 110,*p = &x;
  printf("x is %d,x addr is:%p\n",x,&x);
  printf("p is %d,*p is:%p\n",*p,p);
  int i,j;
  for(i=1;i<=9;i++)
  {
    for(j=1;j<=i;j++)
    {
      printf("%d x %d = %d  ",j,i,j*i);
    }
    printf("\n");
  }
  return 0;
}
