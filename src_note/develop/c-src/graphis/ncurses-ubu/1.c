#include <stdlib.h>
#include <curses.h>
#include <unistd.h>

int main(int argc,char **argv)
{
  if(initscr() == NULL){
	perror("initscr");
	return -1;
  }
  printw("This is a curses window\n");
  printw("Going bye-bye now\n");
  refresh();
  sleep(3);

  endwin();
  exit(0);
}

