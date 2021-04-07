#include <stdlib.h>
#include <stdio.h>
#include <errno.h>

typedef struct node{
  int index;
  struct node *next;
}node;

node *
link_sort(node *pnode)
{
  node *min_pre,*min;
  node *tmp;
  node *new_head;
  tmp = min = pnode;
  new_head = min_pre = NULL;
  while(pnode){
    min = pnode;
    tmp = pnode;
    min_pre = NULL;
    while(tmp->next){
      if(tmp->next->index < min->index){
        min = tmp->next;
        min_pre = tmp;
      }
      tmp = tmp->next;
    }
    if(min == pnode){
      pnode = pnode->next;
      min->next = NULL;
    }else{
      min_pre->next = min->next;
      min->next = NULL;
    }
    min->next = new_head;
    new_head = min;
  }
  return new_head;
}

node *
insert_node_head(node *head,int index)
{
  node *phead = head;
  if(!(phead = (node *)malloc(sizeof(node)))){
    perror("malloc called error");
    exit(ENOMEM);
  }
  phead->index = index;
  phead->next = head;
  return phead;
}

void print_node(node *node)
{
  while(node){
    printf("node->index = %d\n",node->index);
    node = node->next;
  }
}

int main(void)
{
  node *Node = NULL;
  Node = insert_node_head(Node,10);
  Node = insert_node_head(Node,48);
  Node = insert_node_head(Node,2);
  Node = insert_node_head(Node,24);
  Node = insert_node_head(Node,69);
  print_node(Node);
  Node = link_sort(Node);
  print_node(Node);
}

