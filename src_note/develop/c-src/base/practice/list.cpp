#include <stdio.h>
#include "list.h"
/*
* void  insert(struct node  **h,  struct node  *new  );
* void show_list(struct node *h,   void (*show)(struct node *)  );
* 
* //1. 在h链表中查找，将零个、一个或多个查找结果以链表的形返回
* //2. 查找的参数在第三个参数d中确定；
* struct node *search(struct node *h,  int (*comp)(struct node *, struct node *), struct node *d );
*/

//node::node()
//{
//	next=NULL;
//}
void insert(node **h,node *new_h)
{
	while(*h){
		h=&((*h)->next);
	}
	//h=&new_h; 
	*h=new_h; 
}

void show_list(node *h)
{
	while(h)
	{
		h->show();
		h=h->next;
	}
}

