#include "link.h"
Dog insert_head(Dog head,int n)
{
	Dog tmp= (Dog)malloc(sizeof(struct dog));
	tmp->n = n;
	tmp->next = head;
	return tmp;
}
