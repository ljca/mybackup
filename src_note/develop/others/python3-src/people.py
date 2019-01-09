#!/usr/bin/python

"""
persion :

"""

class People():
    def __init__(self):
        self.__name = ""
        self.__age = 0

    @property
    def name(self):
        return self.__name

    @name.setter
    def name(self,name):
        self.__name = name

    @property
    def age(self):
        return self.__age

    @age.setter
    def age(self,age):
        self.__age = age

    def get_info(self):
        #print("My Name is " + self.__name + ",and my age is ",self.__age,".")
        print("My Name is %s and my age is %d." %(self.name,self.__age),end="")
        return ""

    def eatting(self):
        print("I'm a people in The's Earth.")

    def drinkking(self):
        pass

    def walking(self):
        pass

    def slepping(self):
        pass


