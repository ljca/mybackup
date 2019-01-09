#include "link.h"
void find_link(Dog tmp,int n)
{
	int i=0;
	while(tmp->next)
	{
		i++;
		if(n==tmp->n)
		{
			printf("tmp Found in %d\n",i);
		}
		tmp=tmp->next;
	}
}
