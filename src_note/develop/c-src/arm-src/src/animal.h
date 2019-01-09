#pragma once
#include <iostream>
using namespace std;
#ifndef _ANIMAL_
#define _ANIMAL_

namespace tmp{
	class Animal{
	public:
		int color;
		int type;
		string name;
		char sex;
		Animal()
		{
			cout << "class:Animal" << endl; 
		}
		Animal(int color,int type,string name,char sex)
		{
			this->color = color;
			this->type = type;
			this->name = name;
			this->sex = sex;
		}

		virtual void show()
		{
			cout << "class:Animal virtual function show()" << endl;
			//cout << "name is " << this->name << endl;
			//cout << "sex is " << this->sex << endl;
			//cout << "type is " << this->type << endl;
			//cout << "color is " << this->color << endl;
		}
		static void info()
		{
			cout << "class:Animal function info()" << endl;
		}
	};
};
#endif
