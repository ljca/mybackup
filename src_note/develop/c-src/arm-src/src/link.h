#ifndef __LINK_H
#define __LINK_H
#include <stdio.h>
#include <stdlib.h>
typedef struct dog
{
	int n;
	struct dog *pre;
	struct dog *next;
}*Dog;
Dog insert_head(Dog,int);
Dog insert_tail(Dog,int);
void find_link(Dog,int);
Dog del_link(Dog,int);
Dog link_reverse(Dog);
Dog link_sort(Dog);
Dog find_max(Dog);
void show(Dog);
void dou_link(Dog);
#endif
