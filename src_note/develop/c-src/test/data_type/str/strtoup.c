#include "strtoup.h"

char *convert_upper(char **str)
{
  char *tmp = *str;
  //unsigned short i = 0;
  for(;*tmp != '\0';tmp++){
    //if(*tmp > 'z' || *tmp < 'a' || *tmp == ' ') continue;
    if(*tmp >= 'a' && *tmp <= 'z'){
      *tmp = *tmp - CUPPER;
    }else if(*tmp >= 'A' && *tmp <= 'Z'){
      *tmp = *tmp + CUPPER;
    }
    else continue;
  }
  return *str;
}

