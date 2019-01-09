#include <stdio.h>
#include "reversestr.h"

int main(int argc,char **argv)
{
  if(argc != 2){
    fprintf(stderr,"Usage: %s <str>\n",argv[0]);
    return 1;
  }
  printf("%s\n",reverse_str(argv[1]));
  printf("%s\n",reverse_str_2(argv[1]));
  printf("%s\n",reverse_str_3(argv[1]));
  return 0;
}
