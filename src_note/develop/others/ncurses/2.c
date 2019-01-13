#include <ncurses.h>

int main()
{
	if(initscr() == NULL) return -1;
	raw();
	keypad(stdscr,TRUE);
	noecho();
	printw("pressed Enter ther any key(but can\'t be F9- F12): \nEnter the q quit\n");
	int ch;
	while((ch = getch()) != 'q'){
		switch(ch){
			case KEY_F(1):
				printw("F1 Key pressed\n");
				break;
			case KEY_F(2):
				printw("F2 Key pressed\n");
				break;
			case KEY_F(3):
				printw("F3 Key pressed\n");
				break;
			case KEY_F(4):
				printw("F4 Key pressed\n");
				break;
			case KEY_F(5):
				printw("F5 Key pressed\n");
				break;
			case KEY_F(6):
				printw("F6 Key pressed\n");
				break;
			case KEY_F(7):
				printw("F7 Key pressed\n");
				break;
			case KEY_F(8):
				printw("F8 Key pressed\n");
				break;
			case KEY_F(9):
				printw("F%d Key pressed\n",KEY_F(9));
				break;
			case KEY_F(10):
				printw("F%d Key pressed\n",KEY_F(10));
				break;
			default:
				printw("The pressed key: ");
				attron(A_BOLD);
				printw("%c\n",ch);
				attroff(A_BOLD);
		}
	}
	refresh();
	endwin();
	return 0;
}
