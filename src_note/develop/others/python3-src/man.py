#!/usr/bin/python

"""

"""

from people import People

class Man(People):
    def eatting(self):
        print("I'm a man,but i like eatting bananas and sports.")

kyzs = Man()

kyzs.name = "kyzs"
#print(kyzs.name)
kyzs.age = 24

print(kyzs.get_info())
kyzs.eatting()

