#include "link.h"
void show(Dog head)
{
	while(head != NULL)
	{
		printf("head->n=%d\n",head->n);
		head = head->next;
	}
}
