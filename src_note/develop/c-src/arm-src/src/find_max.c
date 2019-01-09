#include "link.h"

Dog find_max(Dog h)
{
	Dog max = h;
	Dog tmp=h;
		while(tmp)
		{
			if(max->n < tmp->n)
			{
				max = tmp;
			}
			tmp=tmp->next;
		}
		printf("max->n is %d\n",max->n);
	return max;
}
