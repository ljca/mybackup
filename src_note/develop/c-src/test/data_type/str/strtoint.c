#include <stdio.h>
#include <errno.h>
#include <math.h>

int myatoi(const char *str)
{
  char *tmp = (char *)str;
  int num = 0;
  while(*tmp){
    if(*tmp <= '9' && *tmp >= '0') num = num * 10 + *tmp - '0';
    //if(num > ~0x0) return (num = 0);
    tmp++;
  }
 // while(*tmp){
  //while(*tmp >= '0' && *tmp <= '9'){
  //  num = num * 10 + *tmp - '0';
  //  tmp++;
  //  if(num > (1u << sizeof(int) * 8) - 1){
  //    return num = 0;
  //  }
  //}
 // }
  //if(*str == '-') num = -num;
  return num;
}

int main(int argc,char **argv)
{
  if(argc != 2){
    fprintf(stderr,"Usage: %s <str>\n",*argv);
    return EINVAL;
  }
  printf("%d\n",myatoi(*++argv));
}

