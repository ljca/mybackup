#include <stdio.h>
//#include <stdlib.h>

int main()
{
  printf("input string: ");
  char str[50] = "";
  //char *str=malloc(sizeof());
  scanf("%s",&str);
  printf("%s\n",str);
  int num = 0,i=0;
  while(*str)
  {
    if('0'<=*str && '9'>=*str)
    {
      num=num*10+(*str-'0');
    }
    i++;
    *str=*(str+i);
  }
  printf("%d",num);
  return 0;
}
