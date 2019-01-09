#include <stdio.h>


int main()
{
  int arry[] = {52,192,12,68,29,192,64};
  int len = sizeof(arry)/sizeof(arry[0]);
  int first,end,tmp;
  first = 0;
  end = len - 1;
  tmp = arry[first];
#if 0
  if(tmp > arry[end]);
  first++;
  tmp arry[first];

#endif
  printf("-----------------\n");
  printf("tmp = %d\n",tmp);
  printf("arry[%d] = %d\n",end,arry[end]);
  //tmp > arry[end];
  while(end > first && tmp <= arry[end]) --end;
 
  //printf("first = %d\n",first);
  printf("end = %d\n",end);
  printf("tmp = %d\n",tmp);
  printf("arry[%d] = %d\n",end,arry[end]);

  printf("-----------------\n");
  printf("tmp = %d\n",tmp);
  printf("arry[%d] = %d\n",end,arry[end]);
  while(first < end && tmp >= arry[first]) ++first;
  
  printf("first = %d\n",first);
  printf("tmp = %d\n",tmp);
  //printf("end = %d\n",end);
  printf("arry[%d] = %d\n",first,arry[first]);
}

