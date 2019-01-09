#include "sum.h"

int sum(int n)
{
  int i = 0,sum = i;
  for(;i < n;++i,sum += i) ;
  return sum;
}

int acc_add(int n)
{
	return (n + 1L) * n / 2;
}

int acc_add1(int n)
{
	int sum = 0, i = 0;
	for(;i <= n;i++) sum += i;
	return sum;
}
