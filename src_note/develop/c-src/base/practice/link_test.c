#include <stdio.h>
#include <stdlib.h>
struct Number{
	int nu;
	struct Number *next;
};
struct Number *insert_h(struct Number *tmp,int n)
{
	struct Number *new_h = (struct Number *)malloc(sizeof(struct Number));
	//if(tmp==NULL){
	//	tmp->nu=nu;
	//	tmp->next=NULL;
	//}else{
	new_h->nu = n;
	new_h->next = tmp;
	//}
	return new_h;
}

void show(struct Number *num)
{
	while(num){
		printf("%d ",num->nu);
		num = num->next;
	}
	printf("\n\n");
}

int main()
{
	struct Number *num1 = NULL;
	int i = 0,j = 0;
	struct Number *num2 = NULL;
	//struct Number *h=NULL;
	for(i = 1,j = 26;i<=25,j<=50;i++,j++){
		num1 = insert_h(num1,i);
		num2 = insert_h(num2,j);
	}
	printf("Num1 Date: %s %s\n",__DATE__,__TIME__);
	show(num1);
	printf("Num2 Date: %s %s\n",__DATE__,__TIME__);
	show(num2);
	struct Number *tmp = num1;
	//偶数链表
	struct Number *even_n = NULL;// (struct Number *)malloc(sizeof(struct Number));
	//奇数链表
	struct Number *odd_n = NULL;// (struct Number *)malloc(sizeof(struct Number));
	while(tmp){
		if(0 == tmp->nu%2){
			even_n = insert_h(even_n,tmp->nu);
			//printf("Even Number Link_list, Date: %s %s\n",__DATE__,__TIME__);
			//show(even_n);
		}
		else{
			odd_n = insert_h(odd_n,tmp->nu);
			//printf("Odd Number Link_list, Date: %s %s\n",__DATE__,__TIME__);
			//show(odd_n);
		}
		tmp = tmp->next;
	}
	printf("Even Number Link_list, Date: %s %s\n",__DATE__,__TIME__);
	show(even_n);
	tmp = NULL; /*free(tmp);*/tmp = num2;//even_n=NULL;
	while(tmp){
		if(0 == tmp->nu%2){
			even_n = insert_h(even_n,tmp->nu);
			//printf("Even Number Link_list, Date: %s %s\n",__DATE__,__TIME__);
			//show(even_n);
		}
		else{
			odd_n = insert_h(odd_n,tmp->nu);
			//printf("Odd Number Link_list, Date: %s %s\n",__DATE__,__TIME__);
			//show(odd_n);
		}
		tmp = tmp->next; 
	}
	printf("Odd Number Link_list, Date: %s %s\n",__DATE__,__TIME__);
	//printf("\n");
	show(odd_n);
	free(num1);
	free(num2);
	free(tmp);
	return 0;
}
