#include <string.h>
#include "reversestr.h"

char *reverse_str(char *str)
{
  char ch;
  char *start = str;
  char *left = str;
  while(*str++) ;
  str -= 2;
  while(left < str){
    ch = *left;
    *left++ = *str;
    *str-- = ch;
  }
  return start;
}

char *reverse_str_2(char *str)
{
  unsigned long i = 0,j = strlen(str) - 1;
  char ch;
  for(;i < j;i++,j--){
    ch = *(str + i);
    *(str + i) = *(str + j);
    *(str + j) = ch;
  }
  return str;
}

char *reverse_str_3(char *str)
{
  unsigned long i = 0,str_len = strlen(str) - 1;
  for(;i < str_len / 2;i++){
    char ch = *(str+i);
    *(str + i) = *(str + str_len - i);
    *(str + str_len - i) = ch;
  }
  return str;
}

/*  vim:set expandtab */
