#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <curses.h>
#include <string.h>

int main()
{
  const char whtch_one[] = " First Witch ";
  const char whtch_two[] = " Second Witch ";
  const char *scan_str;


  if(!initscr()){
    perror("init scr error");
    exit(EXIT_FAILURE);
  }

  scan_str = whtch_one + strlen(whtch_one) - 1;
  attron(A_BOLD);
  printw("scan_str = %s\n",scan_str);
  printw("whtch_one = %s\n",whtch_one);
  printw("whtch_two= %s\n",whtch_two);

  printw("%d\n",strlen(whtch_one));
  printw("%d\n",strlen(whtch_two));
  attroff(A_BOLD);
  refresh();
  sleep(1);
  move(8,15);
  attron(A_STANDOUT);
  printw("Thunder and Lightning");
  attroff(A_STANDOUT);
  refresh();
  sleep(1);

  move(10,10);
  printw("When shall we three meet aagin");
  refresh();

  attron(A_DIM);
  while(scan_str != whtch_one){
    move(10,10);
    insch(*scan_str--);
  }
  refresh();
 // printw("%c %c\n",ACS_VLINE,ACS_HLINE);
 // refresh();
  attroff(A_DIM);
  sleep(3);

  endwin();
  exit(EXIT_SUCCESS);
}

