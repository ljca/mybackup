# 邦飞科技笔试题资料
## 简答题：
- [x] 表达式中 p 的含义: `int (*p(int, char *))(int);`
> 函数 p 有一个int型和`char *`型的参数，函数的返回值是一个指向返回值为int型且带有一个int型参数的函数。

- [x] sizeof和strlen的区别
> sizeof是C语言的一个运算符，不仅可以对数据类型进行计算内存占用大小，还可以计算表达式或者变量的内存占用大小。
> strlen 是C语言的库函数，仅仅可以对字符数组或者字符指针指向的字符串长度进行计算。

- [x] 内存泄露和野指针是什么意思，应怎样避免
> 当一个指针访问了，我们就认为内存可能泄露了。
> 野指针是一个在内存中存在，但不知道指向什么地方的指针。
> 比如没有初始化的指针，分配了内存之后通过free调用释放掉内存但没有置NULL的指针。

- [x] sprintf、strcpy 及 memcpy 函数有什么区别，你喜欢哪一个，为什么
> sprintf 一般用来将流拷贝到一个字符串中。
> strcpy 仅仅只能拷贝字符串字符到另外的字符串中，可能存在溢出的可能。
> memcpy 函数功能很强，可以拷贝任意数据类型的数据到另外的内存中，但这需要处理好数据类型的转换。
> 使用那个函数完全是根据需求,但sprintf使用较多。

- [x] 变量的声明和定义有什么区别？
> 变量声明不会分配内存，允许出现在源文件的任意地方。而定义只允许出现在单个源文件的单处地方(除非使用了 static 关键字，不然如果不这样，在链接的时候会出现重复定义符号的错误并会导致程序编译失败)，并且会分配内存。

- [x] `#ifndef #define #else` 有什么作用
> `#ifndef 预处理指令可以用来检测宏是否已经定义，一般用于防止重复包含头文件。而 #define 预处理指令用来定义一个宏.#else的作用类似if-else分支语句的else语句，如果#ifdef 或者 #ifndef 指令测试失败，则会转入#else预处理。`

- [x] C语言中static、const、extern、volatile关键字各有什么作用
> static是一种存储类说明符，它限制变量只在定义它的源文件的上下文中有效，其它的源文件无法访问它。 解决了同名变量不能在多个翻译单元定义的问题。
> const 用于限定变量。通常用来保护内存。作用于普通变量时使变量所在的内存不能再被修改，作用于指针时不能在改变指针的指向。
> extern 关键字主要用来 当在一个源文件的所有函数之外定义了一个全局变量，而想要在其它的源文件中访问它，就要在使用它的源文件先使用extern关键字先声明中这个全局变量。
> volatile :编译器在编译时会对代码进行优化，volatile关键字会告诉编译器由它修饰的变量不需要优化。

- [x] new/delete 与 malloc()/free() 的区别
> 它们都可以用来分配/释放内存。new/delete 是C++中的运算符，分配和释放内存时都由编译器负责。而malloc()/free()是库函数，无论是分配还是释放内存，都要自己手动调用，内存分配/释放之后还要对结果进行检查并进行下一步的清理工作以防止可能出现的内存泄露和野指针问题。

- [x] 详细解释编辑、编译、链接、运行四部分的作用
> 编辑是将相对于汇编代码和机器指令更高级的源程序写入一个文件中。
> 接下来对它进行编译，而编译又分为预编译和编译。
预编译主要由cpp负责处理源文件中的预处理指令，完成#define定义的宏的替换，处理#include指令：展开头文件，删除注释。以及其它预处理指令。
> 而编译也有几步。在这个过程中，首先由gcc调用lex,yacc对已经预处理过的源文件进行词法、语法、语义进行分析，如果这其中存在问题就会停止编译。接下来会将它进一步翻译成汇编代码和机器指令。紧接着会创建目标文件以及目标文件的各个节
链接：如果有多个目标文件，首先将它们中的段或者节进行合并。然后尝试确定符号表符号的地址，以及某些需要进行重定位的符号。如果一切顺利，会创建一个可执行文件。

- [x]  C语言中将内存分为几个区，每个区的作用是什么，每个区的地址在什么时候确定，为什么需要分区

- [x]  解释堆和栈在程序存储空间上代表的含义和区别
> 堆和栈是用户进程地址空间中两种不同的内存区域。
> 栈也被称为堆栈，是程序运行时用来保存局部变量以及函数参数的地方。而堆上面的内存在使用时需要手动进行分配并在使用完后释放。

- [x]  分别写出指针、整型、字符和浮点数与零值的比较方式
```c
 /* 指针比较 */
 int *p = NULL;
 if(!p) <==> if(NULL == p)
/* 整型数比较 */
 if(0 == i)
 /* 字符型比较 */
 if('\0' == ch)
 /* 浮点数比较 */
  #define EPSITON (1E-6)
  if(f_var >= -EPSTION && f_var <= EPSITON)
```

----------------------
- [x]  交换两个变量（整型）的值，且不允许使用中间值
```c
 void swap(int *a,*b)
 {
   *a ^= *b ^= *a ^= *b;
 }
```
  
- [x]  区别`int (*p)[5]`和`int *p[5]`。再区别`int *(*p)(int, char *)`和`int *p(int, char*)`
> `int (*p)[5]` ====> 一个数组指针 
   `int *p[5]` ====> 一个指针数组，数组的每一个元素都指向一个整型数组的首元素的首地址
   `int *(*p)(int, char *)` ====> 一个带有一个 int 和一个指向 char 型的指针参数并且返回一个指向 int 型指针的函数指针。
   `int *p(int, char*)` ====>  一个带有一个int和一个指向 char 的参数并且返回值指向一个int型指针的函数 

- [x]  以下两种方式的区别是什么? `char string[] = "Linux C";	char *p = "Linux C";`
> 两种方式都可以理解为一个字符串。但两种变量存储方式和位置都不同。string 是一个字符数组，在程序运行时才会在栈上分配一段内存，并允许修改。而p指向一个常量字符串的首个字符地址，可能会在编译和链接时被gcc放到最终可执行文件的text段，并不允许直接修改它的指向，但可以间接修改它执行的内存中的值。

- [x]  进程和程序的区别
> 程序是一种包含二进制代码的普通文件，操作系统的命令解释器可以直接解释并载入内存运行。而进程是在程序被装入内存运行时由操作系统创建的。

- [x]  vfork和fork的区别，cow是什么意思
> vfork 和 fork 都能创建一个子进程，子进程继承了父进程的所有资源，包括堆栈，共享内存，打开的文件描述符。

- [ ]  软件工程分为哪五部分，各部分的主要工作是什么
>

- [ ] 反转一个栈

- [ ] 怎样判断链表是否有环

- [ ] 内核与应用层之间通信有哪些方式，请简述netlink机制
>

- [x]  说明队列和栈的异同
> 队列和栈都是一种数据结构，队列是一种一端进，另一端出，先进先出的数据结构，而栈是一种允许从一端进并且后进先出的数据结构。

- [ ]  产生死锁的原因有哪些，死锁的四个必要条件是什么
 
- [ ]  开发板上电没有反应，应该怎样检查
>

- [ ] 比较linux操作系统内核态和用户态的抢占性，及两者之间存在差异的原因
>

- [ ] 实时性linux系统和非实时性系统的区别，聚内核和微内核有什么区别
> 实时性linux系统要求系统对出现的事件立即进行处理。
> 微内核

- [x]  TCP/IP分为几层，各层的主要工作是什么
> TCP/IP 协议族如果不包含物理层则共分四层，从高到低分别是
  - 应用层 
  - 传输层 TCP/UDP/SCTP 负责数据包端到端的传输
  - 网络层 IP 负责数据包点到点的传输
  - 链路层和物理层 ARP/NARP

- [x]  UDP和TCP的区别是什么
> UDP和TCP同属TCP/IP协议族运输层协议，但UDP是用户数据报，不关心传输结果，而TCP是面向连接的传输层协议，在传输之前会建立连接，对传输过程的细节很关心，传输完成之后才会断开连接。

- [x]  ARP协议的作用
> ARP 是TCP/IP协议族链路层上的协议，它负责在底层数据的传输，询问和应答主机或者路由等设备硬件地址。

- [ ]  中断和异常是什么，有什么区别
> 异常是应用程序产生的一个错误

- [x]  对于整形变量A=0x12345678,请画出在little endian及big endian的方式下在内存中是如何存储的
> <-----------
  high     low(一字节偏移)
  78 56 34 12 大端
  12 34 56 78 小端

- [x]  嵌入式系统总是要用户对变量或寄存器进行位操作。给定一个整型变量a，写两段代码 ，第一个设置a的bit 3，第二个清除a 的bit 3。在以上两个操作中，要保持其它位不变。
```c
static int a;
(~0x0 & a) |= (0x1 << 3)
a &= ~(0x1 << 3)
```

- [x]  ARM-Linux启动分为几部分，简述流程
> 上电开机 -> bootloader载入内核 -> 内核挂载文件系统并启动根进程init.....

- [x]  描述LINUX中字符设备驱动的基本编程框架
 1. 模块初始化(`module_init`)
  - 初始化总线
  - 初始化字符设备
  - 创建节点
  - .....
 2. 当模块从内存卸载(`module_exit`)
  - 移除节点
模块声明语句
`MODULE_LINCENSE("")`
....

- [x]  操作系统的功能
  1. 处理器管理/cpu时间分配
  2. 内存管理
  3. 文件系统管理
  4. 进程调度/作业管理
  5. 设备管理

- [x] 浅谈bootloader,kernel,filesystem三者之间的关系
> 首先系统上电开机，载入 bootloader，然后 bootloader 根据引导参数找到内核并将引导权移交给 kernel，内核启动第一个进程 init 进入用户空间并继续接下来的启动工作。

- [x] Linux系统下.ko文件是什么文件？.so文件是什么文件？
> .ko 是Linux内核的模块文件，可以在内核中动态载入和卸载(如果内核允许动态载入的话)。
> .so 是Unix变体通用的动态库，在可执行文件中仅仅存在它们的名字，然后可执行文件运行时由动态加载器在内存中载入。相当于windows下的DLL.

- [x] linux操作系统有哪五个基本的组成部分
+ 进程通信
+ 作业调度
+ 虚拟文件系统
+ 内存管理
+ 网络接口

- [x] 有定义：`short (*a)[4][3][2];` `sizeof(a)、sizeof(a[0])、sizeof(a[0][0]、sizeof(a[0][0][0]和sizeof(a[0][0][0][0])`分别是多少？为什么
 
> 32位系统：`sizeof(a) = 4 sizeof(a[0]) = 48 sizeof(a[0][0] = 12 sizeof(a[0][0][0] = 4 sizeof(a[0][0][0][0] = 2`
> 变量a是一个指针变量，因此在32系统上占4个字节，a[0][0][0][0] 代表数组最后一位的第一个元素，而这个元素是个short类型的，因此占用2个字节。

- [x] 定义一个宏，用于交换a和b的值
```
   #define swap(a,b) \
   {int t;t = a;a = b;b = t;}
```

- [x]  进程间的通信有哪些，它们都有哪些优缺点，你最喜欢用哪一种，为什么
+ 管道
+ 传统IPC(信号 信号量 消息队列 共享内存) 
+ 套接字(socket)

- [x] 求从10到100中能被3或5整除的数的和
```c
    unsigned int 
    sum(void)
    {
      unsigned int i = 10,sum = 0;
      for(;i < 101;i++){
        if(i % 3 == 0 || i % 5 == 0){
          sum+= i;
        }
      }
      return sum;
    }
```

----------
- [x] 将一个字符串逆序，不要使用反转函数
```c
  char *reverse_str(char *str)
  {
    char *start = str;
    char *end = str;
    char ch;
    while(*str++) ;
    while(end < str){
      ch = *end;
      *end++ = *str;
      *str-- = ch;
    }
    return start;
  }
```

- [x] 不用中间变量，交换ab的值
```c
  void swap(int *a,int *b)
  {
    *a ^= *b ^= *a ^= *b;
  }
```

## 编程题

- [x] 单链表完成结点的添加、删除、打印、排序、逆转操作
```c
    /* 单链表 */
    typedef struct node{
      int index;
      struct node *next;
    }node;
    /* 节点添加：头插法 */
    node *
    link_add_node_head(node *pnode,int index)
    {
      node *new_head = NULL;
      if((new_head = (node *)malloc(sizeof(node)))){
        perror("genary memeory error");
        exit(NOMEM);
      }
      new_head->index = index;
      new_head->next = pnode;
      return new_head;
    }
```
   
```c
    /* 排序 */
    node *
    link_sort(node *pnode)
    {
      node *min_pre,*min;
      node *tmp;
      node *new_head;
      tmp = min = pnode;
      new_head = min_pre = NULL;
      while(pnode){
        min = pnode;
        tmp = pnode;
        min_pre = NULL;
        while(tmp->next){
          if(tmp->next->index < min->index){
            min = tmp->next;
            min_pre = tmp;
          }
          tmp = tmp->next;
        }
        if(min == pnode){
          pnode = pnode->next;
          min->next = NULL;
        }else{
          min_pre->next = min->next;
          min->next = NULL;
        }
        min->next = new_head;
        new_head = min;
      }
      return new_head;
    }
    /* 打印节点 */
    void print_node(node *pnode)
    {
      while(node){
        printf("pnode->index = %d\n",pnode->index);
        pnode = pnode->next;
      }
    }
```

- [x] 函数实现冒泡排序、选择排序、插入排序
```c
  /* 冒泡排序 */
  int tmp;
  int arr_num[6] = {192,29,292,192,92,592};
  #define ARR_LEN (sizeof(arr_num) / sizeof(arr_num[0]))
  int i = 0,j = ARR_LEN - 1;
  for(;i < ARR_LEN - 1;i++){
    for(;j < i;j--){
      if(arr_num[j - 1] > arr_num[j]){
        tmp = arr[j - 1];
        arr[j - 1] = arr[j];
        arr[j] = tmp;
      }
    }
  }
```

----------------------------------------
- [x] 函数实现atoi(字符串转整形)和itoa(整形转字符串)
```c
   unsigned long my_atoi(char *str)
   {
     int num = 0;
     while(*str++ != '\0'){
       if(*str >= '0' && *str <= '9'){
         num = (*str - '0') + num * 10;
       }else continue;
     }
     return num;
   }
   /* myitoa 实现*/
   char *
   myitoa(unsigned long num)
   {
     char str[sizeof(unsigned long)] = {0};
     while(num < 0){
       str[i++] = (num % 10 ) + '0';
       num /= 10;
     }
     return str;
   }
```

- [x] 请编写一个 C 函数，该函数将一个字符串逆序，并分别用函数指针和回调函数调用
```c
    char *
    reverse_str(char *str)
    {
      char *tmp;
      char *left;
      tmp = left = str;
      while(*tmp++) ;
      tmp -= 2;
      char ch;
      while(left < tmp){
        ch = *left;
        *left++ = *tmp;
        *tmp-- = ch;
      }
      return str;
    }
```

- [x] 函数实现strcpy、strlen、strcmp函数
```c
  /* my_strlen() */
  unsigned long my_strlen(const char *str)
  {
    char *tmp = str;
    unsigned long count = 0;
    for(;*tmp;tmp++,count++) ;
    retrurn count;
  }
```

```c
  /* my_strcpy() */
  char *my_strcpy(char *src,char *dest)
  {
    int len_str = strlen(src);
    char *tmp = dest;
    if(!src){
      perror("");
      return NULL;
    }
    while((*dest++ = *src++) != '\0') ;
    return tmp;
  }
  /* my_strcmp() */
  short my_strcmp(char *src,char *dest)
  {
    short res = -1;
  }
```

- [x] 请编写函数fun，其功能是：将s所指字符串中ASCII值为偶数的字符删除，串中剩余字符形成一个新串放在t所指的数组中
```c
    char (*fun(char *str))[255]
    {
      //char (*t)[255] = {NULL};
      char t[255] = {NULL};
      char *tmp = str;
      int i = 0;
      while(*str++){
        if(*str% 2 == 0){
          tmp[i] = str[i + 1];
        }
        tmp++;
      }
    
      //for(;*tmp;tmp++,i++){
      //  if(*tmp % 2 != 0){
      //    *(*(t + i)) = *tmp;
      //  }
      //}
      return t;
    }
```

- [x] 判断一个数是否是2的乘方
```c
   _Bool check_(int num)
   {
     int i = 1;
     for(;i < sizeof(num) + 1;i++){
       if(num == (1 << i)) return true;
       else return false;
     }
   }
```

- [ ] 函数实现`3*2`矩阵的转置，并分别用函数指针和回调函数调用
```c

```

- [ ] 实现双向循环链表的创建、插入、删除、排序操作
```c

```

- [ ] 两个字符串，s,t;把t字符串插入到s字符串中，s字符串有足够的空间存放t字符串
```c

```

- [ ] 请编写一个函数`void fun(char *a，char *b，int n)`，其功能是：删除一个字符串中指定下标的字符。其中，a指向原字符串，删除后的字符串存放在b所指的数组中，n中存放指定的下标。例如，输入一个字符串World，然后输入3，则调用该函数后的结果为Word

```c

```

- [ ] 请编写一个 C 函数，该函数在给定的内存区域搜索给定的字符，并返回该字符所在位置索引值
```c

```

- [ ] 编程实现网络文件传输，请分别用TCP和UDP的方式传输不小于5M的文件
```c

```

- [ ] 用IO多路复用实现局域网聊天工具（select或者poll都可以）
```c

```

- [ ] 函数实现TCP/IP网络中的校验和函数
```c

```

- [ ] 编写一对socket程序，要求类似于network echo procotol。
> Client每隔1秒把自己的IP地址轮流循环发送给一个Server.
Server接到IP后，在屏幕上打印对方IP；然后把自己的IP发送回去。
Client收到回复后，在屏幕上打印对方IP。
程序一直运行，直到用户退出。各自分类统计接收到的各IP的数据包的个数。
注意：Client可以向多个Server发送请求，Server也可以接收多个Client请求。
```c

```

- [ ] 裸板对串口编程，编写一对类似ping的程序，作用在串口上，
解serial的联通情况，自定义协议.要求：定义一个联通和响应协议。至少具有：发送、回复、超时三种状态。可以不对数据进行校验。
```c

```

- [ ] 函数实现快速排序
```c

```

- [ ] 构建一颗哈弗曼树，然后对其编码
```c

```

- [ ] 实现函数： `int comp(char *str1, char *str2, char *substr, int *len);`
> 将str1和str2的最大公共子串存在substr中，如果最大公共字串有多个，保存最后一个，len表示substr的长度，函数返回最大公共字串的个数。

```c

```


- [ ] 编写程序实现汉诺塔
```c

```

- [ ] 构建一颗不少于15个节点的树，分别用前序、中序和后续进行
问
```c

```
