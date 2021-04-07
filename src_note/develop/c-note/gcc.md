<link href="../../css/style.css" rel="stylesheet" type="text/css" />


# gcc

```
../gcc-4.9.2/configure --disable-cloog-version-check --disable-isl-version-check   --prefix=/home/external/usr/tools/gcc-4.9.2 --enable-languages=c,c++ --disable-multilib --disable-bootstrap --with-system-zlib
```


gcc常用编译选项                                                     
 *-c
 *-E
 *-W
 *-f和-shared
 *-O
 *-D



1. 静态库(a)和动态库(so)             
  静态库创建修改打包工具ar            
  ```bash
  ar crsn test.a *.o
  ```

2. 创建一个共享库 
  ```bash
  gcc -fPIC -shared -o libtest.so *.c
  ```
gcc -Wall -fdiagnostics-color=auto -o float float.c

> 传递给汇编器或者链接器的选项后需要立即跟上逗号和选项。

+ 传递给汇编器的选项：`-Wa`

+ 传递给链接器的选项：`-Wl`


+ 汇编选项`-S`，编译时在汇编后生成的文件中生成源代码行号信息：

`-fverbose-asm`

+ 生成剖析信息供 prof 程序使用：`-pg -g`


+ -s 去除可执行文件中的符号表

+ -Idir[:dir[:....]]

> 链接选项：

+ -L

+ -l


> 源代码选项：

+ -fsyntax-only

+ -Wall

+ -save-temps：保存编译时生成的临时文件

2017年 10月 30日 星期一 22:51:54 CST
