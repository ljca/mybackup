#include "link.h"
void del_link1(Dog tmp,int n)
{
	Dog head = tmp;
	Dog prev = head->next;
	while(prev)
	{
		if(n==prev->n)
		{
			head->next=prev->next;
			free(prev);
			return;
		}
		else
		{
			head = prev;
			prev = prev->next;
		}
	}
}
