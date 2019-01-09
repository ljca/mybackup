#  SSH
2016/2/17 星期三  框架技术的初级应用
使用框架技术来重构WEB项目
为什么要使用框架技术？
JDBC虽然性能良好，查询快速，但在使用JDBC操作数据库时，存在了大量冗余代码，所以为了简化代码操作，引入了框架技术。
ORM(Object/Relation Mapping)思想:对象/关系映射
Hibernate是ORM的一个实现，它是一个免费的持久化层框架，网址在
https://sourceforge.net/projects/hibernate/files/
使用持久化框架Hibernate前的准备：
Hibernate所需jar包：https://sourceforge.net/projects/hibernate/files/hibernate3/
...\hibernate-distribution-3.3.2.GA\lib\required
 antlr-2.7.6.jar 语法分析
 commons-collections-3.1.jar 集合和工具类
 dom4j-1.6.1.jar XML解析
 hibernate3.jar 核心工具包
 javassist-3.9.0.GA.jar 分析、编辑和创建java字节码的类库
 jta-1.1.jar Java事务API
 slf4j-api-1.5.8.jar 日志支持

导入hibernate工具jar包及其所需jar包。
* 在src(！放在哪里其实并不重要，因为这个配置文件是可以放在web项目中的其它位置的，如果确实要这么做，需要在hibernage配置文件中配置location)目录下创建hibernate配置文件(hibernate.cfg.xml或者hibernate.properties,这两个配置文件* 在...\hibernate-distribution-3.3.2.GA\project\etc目录下都有示例)，在官网下载的压缩包中有模板文件。
.......
* 配置子元素和属性
* 在hibernate-configure元素下配置session-factory子元素
* 在session-factory元素节点下配置property子元素
* 在property子元素中配置name属性值和元素节点值
<hibernate-configure>
<session-factory>
<!-- 指定驱动字符串 -->
<property name="connection.driver_class"></property>
<!-- 指定连接数据库的url -->
<property name="connection.url">....</property>
<!-- 数据库用户名 -->
<property name="connection.username">....<property>
<!-- 指定用户的密码 -->
<property name="connection.password">...</property>
<!-- 指定数据库方言 -->
<property name="connection.dialect">...</property>
<!-- show_sql:运行在控制台显示执行的sql --> 
<property name="show_sql">true|false</property>
<!-- format_sql:运行时在控制台显示的sql经过了格式化 -->
<property name="format_sql">true|false</property>
.....
</session-factory>
</hibernate-configure>

配置持久化类和映射文件
* 持久化类一般对应项目中实体层的实体类，而一般将映射文件与实体类放在同一目录下，通常以实体类名作为名称，以.hbe.xml作为扩展的配置文件
* 配置元素和属性
* 选中创建持久化类即实体类的包，右键->新建XML(Basic Templates)->Next->Create ...from a DTD file->Next->Select XML Catalog entry->Next-Finish(Hibernate配置文件可使用相同的方式，也可以使用Hibernate的模板文件和iEclipse的反向工程工具来生成配置文件和映射文件)
.....
* 在hibernate-mapping节点元素的class节点元素中
<hibernate-mapping>
<!-- 指定class元素的name属性，值为实体类的全限定名(类名和包名) -->
<!-- 指定class元素的table属性,值为数据库中的数据表名 -->
<class name="" table="" scheme="">
* 配置id子元素
<id name="" column="" type="">
<gen... class="assign|native|increment|..." />
</id>
配置property子元素及其属性和值:
<!-- 属性name指定实体类的属性名,属性insert,属性not-null,属性update,属性unique,属性type指定列在Java中对应的数据类型,属性length指定长度 -->
<!-- 属性column指定数据库列的字段名，它也可单独作为子元素出现，但需要指定name属性值 -->
<property name="" column="" type="" not-null="" length="" unique="" update=""....></property>
</class>
</hibernate-mapping>
* 最后还需要将持久化类的映射文件和Hibenate配置文件关联
* 在Hibenate配置文件中配置mapping子元素的resource属性值为映射文件在web项目中的路径
<mapping resource="映射文件的相对路径" />
* 通过Configuretion对象读取默认位置的hibernate配置文件，一般是位于根下的hibernate.cfg.xml
-> Configuretion cf = new Configuretion().configure();
* 通过SessionFactory构建Session工厂实例,一旦Session工厂构建完成，则不再需要Configuretion实例
-> SessionFactory sf = cf.buildSession...();
* 获取Session实例
-> Session session = sf.openSession();
或者sf.getCurrentSession() //不需要关闭Session。
* 开始一个事务(！如果只是查询，则不需要开启事务功能，如果是增删改，则应该开启事务功能)
Transaction tx = session.beginTransaction();
* 持久化操作API.
* 通过表的主键字段查询对应单条记录
Session对象的get()和load()的方法的区别
* load会延迟加载，即第一次访问非id属性的时候才会执行数据库的查询操作。而get方法会立即向数据库发送一条SQL执行
* load方法如果没有在缓存中找到oid,则会抛出异常，而get方法只会返回一个null
/* 参数，clasz 实体类在内存中的对象 Seri... id OID(Object Identity主键标识符即主键在数据库中的值)
get方法原型：get(Class calsz,Serithrowd id);
load方法原型: load(Class thisClass,Serithrowd id);
！增删改必须使用事务功能
* 持久化操作，包括增删改
Seri... save(Object object)
saveOrUpdate()
merge()
update()
delete()
！虽然save和udpate方法都可以实现保存和更新操作，但save方法
* 提交事务
tx.commit();
* 关闭Session实例。
session.close();
Hibenate持久化的三种状态
瞬时状态
在内存中已经实例化但尚未执行持久化操作的对象
游离状态
Session被关闭之后，所有对象都不在Session管理中，
如果在数据库中还存在一条记录与之对应的对象
持久状态
执行持久化操作之后，比如sava或者update等方法之后的对象
脏数据检查
脏数据:缓冲区中存在与数据库不一致的数据
自动检查脏数据
当提交一个事务前

手动同步(Sync):
这通过调用flush方法来实现
HQL(Hibernate Query Language):Hibernate查询语言
支持PL/SQL、SQL
from 实体类
from 实体类 别名
from 实体类 条件

list()/itator()，使用Query实例调用。
List<Object> list();
* 构建query实例。
Query query = session.createQuery("hql查询语句"或者变量);
事务操作
Hibernate中的关系映射
一对多映射配置/多对一映射配置
持久化类中增加一个声明为Set集合的字段，
配置<set>元素
<!-- name:持久化类属性名 -->
<!-- cascade:级联操作，可取值有none -->
<!-- inverse:反转操作，由外键表中的字段自己维护外键 -->
<!-- -->
<set name="" cascade="none|save-update|delete|all" inverse="true|false"> 
<key column=""></key> <!-- 外键列名:外键表与主键表关联时的列名 -->
<one-to-many class="" /> <!-- 持久化类的全限定名，此处为外键表对应的持久化类 -->
</set>

多对一
<many-to-one 
name="" <!-- 持久化类属性名,此处是 -->
column="" <!-- 此处应为外键表关联主键表的外键列名 -->
class="" <!-- 外键表关联主键表，此处应为主键表对应的持久化类全限定名 -->
/>
多对多映射配置

一对一映射配置
使用主键
<one-to-one> <!-- -->

使用唯一约束
<many-to-one> <!-- -->
！使用iEclipse反向工具生成Hibernate配置文件和实体类映射文件
右键选中的项目->选择iEclipse右键菜单-Add...
Hibernate的连接查询
支持内连接和外连接查询，但HQL和SQL语法不同。
* 内连接查询语法
select Entity_alias from Entity Entity_alias inner join Entity_alias.property
HQL迫切连接查询
select Entity_alias from Entity Entity_alias inner join fetch Entity_alias.property
HQL的参数绑定方式
* 命名参数由一个英文字符下的冒号和参数名组成(!这个参数名需要和持久化类的属性对应)。
命名参数(:属性名)，使用命名参数绑定

Query接口提供的参数绑定方法:
set....
* 绑定任意类型的参数。
setParameter(Integer index,Object value);setParameter(Object object,String value);
命名参数绑定方式:绑定命名参数到实体(！命名参数名必须和持久化类中的属性对应)
setPropertys(Entity entity);
HQL动态查询
* 根据查询条件动态构建hql语句。
HQL的分页和投影查询
使用HQL分页查询
* 从第几条记录开始，并且不包括该条记录。
setFirstResult(int firstResult);
* 设置每页最大返回记录数。
setMaxResults(int MaxCountSize);
返回唯一结果
Object uniqueResult();

HQL中的投影查询

优化Hibernate查询/使用Hibernate缓存
Hibernate缓存包：http://mvnrepository.com/artifact/net.sf.ehcache/ehcache/
logging.jar
ehcache.jar
http://www.ehcache.org/downloads/
一级缓存
二级缓存
查询缓存
连接查询

使用Session、JDBC、HQL执行批量操作

Hibernate-HQL查询技巧
all
any
some
in
exists

使用命名查询
<!-- HQL命名查询 -->
<query name="">
<![CDATE[ ..... ]]>
</query>
<!-- SQL命名查询 -->
<sql-query name="">
<![CDATE[ .... ]]>
</sql-query>

Criteria对象查询
构建Session实例
* 构建Criteria实例
Criteria .. = session.createCriteria(Clasz class);

条件查询
Criteria对象.add(Criteria运算方法)
Criteria运算方法
HQL和Criteria比较运算
* Criteria实例的add方法参数是Criteria,返回值也是Criteria。
！第一个参数是持久类的属性，第二个参数是条件值。isNull和inNotNull不需要指定条件值。
> -> Criteria Restrictions.gt(String PropertyName,Object value)
< -> Criteria Restrictions.lt(..)
>= -> Criteria Restrictions.ge(..)
<= -> Criteria Restrictions.le(..)
<> -> Criteria Restrictions.ne(..)
== -> Criteria Restrictions.eq()
...
is null -> Criteria Restrictions.isNull(String Property)
not null -> Criteria Restrictions.isNotNull(String Property)

范围运算
Criteria Restrictions.in(String PropertyName,Collection values|Object[] values)|Restrictions.not in()
Criteria|SimpleExpression Restrictions.like(String PropertyName,Object value);
Restrictions.between(String PropertyName,Object Object1,Object object2) | Restrictions.not between()
Restrictions.
Restrictions.
逻辑运算
Restrictions.and()
Restrictions.or()

Criteria分页查询
.....
* 从几条记录开始并且不包括该条记录。
setFirstResult()
* 页面大小，即单页显示数据表的记录数。
setMaxResults(pageSize);
使用注解的方式完成数据库持久化操作
Hibernate提供了另一种配置持久化类的方式:An....(！需要添加annotation.jar工具包),这种方式无需特别配置实体类映射文件
https://sourceforge.net/projects/hibernate/files/hibernate-annotations/3.4.0.GA/hibernate-annotations-3.4.0.GA.tar.gz/download
在实体类中，以英文字符中的 @ 符来给持久化类及其属性和方法添加注解，无需生成持久化类映射文件。
在Hibernate配置文件中添加映射类
<!-- class属性指定映射实体类而不是使用映射文件，这个属性不能和resource同时使用。属性值为持久化类的全限定名,即包名+类名 -->
<mapping class="" />
@Enitity
@Table(scheme=?,catlog=?,name=?)

@Id
@GeneratedValue(strategy=?,generator=?)
@UniqueConstraint
@Column
@Transent

注解实体映射
@OneToMany
@ManyToOne
@ManyToMany
@OneToOne
* 构建SesseionFactory
SessionFactory sf = new AnnotationConfiguretion().configure().buildSessionFactory();
* 构建Session实例
Session session = sf.OpenSession();
.....

持久层框架:iBatis框架 使用ibatis完成持久化操作
ibatis工具类:mybatis.jar https://github.com/mybatis/mybatis-3/releases
ibatis配置文件
<!-- ibatis主配置文件xml声明 -->
<?xml version="1.0" encoding="UTF-8"?>

<!-- 本地dtd文件全路径或者是相对于项目上下文路径 -->
<!-- 这一行指定iBatis使用本地的dtd约束文件， "-//mybatis.org//DTD Config 3.0//EN"指定ibatis版本语言等信息 -->
<!DOCTYPE configuration PUBLIC "-//mybatis.org//DTD Config 3.0//EN" "mybatis-3-config.dtd">
<configuration>
<!-- typeAliases元素配置pojo的别名 -->
<typeAliases>
<!-- alias属性指定别名，type属性对应pojo的全限定名 -->
<typeAlias alias="" type=""/>
</typeAliases>
<!-- 此元素用于配置多个数据库信息 -->
<enviranments default=?>
<!-- 此元素配置具体数据库信息 -->
<enviranment id=?>
<!-- 配置事务管理器，由type属性指定,可选值：JDBC:使用JDBC直接管理。MANAGED:由应用服务器管理，ibatis -->
<transactionManager type="JDBC|MANAGED" />
<!-- 配置具体数据源，由type属性指定，可选值有：UNPOOLED|POOLED:使用连接池。|JNDI:使用JNDI连接池，这必须已经正确配置了JNDI数据源。 -->
<dataSource type="UNPOOLED|POOLED|JNDI">
<!-- 配置数据库具体参数 -->
<!-- 指定数据库驱动类 -->
<property name="dirver" value="" />
<!-- url:连接数据库的字符串 -->
<property name="url" value="" />
<!-- username:模式.用户 -->
<property name="username" value="" />
<!-- password:用户模式密码 -->
<property name="password" value="" />
</ dataSource>
</ enviranment>
</ enviranments>
<!-- mapers元素配置SQL映射文件的路径，ibatis会根据这个路径寻找SQL映射文件 -->
<mappers>
<!-- SQL映射文件的全路径 -->
<mapper resource="" />
......
</mappers>
</configuretion>
ibatisSQL映射文件
<!-- xml声明 -->
<?xml version="1.0" encoding="UTF-8"?>
<!-- 这一行指定iBatis使用本地的dtd约束文件 -->
<!DOCTYPE mapper PUBLIC "http://mybatis.org/dtd/mybatis-3-mapper.dtd" "mybatis-3-mapper.dtd">
<!-- 命名空间属性是必须的，它的值对应接口的长名称(全限定名)，也可以是短名称即只是一个接口名称 -->
<mapper namespace="">
<!-- select元素指定sql语句，id值对应接口中的抽象方法名，不包括圆括号;resultType属性值对应查询返回结果，如果要返回实体，则应该使用实体类的全限定名-->
<select id="" resultType="" ...>DQL语句</select>
<insert></insert>
<update></update>
<delete></delete>
</mapper>
* 配置好iBatis主配置文件和SQL映射文件之后
> 构建InputStream或者Reader实例
Resouces.getResouceAsReader方法定义:
public static Reader getResourceAsReader(String resource) throws IOException
或者InputStream对象:
public static InputStream getResourceAsStream(String resource) throws IOException
java.io.Reader reader = org.apache.ibatis.io.Resources.getResouceAsReader("");
> 构建SqlSessionFactory获取Session工厂
> 获取SqlSession实例
if(null != sf){
	SqlSession session = sf.OpenSession();
}
if(null != reader){
	SqlSessionFactory sf = new SqlSessionFactoryBuilder().build(Reader reader);
}
......
iBatis的条件查询

ibatis动态查询和动态多条件查询

配置ibatis的缓存
<!-- -->
<settings>
 <setting name="cacheEnable" value="true">
</settings>
在Mapper映射文件中开启二级缓存

Struts2初步
* Struts2是MVC的一个优秀实现，不过它位于Web层
MVC设计模式(Model-View-Controller)
ModelI模式
ModelII模式
http://struts.apache.org/download.cgi#struts25
DTD(Documnet Type Defined):文档类型定义
在xml文档中声明dtd
<!DOCTYPE 根元素名称 [次级元素以及子元素声明 元素属性声明]>
引用外部DTD
<!-- 根元素声明 ，元素类型可以是元素的数据类型，也可以是纯元素，即是使用通配符包含次级元素或者子元素 -->
<!-- 元素类型以#号为前缀。#PCDATA包含任意字符数据 -->
<!ELEMENT 根元素名称 (元素类型)>
<!-- 次级元素声明 -->
<!ELEMENT 子元素名称 (元素类型)>
<!-- 子元素声明 -->
<!ELEMENT 子元素名称 子元素数据类型>
<!-- 属性声明，属性数据类型不能以#号为前缀。属性值包括#REQUIRED:属性值是必须的，#IMPLIED:属性值不是必须的,#FIXED:属性值是固定的 -->
<!-- 属性的数据类型可以是CDATA:字符数据类型,ID,IDREF,ENTITY,ENTITIES -->
<!ATTLIST 元素名称 属性名称 属性值 [redirect (值集合) "默认值" ]>

在xml文档中引用外部dtd
<!DOCTYPE 根元素名称 SYSTEM "dtd文件路径">

自定义控制器Controller

System类方法
获取项目上下文根路径
String java.lang.System.getProperty(String key);
key的可取值:
user.dir //项目上下文根路径
user.home //用户主目录
user.name //用户名
os.neme //系统名称
os.arch //系统架构
os.version //系统版本信息
java.version //返回java版本
java.home //返回java安装路径
java.class.path //类的构建路径
java.ext.dirs //java工具类路径

java.lang.System.out.print
java.lang.System.out.println
java.lang.System.err.print
java.lang.System.exit(int number); //退出所有线程，以指定的返回值状态返回。
xml文件解析
确认工具类dom4j.jar已经正确导入了项目中，并添加了引用
SAXReader类
构建org.dom4j.io.SAXReader实例
 -> SAXReader reader = new SAXReader();
 * 构建org.dom4j.Document实例
 -> Document document = null;
 * 通过读取xml文件构建document实例。
-> document = reader.read(new File("xml文件全路径"));
Document实例方法:
获取根节点: Element getRootElement();
Element实例方法:
获取节点下的单个子节点元素: Element element();
获取指定节点下的单个子节点元素: Element element(String name);
获取某个节点下的所有子节点: List elements();
获取指定的节点下的所有子节点: List elements(String name);
获取节点元素的名称: String getName();
获取节点上的文本: String getText();
获取节点元素的属性: String attribute();
获取某个节点下的所有属性: List attributes();

Struts2初步
struts主配置文件struts.xml
<struts>
<!-- 通过constant元素可以更改struts的一些默认行为。 -->
<constant name="" value="">
<!-- -->
<package name="" namespace="" extends="">
<!-- -->
<default-action-ref name="" />
<!-- -->
<action name="" class="" method="">
<!-- -->
<result name=""></result>
</action>
</package>
</struts>
配置好了struts，还需要在web程序主配置文件中web.xml配置过滤器
<filter>
<filter-name>
<filter-class>
<filter>
<filter-mapping>
<filter-name><filter-name>
<!-- 拦截元素 -->
<url-pattern></url-pattern>
<filter-mapping>
Struts核心控制器
核心控制类:StrutsAndExecuteFilter
主要可以使用通过两种方式来实现Action类的编写。！并非必须通过实现Action接口或者通过继承ActionSupport类
事实上，被用来处理业务的Action也可以只需要一个返回值为字符串的无参方法也能正常的在实现交互。
1.实现open..Action接口，并重写execute方法(！并非必须重写这个方法，也可以使用一个字符串返回值的无参方法)。
2.继承ActionSupport类，重写execute方法(!同上)

为了方便使用，Struts也提供了一个叫做OGNL(Object ... Na.. Language):对象图导航语言
<!--使用之前导入标签库-->
<%@ taglib="/struts-tags" prefix="s" %>
<!-- 访问JavaBean属性，字段如果是private属性，则必须提供getter和setter方法，如果字段是public的， -->
<!-- 前缀s:表示使用了OGNL -->
<s:property value="">
Struts拦截器
* 拦截器包括拦截器栈(即一组拦截器)和拦截器。这可以通过实现Intercepter接口或者继承IntercepterSupport类来实现拦截请求。
* 然后，还要在struts主配置文件使用<intercepter>元素配置拦截器。一个典型的intercepter配置可以使用类似于以下形式

Struts标签
* Struts也在视图层整合了了一组功能强大的标签库，可以更方便的在视图层与Struts控制器Action交互。它提供的标签库主要包括Struts通用标签和UI标签。
* 而Struts UI标签即用户交互标签，比较常用的表单标签类似于html元素中的表单元素,但它在表单元素之前添加了一个前缀。
<s:form></s:form>
<s:password label=""></s:password>
<s:radio></radio>
<s:checkbox></s:checkbox>
<s:textarea></s:textarea>
<s:submit />
<s:reset />
<s:button />

* 通用标签包含条件标签即流程控制标签和专用于进行迭代集合或者数组的迭代标签。
<s:if></s:if>
<s:else></s:else>
<s:elseif></s:elseif>
<iterator></iterator>
Struts数据校验
！JavaScript可以让浏览器产生一些很炫的特效，或者提供一些更好的用户交互。然而，不幸的是，总会有一些老旧的浏览器不支持JavaScript或者一些龟毛的用户会将JavaScript禁用掉，这样，如果只使用了前台的表单验证，则整个web程序可能会运行失败。
* 用户提交的表单总是需要进行验证的，如果接受了非法的用户输入，则可能引起整个web程序崩溃。前台使用JavaScript或者JavaScript的一些核心库来进行验证，因此，无论如何也应该在后台同时对用户提交的表单进行数据验证。总结起来可以以下三种方式在后台来完成数据校验
在action中使用validata方法
在action中使用validateXXX方法
使用struts自带的验证框架
* 全局配置文件和局部配置文件
* 同包下，命名方式类似于Action类名-validation.xml的方式。如果使用了别名，则需要使用Action类名_alias-validation.xml方式。
web程序的国际化
Sprint框架及其应用：
 Spring框架地址:http://repo.spring.io/release/org/springframework/spring/
Spring原理解释

Spring管理所有对象的初始化。
IoC(Inverse of Control):控制反转或者依赖注入(DI)
AOP(A..)
 vim:set filetype=markdown: 
