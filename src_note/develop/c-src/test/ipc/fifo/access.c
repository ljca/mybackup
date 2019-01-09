#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>

int main(int argc,char **argv)
{
  if(argc != 2){
    fprintf(stderr,"Usage: %s <file>\n",*argv);
    return EXIT_FAILURE;
  }
  printf("%s\n",access(*++argv,F_OK) != 0 ? "FAILED" : "OK");
  return 0;
}

