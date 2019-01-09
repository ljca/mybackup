#include <term.h>
#include <curses.h>
#include <stdio.h>
#include <stdlib.h>

int main()
{
  setupterm(NULL,fileno(stdout),NULL);
  printf("lines = %d，cols = %d\n",tigetnum("lines"),tigetnum("cols"));
  printf("cups = %s\n",tigetstr("cup"));
  printf("Done.\n");
  //putp(tparm(tigetstr("cup"),0,0));
  putp(tigetstr("clear"));
  exit(0);
}

