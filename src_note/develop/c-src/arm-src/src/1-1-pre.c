#include <stdio.h>
int main(void)
{
	int i=1,j=2;
	printf("i=%d,j=%d\n",i,j);
	printf("i addr is:%#X\nj addr is:%#X\n",&i,&j);
	printf("%d+%d=%d\n",i,j,*(&i)+*(&j));
	printf("%d-%d=%d\n",i,j,*(&i)-*(&j));
	printf("%d*%d=%d\n",i,j,*(&i)**(&j));
	printf("%d/%d=%d\n",i,j,*(&i)/(*(&j)));
	printf("%d%%%d=%d\n",i,j,*(&i)%*(&j));
	return 0;
}
