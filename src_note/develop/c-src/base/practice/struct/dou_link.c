#include <stdio.h>
#include <stdlib.h>
typedef struct Person
{
	int age;
	char *name;
	struct Person *pre;
	struct Person *next;
}*person;
void dou_link(person p);

int main()
{
	person p = (person)malloc(sizeof(struct Person)); 
	dou_link(p);
	return 0;
}

void dou_link(person p1)
{
	person head = p1;
	person p1_pre=p1->pre = NULL;// p1->next->p1_pre=p1;
	person p1_next = p1->next;
}
