/*
* File Name: file_read3.c
* Create Date: 2016年12月02日 星期五 09时24分26秒
*/
#include <stdio.h>
#include <string.h>
#include <stdlib.h>

#ifndef _TMP_
#define _TMP_
struct Tmp
{
  char *name;
  int count;
  struct Tmp *next;
};

#endif
void read_f (char *);

int
main (int argc, char *argv[])
{
  if (argc == 1)
    return;
  read_f (argv[1]);
  return 0;
}

void
read_f (char *path)
{
  FILE *fp = NULL;
  fp = fopen (path, "r");
  if (NULL != fp)
    {
      //char buf[500] = "";
      //fread(buf,100,5,fp);
      char *p = NULL;
      int n = 0;
      int ret = 0;
      int tmp = 0;
      int num = 0;
      //Tmp *tmp = (struct Tmp)malloc(sizeof(struct Tmp));
      //printf("This File is: %s,Time %s %s\n",__FILE__,__DATE__,__TIME__);
      while (-1 != (ret = (getline (&p, &tmp, fp))))
	{
	  printf ("%d %s", ++n, p);
	  num += ret;
	}
      printf ("\nTotal characters: %d bytes.\n", num);
      printf ("Total line: %d lines.\n", n);
      //strtok(p," ");
      //char *tmp_str = "";
      //while(tmp_str=strtok(p," ")){
      //      tmp->name=tmp_str;
      //      tmp->count=atoi(tmp_str);
      //      p=NULL;
      //}
      free (p);
      fclose (fp);
    }
  else
    {
      perror ("");
      return;
    }
}
