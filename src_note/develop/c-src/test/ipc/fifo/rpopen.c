#include <stdio.h>
#include <stdlib.h>

int main(int argc,char **argv)
{
  if(argc != 2){
    fprintf(stderr,"Usage: %s <command>\n",*argv);
    return EXIT_FAILURE;
  }
  FILE *fp;
  if(!(fp = popen(*++argv,"r"))){
    perror("");
  }
  char buf[BUFSIZ] = {0};
  if(fread(buf,sizeof(char),sizeof(buf),fp) > 0) puts(buf);
  pclose(fp);
  return 0;
}

