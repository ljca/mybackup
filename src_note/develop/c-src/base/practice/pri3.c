#include <stdio.h>

int main(void)
{
	int i = 20,j=3;int *i_po = &i,*j_po=&j;
	printf("i=%d\n",i);printf("j=%d\n",j);
	printf("i+j=%d\n",i+j);
	printf("i-j=%d\n",i-j);
	printf("i*j=%d\n",i*j);
	printf("i/j=%d\n",i/j);
	printf("i%j=%d\n",i%j);
	/* 
	 *
	 */
	
	printf("i address is:%p\n",i_po);
	printf("j address is:%p\n",j_po);
	printf("i+j=%d\n",/*加*/*i_po+*j_po);
	printf("i-j=%d\n",/*减*/*i_po-*j_po);
	printf("i*j=%d\n",/*乘*/*i_po**j_po);
	printf("i/j=%d\n",/*除*/*i_po/(*j_po));
	printf("i%%j=%d\n",/*求余*/*i_po%*j_po);
	return 0;
}
