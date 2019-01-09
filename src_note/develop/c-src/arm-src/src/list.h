
#ifndef  _LIST_H_
#define  _LIST_H_

struct node  {
	/*struct */node *next;
	virtual void show(){}
	virtual int comp(node *,node *){}
};

void  insert(node  **h,  node  *new_h);
void show_list(node *);

//1. 在h链表中查找，将零个、一个或多个查找结果以链表的形返回
//2. 查找的参数在第三个参数d中确定；
struct node *search(node *h, node *d );

#endif

