#!/usr/bin/python

import re

#string="Java|C|C++|PHP|Python|Perl"
string="Javac#Cc#C++c#PHPc#Pythonc#Perl"

#r = re.findall('\w*![|]',string)
print(string.replace("c#"," <<c#>> "))

def convert(value):
    return " <<" + value.group() + ">> "

r = re.sub("c#",convert,string)

print(r)

del r 


def convert(value):
    print(int(value.group()),end=" ")
    if int(value.group()) >= 6:
            return '9'
    else:
        return '0'


import re
string = "A83C72D10D8E67"
print(re.sub("\d",convert,string))

print(re.search("\d",string).span())
string = "life is short,i use python,i love python"
print(re.search("life(.*)python(.*)python",string).group(0,1,2))
print(re.search("life(.*)python(.*)python",string).groups())
#print(re.search("life(.*)python",string).group(1))
#print(re.findall("life(.*)python",string))


del string
del convert
del re

