#include<stdio.h>
#include "pra1.h"

//#pragma message "hello,compoie"
int main(void)
{
#ifdef TITLE
  printf("%s\n",TITLE);
#endif
#ifdef _LINE_
  printf("This is%dLine\n",_LINE_);
#endif
#ifdef _FILE_
  printf("File is%s\n",_FILE_);
#endif
#ifdef _DATE_
  printf("Current Time is%s\n",_DATE_);
#endif
  return 0;
}
