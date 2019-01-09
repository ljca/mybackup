#  Java
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

 ◆ 类

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

匿名类

匿名内部类

◆ 类成员:对象(引用数据类型)

> 在Java中，还存在一种匿名对象的写法。为一个集合或者泛型集合添加数据时;测试一个实例方法或者这个实例方法只需要调用一次时。

> Note：

+ 创建对象时不需要声明一个对象来保存，直接使用new 数据类型().成员名的形式调用
+ 显式对象及匿名对象
+ 匿名对象:实例化一个类时，不声明对象名和对象的类型
+ 适合临时调用实例对象方法
+ 在集合中添加对象时

◆ 类成员：方法

> 方法是Java中必不可少的元素，存在不同的几种方法定义形式，不仅仅是功能和结构上。用于传递数据和增加代码重用性。逻辑代码必须位于方法之中，语法:
  
```Java
[访问修饰符] [static] 方法返回值 方法名(参数列表，允许无参){

//方法体
}
```

ps: 构造方法、抽象方法使用与此不同的形式来定义或者声明。

+ 类成员:字段 

> 字段私有，字段getter/setter方法公开

★ 类成员：变量及数据类型

> 程序中，变量的声明和定义是必须的，它被用来临时保存一些程序运行所依赖的值，这个值可以是计算内存地址

◆ 基本和引用数据类型

 + byte|short|int|lang
 + float|double
 + char|String(引用数据类型)

  变量可以在声明它的时候给它赋值:

```Java
[访问修饰符] [static] 变量类型 变量名[ = 初值];
```

◆ 类成员：数组(引用类型)，可以分为基本、引用，以及对象数组
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

◆ 对象数组的声明


◆ 类成员: 静态代码块和代码块

在一个类或者一个方法中，可以使用一组花括号将代码包含，来声明一个代码块{}，它并不会比，除非它被声明为静态的(static)
static{}

★ java中的访问修饰符

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

★ 面向对象的第一大特征:封装

+ 将类的属性私有化，提供对外访问接口，并创建getset方法返回值
+ 如果已经定义了私有属性，则可以使用快捷键:Shift+Alt+S来快速创建属性对应的getter/setter方法

★ 面向对象第二大特征:继承

+ 父类派生子类的过程。一个子类只允许继承一个父类，同时继承多个父类是不允许的通过继承，子类可以访问父类的所有非私有成员，还可以定义自身的成员
+ 使用this或者super来访问父类非私有成员以及this、super的区别
+ this 指代当前实例对象，通过this可以访问实例变量和方法以及构造。但this不允许调用类属性和类方法，也不允许调用局部变量

★ 面向对象第三特征:多态

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

★ 构造方法

在一个类中，存在一个特殊的方法，这个方法方法名和类名一致，它不允许任何返回值类型的关键字(void也不行)修饰，它被称为类的构造方法。

> 注意：

这个类最好不要声明为abstract，构造方法也允许在抽象类中被声明定义，但不能用于实例化构造方法用于初始化类的对象，包括属性和方法，构造方法可以被重载，但不允许被子类继承和重写。语法：

```Java
[访问修饰符] 类名(){} //如果在类中声明定义了有参构造，则无参构造也必须被声明
```

```Java
[访问修饰符] 类名(参数列表){}
```

◆ 方法重载

在同一个类中，可以有一些方法名相同，参数列表不同的方法，包括顺序，个数以及类型不同。这些方法被称为重载方法

方法重载与方法有无返回值，访问权限无关如果调用重载的构造，则必须位于第一行

 ◆ 方法重写

> 在子类中对继承父类的方法重新编写，称为方法的重写。方法重写有以下的要求：

+ 方法名必须相同
+ 参数列表必须一致，包括返回值、类型、个数
+ 重写方法必须具有和被重写方法相同的返回值类型
+ 重写方法不能缩小被重写方法的访问权限

 ◆ extends和super关键字

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

★ 抽象类和抽象方法

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

 ◆ java中的类型转换
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

★ Java中的异常处理

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

★ 使用log4j日志工具记录java运行时的错误信息

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

★ Java中的集合框架

> Note

+ 所有接口都位于java.util包中；
+ Collection接口:允许元素重复，无序
+ Map接口:存储一组成对的键值对集合，键不要求有序，但不允许重复
+ key和value都允许为null,但值value允许重复
+ Set接口\<Cellection接口，存储一组唯一(不允许重复),无序的对象或者元素
+ List接口\<Cellection接口，存储一组允许重复的，有序的的对象或者元素
+ 接口继承关系：List\<ArrayList|LinkedList

◆ ArrayList：List接口常用实现类之一。随机访问性高，添加和删除元素性能低

+ boolean add(Object o);void add(int index,Object o);在集合列表中添加一个元素
+ int size();返回集合列表中的元素个数
+ Object get(int index);返回指定索引位置的元素值
+ remove(index);remove(Object)
+ contains()

◆ LinkedList：List接口常用实现类之一。随机访问性低，添加和删除元素性能高

+ getFirst();
+ getLast()
+ addFirst();
+ addLast()


◆ Map接口\<HashSet>实现类

◆ HashSet实现判断对象是否相等，根据HashCode来决定元素存储在结合中的某个位置

◆ 集合框架的迭代器Iterator

+ Collection接口提供了一个iterator()用于遍历集合类
+ Iterator iterator();
+ boolean hasNext();判断是否存在另一个可访问的元素
+ Object next();返回要访问的下一个元素,这个元素被访问时是Object类型

◆ Collection接口\<Map接口\<HashMap实现类

+ put(key,value);向集合中添加元素添加元素
+ Object get(key);通过键取值
+ keySet();获取键集合
+ valueSet();获取值集合

◆ Java中的泛型集合：在定义类或者接口的时候指定一个形式参数，在使用时传入一个实际的参数。语法：

List\<ClassType 泛型集合名　= new ?\<ClassType();

+ 泛型集合可调用集合框架的方法。
+ 泛型集合使用时不必拆箱和装箱(数据类型转换)
+ 泛型的遍历可以使用foreach循环。语法：

for(变量类型 变量名:泛型集合名){}

★ JDBC(Java DataBase Connected)：使用纯Java方式连接数据库，则需要先下载数据库厂商提供的驱动程序jar包，并将jar包引入工程中

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

PreparedStatement接口是Statement的子接口
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

★ 数据访问层(数据持久化)

在Java中使用分层结构来减少代码的冗余
分层结构有什么好处？
便于代码重用，提高开发效率，更好的分工协作
封装，对外提供接口
顺序访问，上一层调用下一层

◆ 数据层DAO(DataAccess Object):数据库存取对象
可以很好的隔离业务逻辑层
DAO接口：层与层之间通过接口进行调用，降低耦合性；把所有对数据库的操作定义成抽象方法，在接口的实现类重写方法,可声明在包(.dao.)下
DAO实现类:实现DAO接口中的抽象方法;DAO工具类：提供一些打开和关闭连接的方法,不仅仅是对于数据库的连接。可声明在包(.dao.impl)下

◆ DAO实体层
DAO实体类：一张表对应一个实体类，属性于数据库表中的列一一对应，可声明在实体类包(.entity.)下
使用实体类在各层之间传递数据，应该以对象为单位传递数据，而不是以属性来传递数据

  业务层:
.biz.

★ 文件io操作

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

◆ Java中的io流
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


★ Java中的反射机制：Java将所有事物都看做对象。而每个类一被jvm加载，则会在内存中创建一个与之对应的Class对象

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


★ 使用Dbutils工具包简化jdbcGUID代码

获取Java工具包commons-dbutils.jar,此工具包由apache公司提供
导入工具包到项目
此工具包提供了三个包 `org.apache.org` `QueryRunner`类

提供了对数据库DML的方法,即包括对数据库的增删改查

> 对数据库的查询提供了重载方法query，方法原型声明如下

+ public Object query(Connection con,String sql,ResultSetHandder rsh); // 执行没有参数设置或者交换的sql，如查询一个表中的所有记录
+ public Object query(.....);
+ public Object query();
+ public Object query();


Dbutils工具类
 提供了包含多个重载的关闭连接的类方法，所有方法都是静态的，并且都没有返回值
 参数可以是连接对象，结果集对象，执行一个安全的sql的预编译对象Prep..stateMent

+ void close(参数|参数集|null); // 如果传递的参数为null,则
+ void closeQue...(); // 调用此方法可以关闭连接并且隐藏抛出的异常
+ void commitAndClose...() // 这个方法允许向数据库提交sql之后就关闭数据库连接;
+ Abstract..
+ SetRusultHandder接口
+ SetRusultHandder包含了多个实现类
+ BeanHandder
+ BeanListHandder
.......

术语

+ JDK(Java Divelopment Kit):Java开发工具包。java程序的开发：编译，运行都需要它
+ JRE(Java Runtime Environment)：Java运行时环境，java程序的运行需要它
+ Java SE(Java Platform Standrad Environment):java标准平台环境，主要用于桌面程序的开发
+ Java EE(....Enterprise Environment)：java企业平台环境，用于Internet程序开发
+ Java ME(.......Moble Environment):Java移动平台开发环境

★ 配置Java及环境变量

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

★ java 运算符

位运算符 &:|"~:

算术运算符

关系运算符

逻辑运算符

&&:
||:
!:

 vim:set filetype=markdown: 
+ [ant的安装、使用，build.xml简单编写 - 不学习就淘汰 - 博客频道 - CSDN.NET](http://blog.csdn.net/bao19901210/article/details/23844107)

+ [ANT及build.xml文档编写 - struts2 - ITeye技术网站](http://aaagu1234.iteye.com/blog/927494)

+ [Ant系列-第一个build.xml - 综合编程类其他综合 - 红黑联盟](http://www.2cto.com/kf/201503/385906.html)

+ [hibernate4的BaseDao实现_小组_ThinkSAAS](http://www.thinksaas.cn/group/topic/102449/)

+ [hibernate--basedao，借鉴别人的完善自己的](http://www.360doc.com/content/16/0331/12/27730037_546781068.shtml)

+ [hibernate框架BaseDao - 开源中国社区](http://www.oschina.net/code/snippet_1170373_22692)

+ [ImageUtil - Thinking的专栏 - 博客频道 - CSDN.NET](http://blog.csdn.net/hjxgood/article/details/46913035)

+ [Java读取文件方法大全 - lovebread - 博客园](http://www.cnblogs.com/lovebread/archive/2009/11/23/1609122.html)

+ [JAVA-反射-getGenericSuperclass（）介绍 - Eason_Chan - 推酷](http://www.tuicool.com/articles/JbyEjyJ)

+ [Java学习笔记之使用反射+泛型构建通用DAO - Darker - 博客园](http://www.cnblogs.com/RGogoing/p/5325196.html)

+ [jQuery Ajax异步处理Json数据详解_jquery_脚本之家](http://www.jb51.net/article/42795.htm)

+ [jQuery使用$.each遍历json数组的简单实现方法_jquery_脚本之家](http://www.jb51.net/article/82576.htm)

 + [Ajax 详解 (2) ：XHR 实例 GET 和 POST 异步和同步 - 温故而 ' 自信 ' - SegmentFault](https://segmentfault.com/a/1190000002789203)

+ [Mybatis 3.1中 Mapper XML 文件 的学习详解 - zhll3377的专栏 - 博客频道 - CSDN.NET](http://blog.csdn.net/zhll3377/article/details/8203440)

+ [mybatis关系映射之一对多和多对一](http://www.mamicode.com/info-detail-188913.html)

+ [MyBatis学习总结(一)——MyBatis快速入门 - 孤傲苍狼 - 博客园](http://www.cnblogs.com/xdp-gacl/p/4261895.html)

+ [ParameterizedType获取java泛型参数类型_Swift_IThao123 - IT行业第一站](http://www.ithao123.cn/content-563783.html)

+ [PHP_ internals_windows_stepbystepbuild](https://wiki.php.net/internals/windows/stepbystepbuild#build_your_own_php_on_windows)

+ [PO BO VO DTO POJO DAO概念及其作用（附转换图） - 交口称赞 - BlogJava](http://www.blogjava.net/vip01/archive/2007/01/08/92430.html)

+ [Struts2-I18n国际化 - PerfectPlan - ITeye技术网站](http://perfectplan.iteye.com/blog/1561810)

+ [Struts2工作原理 - 博学而笃志，切问而近思 - 博客频道 - CSDN.NET](http://blog.csdn.net/wuwenxiang91322/article/details/11070513)

+ [Struts2下使用Common-FileUpload实现文件上传 - 海洋之心 - 博客频道 - CSDN.NET](http://blog.csdn.net/cuihaiyang/article/details/6289639)

+ [Struts 2中实现文件下载（修正中文问题） - 火拳 - ITeye技术网站](http://pengranxiang.iteye.com/blog/259401)

+ [VO ，PO ，BO，QO, DAO ,POJO,概念 - 业精于勤荒于嬉！ - BlogJava](http://www.blogjava.net/luofeng225/archive/2009/03/28/262620.html)

+ [黑马程序员--Java基础加强--12.利用反射操作泛型I【与反射+泛型相关的接口类型综述】【Type】【ParameterizedType】【个人_精品文库_IThao123 - IT行业第一站](http://www.ithao123.cn/content-3156676.html)

+ [基于hibernate的BaseDAO接口 - Thinking的专栏 - 博客频道 - CSDN.NET](http://blog.csdn.net/hjxgood/article/details/45170349)

+ [类名.class, class.forName(), getClass()区别 - 网络终结者 - 博客园](http://www.cnblogs.com/feiyun126/archive/2013/08/01/3229492.html)

+ [轻松掌握XMLHttpRequest对象 - Bēniaǒ - 博客园](http://www.cnblogs.com/beniao/archive/2008/03/29/1128914.html)

+ [认真学spring官网，很容易找到spring4的jar包下载位置 - OPEN资讯](http://www.open-open.com/news/view/1eb1613)

+ [如何开发Leanote桌面端插件 · Issue _110 · leanote_desktop-app · GitHub](https://github.com/leanote/desktop-app/issues/110)

+ [如何开发Leanote桌面端主题 · Issue _109 · leanote_desktop-app · GitHub](https://github.com/leanote/desktop-app/issues/109)

+ [使用ant编译打包、部署简单的javaweb项目 --02 - 小代码2016的个人页面 - 开源中国社区](http://my.oschina.net/iamhere/blog/526750)

+ [使用Struts2验证框架实现输入校验 - 海洋之心 - 博客频道 - CSDN.NET](http://blog.csdn.net/cuihaiyang/article/details/6295763)

+ [掌握 Ajax，第 1 部分_ Ajax 入门简介](http://www.ibm.com/developerworks/cn/xml/wa-ajaxintro1.html#ibm-pcon)

+ [掌握 Ajax，第 7 部分_ 在请求和响应中使用 XML](http://www.ibm.com/developerworks/cn/xml/wa-ajaxintro7.html)

+ 你知道hover、active这四个伪类为什么要按顺序写吗 - 推酷

+ 青鸟论坛 - 云豆网，北大青鸟官方学员社区

+ JAVA_北大青鸟官方网站

+ myeclipse使用常见问题 - 备忘录之胡言乱语 - ITeye技术网站

+ myEclipse运行很慢的原因及MyEclipse6_5屏蔽jsp校验 - 李宗辉 - 博客园

+ Tomcat6_0配置JNDI数据源完整例子 - jiafugui的专栏 - 博客频道 - CSDN_NET

