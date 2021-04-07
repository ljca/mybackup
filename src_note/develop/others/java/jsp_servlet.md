<link href="../../../css/style.css" rel="stylesheet" type="text/css" />


# Jsp & Servlet：

C/S(Client/Server):客户端/服务器端模式，基于局域网
使用C/S结构的Web应用程序，则必须安装客户端程序，维护和升级必须在服务器和客户端同时进行
B/S(Browser/Server):浏览器/服务器模式，基于请求和响应
维护时只需要对服务器进行就可以了，维护升级更新快 适用点和依赖不同

URL包括协议:主机名:端口和资源路径。

静态网页与动态网页的区别？
静态网页对搜索引擎支持比较好，只是一个HTML网页，并且不具备于数据库交互的能力

运行环境部署：

## Ant：自动编译、

+ [ant](https://www.apache.org/dist/ant/binaries/)
+ [Tomcat](http://archive.apache.org/dist/tomcat)

[^web_]: web容器:存放网页的服务器

## 使用APACHE开源项目：Tomcat服务器，Tomcat服务器的安装及配置

Tomcat目录结构
bin:可执行文件目录;conf:Tomcat服务器配置文件;
temp:webapps:web项目部署的目录;
work:lib:Tomcat服务器所依赖的第三方jar包存放路径;
logs:Tomcat服务器存放日志文件目录

启动和关闭Tomcat服务器服务

> 在Tomcat下手动部署Web项目

  在webapps下新建项目存放目录>在项目存放目录下新建目录WEB-INF>在WEB-INF下新建目录classes和lib,配置文件web.xml
  /:项目根目录
  /WEB-INF:
  web.xml:配置文件
  /WEB-INF/classes:项目可执行字节码文件 /WEB-INF/lib:项目依赖的jar工具包
  /index.jsp:页面跳转文件

> 使用MyEclipse部署Web项目

  新建WEB项目>发布WEB项目，发布之前，确保JDK的正确配置，并且打开了web容器服务

# ★ JSP(Java Server Page)
可以看做动态的html网页，将java代码嵌入html文件<%%>标记中
  ◆ page指令(jsp页面声明指令)
page指令主要用于声明和导入，以`<%@ 开始，以%>`结尾，语法:

```jsp
  <%@ page language="" import="" contentType="text/html;charset=utf-8" %>
```

  page指令包含页面声明language，
  文档类型及编码格式声明contentType:
  包导入声明import，多个包之间使用逗号分隔
  ◆ include指令(静态包含指令) `<%@ file="文件路径"%>`
 ps:所有java代码都要包含在<%%>中

## ★ JSP脚本元素
 ◆ 表达式(expression)
  在jsp中使用表达式，不能在表达式后添加分号 `<%=变量 %>`
 ◆ 小脚本(scriptlet) 
  小脚本功能强大，使用时只需要将java代码插入到标记<% %>之间
 ◆ 声明(declaration)
声明应该包含在<%! %>之间，可以在<%! %>之间声明java方法......
  注意：声明的方法应该返回值

## ★ JSP内置对象

内置对象由WEB容器存储加载的一组Severlet API,这些实例已经由JSP规范默认初始化，使用时不需要实例化。而可以直接使用对象名.方法名()的方式调用

###  ◆ out对象:用于输出
###  ◆ request对象：处理浏览器请求

+ String getParameter(String name);
+ String[] getParameter(String name);
+ void setCharacterEncoding(String charset); // 设置页面编码
+ void setAttribute(String key,Object obj);  //可以将对象通过键和值的形式保存到request作用域中，然后使用通过键来访问对象
+ void getAttribute(String key); //通过键的形式访问对象

[preblem]: 如果通过get方式提交数据并且在页面还存在中文。那么跳转后再访问则会出现乱码。可通过在Tomcat配置文件server.xml设置编码集来解决这个问题；在conf\server.xml文件中的第一个`<Connecter>`元素下添加属性URIEncoding="UTF-8"

+ RequestDispatchar getRequestDispatcher(String path).forward(request,reponse); 
+ gertRequestDispatcher(String path)方法返回一个javax.servlet.RequestDispatcher对象，该对象的forward方法可以在其它页面转发浏览器请求，这并不会更新URL

###  ◆ response对象
  响应浏览器请求，用于在各个页面间传递消息和跳转

> 常用方法：

+ void response.addCookie(Cookie对象); //在客户端添加cookie
+ void response.setContentType(String type);
+ void response.setCharecterEncoding(String charset); // 设置响应所采用的编码集
+ void response.sendRedirect(String location);  //重定向浏览器请求到新的URL

### ◆ 转发和重定向

   都能实现页面间的跳转

   转发：服务器端将多条信息在多个页面进行传递，在服务端进行，URL并不会更新
   重定向：客户端发送请求>服务端返回页面>客户端跳转到指定页面，跳转到新的URL；客户端发送新的请求

+ setAttribute("名",值); //在request作用域中设置属性
+ getAttribute("名",值);

###   ◆ session对象

  记录浏览器访问状态以及权限控制，跟踪会话
    * 浏览器和WEB服务器使用HTTP协议进行通信
    * 会话：浏览器和服务器之间可能包含多个请求的一次通话，打开一个新的浏览器窗口会是一次新的tcp/ip请求，因此，服务器会再次为新的浏览器创建一个session对象，分配一个唯一的sessionid；通过这个sessionid，服务器可以判断多个浏览器之间不同的请求
        浏览器在与服务器交互的过程中，服务器会先判断是否存在这个session对象
        会话共享:打开一个相同的浏览器窗口向服务器发送tcp/ip请求，即使浏览器版本不同，也会被服务器认为是同一个session对象，可以在启动浏览器时使用 -nomarge选项来避免浏览器会话共享
    *  如果在会话中服务器与浏览器不存在session对象，则会创建一个session对象并且分配一个唯一的sessionid来标识session对象，但这个sessionid只在有效时间内有效，超过则会被销毁；如果在浏览器中没有手动销毁session对象，则退出浏览器也不会真的销毁session对象，session对象只会在会话超时后被销毁，默认为30分钟
    * 浏览器使用cookie来记录服务器的sessionid

>  session对象的常用方法：

```jsp
     > setAttribute(String key,String Value); //手动保存session对象到session中
     > Object getAttribute(String key);  // 通过key获取session中保存的对象
     > void invalidate(); 手动销毁session对象
     > String getId(); //获取sessionid
     > void setMaxInactiveInterval(int interval); //设置session对象有效时间
     > int getMaxInactiveInterval();  //获取session对象的有效非活动时间，以秒为单位
     > void removeAttribute(String key);  //在session中通过指定名称(key)移除对应session对象
```

### ◆ application对象:应用程序上下文对象
   存储的数据可以让同一个web服务器的web系统所有用户共享，application对象只能有一个实例；

> application对象常用方法:

```jsp
   > void setAttribute(String key,Object value); // 以key/value的形式将对象存储到application对象中
   > Object getAttribute(String key);  //通过key获取application中存储的对象
   > String getRealPath(String Path);  //返回相对路径的真实路径
```
 
### ◆ Cookie：在浏览器中记录服务器的会话状态
  主要有以下作用:
    对浏览器特定对象的跟踪，如访问次数、最后访问时间、路径
    统计网页浏览次数
    在cookie有效期内，记录用户登录次数
   Cookie类位于javax.servlet.http包下；name:代表cookie的名称;value:代表当前key对应的值

>  创建Cookie对象

```jsp
> Cookie Cookie对象名 = new Cookie(String key,String value);
 * 通过response对象的addCookie()写入Cookie，读取cookie调用JSP内置对象request对象getCookies()方法；
  > void response.addCookie(Cookie对象); //在客户端添加cookie
  > Cookie[] getCookies();
 * Cookie对象的常用方法：
    > void setMaxAge(int expiry);  //设置Cookie对象的有效期，以秒为单位
    > void setValue(String value); //创建cookie对象之后，重新给cookie对象指定新的名称
    > String getName(); //获取cookie对象的名称
    > String getValue(); //获取cookie对象的值
    > int getMaxAge(); //获取cookie对象的有效期限
```

## ◆ 作用域

```jsp
  page:只对jsp页面有效
  request:可在页面转发时生效，相关方法:
  setAttribute(String key,Object obj);
getAttribute(String key);
  response:可在
  session:可在会话间有效
  application:
  * session对象和Cookie对象的区别
   session:
   在服务器端保存客户端的状态信息，会话结束之后，数据就被销毁，可以保存任意对象和比较重要的信息
   Cookie:
   在客户端能以字符串的形式长期保存各种状态信息，但对于比较重要的数据并不安全
```

## ★ JavaBean：符合规范的类被称之为javaBean
必须有一个无参构造，属性必须私有，对外提供访问属性的getter/setter方法
JavaBean包含业务Bean:封装业务逻辑代码和数据Bean：封装数据
优势:
提高代码可重用性集可维护性，减少代码冗余，功能更明确

## ★ 使用分层实现业务处理

### ◆ JNDI(Java Naming Directory Interface):Java命名和目录接口，是一组为应用程序设计的API
将对象与名字绑定，应用程序使用时可通过名字获取对象或者业务

### ◆ 配置context.xml文件(测试)
添加`<Environment>`元素：此元素配置的值对整个web程序可见，包含的属性有name:type:value:
name:环境条目名称,相对于java:comp/env的名称
type:环境条目的java类名的全称
value:通过JNDI context请求时，返回给应用的参数值，该值必须强制类型转换为type属性定义的Java类型

### ◆ 数据库连接池(Connection Pool)
在Tomcat服务器中建立一个一块缓存区域，用来存储事先已经建立好的数据库连接
在需要进行数据库连接请求时，可以直接通过事先定义好的名称来取得数据库连接，而无需在从数据库中取得数据库连接,这些连接由Tomcat进行管理
数据库连接池负责分配、管理和释放数据库连接，它允许应用程序使用同一个数据库连接(这个连接必须被上一个web程序释放)

### ◆ DataSource(javax.sql.DataSource)类:这个类由Tomcat提供，因此不能通过创建实例的方式创建DataSource对象
在Tomcat中配置好的数据库连接池以数据源的形式存在
使用JNDI访问数据库：添加jdbc驱动和动态的配置数据源
ps:修改context配置文件之后，不要关闭MyEclipse和Tomcat

1. 动态配置conf\context.xml文件(对所有web程序生效)

也可单独在web项目根目录下添加context配置文件，同样在`<Context>`元素下配置`<Resource>`元素。web.xml文件也要配置
 此方式只对项目生效

在conf\context.xml文件的`<Context>`元素下添加`<Resource>`元素：此元素的属性用来配置数据库连接池中的参数
  Resource元素需要有以下属性

+ name:指定访问JNDI名字(在配置文件context.xml下的Resource元素中被指定);
+ auth:Manager方式[取值:Container(由Tomcat服务器创建Resource)|Application(由web应用程序创建和管理)];
+ type:指定Resource所属Java类名；maxActve:指定连接池中最大激活连接数；
+ maxIdle:指定连接池中允许存放的数据库连接最大值；
+ username:指定访问数据库用户名；password:指定访问数据库的密码
+ driverClassName:指定连接数据库的jdbc驱动类型；url:指定连接数据库的URL

2. 配置web.xml文件
在<web-app>元素下添加<resource-ref>元素:包含对外部资源的引用，包含description属性、res-ref-name、res-type、res-auth属性
  属性列表:(属性值要与context.xml配置文件下Context元素下的Resource元素属性值对应)
  description:对引用资源的说明；res-ref-name:指定引用资源的JNDI名字；
  res-type:指定引用资源的类名；res-auth:指定引用资源的Manager

4. 添加jdbc驱动到Tomcat>lib目录
ps:如果在添加驱动之前已经打开MyEclipse,则必须重启MyEclipse方可生效

使用javax.naming包下的Context接口来取得DataSource对象，再由DataSource对象的getConnection()方法取得连接
 Context接口:由一组名称到对象组成;InitialContext接口是Context接口的实现类
 初始化一个Context对象
 Context ctex = new InitialContext();

5. 获取数据源对象

  Object lookup(String name); //根据JNDI名称检索数据源对象;JavaEE所有应用程序中所有名称都要以java:comp/env为前缀，此方法经过强制类型转换取得DataSource对象
  DataSource ds = (DataSource)ctex.lookup(JNDI名字);
  获取数据源 ds.getConnetction();  //此方法返回一个数据库连接对象

ps:连接成功之后必须关掉数据库连接，否则会出异常，这里的关掉连接只是释放数据源到Tomcat数据库连接池

 ◆ 使用集合封装数据>保存集合结果到request或者session作用域>遍历集合取出集合中的数据

## ★ Java WEB程序中的分层模式
◆ 表示层：提供交互式界面，位于最顶层，web程序通常以jsp/html文件为主
◆ 业务逻辑层:通常是定义一组接口，放在diz包下
◆ 数据访问层:位于最底层，不必依赖其它层通常放在dao包下
◆ 实体层:存放一些实体类，实体类是存放了一些用于在数据库和其它页面之间进行传递数据的字段，这些字段一般会将它进行封装
通常使用.entity.的包来组织

## ★ 使用分页技术来显示查询结果
 获取数据库表的记录数>根据每页显示条数计算所需页面

## ★ 使用Commons-Upload组件上传文件到服务器

  上传文件，需要有Commons-Upload组件，但是IDE默认是不包含Commons-Upload组件的，所以需要从网络获取Commons-Upload组件并包含到web项目中；Upload组件包含可执行jar包:commons-io.jar及commons-fileupload.jar 同时，必须为`<form>`元素的enctype指定一个值。

+ multipart/date:用于上传二进制/多媒体文件;
+ text/plain:主要用于上传纯文本文档
+ application/x-www-form-urlencoded:默认值，以字符串的形式上传;此种方式无法上传文件。

  文件上传的基本API:(使用之前确保已经包含Commons-Upload组件到web项目中)

```jsp
  ServletFileUpload类
  需要一个FileItemFactory来完成实例化。语法：
  > ServletFileUpload 对象名 = new ServletFileItemUpload(FileItemFactory ll);
  FileItem接口的实现类DiskFileItem
  FileItemFctory接口及其实现类DiskFileItemFactory
```

# ★ 使用Servlet开发web应用程序
一个符合Servlet规范的java程序，是一个基于java的web组件，由web容器管理。用于生成动态内容
用来处理客户端请求，并响应的服务端程序
  开发一个Servlet程序,可以使用下列几种形式之一

+ 在java中实现Servlet接口
如何使用Servlet？
在web.xml中配置servlet

```xml
<servlet>
<servlet-name>类名</servlet-name>
<servlet-class>包名+类名</servlet-class>
</servlet>
//配置映射
<servlet-mapping>
<servlet-name>类名</servlet-name>
<url-pattern>路径</url-pattern>
</servlet-mapping>
```

+ 继承GenericServlet(继承自Servlet接口的一个抽象类)，不必依赖于任何网络传输协议

+ 专用于处理http协议的Servlet:抽象类HttpServlet继承自GenericServle
使用这个类，如果没有特殊需求，那么一般只需要重写doGet(),doPost()这两个方法就可以了;

## ★ Servlet生命周期

实例、初始化:第一次请求时被处理，只会在发送第一次请求时被执行，注意：实例化比初始化先被执行。处理事务、 销毁:web容器被关闭或者重新加载项目中的Servlet程序

ServletConfig接口

获取Servlet信息
getInitParmeter(name) //初始化参数
getServletContext(source) //获取应用程序上下文路径

## ★ 使用EL(Expression Language)访问数据，仅能访问jsp内置对象作用域中的数据。语法：${}

EL访问数据时，依次从page到applicaion这几个jsp内置对象中查找并按作用域小的到大的进行访问，如果想要访问某个对象中的数据，那么可以使用它所对应的的隐式对象进行访问

◆ 作用域对象： `pageScope、requestScope、..applicatonScope`

◆ 参数对象：param 使用param获取参数、使用paramValues获取一组参数。语法

 + param.参数名
 + paramValues

◆ 页面上下文对象:pageContext

### ★ EL支持运算符
  基本的算术、逻辑、关系运算符
  除了基本的，同样也支持这种方式：等于(eq)、不等于(ne)、大于(gt)、小于(lt)、大于等于(ge)、小于等于(le)
ps:访问对象属性需要用EL表达式。如果不对EL进行配置，那么可能无法访问对象的方法
.运算符导航对象属性....
[]可以访问所有点运算符中的数据，也可以访问数组或者集合。//使用[]访问对象属性时，需要为属性加上双引号或者单引号

### ★ 使用JSTL(Jsp Standard Tag Library):JSP标准标签库替换JSP页面的java代码
使用之前需要导入标准标签库,语法：
 prefix:定义前缀，uri:指定标签库类型 `<%@ taglib uri="" prefix="" %>`

◆ 标准标签库中的核心标签库
ps:变量及表达式的存取需要使用EL表达式。假设存在一个前缀为c的核心标签库，那么
 ◆ 通用标签库：

```jstl
<c:set>:定义变量并赋值,以下语法定义一个基本的变量并为它赋值：
<c:set></c:set>
 主要有以下几个属性：var:value:target:default:
 <c:out>:输出
 <c:remove>:删除作用域中的数据
 标准标签库中的条件和迭代标签 
<c:remove></c:remove>
◆ 条件标签库if:
<c:if test="" ></c:if>
test:
choose-when...
◆ 迭代标签forEach
主要属性：
items:集合，数组。通过EL表达式获取
var:定义变量。语法: var="变量名"
begin:
end:
step:步长值
varStatus:
status:迭代状态值，它主要有以下子属性
 index:
 count:
 first:
 last:
 current:
```

#### ★ 在web项目中使用jstl自定义标签
继承SimpleTagSupport类并重写doTag方法，配置tld文件
在taglib节点映射url节点

```xml
....
<short-name></short-name> <!-- 配置标签短名 -->
<uri></uri> <!-- 配置tag标签映射路径-->
配置tag节点
<tag>
"
<name></name>
"标签映射类
<tag-class></tag-class>
"是否有标签体
<body-content>scriptless</body-content>
* 让自定义标签拥有属性
* 在类中封装属性，并提供对外的get/set方法。
"配置节点属性
<attribute>
</attribute>
</tag>
映射属性<attribute></..>
```

#### jsp调用自定义标签
导入标签库 -> 调用标签
在web项目使用过滤器
实现javax.serverlet.Filter接口,重写doFilter()和init()方法。

# ★ 使用Dbutils工具包简化jdbcGUID代码

获取Java工具包commons-dbutils.jar,此工具包由apache公司提供
导入工具包到项目
此工具包提供了三个包 `org.apache.org` `QueryRunner`类

提供了对数据库DML的方法,即包括对数据库的增删改查

> 对数据库的查询提供了重载方法query，方法原型声明如下

+ public Object query(Connection con,String sql,ResultSetHandder rsh); // 执行没有参数设置或者交换的sql，如查询一个表中的所有记录
+ public Object query(.....);
+ public Object query();
+ public Object query();


## Dbutils工具类
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

# 附
## FIQ：

？在java为MS-SQ中的Data类型的赋值
-> new java.sql.Date(....getTime());
？将字符串转换为一个日期对象
* SimpleDateFormat对象的parse()方法 
-> new SimpleDateFormat("参数").parse();

2015/11/13 星期五 Jsp问题日志
？Jsp中为什么不允许存在两个以上的<%-- --%>注释
？能否在requst中保存一个泛型集合的对象
方法原型为：
reqeust.setAttribute(String key,Object value); // 这里可以将任意对象保存到requst作用域中
requset.getAttribute(String key); // 通过键取出对象，如果对象不是String类型，则需要强制类型转换。

？在JSTL中能否直接调用方法给EL表达式赋值
目前的方法是在实体类中声明私有字段，并创建私有字段的getter/setter方法
jsp中除了可以通过字段的set方法为字段赋值，通过字段的get方法进行取值
* 此方式必须在实体类中将字段私有化，并创建私有字段的getter/setter方法。私有字段如果没有get方法，通过EL表达式可能无法正常显示字段的值
如果使用JSTL来访问字段，则需要使用EL表达式访问字段属性 //(其实JSTL和EL事实上还是通过访问私有字段的get方法来取出字段的值)
如果在X类中已经声明了一个私有字段ll，并创建了它的get/set方法，则以下EL表达式 -->
....
X x = new X();
String xx = x.ll;
${xx}将返回ll的值 //EL表达式中如果没有特殊声明，则不能直接调用方法

？ 如果已经将对象保存到内置对象(page对象除外)的作用域中，并且使用转发的形式跳转页面，则允许直接在JSTL/EL访问保存在request作用域的对象，而不需要另行调用request对象的getAttribute("对象名")方法取出request作用域中的对象
request.getRequestD..("路径").forward(request,response);

？ 在Servlet调用了DAO下查询数据的方法，并且已经保存到request作用域中，在首页使用JSTL遍历，然后在浏览器中访问首页时，数据为空而不显示？
// 没有抛出异常，也没有任何提示，就是啥都没有
！这个问题可能跟数据库有关，如果更改数据库中的数据，则需要重启MyEclipse，重启数据库服务
！保存到session或者request对象应该要有必要的非空验证。如果在视图层没有基本的非空验证检查，那么首次访问必须访问Servlet、控制器、Action来防止可能出现的空指针异常。

2015/11/27 星期五
？使用commons组件实现上传文件

设置表单的提交方式为post，并且为属性enctype指定一个值:text|muilpart/form-data //text：纯文本格式。muilpart/form-data:多媒体文件格式
在项目中包含commons组件(commons-io.jar;commons-upload.jar)
FileItemFactory接口
其实现类DiskFileItemFactory方法setRepositoroyPath(String path)可以设置上传文件临时存放路径
实例化类ServletFileUpload upload = new ServletFileUpload(new DiskFileItemFactory);
setSizeMax(long size) //设置上传文件最大值
List parseRequst(HttpServletRequst req); //解析form表单中的数据，并返回一个FileItem集合
static final boolean isMuiltpartForm(HttpRequst req): //检查上传文件是否是多媒体格式
实例化FileItem类
long getSize();//获取上传文件大小
String getName(); // 获取上传文件名
String getString(); String getString(String encoding);//将FileItem中保存的主体内容以一个字符串返回，可以使用它的重载方法设置返回字符串的编码
boolean ifFormFlied(); //判断FileItem中封装的数据类型，文件表单类型返回flase,普通类型返回true
write(File对象或者文件具体写入路径); //写入文件到磁盘

2015/11/27 星期五 ？使用分页显示查询结果
sql语句使用not in筛选记录
统计数据库表中的记录总数
指定每页显示记录数>根据每页显示记录数统计总共需要显示的页码总数
动态显示查询页面
使用参数传递页码数，默认为1
对页码进行必要的判断，不能出现小于1，或者大于记录总数的情况
判断是否是第一次访问首页，如果是则跳转到控制页重新获取记录集合，否则遍历集合取出记录
页码之间的跳转为控制页传递一个页码
2015/11/25 星期三

html错题日志
jQury中的animate()方法：自定义动画，参数
queyue:duration:
2015/12/2 星期三
验证字符串是否与正则表达式中的项匹配，定义语法
/ 正则表达式的容器，^ 正则表达式的开始,$ 正则表达式结束
var variable = /^[\w]+.?{}\d\.$/

## 特殊符号

+ 匹配前一项1次或者多次
* 匹配前一项0次或者多次
. 匹配前一项一次
? 匹配前一项0次或者一次
{} 匹配指定的次数，前一个整数指定至少匹配的次数、后一个整数指定最多匹配的次数
项，以反斜杠开始
\w 代表单个数字、字母、下划线、美元符号等价于[0-9a-zA-Z_],\W
\d 单个数字,等价于[0-9] \D
\. 英文句点
用于验证字符串是否匹配正则表达式的方法，使用值为正则表达式的变量来调用
test(字符串|变量) 验证圆括号中的表达式或者变量是否与定义的正则表达式匹配 match()


2015/12/7 星期一

？在javascript中以style属性设置样式时，如果在属性中存在中划线'-'，则应该将中划线去掉，并且将紧邻中划线的后一个字母大写

？使用EL表达式如果试图通过内置对象的作用域直接访问保存的对象，则什么也无法取出。只能通过作用域中保存的字符串类型的键来访问
* EL表达式并不直接支持访问作用域中的保存的对象，只能间接访问保存到作用域中的键来访问保存的对象

2015/12/19 星期六

？我为什么不能将web项目部署到web容器上

？web项目部署遇到错误但是在控制台却显示部署成功，而我试图访问web项目下的资源时却被提示不可用

？部署状态显示为一个黄色警告符，查看web容器下的项目部署目录，存在项目的文件夹，但是有些文件并不存在，
试图访问jsp和servlet时，web容器提示资源不可用
* 可以尝试移除项目后重新部署项目，或者重启服务、IDE和计算机

？启动Tomcat7服务时初始化上下文出错，启动服务成功，但是我试图访问web项目下的资源时却被提示不可用

2015/12/22 星期二
？web容器为何不对jsp页面中的EL表达式进行解析，而是直接将要解析的EL表达式显示在了页面
!

* web-app版本太低，低版本的web-app不支持EL表达式。web.xml配置文件存在错误的dtd声明或者在节点web-app的属性中不存在web程序版本声明等信息， 则可能会出现这种情况

* 和web容器版本有关系，如果在web.xml中的声明的web-app版本小于2.4以下，而web容器使用的是旧版本
* 和页面指令属性isELIgnore的值有关，如果将它的值设为真，则web容器将不会对jsp页面中的EL表达式进行解析

？Tomcat关闭时，在控制台提示严重错误:The web application [/HouseMgr] created a ThreadLocal with key of type [java.lang.ThreadLocal] 
(value [java.lang.ThreadLocal@6fec71ff]) and a value of type [java.lang.Class]
(value [class oracle.sql.AnyData Factory]) but failed to remove it when the web application was stopped. 
Threads are going to be renewed over time to try and avoid a probable memory leak

！来自Google的翻译:
Web应用程序[/ HouseMgr]创建一个ThreadLocal类型的键[java.lang.ThreadLocal中]
值为...和类型为[java.lang.Class]
值...但是在应用程序停止运行时未能将它移除，随着时间的推移，线程将要更新，以尽量避免可能的内存泄漏

！来自....博客的解决方案
1. 6.0以上版本的Tomcat在运行时部署项目可能存在内存泄露的问题，安全的部署项目应该在Tomcat服务被停止之后。或者关掉6.0以上版本的tomcat内存溢出监听功能

在tomcat的server.xml文件中把 `<Listener className="org.apache.catalina.core.JreMemoryLeakPreventionListener"/>` 注释了就行了


# 参阅：

+ [ant的安装、使用，build.xml简单编写 - 不学习就淘汰 - 博客频道 - CSDN.NET](http://blog.csdn.net/bao19901210/article/details/23844107)

+ [ANT及build.xml文档编写 - struts2 - ITeye技术网站](http://aaagu1234.iteye.com/blog/927494)

+ [Ant系列-第一个build.xml - 综合编程类其他综合 - 红黑联盟](http://www.2cto.com/kf/201503/385906.html)

+ [使用ant编译打包、部署简单的javaweb项目 --02 - 小代码2016的个人页面 - 开源中国社区](http://my.oschina.net/iamhere/blog/526750)
+ Tomcat6_0配置JNDI数据源完整例子 - jiafugui的专栏 - 博客频道 - CSDN_NET

