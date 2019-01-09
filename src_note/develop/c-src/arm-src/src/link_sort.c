#include "link.h"
Dog link_sort(Dog h)
{
	Dog new_h = (Dog)malloc(sizeof(struct dog));
	Dog max = NULL;
	Dog pre = NULL;
	Dog tmp = h;
	while(h){
		max=h;
		pre=NULL;
		tmp=h;
		while(tmp->next){
			if(max->n > tmp->next->n){
				max=tmp->next;
				pre=tmp;
			}
			tmp = tmp->next;
		}
		if(h==max){
			h=h->next;
			max->next=NULL;
		}
		else{
			pre->next=max->next;
			max->next=NULL;
		}
		max->next=new_h;
		new_h=max;
	}
	printf("max %d\n",max->n);
	return new_h;
}

int main()
{
	Dog dogs=NULL;
	dogs = insert_tail(dogs,8);
	dogs = insert_tail(dogs,5);
	dogs = insert_tail(dogs,7);
	dogs = insert_tail(dogs,1);
	dogs = insert_tail(dogs,9);
	dogs = insert_tail(dogs,2);
	show(dogs);
	link_sort(dogs);
	show(dogs);
	return 0;
}
