#!/usr/bin/python

for i in range(1,10):
    print("\n")
    for j in range(1,10):
        if j <= i:
            print(j,"x",end=" ")
            print(i,"=",end=" ")
            print(i*j,",",end=" ")
