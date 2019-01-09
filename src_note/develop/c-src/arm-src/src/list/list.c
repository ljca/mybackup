#include "list.h"
#include <stdio.h>

void insert(struct node **h,struct node *new_h)
{
	*h = new_h->next;
}

void show_list(struct node *h,void (*show)(struct node *))
{
	struct node *tmp;
}
