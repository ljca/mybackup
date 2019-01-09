#include <stdio.h>
#include "sum.h"
#include "narcissus.h"

int main()
{
	int n = 100;
	printf("1 + 2 + 3 + .... + %d = %d\n",n,sum(n));
	printf("1 + 2 + 3 + .... + %d = %d\n",n,acc_add(n));
	printf("1 + 2 + 3 + .... + %d = %d\n",n,acc_add1(n));
  int (*num)[5] = {NULL};
  //num = (int (*)[5])malloc(sizeof(num));
  num = narcissus();
  free(num);
  num = NULL;
}
