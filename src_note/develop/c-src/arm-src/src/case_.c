#include <stdio.h>
int main(void)
{
  int n=0;
  printf("Please Input score:");
  scanf("%d",&n);
  /*
  switch(n)
  {
    case 50:
    case 60:
  }
  */
  if(n>=90) printf("A类\n");
  else if(n>=80&&n<90) printf("B类\n");
  else if(n>=70&&n<80) printf("C类\n");
  else if(n>=60&&n<70) printf("D类\n");
  else printf("E类\n");
  return 0;
}
