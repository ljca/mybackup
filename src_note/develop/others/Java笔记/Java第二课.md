#  Java第二课

&nbsp;&nbsp;Java 吸收了`C++`的优点，代码组织方式借鉴了 C++ 的，却与 C++ 的存在着不同。

下面是一个 Java 程序的基本组织结构：

=============== Test.java ================

```Java
// 包声明语句
// 类导入语句

// 类定义
public class Test{
  // 方法定义或者调用

  // main 方法
  public static void main(String args[]){
    System.out.print("Hello,Java!");
  }
}
```

> Note！！！

1. Java 的类名定义不是随意的。假如一个类被声明为`public`，则保存源代码的文件其文件名中没有后缀的地方必须和类名一致。
2. 
3. 

```Bash
# 尝试使用`javac`将`Test.java`编译成与机器无关的字节码文件，如果其中存在着错误，则将会导致编译失败。
javac Test.java

# 如果成功产生字节码文件 Test.class，以`java`运行这段字节码。
java Test
```

