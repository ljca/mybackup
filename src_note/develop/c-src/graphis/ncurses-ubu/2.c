#include <curses.h>

int main()
{
  if(initscr() == NULL) return -1;
  printw("enter the key(but can\'t be F9-F12)\nenter the q quit!\n");
  raw();
  keypad(stdscr,TRUE);
  noecho();
  int ch;
  while((ch = getch()) != 'q'){
	switch(ch){
	  case KEY_F(1):
		printw("KEY: F1\n");
		break;
	  case KEY_F(2):
		printw("KEY: F2\n");
		break;       
	  case KEY_F(3): 
		printw("KEY: F3\n");
		break;       
	  case KEY_F(4): 
		printw("KEY: F4\n");
		break;      
	  case KEY_F(5):
		printw("KEY: F5\n");
		break;       
	  case KEY_F(6): 
		printw("KEY: F6\n");
		break;        
	  case KEY_F(7):  
		printw("KEY: F7\n");
		break;         
	  case KEY_F(8):   
		printw("KEY: F8\n");
		break;
	  default:
		printw("KEY: ");
		attron(A_BOLD);
		printw("%c\n",ch);
		attroff(A_BOLD);
		refresh();
		break;
	}
  }
  endwin();
}

