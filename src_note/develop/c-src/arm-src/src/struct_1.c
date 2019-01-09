#include <stdio.h>

struct person
{
	int age;
	char sex;
	char *name;
}person2 = {18,'M',"Tom"};

int main()
{
//	struct person p;
	//struct person ;
//	struct person *p2 = &p;
//	p2->age=28;
	//printf("p.age %d\n",p.age=18);
//	printf("p->age %d\n",p2->age);
	printf("name %s\n",person2.name);
	printf("age %d\n",person2.age);
	printf("sex %c\n",person2.sex);
	struct person p3 = {
		.age=20,
		.sex = 'F',
		.name = "Jack"
	};
	printf("name %s\n",p3.name);
	printf("age %d\n",p3.age);
	printf("sex %c\n",p3.sex);
	struct person *p4 = &p3;
	p4->age = 25;
	p4->sex = 'M';
	p4->name = "Bob";
	printf("name %s\n",p4->name);
	printf("age %d\n",p4->age);
	printf("sex %c\n",p4->sex);
	return 0;
}
