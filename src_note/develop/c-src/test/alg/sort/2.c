#include <stdio.h>

int main()
{
  int a[5] ={7,5,8,3,9};
  int i=0,j =0,tmp =0;
  for(i =0;i<5;i++)
  {
    for(j =i+1;j<5;j++){
      if(a[i]>a[j]){
        tmp = a[i];
        a[i]=a[j];
        a[j] =tmp;
      }
    }
  }
  for(i=0;i<5;i++){
    printf("%d\n",a[i]);
  }
  return 0;
}
