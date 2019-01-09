#include <stdio.h>
#include <stdlib.h>

typedef struct Person{
	int age;
	char sex;
	char *name;
	char *gf;
	void (*show)(struct Person **);
}person;

void ShowInfo(person **);

int main()
{
	person **per=(person **)malloc(sizeof(struct Person)); 
	(*per)->age=10;
	printf("core dump!\n");
	(*per)->sex='F';
	(*per)->name="Bob";
	(*per)->gf="lucy";
	(*per)->show=ShowInfo;
	return 0;
}

void ShowInfo(person **per)
{
	printf("age %d\nsex %c\nname %s\ngf %s\n",(*per)->age,(*per)->sex,(*per)->name,(*per)->gf);
}

/*
 *
	person *per=(person *)malloc(sizeof(person));
	per->age=10;
	per->sex='F';
	per->name="Bob";
	per->gf="lucy";
 */
