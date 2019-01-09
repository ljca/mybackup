
#ifndef  _LIST_H_
#define  _LIST_H_

struct node  {
	struct node *next;
};

void  insert(struct node  **h,  struct node  *new  );
void show_list(struct node *h,   void (*show)(struct node *)  );

//1. 在h链表中查找，将零个、一个或多个查找结果以链表的形返回
//2. 查找的参数在第三个参数d中确定；
struct node *search(struct node *h,  int (*comp)(struct node *, struct node *), struct node *d );

#endif

