#include <stdio.h>
#include <stdlib.h>
typedef struct Node{
	int num;
	struct Node *next;
}node;

node *insert_head(node *,int);

void show(node *);

int main()
{
	node *nodes = NULL;
	nodes = insert_head(nodes,5);
	nodes = insert_head(nodes,6);
	nodes = insert_head(nodes,1);
	nodes = insert_head(nodes,2);
	nodes = insert_head(nodes,9);
	nodes = insert_head(nodes,8);
	nodes = insert_head(nodes,5);
	nodes = insert_head(nodes,7);
	show(nodes);
	//free(nodes);
	return 0;
}

node *insert_head(node *nods,int n)
{
	node *new_node = (node *)malloc(sizeof(node));
	new_node->num=n;
	new_node->next=nods;
	return new_node;
}
void show(node *h)
{
	node *nodes=h;
	while(nodes){
		printf("node nuber %d\n",nodes->num);
		nodes=nodes->next;
	}
}
