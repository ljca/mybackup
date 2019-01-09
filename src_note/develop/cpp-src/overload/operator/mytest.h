#ifndef __MYTEST_H
#define __MYTEST_H
class Test{
	private:
		int hours;
		int minutes;
	public:
		Test();
		Test(int h,int m = 0);
		void AddMin();
		void AddHr();
		void Reset(int h = 0,int m = 0);
		Test operator+(const Test &t) const;
		void show() const;
};

#endif
