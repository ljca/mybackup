
#ifndef  _LIST_H_
#define  _LIST_H_

struct node  {
	struct node *next;
};

void  insert(struct node  **h,  struct node  *new  );
void show_list(struct node *h,   void (*show)(struct node *)  );


#endif

