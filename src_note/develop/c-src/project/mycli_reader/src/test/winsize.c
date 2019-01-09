#include <stdio.h>
#include <unistd.h>
#include <termios.h>
#include <sys/ioctl.h>

int main()
{
  struct winsize w_size;
  ioctl(STDIN_FILENO,TIOCGWINSZ,&w_size);
  printf("rows = %d,cols = %d\n",w_size.ws_row,w_size.ws_col);
  printf("x = %d,y = %d\n",w_size.ws_xpixel,w_size.ws_ypixel);
}
