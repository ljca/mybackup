<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# Java 笔记
## [Java第一课：Java开发环境](java/Java第一课：Java开发环境.md)
## [Java第二课](java/Java第二课.md)
## [在Java中使用JNI(Jave Native Interface)调用C库](java/jni.md)
## [Jsp & Servlet：](java/jsp_servlet.md)
## [Structs Sprint Hibernate：Java Web 的三大框架](java/jsp_ssh.md)
## [调整java图形程序默认字体](java/调整java图形程序默认字体.md)

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
