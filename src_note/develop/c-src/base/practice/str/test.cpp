#include <stdio.h>

struct Test{
	int id;
	Test(){
		printf("This is Test's structure function\n");
	}
	void show()
	{
		printf("This is Test struct Test;\n" "Test id = %d\n",this->id);
	}
};
struct Test1 : public Test{
	char *name;
	Test1()
	{
		this->show();
	}
	void show()
	{
		printf("This is structure Test1\n" "name is %s\n",name);
		printf("This is structure Test1\n" "this name is %s\nthis id = %d\n",this->name,this->id);
	}
};

int main()
{
	Test1 test1;
	Test *test;
	test=new Test();
	test->id=5;
	test->show();
	test1.id=7;
	//test = new Test1();
	test1.name="Jack";
	test1.show();
	return 0;
}
