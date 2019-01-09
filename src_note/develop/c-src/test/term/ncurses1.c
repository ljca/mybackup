#include <stdio.h>
#include <curses.h>
#include <unistd.h>

int main()
{
  WINDOW *win;
  if(!(win = initscr())){
    perror("init scr error");
  }

  //move(1,1);

  printw("nucrses called.\n");

  refresh();

  //beep();

  flash();
  refresh();

  sleep(2);
  clear();

  move(LINES - 1,0);
  refresh();
  //leaveok(win,true);
  sleep(1);

  move(0,COLS - 1);
  refresh();
  //leaveok(win,true);
  sleep(1);

  move(LINES - 1,COLS - 1);
  refresh();
  //leaveok(win,true);
  sleep(1);
  move(0,0);
  sleep(1);

  endwin();
}

