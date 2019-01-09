#include <unistd.h>
#include <stdio.h>
#include <termios.h>

char *menu_str[] = {
  "j - ",
  "k - ",
  "b - ",
  "n - ",
  "<Space> ",
  "a - ",
  "q - Quit.",
  NULL
};

int getchoice(char *choices[],FILE *in,FILE *out)
{
  int choice = 0;
  int selected;
  char **option;
  do{
    fprintf(out,"Chooise: Please select action: \n");
    option = choices;
    while(*option){
      fprintf(out,"%s\n",*option);
      option++;
    }
    do{
      selected = fgetc(in);
    }while(selected == '\n' || selected == '\r');
    option = choices;
    while(*option){
      if(selected == *option[0]){
        choice = 1;
        break;
      }
      option++;
    }
    if(!choice) fprintf(out,"incorrect choice, select again\n");
  }while(!choice);
  return selected;
}

int main()
{
  struct termios old_term,new_term;

  FILE *in,*out;

  if(!(in = fopen("/dev/tty","r")) || !(out = fopen("/dev/tty","w"))){
    perror("error");
    return;
  }

  tcgetattr(fileno(in),&old_term);

  new_term = old_term;

  new_term.c_lflag &= ~ECHO;
  new_term.c_lflag &= ~ICANON;
  new_term.c_lflag &= ~ISIG;
  new_term.c_cc[VMIN] = 1;
  new_term.c_cc[VTIME] = 0;

  if(tcsetattr(fileno(in),TCSANOW,&new_term) != 0){
    perror("error");
  }
  
  int choice = 0;

  do{
    choice = getchoice(menu_str,in,out);
    printf("choice is %c\n",choice);
  }while(choice != 'q');

  tcsetattr(fileno(in),TCSANOW,&old_term);
}

