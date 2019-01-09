#include "link.h"
Dog del_link(Dog head,int n)
{
	Dog tmp = head;
	Dog found = head;
	while(tmp->next)
	{
		if(n==tmp->n)
		{
			found = head;
			head = head->next;
			tmp=head;
			free(found);
			//break;
		}
		else if(n==tmp->next->n)
		{
			//printf("%d\n",tmp->next->n);
			//break;
			found = tmp->next;
			tmp->next=tmp->next->next;
			free(found);
		}
		else
		{
			tmp = tmp->next;
		}
	}
	return head;
}
