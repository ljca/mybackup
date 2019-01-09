#include <stdio.h>
#include <errno.h>
#include <string.h>
#include "datatype.h"

int main(int argc,char **argv)
{
  //printf("wchar() = %lc\n",wchart(L'我'));
  char ch = 'a';
  char str[27] = {0};
  unsigned short i = 0;
  for(;i < sizeof(str) - 1;ch++,i++){
    *(str + i) = ch;
  }
  printf("%s\n",str);

  for(i = 0;i < strlen(str);i++){
    *(str + i) = *(str + i) - CUPPER;
  }
  printf("%s\n",str);

  if(argc != 2){
    fprintf(stderr,"Usage: %s <string>\n",argv[0]);
    return -1;
  }
  enum Color color = Yellow;
  printf("color = %d\n",enum_(color));
}
