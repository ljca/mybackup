/*
 * =====================================================================================
 *
 *       Filename:  findstr.c
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017年03月30日 16时38分30秒
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  YOUR NAME (), 
 *   Organization:  
 *
 * =====================================================================================
 */

#include <stdio.h>
#include <string.h>

int main(int argc,char **argv)
{
  if(argc != 2){
    perror("");
    //return -1;
  }
  //argv[1];
  char *str; 
  if((str = strstr("hello world world","or"))){
    printf("%s\n",str);
  }

  return 0;
}
