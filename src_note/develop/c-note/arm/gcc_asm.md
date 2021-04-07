<link href="../../../css/style.css" rel="stylesheet" type="text/css" />


# 嵌入式第二课：gcc内联汇编基础

gcc内联汇编，在代码中嵌入汇编指令基础语法：

  

    
    
    #include <stdio.h>
    int main()
    {
        int num1,num2;
        __asm__ [__volatile__]( //__asm__和__volatile__都可以使用别名，内嵌汇编可以写在同一行上。
            "movl %1,%0" //汇编模板，如果有多个，使用分隔符(制表符，换行符，分号)分开
            :"" () //输出部分
            :"" () //输入部分
            : /* 破坏/保护部分*/]
            );
        return 0;
    }

  

```c
#include<stdio.h>
intmain()
{
intnum1,num2;
__asm__[__volatile__](//__asm__和__volatile__都可以使用别名，内嵌汇编可以写在同一行上。
"movl%1,%0"//汇编模板，如果有多个，使用分隔符(制表符，换行符，分号)分开
:""()//输出部分
:""()//输入部分
:/*破坏/保护部分*/]
);
return0;
```

