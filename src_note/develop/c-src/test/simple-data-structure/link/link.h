#ifndef __LINK_H_
#define __LINK_H_
typedef struct LinkList{
  int index;
  struct LinkList *next;
}LinkList;

static void init_linklist();

struct LinkList *
addnode(LinkList *phead,int data);

struct LinkList *
addnode_to_head(LinkList *phead,int data);

unsigned int count_node(LinkList *phead);
void sort_linklist(LinkList *phead);

int destory_linklist(LinkList *phead);

void clean_linklist_node(LinkList *phead);

#include <stdlib.h>
#include <stdio.h>

#endif
/* vim:set ft=c st=2 et: */
