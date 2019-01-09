#include <iostream>
#include "mytest.h"

int main()
{
	Test test1(1,10);
	Test test2(2,20);
	Test test3(3,30);
	test1.show();
	test2.show();
	test3.show();
	Test total;
	total = test1 + test2;
	std::cout << "test1 + test2 = ?\n\r";
	total.show();
	std::cout << std::endl;
	return 0;
}
