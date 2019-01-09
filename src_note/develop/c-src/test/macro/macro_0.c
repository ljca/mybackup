#include <stdio.h>
#define SEC_A_YEAR (365UL*24*60*60)

int main()
{
	const unsigned long sec_a_year = 365UL*60*60*24;
	const int arry = 3;
	int array[arry] = 0;
	printf("SEC_A_YEAR = %ld\n",SEC_A_YEAR);
	printf("SEC_A_YEAR = %ld\n",sec_a_year);
}
