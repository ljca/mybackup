#include <unistd.h>
#include <stdlib.h>
#include <curses.h>
#include <string.h>

#define LEN 128

int main()
{
  initscr();

  move(5,10);
  printw("Please login: ");

  move(7,10);
  printw("User name: ");
  char name[LEN];
  getstr(name);

  move(8,10);
  printw("Password: ");
  refresh();

  cbreak();
  noecho();

  int i = 0;
  char passwd[LEN];
  bzero(passwd,LEN);
  while(i < LEN){
    passwd[i] = getch();
    if(passwd[i] == '\n') break;
    move(8,20 + i);
    addch('*');
    refresh();
    i++;
  }

  echo();
  nocbreak();
  char *real_passwd = "xzyxx";
  move(11,10);
  if(strncmp(real_passwd,passwd,strlen(real_passwd)) == 0) printw("Correct");
  else printw("Wrong");

  printw(" Password");
  refresh();
  sleep(2);

  endwin();
  exit(EXIT_SUCCESS);
}

