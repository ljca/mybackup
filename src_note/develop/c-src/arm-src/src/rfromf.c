/*
* File Name: file_read4.c
* Create Date: 2016年12月05日 星期一 11时20分13秒
*/
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

struct readFF
{
  int num;
  char str[15];
  struct readFF *next;
};


int
main ()
{
  return 0;
}

void
readed ()
{
  FILE *fp = NULL;
  fp = fopen ();
  if (NULL != fp)
    {
      int n;
      getline ();
      fclose (fp);
    }
}
