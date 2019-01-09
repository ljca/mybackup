#include <sys/ioctl.h>
#include <fcntl.h>
#include <unistd.h>

int main(int argc,char *argv[])
{
  ledoff();
  return 0;
}

int ledon()
{
  int fd;
  if((fd = open("/dev/tiny4412led_misc",O_RDWR)) < 0){
	return -1;
  }
  if(ioctl(fd,1) < 0){
	return -2;
  }
  return 1;
}

int ledoff()
{
  int fd;
  if((fd = open("/dev/tiny4412led_misc",O_RDWR)) < 0){
	return -1;
  }
  if(ioctl(fd,0) < 0){
	return -2;
  }
  return 1;
}

