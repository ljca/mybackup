#include "list.h"
#include <stdio.h>
#include <stdlib.h>

struct Dog{
	int color;
	int type;
	struct node no;
};
struct node *nodes;
struct Dog dogs;
int comp_color(struct node *arg,struct node *cur)
{
	struct dog *d,*a;
	d = container_of(arg,struct dog,no);
	a = container_of(cur,struct dog,no);
	if(a->color == d->color){
		return 0;
	}
	return 1;
}

struct node *new_link = search(nodes,comp_color,&dogs.no);

int main()
{
	return 0;
}
