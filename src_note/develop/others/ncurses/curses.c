#include <curses.h>
#include <unistd.h>

int main()
{
	if(initscr() == NULL) return -1;
	cbreak();
	//int ch;
	//while((ch = getch()) != 'q'){
	//	switch(ch){
	//		case KEY_LEFT:
	//			break;
	//	}
	//}
	start_color();
	init_pair(1,COLOR_CYAN,COLOR_BLACK);
	WINDOW *win;
	win = newwin(10,5,30,30);
	box(win,0,0);
	//wborder(win,'+','+','-','-','-','-','-','-');
	wrefresh(win);
	refresh();
	sleep(10);
	delwin(win);
	endwin();
	return 0;
}
