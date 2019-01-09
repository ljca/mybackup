#include "link.h"
int main()
{
	Dog dogs = NULL;
	//dogs = insert_head(dogs,1);
	//dogs = insert_head(dogs,2);
	//dogs = insert_head(dogs,3);
	//dogs = insert_head(dogs,4);
	dogs = insert_tail(dogs,10);
	dogs = insert_tail(dogs,20);
	dogs = insert_tail(dogs,30);
	dogs = insert_tail(dogs,40);
	dogs = insert_tail(dogs,50);
	dogs = insert_tail(dogs,60);
	//printf("dogs->n=%d\n",dogs->n);
	//printf("dogs->next->n=%d\n",dogs->next->n);
	//printf("dogs->next->next->n=%d\n",dogs->next->next->n);
	//printf("dogs->next->next->next->n=%d\n",dogs->next->next->next->n);
	//show(dogs);
	//find_link(dogs,30);
	//dogs = del_link(dogs,60);
	show(dogs);
	//dogs=link_reverse(dogs);
	//link_sort(dogs);
	find_max(dogs);
	//show(dogs);
	//free(dogs);
	return 0;
}
