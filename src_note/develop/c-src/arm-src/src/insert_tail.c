#include "link.h"
Dog insert_tail(Dog head,int n)
{
	Dog tmp=head;
	Dog tail=(Dog)malloc(sizeof(struct dog));
	tail->n=n;
	tail->next=NULL;
	if(NULL==tmp) // 如果没有头指针,新的指针成为头指针
	{
		head=tail;
	}
	else
	{
		while(tmp->next)
		{
			tmp=tmp->next;
		}
		tmp->next=tail;
	}
	return head;
}

