#include <iostream>
#include "mytest.h"

Test::Test()
{
	hours = minutes = 0;
}

Test::Test(int h,int m)
{
	hours = h;
	minutes = m;
}

void Test::AddMin()
{
}

void Test::AddHr()
{
}

void Test::Reset(int h,int m)
{
}

void Test::show() const
{
	std::cout << hours << " hours," << minutes << " minutes" << std::endl;
}

Test Test::operator+(const Test &t) const
{
	Test test;
	test.minutes = minutes + t.minutes;
	test.hours = hours + t.hours + test.minutes / 60;
	test.minutes %= 60;
	return test;
}
