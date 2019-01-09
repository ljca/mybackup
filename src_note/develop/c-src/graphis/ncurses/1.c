#include <ncurses.h>
int main()
{
	if(initscr() == NULL){
		return -1;
	}
	printw("Hello World!!!\n");
	refresh();
	getchar();
	endwin();
	return 0;
}
