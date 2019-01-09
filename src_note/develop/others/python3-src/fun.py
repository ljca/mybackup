#!/usr/bin/python

import sys

sys.setrecursionlimit(10000000)

def add(a,b):
    return a + b

def swap(a,b):
    #print(a,b,end=" ")
    t = a
    a = b
    b = t
    return a,b

a = 2
b = 5

#print(a,b)

print(a,b,swap(a,b))

print("a + b = ",add(a,b))

