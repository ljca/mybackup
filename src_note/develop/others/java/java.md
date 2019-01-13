# Java
﻿★ 包、类、对象、方法以及其它类中的成员
java中的包(package)及import关键字
java中使用包(package)组织管理类，这样可以有效解决类名冲突的问题，包名不允许以点开始和结尾但可以用英文句点作为分隔符，包名一般都是小写字符组成，并且一般会以域名倒置的形式来命名一个包；如果在一个公共类有包声明语句，那么包声明语句必须位于所有代码之前。


> 包声明语句：

```Java
package 包名;
```

> 包导入语句：

```Java
java.lang包被系统默认导入，但要调用其它包中的公共方法、对象....则必须在一个公共类被声明或者定义之前、包声明语句之后使用import关键字显式导入这个包。语法：

import 包名.类名(代表所有类);
```

## ◆ 类

&nbsp;&nbsp;类是Java组织代码的顶级结构。Java规定，除包声明和包导入语句之外，类成员的定义必须包含在类中,逻辑结构(if,for....)必须包含在方法或者代码块中。允许在定义类时继承一个父类并实现多个接口，这并不是必须的。语法：

```Java
包声明语句.
包导入语句.
public class 类名{
  //类的入口方法，无论它在什么地方，它总是被最先执行
  public static void main(Args[] args){
  }
}
```

它也可以使用以下的形式声明和定义

```Java
public class 类名 [[extends] 父类 [impre..] 接口1,...接口n()]{ 
 //类的内部类 
 class 类名{}
  //类的构造方法
  .....
  类的其它成员
}
```

> Note：

+ 如果在一个类存在入口方法(main方法)，那么这个类必须被声明为一个公共类(public)，并且命名必须和声明的公共类名保持一致
+ 允许在一个公共类中定义多个类，这些类都不能使用public来修饰。并且类名必须和声明的公共类名保持一致
+ 允许在一个类中再次定义一个类，它被称为类的内部类

### 匿名类

### 匿名内部类

## ★ 类成员

### 变量及数据类型

> 程序中，变量的声明和定义是必须的，它被用来临时保存一些程序运行所依赖的值，这个值可以是计算内存地址

◆ 基本和引用数据类型

 + byte|short|int|lang
 + float|double
 + char|String(引用数据类型)

  变量可以在声明它的时候给它赋值:

```Java
[访问修饰符] [static] 变量类型 变量名[ = 初值];
```

### 类成员:字段 

> 字段私有，字段getter/setter方法公开



### ◆ 类成员：数组(引用类型)，可以分为基本、引用，以及对象数组
数组在声明可以留空长度也可以指定长度，也可以在声明数组的同时给数组赋值
 以下数组声明都是合法的：

```Java
[访问修饰符] [static]  类型 数组名[] = new 类型[];  //方括号[]放在变量名前也是被允许的
```

```Java
[访问修饰符] [static]  类型 数组名[] = new 类型[长度];
```

```Java
[访问修饰符] [static]  类型 数组名[] = new 类型[值1，值2.....值n];
```

### ◆ 类成员:对象(引用数据类型)

> 在Java中，还存在一种匿名对象的写法。为一个集合或者泛型集合添加数据时;测试一个实例方法或者这个实例方法只需要调用一次时。

> Note：

+ 创建对象时不需要声明一个对象来保存，直接使用new 数据类型().成员名的形式调用
+ 显式对象及匿名对象
+ 匿名对象:实例化一个类时，不声明对象名和对象的类型
+ 适合临时调用实例对象方法
+ 在集合中添加对象时

### ◆ 类成员：方法

> 方法是Java中必不可少的元素，存在不同的几种方法定义形式，不仅仅是功能和结构上。用于传递数据和增加代码重用性。逻辑代码必须位于方法之中，语法:
  
```Java
[访问修饰符] [static] 方法返回值 方法名(参数列表，允许无参){

//方法体
}
```

ps: 构造方法、抽象方法使用与此不同的形式来定义或者声明。

### ◆ 对象数组的声明


### ◆ 类成员: 静态代码块和代码块

在一个类或者一个方法中，可以使用一组花括号将代码包含，来声明一个代码块{}，它并不会比，除非它被声明为静态的(static)
static{}

### ★ 构造方法

在一个类中，存在一个特殊的方法，这个方法方法名和类名一致，它不允许任何返回值类型的关键字(void也不行)修饰，它被称为类的构造方法。

> 注意：

这个类最好不要声明为abstract，构造方法也允许在抽象类中被声明定义，但不能用于实例化构造方法用于初始化类的对象，包括属性和方法，构造方法可以被重载，但不允许被子类继承和重写。语法：

```Java
[访问修饰符] 类名(){} //如果在类中声明定义了有参构造，则无参构造也必须被声明
```

```Java
[访问修饰符] 类名(参数列表){}
```


## ★ java中的访问修饰符

friendly(java默认修饰符，可在同一个包和定义它的类中被访问);public(最大访问权限，同一个包中所有都可访问);  
protected(在定义它的类中，继承它的子类，同一个包中可被访问);private(只能在定义它的类中被访问);

◆ static及final关键字

static关键字,被类的所有实例所共用。可修饰变量、类、方法、代码块，此关键字不能和abstract同时出现。一旦被static修饰的成员，将在所有实例对象初始化前被执行;注意：类成员不能访问实例成员，而实例成员可以访问类成员，因为类成员比实例成员先初始化
类成员和类方法会被顺序执行

◆ 终态final

> Note：

+ final可以修饰类、方法、类变量，但不能修饰构造
+ 修饰的类不能被继承
+ 修饰的方法不能被子类重写
+ 变量一旦被fianl修饰，则变成常量，程序运行过程中，不能再被重新赋值
+ 如果修饰的是一个引用数据类型，则不能再被实例化

## ★ 面向对象的特征:

### ★ 封装

+ 将类的属性私有化，提供对外访问接口，并创建getset方法返回值
+ 如果已经定义了私有属性，则可以使用快捷键:Shift+Alt+S来快速创建属性对应的getter/setter方法

### ★ 继承

+ 父类派生子类的过程。一个子类只允许继承一个父类，同时继承多个父类是不允许的通过继承，子类可以访问父类的所有非私有成员，还可以定义自身的成员
+ 使用this或者super来访问父类非私有成员以及this、super的区别
+ this 指代当前实例对象，通过this可以访问实例变量和方法以及构造。但this不允许调用类属性和类方法，也不允许调用局部变量

### ★ 多态

+ 引用同一引用，使用不同实例来执行不同的方法。
+ 当编译时的类型与运行时的类型出现不一致的情况 

> 实现多态的必须条件:

子类必须存在继承或者实现接口；子类重写父类方法

> 多态的特点：

+ 父类出现的地方子类一定也能出现
+ 声明的什么类型就只能访问什么类型的方法
+ new的什么对象就执行谁的方法
+ 实现多态的方式
+ 方法的参数使用父类试下，具体调用过程中可以传入不同的的子类类型，实现多态
+ 方法通过返回值使用父类类型

## 面向对象方法特性
### ◆ 方法重载

在同一个类中，可以有一些方法名相同，参数列表不同的方法，包括顺序，个数以及类型不同。这些方法被称为重载方法

方法重载与方法有无返回值，访问权限无关如果调用重载的构造，则必须位于第一行

### ◆ 方法重写

> 在子类中对继承父类的方法重新编写，称为方法的重写。方法重写有以下的要求：

+ 方法名必须相同
+ 参数列表必须一致，包括返回值、类型、个数
+ 重写方法必须具有和被重写方法相同的返回值类型
+ 重写方法不能缩小被重写方法的访问权限

### ◆ extends和super关键字

+ 如果子类要继承父类，那么子类将不允许使用static修饰
+ 子类继承父类通过extends关键字实现，只允许继承一个父类。
+ 被继承的父类访问修饰符只能是默认的(子类只在当前包下有权继承)或者public(整个项目中都可被继承),不能使用private或者protected修饰。

> 语法：
 
```Java
[访问修饰符] class 子类名 extends 父类名{}
```

 + 只能在子类实例方法和构造中使用super关键字和this访问父类的成员，不允许出现在类方法中
 + 如果在构造中访问，则this和super不能同时存在，并且必须位于第一行
 + 父类成员访问权限不能是private，friendly
 + 父类和子类必须位于同一个包
 + 子类中调用父类构造，默认调用无参构造
 + 实例方法可以同时存在this和super
 + 如果父类中不存在无参构造，则子类必须显示调用父类的有参构造

## ★ 抽象类和抽象方法

+ 只能修饰方法和类，不能修饰构造和属性
+ 如果在类名前使用abstract修饰，则此类被定义为抽象类。一旦类被定义为抽象类，它将只能被子类继承，而不能被实例化
+ 抽象类因为要被继承它的子类重写被声明的抽象方法，所以不能被final修饰，抽象方法也是如此
+ 同理，方法名使用abstract修饰，它将被声明为抽象方法，声明它的类只能被声明为抽象类
+ 如果子类继承的父类为抽象类，则必须在子类中重写所有抽象方法，否则它也只能是抽象类
+ 抽象方法一经声明，它必须在子类中被重写，否则一个父类为抽象类的子类也只能是抽象类
+ 一个类中如果存在抽象方法，则必须被声明为抽象类。但在抽象类中却可以存在一个或者多个抽象方法，甚至抽象类中抽象方法一个也没有也是允许的,语法如下

```Java
[访问修饰符] abstract class 类名{ 

[public] abstract 返回值 方法名([参数列表]); //public与abstract不冲突，它也并不是必须的；位于句末的分号不能被省略
}
```

 抽象类允许存在构造方法，但是这个构造不能用来实例化抽象类，可以被其它子类调用，如果访问修饰符不为private。
 抽象类允许实现接口

## ◆ java中的类型转换
 向上转换,自动转换;向下转换，强制类型转换

 ◆ instanceof关键字

instanceof关键字用于判断对象类型

★ java中的接口：是一组抽象方法的集合(也可以在接口中定义字段，但字段只能是单例的(静态、终态的(即使省略)))。它只有方法的声明，但没有具体实现

+ 接口需要也只能被实现，它不能在类中被实例化；允许继承多个父接口，不允许继承类
+ 接口中所有的方法默认都是抽象方法，即使没有使用abstract修饰，它们都必须重新在子类中被重写
+ 接口中不能声明变量，但可以声明常量，并且这个常量只能是静态的;接口中不允许存在构造方法，因为它和抽象类一样不允许被实例化，但它允许是实现类对象的声明类型


```Java
[访问修饰符] static final 常量名 = 常量值;
```

> java中的接口使用关键字interface声明，使用implements来实现接口，允许实现多个接口，接口用逗号隔开；根据需要修改接口访问修饰符,以便实现接口中的抽象方法。定义语法：

```Java
[访问修饰符] interface 接口名 [extends 父接口一,父接口二....父接口n]{

}
```

> 允许一个类在继承父类的同时又实现接口，但要求继承必须位于接口实现类的implements关键字之前。不必要求它们之间存在本质的联系，只要求能实现接口，即重写接口中的所有抽象方法。语法:

```Java
[访问修饰符] class 类名 [extends 父类] implements 接口1[，接口2....]{

}
```

## ★ Java中的异常处理

> Java中的异常的分类

+ Object\<Throwable\<Error或者Exception\<RuntimeException或者Check异常
+ RuntimeException(运行时异常)，包括RuntimeException及其所有子类，此类异常可以显示声明或者不声明;此类异常可以显式try-catch亦可以不显示try-catch
+ 由check(检查异常)，此类异常要求在程序中必须显示声明,显式try-catch

  ◆ try-catch-finally块

```Java
/* try-catch-finally块中的try块必须存在，即使在try块或者catch块中存在return语句，finally任然会被执行，并且会比return语句先执行。除非在catch块之中强制程序退出System.exit(int x); */
try{
/* 多路捕获异常子类异常必须在前，父类异常Exception在子类异常之后,多个catch块不允许被同时执行，如果一个异常在catch块中已被捕获，那么之后或者之前的catch块将不会被执行 */
  }catch(Input..){
    }catch(Exception e){
/* 如果在程序中不能处理异常，那么请使用throws通知调用者,throw将异常抛给调用者 */
  .....
  }finally{
}
```

+ void printStackTrace();输入异常的堆栈信息
+ String.getMessage();返回异常信息描述字符串

>  定义方法时声明异常，通知调用者处理异常。如果声明是检查异常，则必须显示try-catch异常处理，否则可以不用显示try-catch异常处理

```Java
[访问修饰符] [static] 方法返回值 方法名() throws 子类异常[...,父类异常]{
 // 如果在main()方法声明异常，则将会交给java虚拟机处理
}
```

## ★ Java中的集合框架

> Note

+ 所有接口都位于java.util包中；
+ Collection接口:允许元素重复，无序
+ Map接口:存储一组成对的键值对集合，键不要求有序，但不允许重复
+ key和value都允许为null,但值value允许重复
+ Set接口\<Cellection接口，存储一组唯一(不允许重复),无序的对象或者元素
+ List接口\<Cellection接口，存储一组允许重复的，有序的的对象或者元素
+ 接口继承关系：List\<ArrayList|LinkedList

### ◆ ArrayList：List接口常用实现类之一。随机访问性高，添加和删除元素性能低

+ boolean add(Object o);void add(int index,Object o);在集合列表中添加一个元素
+ int size();返回集合列表中的元素个数
+ Object get(int index);返回指定索引位置的元素值
+ remove(index);remove(Object)
+ contains()

### ◆ LinkedList：List接口常用实现类之一。随机访问性低，添加和删除元素性能高

+ getFirst();
+ getLast()
+ addFirst();
+ addLast()


### ◆ Map接口\<HashSet>实现类

### ◆ HashSet实现判断对象是否相等，根据HashCode来决定元素存储在结合中的某个位置

### ◆ 集合框架的迭代器Iterator

+ Collection接口提供了一个iterator()用于遍历集合类
+ Iterator iterator();
+ boolean hasNext();判断是否存在另一个可访问的元素
+ Object next();返回要访问的下一个元素,这个元素被访问时是Object类型

### ◆ Collection接口\<Map接口\<HashMap实现类

+ put(key,value);向集合中添加元素添加元素
+ Object get(key);通过键取值
+ keySet();获取键集合
+ valueSet();获取值集合

### ◆ Java中的泛型集合：在定义类或者接口的时候指定一个形式参数，在使用时传入一个实际的参数。语法：

List\<ClassType 泛型集合名　= new ?\<ClassType();

+ 泛型集合可调用集合框架的方法。
+ 泛型集合使用时不必拆箱和装箱(数据类型转换)
+ 泛型的遍历可以使用foreach循环。语法：

for(变量类型 变量名:泛型集合名){}

## ★ JDBC(Java DataBase Connected)：使用纯Java方式连接数据库，则需要先下载数据库厂商提供的驱动程序jar包，并将jar包引入工程中

选中要使用jar包的项目右键，依次选择ProjectPropertiesJava Build PathLibraries Add External JARs……
所有对数据库的操作都抛出了检查异常，在调用时必须显式try-catch

1. 要与数据库建立连接，则必须在项目中包含jdbc驱动包(可到官网下载驱动包)
2. 加载驱动

```Java
Class.forName("驱动字符串全限定名");//sql server数据库的驱动字符串为com.microsoft.sqlserver.jdbc.SQLServerDriver

// 创建数据库连接对象，与数据库建立连接。
  
// 连接字符串需要以jdbc:为前缀，语法(sqlserver):

Connection connectionObjectName = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;DatabaseName=数据库名称","用户名","密码"); // 调用DriverManager类创建连接对象，使用Connetction接口接收连接对象

Statement st = connectionObjectName.createStatement();  //使用连接对象实例化Statement对象

实现Statement语句接口，执行SQL语句
Statement接口方法

ResultSet rs = st.executeQuery(String sql);  //调用Statement对象executeQuery()方法创建Result结果集对象

//执行SQL查询并返回ResultSet接口对象

ResultSet executeQuery(String sql);

int executeUpdate(String sql);

boolean execute(String sql);

```

### PreparedStatement接口是Statement的子接口

  调用Connection接口的prepredStatement(Stirng sql)来创建PreparedStatement对象,sql语句可具有零个或者多个参数，这些参数的值在输入时未被指定，而是使用一个问号作为占位符(?)

+ 调用PrepredStatement对象的setxxx方法为sql语句参数赋值，参数
+ setxxx(参数1，参数2)第一个参数指定sql参数位置，从1开始，第二个参数指定值
+ 注意:执行PrepredStatement对象方法不需要参数, 参数在创建PrePredStatement对象时被指定
+ boolean execute(); // 执行任意sql语句，结果如果为ResultSet对象，则返回true,否则返回false
+ int executeUpate(); // 执行预编译sql语句，返回受影响行数
+ RusultSet executeQuery(); // 执行查询语句，并返回结果集对象

◆ 实现ResultSet接口，返回sql语句执行结果集

> ResultSet接口常用方法

+ boolean next();
+ void close();
+ int getInt(int columnIndex);int getInt(String columnLabel);
+ String getString(int columnIndex);String getString(String columnLabel);根据列名返回列的字符串值


◆ 按照连接对象先建立后关闭的原则依次关闭所有创建的数据库对象

## ★ 数据访问层(数据持久化)

在Java中使用分层结构来减少代码的冗余
分层结构有什么好处？
便于代码重用，提高开发效率，更好的分工协作
封装，对外提供接口
顺序访问，上一层调用下一层

### ◆ 数据层DAO(DataAccess Object):数据库存取对象
可以很好的隔离业务逻辑层

### DAO接口：层与层之间通过接口进行调用，降低耦合性；把所有对数据库的操作定义成抽象方法，在接口的实现类重写方法,可声明在包(.dao.)下

### DAO实现类:实现DAO接口中的抽象方法;DAO工具类：提供一些打开和关闭连接的方法,不仅仅是对于数据库的连接。可声明在包(.dao.impl)下

### ◆ DAO实体层
DAO实体类：一张表对应一个实体类，属性于数据库表中的列一一对应，可声明在实体类包(.entity.)下
使用实体类在各层之间传递数据，应该以对象为单位传递数据，而不是以属性来传递数据

### 业务层: .biz.

## ★ 文件io操作

```Java
// 导入io包。
import java.io.;

// 使用File类对象操作文件或者目录
```

+ File类对象主要有以下方法
+ boolean exists(); // 判断是否存在文件或者目录
+ boolean isFile(); // boolean isDirectory(); // 判断是否是文件或者目录
+ mkdir(),boolean createNewFile(); // 创建目录或者文件
+ String getPath(); // String getAbsolutePath(); // 返回File对象所在相对路径，返回.....绝对路径
+ String getName(); // 返回File对象表示的文件或者目录名称
+ boolean delete(); // 删除File对象指定的文件或者目录


```Java
// 如何使用File类来对文件或者目录操作？
File 对象名 = new File(String 路径);  //这里的路径可以是一个指向具体某一个文件的绝对路径，也可以是一个指向目录的目录路径
```

### ◆ Java中的io流
一个字节(1byte=8bit)=8个二进制位的数(8bit)
使用I/O流来从文件中读取或者向文件中写入数据,流的读取和关闭必须显示try-catch。

> 一些主要方法：

+ int read()
+ int read(char[] ch)
+ int read(char[] ch
+ int start
+ int length); // 将输入流读取到字节数组
+ void close();// 关闭输入流
+ void available(); // 返回输入流读取的字节数

输入流，允许从文件中读取数据。有字节和字符输入流
字节输入流：一次读取8个二进制位数据(一个字节的长度)，以InputStream和Reader作为基类
基类InputStream:字节输入流的基类，使用时通常调用它的子类(FileInputStream)的构造来完成实例化。语法

```
InputStream ObjectName = new FileInputStream(File对象|String filename);
```

+ 基类Reader类及其子类FileReader

```
Reader 对象名 = new FileReader(File对象|String filename);
```

字符输入流：一次读取16个二进制位的数据(两个字节,一个汉字的长度)

基类BufferedReader类及其子类FileBufferedReader，需要一个Reader类对象来完成实例化

```
BufferedReader 对象名 = new FileBufferedReader(Reader re);
```

> 方法：

+ String readLine(); // 读取一行数据，返回一行字符串; ps:一般情况下，对ANSI编码集的纯文本文件，读取到的中文显示很正常，其它编码集的读取出来的中文是乱码的
+ void close();

输出流,只允许向文件中写入数据

基类：Writer,OutputStream


## ★ Java中的反射机制：Java将所有事物都看做对象。而每个类一被jvm加载，则会在内存中创建一个与之对应的Class对象

> 获取内存中的对象(包括类)至少有三种方式

1. Class.forName方法加载；

+ Class.forName("类的全限定名即包名.类名"); // 如果成功加载指定的类，则返回一个Class对象，否则抛出ClassNotFound异常
+ Object getClass(); // Object有一个公有的getClass方法，通过此方法可以获取内存中的对象
+ Object object.class; // Object对象都有一个公有的class属性，此属性返回类的全限定名
+ getGenericSupperClass() // Object对象提供了一个getGenericSupperClass方法来直接获取类的直接父类类型
+ java.lang.reflect.Type // 所有类的公共父接口
+ java.lang.reflect.ParameterizedType接口 // 参数化类型接口，一般为泛型

为了获取直接父类的类型的泛型参数类型，应该调用参数化类型接口对象的的getActualTypeArguments方法，而泛型参数大多数并不止一个，因此，此方法返回的是一个数组。

2. ParameterizedType[] getActualTypeArguments() // 此方法获取所有参数化类型对象,返回一个参数化数组


# 附
## ★ 使用log4j日志工具记录java运行时的错误信息

+ 导入log4j包在要使用的项目的src目录下创建log4j.propterties配置文件
+ 添加log4j.propterties配置文件。并在配置文件中添加以下语句

```Java
# 设置日志记录器的输出级别和目的地
输出级别,只会输出高于或者等于的它的信息
fatal:如果程序发生严重错误，将退出程序
error:发生错误也会继续程序的执行
debug:最详细的输出
fatalerrorwarninfodebug
# 设置输出到目的地(Appender),可以是控制台(ConsoleAppender),也可以是日志文件(FileAppender)
# 设置输出日志时的布局类型(Layout)
SimpleLayout:纯文本输出
HTMLLayout:格式化为HTML表格输出
PartternLayout:根据转换模式输出
# 设置输出级别和目的地
log4j.rootLogger=debug(输出级别),stdout(目的地),logfile(可选，但如果要输出到日志文件则此项不可省)，输出目的地需要指定属性配置
# 日志信息输出到控制台(可选一)
log4j.appender.stdout=org.apache.log4j.ConsoleAppender
log4j.appender.stdout.Target=System.err|System.out //默认System.out
log4j.appender.stdout.layout=org.apache.log4j.SimpleLayout|....HTMLLayout
#日志输出位置
log4j.appender.console=org.apache.log4j.ConsoleAppender
#使用简单方式的输出
log4j.appender.console.layout=org.apache.log4j.SimpleLayout
#使用HTML格式输出
log4j.appender.console.layout=org.apache.log4j.HTMLlayout
#使用自定义格式化输出
log4j.appender.console.layout=org.apache.log4j.PartternLayout
#这必须要定义转换格式
log4j.appender.console.layout.ConversionPattern=格式。(可取值为:%d(时间) %p %c(类) %m%n);
# 日志信息输出到文件(可选一)
log4j.appender.logfile=org.apache.log4j.FileAppender
log4j.appender.logfile.File=jbit.log
log4j.appender.logfile.layout=org.apache.log4j.PatternLayout
log4j.appender.logfile.layout.ConversionPattern=%d{} %l %F %p %m%n
```


## 术语

+ JDK(Java Divelopment Kit):Java开发工具包。java程序的开发：编译，运行都需要它
+ JRE(Java Runtime Environment)：Java运行时环境，java程序的运行需要它
+ Java SE(Java Platform Standrad Environment):java标准平台环境，主要用于桌面程序的开发
+ Java EE(....Enterprise Environment)：java企业平台环境，用于Internet程序开发
+ Java ME(.......Moble Environment):Java移动平台开发环境

## ★ 配置Java及环境变量

  一般情况只需要将jdk下的bin目录路径添加到系统变量Path就可以运行或者编译运行java程序了。ps:公共jre下的bin可以不用添加

```batch
:: 新建用户级环境变量JAVA_HOME  新建变量值  将JDK包含的程序路径(一般将jdk或者jre下bin目录的上级目录)添加到系统环境变量Path下
setx JAVA_HOME "java安装路径"
```

```batch
:: 新建用户级环境变量CLASSPATH
setx CLASSPATH ".;%JAVA_HOME%\lib\dt.jar;%JAVA_HOME%\lib\tools.jar"
```

```batch
:: 新建用户级变量Path。添加jdk和jre的程序到此路径下
setx Path "%JAVA_HOME%\jdk\bin;%JAVA_HOME%\jre\bin"
```

CLASSPATH 详情见 [Oracle docs](https://docs.oracle.com/javase/8/docs/technotes/tools/windows/classpath.html).

MyEclipse单元测试功能:Junit
MyEclipse项目测试

> java IDE：

eclipse|MyEclipse配置？

NetBeans

## ★ java 运算符

位运算符 &:|"~:

算术运算符

关系运算符

逻辑运算符

&&:
||:
!:

# java FIQ 

？如果一个实现类在实例化对象时使用了匿名对象，那么除了父类或者接口中的方法外，能否访问自身的方法
经过测试，发现匿名对象同样可以调用自身的成员,匿名对象并没有实现多态。
？jdbc能否通过windows验证的方式连接到SQL Server数据库
这是一种并不推荐的连接方式，建议只做测试使用
1.根据系统的字长，添加对应的sqljdbc_auth.dll动态连接库到系统的system32目录下
2.定义SQL Server数据库连接字符串中时需要将windows集成安全验证IntegratedSecurity设为true，参数用户名和密码省略
加载类
Class.forName("com....SQLServerDriver");
* 如果使用默认端口号，则在连接字符串中可省略端口号
* windows集成安全选项必须设为true;
 -> String url="jdbc:microsoft:sqlserver://localhost:1433;DatabaseName=;Integrated Security=true"
 ..
 con = DriverManager.getConnection(url); //不再指定用户名和密码
 ...
 经过以上的步骤，理论上说就可以实现jdbc使用windows验证方式连接数据库了
？ 为什么要使用多态，面向接口编程？
   List list = new ArrayList();
   List list = new LinkedList();
   List list = new Vectory();
 ？List只是一个接口，为什么可以用来声明一个对象
  声明一个
 * 这里的list只是编译时的类型，当编译器实例化对象完成后会将它转换成new的数据类型，但是这种方式声明的对象只能对接口中的方法进行重写。无法调用自身特有的方法
* 将接口的实现类声明为接口或者将将抽象类的继承类声明为它的抽象父类。这种方式实现了多态。
* 编译时类型为声明类型，即:接口或者抽象父类；运行时则会将它转换为new的类型
* 不使用接口或者抽象类来声明接口实现类或者继承类，这并不是一种被推荐的做法。因为这并没有使用Java面向对象语言中的多态思想。
* 这种方式实例化的对象并没有语法错误。如果要调用实现类自身的方法，则需要使用它new的时候使用的数据类型;这里，也可以使用匿名对象来调用。
  > ArrayList list = new ArrayList();
  > LinkedList list = new LinkedList();
  > HashMap hmmp = new HashMap(String key,String value);
 * 通过这种方式new的对象，除了可以对所继承的接口中的抽象方法进行重写，还可以调用自身的方法。但是这并不方便代码后期的维护。

* 存在一种方式可以让接口被实例化，它必须作为类的内部类来使用,并且要实现接口中所定义的方法。语法:
接口名 标识符 = new 接口(){......实现接口中的方法.....};
抽象类 标识符 = new 抽象类(){......实现抽象方法......};

2015/11/20 星期五
？多态的表现形式
* 通过抽象父类搞出很多子类对象，执行的方法却是子类对象已经重写过的方法;调用的方法都是父类的方法
* 通过抽象父类或者接口创建的子类或者接口实现类对象只能选择重写父类中的方法，如果试图调用子类中存在的而父类中不存在的方法，那么将会发生编译错误。如果确实要调用子类自身的方法，则不能使用父类创建子类对象即不使用多态思想。还可以使用匿名对象来调用
使用父类创建子类对象
使用接口创建接口实现类对象、
使用抽象类创建实现抽象类的子类对象(一般通过子类继承抽象类，重写抽象父类中的所有抽象方法，否则子类也只能是抽象类)

？遍历一个集合中的元素
* 如果集合中添加的只是基本类型数据，那么从一个集合中得到所添加的数据只需要对这个集合进行遍历即可得到值
通过集合的get方法和索引即可得到
可以使用基本的for循环，也可以使用foreach循环
for(int i = 0;i<集合名.size();i++){
 get(i); //取出数据，引用类型转换为值(术语:拆箱)需要经过强制类型转换
}
* 如果在定义集合时使用了泛型，或者集合中保存的是一个数组对象，那么使用foreach循环来遍历集合或者泛型集合显然更方便。
for(集合中存储的数据类型 变量名 : 集合名){
  // 不需要强制类型转换(拆箱的过程)
}
？如果集合中存储的不是基本数据类型,而是一个自定义数据类型的对象呢，如何访问对象的属性和方法或者其它的成员
* 同样只需要遍历集合就行了，只是这里进行遍历的，是集合中存储的对象了；通过访问对象的属性
 如果已经将属性封装，则需要通过调用对象属性所对应的set方法为对象的属性进行赋值同样；
 通过属性对应的get方法即可得到属性的值
* 使用foreach循环来遍历集合中存储的对象，还可以通过集合遍历器Itator来遍历集合。
for(集合中存储的对象的类型 对象名 : 集合名){
  对象名.属性名();或者
  对象名.getxxx();
}
？结果集对象调用getXXX()试图读取某列数据时被JVM提示列名无效
首先应该检查表名以及列名是否正确，如果都确认无误，则继续检查是否将结果集getXXX()要读取的列包含在sql语句查询的列中
* 如果查询语句中没有包含某些列的列名，则通过结果集对象的getXXX()将不能读取这些列的数据
* 结果集对象只能读取sql语句中要查询的列的数据
假设存在一个users表，表中有两个字段，name和pwd
select name from users; //只查询name
....
rs.getX("pwd"); //如果试图调用结果集对象的getX()方法读取pwd字段的值将会无法读取pwd字段的值，JVM将返回列名无效的错误
？静态代码块中的变量和静态变量到底谁先被执行
按照关键字静态的static的定义，会按照顺序对成员访问，静态代码块无法访问类属性即在类中定义的类变量
？接口定义
* 接口中定义声明的变量都必须是公共的、终态的、静态的(即使在接口中定义变量时省略)，调用时无法再被重新赋值
每个变量都要以接口名.变量名来调用
* 接口中的方法都必须是抽象方法。不能有方法体。如果一个子类想要实现它，则必须重写接口中的所有方法
* 接口中的变量不能使用private修饰，方法不能使用static和final修饰，也不能用private修饰
？使用IO流来读取或者向文件中写入信息
* 流的读取和关闭均为检查异常，必须显式try-catch
* 流的读取或者写入之后总是需要被关闭，如果不关闭流，虽然编译运行不会出错，但可能得不到所需要的结果
？如果在一个类中不存在无参构造，则在实例化类对象时必须调用其有参构造来完成对象的实例化，否则会出现编译错误
？如果Java代码块声明了异常却又在方法中抛出异常，
以下代码
.....throws NullPointerException(){
....
throw new Excpetion();
...
}
？Web项目修改了项目名称后，在部署时使用原来的路径
选中项目右键，打开项目属性，搜索web
修改Context...为新的路径

修改了Java代码不重启Tomcat的方法：
Jsp代码修改之后不需要重启Tomcat  
以正常方式启动的Tomcat在修改了Java代码后需要重新部署和重启Tomcat服务  
如果将Tomcat以Debug的方式启动，修改Java代码之后Tomcat会自动重新载入，只限普通Java代码  
如果改了方法定义(方法形参变动，方法名改动等则需要重新部署项目，并重启Tomcat)
  
调试Servlet或者jsp中的小脚本方法：  
应用服务器(如Weblogic,apache Tomcat)应该以Debug方式启动
jsp或者Servlet中需要设置了断点

# 参阅：

+ [如何用java读取一个txt 文件内的内容并把它赋值与String里？-CSDN论坛-CSDN.NET-中国最大的IT技术社区](http://bbs.csdn.net/topics/370213517)

+ [识别常见编码格式文件并转换成UTF-8编码 的java实现 源码 - Michael.Wang - 博客园](http://www.cnblogs.com/DiYuShe/archive/2012/09/03/2668575.html)

+ [java按文件格式读取文件-wlcacc-ChinaUnix博客](http://blog.chinaunix.net/uid-20447986-id-1945567.html)

+ [java操作mysql存储读取图片-xueliangfei-ChinaUnix博客](http://blog.chinaunix.net/uid-26284395-id-3257621.html)

+ [java中时间格式SimpleDateFormat的使用学习-wlcacc-ChinaUnix博客](http://blog.chinaunix.net/uid-20447986-id-1945568.html)

+ [Java读取文件方法大全 - lovebread - 博客园](http://www.cnblogs.com/lovebread/archive/2009/11/23/1609122.html)

+ [ParameterizedType获取java泛型参数类型_Swift_IThao123 - IT行业第一站](http://www.ithao123.cn/content-563783.html)

+ [ImageUtil - Thinking的专栏 - 博客频道 - CSDN.NET](http://blog.csdn.net/hjxgood/article/details/46913035)

+ myeclipse使用常见问题 - 备忘录之胡言乱语 - ITeye技术网站

+ myEclipse运行很慢的原因及MyEclipse6_5屏蔽jsp校验 - 李宗辉 - 博客园
+ [PO BO VO DTO POJO DAO概念及其作用（附转换图） - 交口称赞 - BlogJava](http://www.blogjava.net/vip01/archive/2007/01/08/92430.html)
+ [VO ，PO ，BO，QO, DAO ,POJO,概念 - 业精于勤荒于嬉！ - BlogJava](http://www.blogjava.net/luofeng225/archive/2009/03/28/262620.html)

+ [类名.class, class.forName(), getClass()区别 - 网络终结者 - 博客园](http://www.cnblogs.com/feiyun126/archive/2013/08/01/3229492.html)

+ [黑马程序员--Java基础加强--12.利用反射操作泛型I【与反射+泛型相关的接口类型综述】【Type】【ParameterizedType】【个人_精品文库_IThao123 - IT行业第一站](http://www.ithao123.cn/content-3156676.html)

+ [JAVA-反射-getGenericSuperclass（）介绍 - Eason_Chan - 推酷](http://www.tuicool.com/articles/JbyEjyJ)

+ [Java学习笔记之使用反射+泛型构建通用DAO - Darker - 博客园](http://www.cnblogs.com/RGogoing/p/5325196.html)
