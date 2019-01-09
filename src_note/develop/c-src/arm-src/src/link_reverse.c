#include "link.h"
Dog link_reverse(Dog h)
{
	Dog tmp = NULL;
	Dog old_h = h;
	while(h)
	{
		old_h = old_h->next;
		h->next=tmp;
		tmp = h;
		h=old_h;
	}
	return tmp;
}
