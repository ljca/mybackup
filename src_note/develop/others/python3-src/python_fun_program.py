#!/usr/bin/python
# -*-cp936-*-

# 函数式编程
# 高阶函数

# 闭包函数:函数内部定义函数

# lambda表达式：#匿名函数

f = lambda x,y: x+y

print(f(1,2))

# 条件运算符 ?:
#

#x = 3 
#y = 2
#print(x if x > y else y)

# map 函数
# map(func,list)

#def square(x):
#    return x * x

#r = map(square,[1,2,3,4,5,6,7,8])

r = map(lambda x,y:x*x,[1,2,3,4,5,6,7,8],[2,4,6,8,10,12,14,16])

print(type(r))
print(list(r))

from functools import reduce

## reduce 函数

r = reduce(lambda x,y:x + y,[1,2,3,4,5,6])

print(type(r))
print(r)
#print(list(r))

print(type(range(1,100)))

# filter 函数
#
r = filter(lambda x : x,[1,1,0,0,0,1,1])

print(list(r))

# 装饰器

##
""" 
##decorator()
##wrapper()
"""
import time

def decorator(func):
    def wrapper():
        print(time.time())
        func()
    return wrapper

def f1():
    print("This is f1 function")

def current_time():
    pass

f = decorator(f1)

f()


