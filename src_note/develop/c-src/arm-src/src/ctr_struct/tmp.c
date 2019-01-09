#include <stdio.h>
int main(void)
{
	int i = 1,*p = &i;
	int **p_i=&p;
	printf("%d\n",*p);
	printf("%p\n",&i);
	printf("%p\n",p);
	printf("p addr:%p\n",&p);
	printf("*(&p)%p\n",*(&p));
	p=NULL;
	printf("p addr:%p\n",p);
	printf("p addr:%p\n",&p);
	printf("p addr:%p\n",(&p)+1);
	char *p2="char";
	printf("p2 addr:%p\n",(&p2)+1);
	return 0;
}
