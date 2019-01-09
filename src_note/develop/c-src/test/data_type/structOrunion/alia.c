#include <stdio.h>

struct node{
	char *name;
	struct node *next;
}node; //sizeof(struct node) = 16bytes?

struct Node{
	short sint; // sizeoof(sint) = 2bytes
	int num; // sizeof(num) = 4bytes
	char c; // sizeof(c) = 1bytes ==> 2bytes
	long lnum; // sizeof(lnum) 8bytes
}Node = { // sizeof(Node) = 16bytes? 20bytes? 24bytes?
	.sint = 2,
	.c = 'c',
	.lnum = 10,
	.num = 20,
};

int main()
{
	printf("sizeof(Node.sint) = %d\n",sizeof(Node.sint));
	printf("sizeof(Node.c) = %d\n",sizeof(Node.c));
	printf("sizeof(long long) = %d\n",sizeof(long long));
	printf("sizeof(Node.lnum) = %d\n",sizeof(Node.lnum));
	printf("sizeof(Node.num) = %d\n",sizeof(Node.num));
	printf("sizeof(struct Node) = %d\n",sizeof(struct Node));
	printf("sizeof(struct node) = %d\n",sizeof(struct node));
}
