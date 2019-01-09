#include <curses.h>

int main()
{
  WINDOW *win;
  if((win = initscr()) == NULL) return -1;
  //wprintw(win,"Hi There!!!\n");
  addch(getchar()|A_BOLD|A_UNDERLINE);
  printw("\n");
  mvaddch(100,100,getchar()|A_BOLD|A_UNDERLINE);
  printw("\n");
  refresh();
  sleep(3);
  endwin();
  return 0;
}
