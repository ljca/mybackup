#include <stdio.h>
#include "list.h"
struct Dog : public node{
	int id;
	int color;
	int type;

	void show()
	{
		printf("id %d \n",id);
	}
};
//enum COLOR={RED=1,BLACK,WHITE} red=RED,black=BLACK,white=WHITE;
//enum TYPE={};

int main()
{
	node *nodes= NULL;
	Dog *dog = new Dog();
	//dog.color=2;
	//dog.type=2;
	dog->color=2;
	dog->type=2;
	//printf("Dog color %d\nDog type %d\n",dog->color,dog->type);
	int i=0;
	for(i=1;i<50;i++){
		dog->id=i;
		printf("dog->id %d\n",dog->id);
		if(i%3==0){
			dog->color = 1;
		}else{
			dog->color = 2;
			dog->type=1;
		}
		insert(&nodes,dog);
	}
	show_list(nodes);
	//printf("Dog color %d\nDog type %d\n",dog.color,dog.type);
	return 0;
}
