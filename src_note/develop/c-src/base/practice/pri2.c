#include <stdio.h>

int main(void)
{
	int x = 10; int	y=0;
	if(x<1) {y=x; printf("y=%d\n",y); } 
	else if((x>1||x==1)&&x<10) { y = (2*x+1); printf("y=%d\n",y); }
	else if(x>10||x==10) { y = (3*x-11); printf("y=%d\n",y); }
	return 0;
}
