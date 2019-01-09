#! /usr/bin/python

import json
#string = '{"key":"value1","value":"value2"}'
string = '[{"key":"value1","key2":"value2"},{"key3":true,"key4":false},{"key5":60,"key6":20}]'

tmp=json.loads(string)

print(type(tmp))
print(tmp)
print('tmp[%d]["key"] = %s' %(0,tmp[0]["key"]))
print('tmp[%d]["key2"] = %s' %(0,tmp[0]["key2"]))
#print(tmp[0]["value"])

print(tmp[0:1])
print(tmp[1:2])
print(tmp[-1:])
print("(tmp[:-1] %s" %(tmp[:-1]))

for i in range(0,len(tmp)):
    print("tmp[%d]'type is %s" %(i,type(tmp[i])))
    print("tmp[%d] = %s" %(i,tmp[i]));




string = [{"name":"int","flag":True},{"name":"list","flag":False},{"name":"str","flag":True}]

tmp = json.dumps(string)

print("type(tmp) = %s" %(type(tmp)))

print("tmp = %s" %(tmp))


url="api.douban.com/v2/book/$id"
string=""

del tmp
del string 
del json

