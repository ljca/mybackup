#import package.module [as word]
#import base [as word]
#from package.moulde import words|*

# 可以从一个模块中导入多个成员，多个成员使用逗号分隔。

#from init.base import *
from init import *

print(tools.tool)

for i in base.words:
    print(i,end="  ")

