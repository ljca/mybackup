<link href="../../../css/style.css" rel="stylesheet" type="text/css" />

# 在Java中使用JNI(Jave Native Interface)调用C库

```Bash
mkdir -pv test/test
```

=========== test/test/Test.java ============
```Java
package test.test;

public class Test{
  native void test();
  static{
    System.loadLibrary("test");
  }
  public static void main(String args[]){
    new Test().test();
  }
}
```

编译 java
```bash
javac Test.java
```

用 javah 生成类似 C 的头文件
```bash
javah [-jni] Test //Test是无后缀的Class文件
cp Test.h test.c
```

=========== test.c ==========
```c
#include "Test.h"
//格式： 返回值类型 Java_Java中的包名_类名_类中声明的 native 函数名(JNIEnv *env,jobject job)

void Java_test_test_Test_test(JNIEnv *env,jobject job)
{
  // C 实现
}
```

将 C 编译成与地址无关的动态库，如果 java 是符号链接

```bash
jdk=$(readlink `which java`)
jdk=${jdk%/*}
gcc -fPIC -shared -I$jdk/../include/{,linux} -o libtest.so test.c
```

尝试执行 java 程序
```bash
LD_LIBRARY_PATH=.  java Test
```

