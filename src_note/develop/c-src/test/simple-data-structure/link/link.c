#include "link.h"

static void init_linklist()
{
  /* create Initinal node */
  // LinkList *node = NULL;
  // if(!(node = (LinkList *)malloc(sizeof(LinkList)))){
  //   perror("genary memory error");
  // }
  LinkList node = {
    .index = 1,
    .next = NULL,
  };
}

struct LinkList *
addnode(LinkList *phead,int data)
{
  phead = NULL;
  phead->index = data;
  return NULL;
}

struct LinkList *
addnode_to_head(LinkList *phead,int data)
{
  LinkList *new_head = NULL;
  if(!(new_head = (LinkList *)malloc(sizeof(LinkList)))){
    perror("genary memeory error");
    return NULL;
  }
  new_head->index = data;
  new_head->next = phead;
  return new_head;
}

void addnode_to_tail(LinkList **phead,int data)
{
  LinkList *ptail = *phead;

  struct LinkList *new_tail = NULL;
  if(!(new_tail = (LinkList *)malloc(sizeof(LinkList)))){
    perror("genary memory error");
    return;
  }
  while(ptail->next){
    ptail = ptail->next;
  }
  new_tail->index = data;
  new_tail->next = NULL;
  ptail->next = new_tail;

}

unsigned int count_node(LinkList *phead)
{
  if(!phead) return 0;
  unsigned int count = 1;
  while(phead){
    count++;
    phead = phead->next;
  }
  return count;
}

void sort_linklist(LinkList *phead)
{
  phead = NULL;
}

int destory_linklist(LinkList *phead)
{
  if(!phead) return -1;
  LinkList *tmp = NULL;
  tmp = phead->next;
  while(phead->next){
    free(phead);
    tmp = phead->next;
    phead = tmp;
  }
  return 0;
}

void clean_linklist_node(LinkList *phead)
{
  phead = NULL;
}

/* vim:set et: */
