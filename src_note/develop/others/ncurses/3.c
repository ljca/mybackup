#include <curses.h>

WINDOW *cre_win(int height,int width,int x,int y)
{
	WINDOW *local_win;
	local_win = newwin(height,width,x,y);
	box(local_win,0,0); 
	wrefresh(local_win); /*刷新窗口缓冲，显示box */
	return local_win;
}

void destroy_win(WINDOW *local_win)
{
	wborder(local_win,'|','|','-','-','+','+','+','+');
	wrefresh(local_win);
	delwin(local_win);
}

int main()
{
	WINDOW *win;
	int x,y,width,height;
	int ch;
	if(initscr() == NULL) return -1;
	cbreak();
	keypad(stdscr,TRUE);
	height = 3,width = 10;
	x = (LINES - height) / 2;
	y = (COLS - width) / 2;
	printw("press q exit\n");
	refresh();
	if((win = cre_win(height,width,y,x)) == NULL) return -1;
	while((ch = getch()) != 'q'){
		switch(ch){
			case KEY_LEFT:
				destroy_win(win);
				win = cre_win(height,width,y,--x);
				break;
			case KEY_RIGHT:
				destroy_win(win);
				win = cre_win(height,width,y,++x);
				break;
			case KEY_UP:
				destroy_win(win);
				win = cre_win(height,width,--y,x);
				break;
			case KEY_DOWN:
				destroy_win(win);
				win = cre_win(height,width,++y,x);
				break;
		}
	}
	endwin();
	return 0;
}
