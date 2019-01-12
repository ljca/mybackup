# Jsp-Servlet
Jsp/Servlet
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
？ 如果已经将对象保存到内置对象(page对象除外)的作用域中，并且使用转发的形式跳转页面，则允许直接在JSTL/EL访问保存在request作用域的对象，
而不需要另行调用request对象的getAttribute("对象名")方法取出request作用域中的对象
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

2015/11/27 星期五
？使用分页显示查询结果
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
特殊符号
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
test(字符串|变量) 验证圆括号中的表达式或者变量是否与定义的正则表达式匹配
match()
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
* web-app版本太低，低版本的web-app不支持EL表达式。web.xml配置文件存在错误的dtd声明或者在节点web-app的属性中不存在web程序版本声明等信息，
则可能会出现这种情况
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
1. 6.0以上版本的Tomcat在运行时部署项目可能存在内存泄露的问题，安全的部署项目应该在Tomcat服务被停止之后。
或者
关掉6.0以上版本的tomcat内存溢出监听功能
在tomcat的server.xml文件中把 
<Listener className="org.apache.catalina.core.JreMemoryLeakPreventionListener"/> 注释了就行了
vim:set ft=markdown:
