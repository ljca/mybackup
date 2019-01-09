#include <termios.h>
#include <stdio.h>

int main()
{
  struct termios old_term,new_term;

  char pwd[8] = {0};

  tcgetattr(fileno(stdin),&old_term);

  new_term = old_term;

  new_term.c_lflag &= ~ECHO;

  puts("enter your password: ");
  
  if(tcsetattr(fileno(stdin),TCSAFLUSH,&new_term) != 0){
    perror("error");
  }else{
    fgets(pwd,8,stdin);
    tcsetattr(fileno(stdin),TCSANOW,&old_term);
    fprintf(stdout,"password is %s\n",pwd);
  }
}

