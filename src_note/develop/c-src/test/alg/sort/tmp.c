#include <stdio.h>

int main()
{
  int num[] = {9102,95,2910,22,3232,172,29,2922};
#define NUM_LEN ((sizeof(num)/sizeof(num[0])))
  static const int num_len = sizeof(num) / sizeof(num[0]);
  printf("arr length = %ld\n",NUM_LEN);
  printf("num_len = %d\n",num_len);
  static int i = 0;
  for(;i < num_len;i++) printf("num[%d] = %d\n",i,num[i]);
  /*  数组排序 */
  int j = num_len - 1,tmp;
  for(i = 0;i < num_len - 1;i++){
    for(j = num_len - 1;j > i;j--){
      if(num[j - 1] > num[j]){
        tmp = num[j];
        num[j] = num[j - 1];
        num[j - 1] = tmp;
      }
    }
  }
  
  puts("");
  for(i = 0;i < num_len;i++) printf("num[%d] = %d\n",i,num[i]);
}

