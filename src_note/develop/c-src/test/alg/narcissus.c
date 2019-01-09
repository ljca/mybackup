#include "narcissus.h"
#include <stdio.h>
void narcissus_2();

//int (* narcissus() )[5]
int main()
{
  int num = 100,(*narcissus_num)[5] = {NULL};
  int tmp[3] = {0};
  narcissus_num  = (int (*)[5])calloc(5,sizeof(int));
  // narcissus_num = (int (*)[5])malloc(5 * sizeof(int *));
    int i = 0,count = 0;
	for(;num <= 999;num++){
		int x = num / 100;
		int y = num % 100 / 10;
		int z = num % 10;
    if(num == x*x*x + y*y*y + z*z*z){
      //if(num == pow(x,3) + pow(y,3) + pow(z,3)){
      printf("数%d是水仙花数!\n",num); 
      *(narcissus_num[i]) = num;tmp[i] = num;++i;
      count++;//*(*(narcissus_num + i)) = num;
    }
    //if(i > count) break;
	}

  for(i = 0;i < count;i++){
      printf("数%d是水仙花数!\n",tmp[i]);
  }

  printf("narcissus number is：");
  for(i = 0;i < 5;i++){
    if(*(narcissus_num + i)) printf("%d ",*(*(narcissus_num + i)));
  }
  printf("\n");
  free(narcissus_num);
  narcissus_num = NULL;
  narcissus_2();
//return narcissus_num;
}

void narcissus_2()
{
  unsigned int i = 0,j = 0,k = 1;
  printf("narcissus number is：");
  for(;i < 10;i++)
    for(;j < 10;j++)
      for(;k < 10;k++){
        if((k * 100 + j * 10 + i) == (i * i * i + j * j * j + k * k * k)){
          printf("%u\n",k * 100 + j * 10 + i);
        }
      }
    puts("");
}

