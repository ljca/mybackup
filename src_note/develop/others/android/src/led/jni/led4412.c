#include <jni.h>
#include <sys/ioctl.h>
#include <fcntl.h>
#include <unistd.h>

jint Java_led_test_Led_ledon(JNIEnv *env,jobject job,jint ledarg)
{
  int fd;
  if((fd = open("/dev/tiny4412led",O_RDWR)) < 0){
    return -1;
  }
  if(ioctl(fd,100,ledarg) < 0){
    return -2;
  }
  close(fd);
  return 0;
}

jint Java_led_test_Led_ledoff(JNIEnv *env,jobject job,jint ledarg)
{
  int fd;
  if((fd = open("/dev/tiny4412led",O_RDWR)) < 0){
    return -1;
  }
  if(ioctl(fd,101,ledarg) < 0){
    return -2;
  }
  close(fd);
  return 0;
}

jint Java_led_test_Led_buzon(JNIEnv *env,jobject job)
{
  int fd;
  if((fd = open("/dev/tiny4412led",O_RDWR)) < 0){
    return -1;
  }
  if(ioctl(fd,102) < 0){
    return -2;
  }
  close(fd);
  return 0;
}

jint Java_led_test_Led_buzoff(JNIEnv *env,jobject job)
{
  int fd;
  if((fd = open("/dev/tiny4412led",O_RDWR)) < 0){
    return -1;
  }
  if(ioctl(fd,103) < 0){
    return -2;
  }
  close(fd);
  return 0;
}

/* vim:set ft=c ts=2 st=2 */
