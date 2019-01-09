#!/usr/bin/python

from enum import Enum

class VIP(Enum):
    YELLOW = 1
    GREEN = 2
    BLACK = 3
    RED = 4

#VIP.BLACK = 5
print(VIP.BLACK)

print(type(VIP.BLACK == VIP.RED))

print(type(VIP.GREEN is VIP.BLACK))

#type(is)

#type(in)

print("VIP type is %s" %(type(VIP)))

print("VIP.YELLOW type : %s" %(type(VIP.YELLOW)))

print("VIP.YELLOW.value : %s" %(type(VIP.YELLOW.value)))

print("VIP.YELLOW.name : %s" %(type(VIP.YELLOW.name)))

print("VIP.YELLOW.name = %s" %(VIP.YELLOW.name))
print("VIP.YELLOW.value = %s" %(VIP.YELLOW.value))

for i in VIP:
    print("%s type: %s, %s type: %s:" %(i,type(i),i.name,type(i.name)))
    print("i = %s, i.name = %s" %(i,i.name))

for i in VIP.__members__.items():
    print(i)
    print(type(i))

print(type(VIP(1)))

