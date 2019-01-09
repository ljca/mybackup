#include <stdio.h>
#include <linux/fb.h>
#include <sys/ioctl.h>
#include <fcntl.h>
#include <unistd.h>
#include <sys/errno.h>
#include <string.h>

int main()
{
  int fd;
  if((fd = open("/dev/fb0",O_RDONLY) == -1)){
    perror("open /dev/fb0 error");
    //return EACCES;
  }
  printf("%d\n",fd);
  struct fb_var_screeninfo screen_info;
  bzero(&screen_info,sizeof(screen_info));
  ioctl(fd,FBIOGET_VSCREENINFO,&screen_info);
  printf("width = %d,heihgt = %d\n",screen_info.xres,screen_info.yres);
  close(fd);
}
