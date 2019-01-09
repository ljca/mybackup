#  Jsp_Servlet
Jsp/Serverlet
C/S(Client/Server):客户端/服务器端模式，基于局域网
使用C/S结构的Web应用程序，则必须安装客户端程序，维护和升级必须在服务器和客户端同时进行
B/S(Browser/Server):浏览器/服务器模式，基于请求和响应
维护时只需要对服务器进行就可以了，维护升级更新快 适用点和依赖不同
URL包括协议:主机名:端口和资源路径。
静态网页与动态网页的区别？
静态网页对搜索引擎支持比较好，只是一个HTML网页，并且不具备于数据库交互的能力
运行环境部署：
Ant：自动编译、
项目地址：https://www.apache.org/dist/ant/binaries/
Tomcat下载地址
http://archive.apache.org/dist/tomcat
web容器:存放网页的服务器
使用APACHE开源项目：Tomcat服务器
Tomcat服务器的安装及配置
Tomcat目录结构
bin:可执行文件目录;conf:Tomcat服务器配置文件;
temp:webapps:web项目部署的目录;
work:lib:Tomcat服务器所依赖的第三方jar包存放路径;
logs:Tomcat服务器存放日志文件目录
启动和关闭Tomcat服务器服务
在Tomcat下手动部署Web项目
  在webapps下新建项目存放目录>在项目存放目录下新建目录WEB-INF>在WEB-INF下新建目录classes和lib,配置文件web.xml
  /:项目根目录
  /WEB-INF:
  web.xml:配置文件
  /WEB-INF/classes:项目可执行字节码文件 /WEB-INF/lib:项目依赖的jar工具包
  /index.jsp:页面跳转文件
使用MyEclipse部署Web项目
  新建WEB项目>发布WEB项目，发布之前，确保JDK的正确配置，并且打开了web容器服务
★ JSP(Java Server Page)
可以看做动态的html网页，将java代码嵌入html文件<%%>标记中
  ◆ page指令(jsp页面声明指令)
page指令主要用于声明和导入，以<%@ 开始，以%>结尾，语法:
  <%@ page language="" import="" contentType="text/html;charset=utf-8" %>
  page指令包含页面声明language，
  文档类型及编码格式声明contentType:
  包导入声明import，多个包之间使用逗号分隔
  ◆ include指令(静态包含指令)
    <%@ file="文件路径"%>
 ps:所有java代码都要包含在<%%>中
★ JSP脚本元素
 ◆ 表达式(expression)
  在jsp中使用表达式，不能在表达式后添加分号
  <%=变量 %>
 ◆ 小脚本(scriptlet) 
  小脚本功能强大，使用时只需要将java代码插入到标记<% %>之间
 ◆ 声明(declaration)
声明应该包含在<%! %>之间，可以在<%! %>之间声明java方法......
  注意：声明的方法应该返回值
★ JSP内置对象
内置对象由WEB容器存储加载的一组Severlet API,这些实例已经由JSP规范默认初始化，使用时不需要实例化。而可以直接使用对象名.方法名()的方式调用
  ◆ out对象:用于输出
  ◆ request对象：处理浏览器请求
    > String getParameter(String name);
    > String[] getParameter(String name);
    > void setCharacterEncoding(String charset); // 设置页面编码
    > void setAttribute(String key,Object obj);  //可以将对象通过键和值的形式保存到request作用域中，然后使用通过键来访问对象
    > void getAttribute(String key); //通过键的形式访问对象
ps:如果通过get方式提交数据并且在页面还存在中文。那么跳转后再访问则会出现乱码。可通过在Tomcat配置文件server.xml设置编码集来解决这个问题
     在conf\server.xml文件中的第一个<Connecter>元素下添加属性URIEncoding="UTF-8"
    > RequestDispatchar getRequestDispatcher(String path).forward(request,reponse); //gertRequestDispatcher(String path)方法返回一个javax.servlet.RequestDispatcher对象，该对象的forward方法可以在其它页面转发浏览器请求，这并不会更新URL
  ◆ response对象
  响应浏览器请求，用于在各个页面间传递消息和跳转
  常用方法：
    > void response.addCookie(Cookie对象); //在客户端添加cookie
    > void response.setContentType(String type);
    > void response.setCharecterEncoding(String charset); // 设置响应所采用的编码集
    > void response.sendRedirect(String location);  //重定向浏览器请求到新的URL
       ◆ 转发和重定向的区别
     都能实现页面间的跳转
     转发：服务器端将多条信息在多个页面进行传递，在服务端进行，URL并不会更新
     重定向：客户端发送请求>服务端返回页面>客户端跳转到指定页面，跳转到新的URL
       客户端发送新的请求
      > setAttribute("名",值); //在request作用域中设置属性
      > getAttribute("名",值);

  ◆ session对象
  记录浏览器访问状态以及权限控制，跟踪会话
    * 浏览器和WEB服务器使用HTTP协议进行通信
    * 会话：浏览器和服务器之间可能包含多个请求的一次通话，打开一个新的浏览器窗口会是一次新的tcp/ip请求，因此，服务器会再次为新的浏览器创建一个session对象，分配一个唯一的sessionid；通过这个sessionid，服务器可以判断多个浏览器之间不同的请求
        浏览器在与服务器交互的过程中，服务器会先判断是否存在这个session对象
        会话共享:打开一个相同的浏览器窗口向服务器发送tcp/ip请求，即使浏览器版本不同，也会被服务器认为是同一个session对象，可以在启动浏览器时使用 -nomarge选项来避免浏览器会话共享
    *  如果在会话中服务器与浏览器不存在session对象，则会创建一个session对象并且分配一个唯一的sessionid来标识session对象，但这个sessionid只在有效时间内有效，超过则会被销毁；如果在浏览器中没有手动销毁session对象，则退出浏览器也不会真的销毁session对象，session对象只会在会话超时后被销毁，默认为30分钟
    * 浏览器使用cookie来记录服务器的sessionid
    * session对象的常用方法：
     > setAttribute(String key,String Value); //手动保存session对象到session中
     > Object getAttribute(String key);  // 通过key获取session中保存的对象
     > void invalidate(); 手动销毁session对象
     > String getId(); //获取sessionid
     > void setMaxInactiveInterval(int interval); //设置session对象有效时间
     > int getMaxInactiveInterval();  //获取session对象的有效非活动时间，以秒为单位
     > void removeAttribute(String key);  //在session中通过指定名称(key)移除对应session对象
  ◆ application对象:应用程序上下文对象
   存储的数据可以让同一个web服务器的web系统所有用户共享，application对象只能有一个实例；
   * application对象常用方法:
   > void setAttribute(String key,Object value); // 以key/value的形式将对象存储到application对象中
   > Object getAttribute(String key);  //通过key获取application中存储的对象
   > String getRealPath(String Path);  //返回相对路径的真实路径
  ◆ Cookie：在浏览器中记录服务器的会话状态
  主要有以下作用:
    对浏览器特定对象的跟踪，如访问次数、最后访问时间、路径
    统计网页浏览次数
    在cookie有效期内，记录用户登录次数
   Cookie类位于javax.servlet.http包下；name:代表cookie的名称;value:代表当前key对应的值
 * 创建Cookie对象
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
  ◆ 作用域
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

★ JavaBean：符合规范的类被称之为javaBean
必须有一个无参构造，属性必须私有，对外提供访问属性的getter/setter方法
JavaBean包含业务Bean:封装业务逻辑代码和数据Bean：封装数据
优势:
提高代码可重用性集可维护性，减少代码冗余，功能更明确

★ 使用分层实现业务处理
  ◆ JNDI(Java Naming Directory Interface):Java命名和目录接口，是一组为应用程序设计的API
将对象与名字绑定，应用程序使用时可通过名字获取对象或者业务
◆ 配置context.xml文件(测试)
添加<Environment>元素：此元素配置的值对整个web程序可见，包含的属性有name:type:value:
name:环境条目名称,相对于java:comp/env的名称
type:环境条目的java类名的全称
value:通过JNDI context请求时，返回给应用的参数值，该值必须强制类型转换为type属性定义的Java类型
◆ 数据库连接池(Connection Pool)
在Tomcat服务器中建立一个一块缓存区域，用来存储事先已经建立好的数据库连接
在需要进行数据库连接请求时，可以直接通过事先定义好的名称来取得数据库连接，而无需在从数据库中取得数据库连接,这些连接由Tomcat进行管理
数据库连接池负责分配、管理和释放数据库连接，它允许应用程序使用同一个数据库连接(这个连接必须被上一个web程序释放)
◆ DataSource(javax.sql.DataSource)类:这个类由Tomcat提供，因此不能通过创建实例的方式创建DataSource对象
在Tomcat中配置好的数据库连接池以数据源的形式存在
使用JNDI访问数据库：添加jdbc驱动和动态的配置数据源
ps:修改context配置文件之后，不要关闭MyEclipse和Tomcat
 1.动态配置conf\context.xml文件(对所有web程序生效)
 也可单独在web项目根目录下添加context配置文件，同样在<Context>元素下配置<Resource>元素。web.xml文件也要配置
 此方式只对项目生效
  在conf\context.xml文件的<Context>元素下添加<Resource>元素：此元素的属性用来配置数据库连接池中的参数
  Resource元素需要有以下属性
name:指定访问JNDI名字(在配置文件context.xml下的Resource元素中被指定);
auth:Manager方式[取值:Container(由Tomcat服务器创建Resource)|Application(由web应用程序创建和管理)];
type:指定Resource所属Java类名；maxActve:指定连接池中最大激活连接数；
maxIdle:指定连接池中允许存放的数据库连接最大值；
username:指定访问数据库用户名；password:指定访问数据库的密码
driverClassName:指定连接数据库的jdbc驱动类型；url:指定连接数据库的URL
 配置web.xml文件
在<web-app>元素下添加<resource-ref>元素:包含对外部资源的引用，包含description属性、res-ref-name、res-type、res-auth属性
  属性列表:(属性值要与context.xml配置文件下Context元素下的Resource元素属性值对应)
  description:对引用资源的说明；res-ref-name:指定引用资源的JNDI名字；
  res-type:指定引用资源的类名；res-auth:指定引用资源的Manager
2.添加jdbc驱动到Tomcat>lib目录
ps:如果在添加驱动之前已经打开MyEclipse,则必须重启MyEclipse方可生效
使用javax.naming包下的Context接口来取得DataSource对象，再由DataSource对象的getConnection()方法取得连接
 Context接口:由一组名称到对象组成;InitialContext接口是Context接口的实现类
 初始化一个Context对象
 Context ctex = new InitialContext();
 获取数据源对象
  Object lookup(String name); //根据JNDI名称检索数据源对象;JavaEE所有应用程序中所有名称都要以java:comp/env为前缀，此方法经过强制类型转换取得DataSource对象
  DataSource ds = (DataSource)ctex.lookup(JNDI名字);
  获取数据源
   ds.getConnetction();  //此方法返回一个数据库连接对象
ps:连接成功之后必须关掉数据库连接，否则会出异常，这里的关掉连接只是释放数据源到Tomcat数据库连接池
 ◆ 使用集合封装数据>保存集合结果到request或者session作用域>遍历集合取出集合中的数据
★ Java WEB程序中的分层模式
◆ 表示层：提供交互式界面，位于最顶层，web程序通常以jsp/html文件为主
◆ 业务逻辑层:通常是定义一组接口，放在diz包下
◆ 数据访问层:位于最底层，不必依赖其它层通常放在dao包下
◆ 实体层:存放一些实体类，实体类是存放了一些用于在数据库和其它页面之间进行传递数据的字段，这些字段一般会将它进行封装
通常使用.entity.的包来组织
★ 使用分页技术来显示查询结果
 获取数据库表的记录数>根据每页显示条数计算所需页面
★ 使用Commons-Upload组件上传文件到服务器
  上传文件，需要有Commons-Upload组件，但是IDE默认是不包含Commons-Upload组件的，所以需要从网络获取Commons-Upload组件并包含到web项目中
  Upload组件包含可执行jar包:commons-io.jar及commons-fileupload.jar
  同时，必须为<form>元素的enctype指定一个值。
  multipart/date:用于上传二进制/多媒体文件;
  text/plain:主要用于上传纯文本文档
  application/x-www-form-urlencoded:默认值，以字符串的形式上传;此种方式无法上传文件。
  文件上传的基本API:(使用之前确保已经包含Commons-Upload组件到web项目中)
  ServletFileUpload类
  需要一个FileItemFactory来完成实例化。语法：
  > ServletFileUpload 对象名 = new ServletFileItemUpload(FileItemFactory ll);
  FileItem接口的实现类DiskFileItem
  FileItemFctory接口及其实现类DiskFileItemFactory
★ 使用Servlet开发web应用程序
一个符合Servlet规范的java程序，是一个基于java的web组件，由web容器管理。用于生成动态内容
用来处理客户端请求，并响应的服务端程序
  开发一个Servlet程序,可以使用下列几种形式之一
1.在java中实现Servlet接口
如何使用Servlet？
在web.xml中配置servlet
<servlet>
<servlet-name>类名</servlet-name>
<servlet-class>包名+类名</servlet-class>
</servlet>
//配置映射
<servlet-mapping>
<servlet-name>类名</servlet-name>
<url-pattern>路径</url-pattern>
</servlet-mapping>
2.继承GenericServlet(继承自Servlet接口的一个抽象类)，不必依赖于任何网络传输协议

3.专用于处理http协议的Servlet:抽象类HttpServlet继承自GenericServle
使用这个类，如果没有特殊需求，那么一般只需要重写doGet(),doPost()这两个方法就可以了;
★ Servlet生命周期
实例、初始化:第一次请求时被处理，只会在发送第一次请求时被执行，注意：实例化比初始化先被执行
处理事务、
销毁:web容器被关闭或者重新加载项目中的Servlet程序
ServletConfig接口
获取Servlet信息
getInitParmeter(name) //初始化参数
getServletContext(source) //获取应用程序上下文路径
★ 使用EL(Expression Language)访问数据，仅能访问jsp内置对象作用域中的数据。语法：${}
EL访问数据时，依次从page到applicaion这几个jsp内置对象中查找并按作用域小的到大的进行访问，如果想要访问某个对象中的数据，那么可以使用它所对应的的隐式对象进行访问
◆ 作用域对象：
pageScope、requestScope、..applicatonScope
◆ 参数对象：param
使用param获取参数、使用paramValues获取一组参数。语法
  > param.参数名
  > paramValues
◆ 页面上下文对象:pageContext
 ★ EL支持运算符
  基本的算术、逻辑、关系运算符
  除了基本的，同样也支持这种方式：等于(eq)、不等于(ne)、大于(gt)、小于(lt)、大于等于(ge)、小于等于(le)
ps:访问对象属性需要用EL表达式。如果不对EL进行配置，那么可能无法访问对象的方法
.运算符导航对象属性....
[]可以访问所有点运算符中的数据，也可以访问数组或者集合。//使用[]访问对象属性时，需要为属性加上双引号或者单引号
 ★ 使用JSTL(Jsp Standard Tag Library):JSP标准标签库替换JSP页面的java代码
使用之前需要导入标准标签库,语法：
 prefix:定义前缀，uri:指定标签库类型
 <%@ taglib uri="" prefix="" %>
◆ 标准标签库中的核心标签库
ps:变量及表达式的存取需要使用EL表达式。假设存在一个前缀为c的核心标签库，那么
 ◆ 通用标签库：
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
 ★ 在web项目中使用jstl自定义标签
继承SimpleTagSupport类并重写doTag方法，配置tld文件
在taglib节点映射url节点
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

jsp调用自定义标签
导入标签库 -> 调用标签
在web项目使用过滤器
实现javax.serverlet.Filter接口,重写doFilter()和init()方法。
 vim:set filetype=markdown: 
