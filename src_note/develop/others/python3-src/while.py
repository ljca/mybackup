#!/usr/bin/python

#counter = 1

#while counter < 100:
#    print(counter,end="  ")
#    counter += 1;
#else:
#    print("EOF")

#words = ['Windows','Linux',"Unix","Mac OS"]

#for i in words:
#    print(i,end=' ')

num = [['Windows','Linux',"Unix","Mac OS"],(10,20,30,50)]

for i in num:
    for n in i:
        if n == "Unix":
            break
        print(n,end="  ")
else:
    print("\ndone!")

for i in range(0,10,2): 
    print(i,end="  ")

for i in range(10,0,-2): 
    print(i,end="  ")

print("\n")


