#!/usr/bin/python

def curve_pre():
    a = 25
    def curve(a):
        a = 10
        print(a)
        return a * a * a
    print(a)
    return curve

#c = 2
f = curve_pre()

print(f(3))

