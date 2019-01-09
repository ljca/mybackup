#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "fileutil.h"

int main(int argc,char *argv[])
{
  switch(argc){
    case 2:
      read1(argv[1]);
      break;
    case 3:
      write1(argv[1],argv[2]);
      break;
    default:
      fprintf(stderr,"Read File Usage: %s [file]\n",argv[0]);
      fprintf(stderr,"Write File Usage: %s [file] <text>\n",argv[0]);
      break;
  }
  return 0;
}
