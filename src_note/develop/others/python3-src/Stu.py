#!/usr/bin/python

class Student():
    #name = "许**"

    def __init__(self,name,age):
        self.__name = name
        self.__age = age
        self.__address = ""
        self.__email = ""
        self.__tel = ""
        #return self.name,self.age


    def stu_info(self):
        #print("姓名：" + self.name)
        print(self.__name,end="，")
        #print("年龄：" + str(self.age))
        print(self.__age)
        #print("住址：" + self.address)
        print(self.__address)
        #print("email：" + self.email)
        print(self.__tel);
        print(self.__email)
        #print(self.__class__)
        #print("self.__classs__.age：" + str(self.__class__.age))
        return ""

    @classmethod
    def init(cls):
        print("I'm python class method!")
        #cls.age += 1;

    @staticmethod
    def add(x,y):
        print("I'm python static method!")
        #print(Student.age)
        return x + y


stu = Student("cajl",20);
#stu.stu_info();

print(Student("sjah",21).__dict__)

print(stu.__dict__)

print(stu.add(5,3))
print(Student.add(1,2))

Student.init();

