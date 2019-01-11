#  framboader
MyEclipse-Hibernate 
ERROR:
？信息: Reading mappings from resource : test.entity.District.hbm.xml
Exception in thread "main" org.hibernate.MappingNotFoundException: resource: test.entity.District.hbm.xml not found
<mapping resource="test.entity.Street.hbm.xml" /> --> ！低版本Hibernate的持久化类映射文件的映射节点不能使用点号作为路径分隔符。
<mapping resource="test/entity/District.hbm.xml" />
！resource属性值中的路径错误，或者使用了其它字符作为路径分隔符，低版本的hibernate只能以标准的正斜杠'/'作为路径分隔符。

ERROR：
？Exception in thread "main" org.hibernate.HibernateException: Dialect class not found: org.hibernate.dialect.Oracle11gDialect
at org.hibernate.dialect.resolver.DialectFactory.constructDialect(DialectFactory.java:160)
at org.hibernate.dialect.resolver.DialectFactory.buildDialect(DialectFactory.java:100)
at org.hibernate.cfg.SettingsFactory.buildSettings(SettingsFactory.java:117)
at org.hibernate.cfg.Configuration.buildSettingsInternal(Configuration.java:2119)
at org.hibernate.cfg.Configuration.buildSettings(Configuration.java:2115)
at org.hibernate.cfg.Configuration.buildSessionFactory(Configuration.java:1339)
at test.dao.OracleDao.queryDistricts(OracleDao.java:34)
at test.dao.OracleDao.main(OracleDao.java:44)
？Caused by: java.lang.ClassNotFoundException: org.hibernate.dialect.Oracle11gDialect

<property name="dialect">org.hibernate.dialect.Oracle10gDialect</property>
！数据库方言属性dialect设置错误了错误的值。


二月 29, 2016 11:59:22 上午 org.hibernate.util.NamingHelper getInitialContext
信息: JNDI InitialContext properties:{}
二月 29, 2016 11:59:22 上午 org.hibernate.impl.SessionFactoryObjectFactory addInstance
ERROR：
？警告: Could not bind factory to JNDI
javax.naming.NoInitialContextException: Need to specify class name in environment or system property, or as an applet parameter, or in an application resource file:  java.naming.factory.initial
at javax.naming.spi.NamingManager.getInitialContext(NamingManager.java:662)
at javax.naming.InitialContext.getDefaultInitCtx(InitialContext.java:307)
at javax.naming.InitialContext.getURLOrDefaultInitCtx(InitialContext.java:344)
at javax.naming.InitialContext.getNameParser(InitialContext.java:499)
at org.hibernate.util.NamingHelper.bind(NamingHelper.java:75)
at org.hibernate.impl.SessionFactoryObjectFactory.addInstance(SessionFactoryObjectFactory.java:113)
at org.hibernate.impl.SessionFactoryImpl.<init>(SessionFactoryImpl.java:348)
at org.hibernate.cfg.Configuration.buildSessionFactory(Configuration.java:1341)
at test.dao.OracleDao.queryDistricts(OracleDao.java:34)
at test.dao.OracleDao.main(OracleDao.java:44)
！如果没有使用JNDI,则不能为hibernage-configuretion节点下的session-factory子元素设置name属性。

ERROR：
？Caused by: org.hibernate.PropertyNotFoundException: Could not find a getter for distirictId in class house.entity.Street
at org.hibernate.property.BasicPropertyAccessor.createGetter(BasicPropertyAccessor.java:306)
at org.hibernate.property.BasicPropertyAccessor.getGetter(BasicPropertyAccessor.java:299)
at org.hibernate.mapping.Property.getGetter(Property.java:294)
at org.hibernate.tuple.entity.PojoEntityTuplizer.buildPropertyGetter(PojoEntityTuplizer.java:300)
at org.hibernate.tuple.entity.AbstractEntityTuplizer.<init>(AbstractEntityTuplizer.java:141)
at org.hibernate.tuple.entity.PojoEntityTuplizer.<init>(PojoEntityTuplizer.java:78)
... 15 more
！引用找不到类:不能在实体类Street中找到关于字段districtId的getter方法。

ERROR：
？Exception in thread "main" org.hibernate.HibernateException: Unable to instantiate default tuplizer [org.hibernate.tuple.entity.PojoEntityTuplizer]
at org.hibernate.tuple.entity.EntityTuplizerFactory.constructTuplizer(EntityTuplizerFactory.java:110)
at org.hibernate.tuple.entity.EntityTuplizerFactory.constructDefaultTuplizer(EntityTuplizerFactory.java:135)
at org.hibernate.tuple.entity.EntityEntityModeToTuplizerMapping.<init>(EntityEntityModeToTuplizerMapping.java:80)
at org.hibernate.tuple.entity.EntityMetamodel.<init>(EntityMetamodel.java:323)
at org.hibernate.persister.entity.AbstractEntityPersister.<init>(AbstractEntityPersister.java:456)
at org.hibernate.persister.entity.SingleTableEntityPersister.<init>(SingleTableEntityPersister.java:131)
at org.hibernate.persister.PersisterFactory.createClassPersister(PersisterFactory.java:84)
at org.hibernate.impl.SessionFactoryImpl.<init>(SessionFactoryImpl.java:267)
at org.hibernate.cfg.Configuration.buildSessionFactory(Configuration.java:1341)
at house.dao.OracleDao.queryDistricts(OracleDao.java:47)
at house.dao.OracleDao.main(OracleDao.java:68)
！来自yuhuashi - 博客园
第一种可能是缺少javassist.jar包，下面给出下载地址。http://mirrors.ibiblio.org/pub/mirrors/maven/javassist/jars/javassist-3.0.jar
第二种可能是hibernate.cfg.xml的mapping配置错误，仔细检查这个文件，把有错误的先注释掉再试试。
第三种可能是某个实体类中外加了某些getXX(),而不存在XX属性，这时要在get上加@Transient,不持久化它就行了。
或者是实体表或映射表中属性写的不一致导致的，所以要细心检查实体类、.hbm.xml和数据库之间的属性名、字段名还有类型是否写错了。

警告: The Oracle9Dialect dialect has been deprecated; use either Oracle9iDialect or Oracle10gDialect instead
！来自谷歌的翻译：
Oracle9Dialect方言已被弃用;使用别的Oracle9i方言或者Oracle10i方言代替

警告: The OracleDialect dialect has been deprecated; use Oracle8iDialect instead
OracleDialect方言已被弃用;使用Oracle8i方言代替

ERROR：
SLF4J: Class path contains multiple SLF4J bindings.
SLF4J: Found binding in [jar:file:/G:/win8.1/MyEclipse/plugins/com.genuitec.eclipse.j2eedt.core_11.5.0.me201311281640/data/libraryset/EE_6/bean-validator.jar!/org/slf4j/impl/StaticLoggerBinder.class]
SLF4J: Found binding in [jar:file:/G:/win8.1/MyEclipse/plugins/com.genuitec.eclipse.j2eedt.core_11.5.0.me201311281640/data/libraryset/EE_6/weld-osgi-bundle.jar!/org/slf4j/impl/StaticLoggerBinder.class]
SLF4J: See http://www.slf4j.org/codes.html#multiple_bindings for an explanation.
Exception in thread "main" java.lang.NullPointerException
at test.dao.impl.IDistrictDaoImp.countAll(IDistrictDaoImp.java:28)
at test.dao.impl.IDistrictDaoImp.main(IDistrictDaoImp.java:34)
！空指针异常，sqlSession对象在关闭前应该进行非空验证


ERROR：
SLF4J: Class path contains multiple SLF4J bindings.
SLF4J: Found binding in [jar:file:/G:/win8.1/MyEclipse/plugins/com.genuitec.eclipse.j2eedt.core_11.5.0.me201311281640/data/libraryset/EE_6/bean-validator.jar!/org/slf4j/impl/StaticLoggerBinder.class]
SLF4J: Found binding in [jar:file:/G:/win8.1/MyEclipse/plugins/com.genuitec.eclipse.j2eedt.core_11.5.0.me201311281640/data/libraryset/EE_6/weld-osgi-bundle.jar!/org/slf4j/impl/StaticLoggerBinder.class]
SLF4J: See http://www.slf4j.org/codes.html#multiple_bindings for an explanation.
Exception in thread "main" org.apache.ibatis.exceptions.PersistenceException: 
### Error building SqlSession.
### The error may exist in test.dao.District-Mapper.xml
### Cause: org.apache.ibatis.builder.BuilderException: Error parsing SQL Mapper Configuration. Cause: java.io.IOException: Could not find resource test.dao.District-Mapper.xml
at org.apache.ibatis.exceptions.ExceptionFactory.wrapException(ExceptionFactory.java:30)
at org.apache.ibatis.session.SqlSessionFactoryBuilder.build(SqlSessionFactoryBuilder.java:54)
at org.apache.ibatis.session.SqlSessionFactoryBuilder.build(SqlSessionFactoryBuilder.java:38)
at test.dao.impl.IDistrictDaoImp.countAll(IDistrictDaoImp.java:21)
at test.dao.impl.IDistrictDaoImp.main(IDistrictDaoImp.java:36)
Caused by: org.apache.ibatis.builder.BuilderException: Error parsing SQL Mapper Configuration. Cause: java.io.IOException: Could not find resource test.dao.District-Mapper.xml
at org.apache.ibatis.builder.xml.XMLConfigBuilder.parseConfiguration(XMLConfigBuilder.java:118)
at org.apache.ibatis.builder.xml.XMLConfigBuilder.parse(XMLConfigBuilder.java:96)
at org.apache.ibatis.session.SqlSessionFactoryBuilder.build(SqlSessionFactoryBuilder.java:52)
... 3 more
Caused by: java.io.IOException: Could not find resource test.dao.District-Mapper.xml
at org.apache.ibatis.io.Resources.getResourceAsStream(Resources.java:114)
at org.apache.ibatis.io.Resources.getResourceAsStream(Resources.java:100)
at org.apache.ibatis.builder.xml.XMLConfigBuilder.mapperElement(XMLConfigBuilder.java:358)
at org.apache.ibatis.builder.xml.XMLConfigBuilder.parseConfiguration(XMLConfigBuilder.java:116)
... 5 more
！mapper元素resource属性值中的路径错误导致系统找不到SQL映射文件。


ERROR：
SLF4J: Class path contains multiple SLF4J bindings.
SLF4J: Found binding in [jar:file:/G:/win8.1/MyEclipse/plugins/com.genuitec.eclipse.j2eedt.core_11.5.0.me201311281640/data/libraryset/EE_6/bean-validator.jar!/org/slf4j/impl/StaticLoggerBinder.class]
SLF4J: Found binding in [jar:file:/G:/win8.1/MyEclipse/plugins/com.genuitec.eclipse.j2eedt.core_11.5.0.me201311281640/data/libraryset/EE_6/weld-osgi-bundle.jar!/org/slf4j/impl/StaticLoggerBinder.class]
SLF4J: See http://www.slf4j.org/codes.html#multiple_bindings for an explanation.
Exception in thread "main" org.apache.ibatis.exceptions.PersistenceException: 
### Error querying database.  Cause: java.sql.SQLException: The Network Adapter could not establish the connection
### The error may exist in test/dao/District-Mapper.xml
### The error may involve test.dao.IDistrictDao.countAll
### The error occurred while executing a query
### Cause: java.sql.SQLException: The Network Adapter could not establish the connection
..........................................................................
Caused by: java.net.ConnectException: Connection refused: connect
at oracle.net.nt.TcpNTAdapter.connect(TcpNTAdapter.java:141)
at oracle.net.nt.ConnOption.connect(ConnOption.java:123)
at oracle.net.nt.ConnStrategy.execute(ConnStrategy.java:337)
... 31 more
！未打开Oracle数据库服务

%%%% Error Creating SessionFactory %%%%
org.hibernate.InvalidMappingException: Could not parse mapping document from resource movie/entity/MovieType.hbm.xml
at org.hibernate.cfg.Configuration.addResource(Configuration.java:616)
at org.hibernate.cfg.Configuration.parseMappingElement(Configuration.java:1635)
at org.hibernate.cfg.Configuration.parseSessionFactory(Configuration.java:1603)
at org.hibernate.cfg.Configuration.doConfigure(Configuration.java:1582)
at org.hibernate.cfg.Configuration.doConfigure(Configuration.java:1556)
at org.hibernate.cfg.Configuration.configure(Configuration.java:1476)
at movie.util.HibernateSessionFactory.rebuildSessionFactory(HibernateSessionFactory.java:69)
at movie.util.HibernateSessionFactory.getSession(HibernateSessionFactory.java:53)
at movie.dao.impl.MovieDaoImpl.queryAllMovies(MovieDaoImpl.java:17)
at movie.dao.impl.MovieDaoImpl.main(MovieDaoImpl.java:34)
Caused by: org.hibernate.DuplicateMappingException: Duplicate collection role mapping movie.entity.MovieType.movies
at org.hibernate.cfg.Mappings.addCollection(Mappings.java:147)
at org.hibernate.cfg.HbmBinder.createClassProperties(HbmBinder.java:2085)
at org.hibernate.cfg.HbmBinder.createClassProperties(HbmBinder.java:2060)
at org.hibernate.cfg.HbmBinder.bindRootPersistentClassCommonValues(HbmBinder.java:381)
at org.hibernate.cfg.HbmBinder.bindRootClass(HbmBinder.java:295)
at org.hibernate.cfg.HbmBinder.bindRoot(HbmBinder.java:166)
at org.hibernate.cfg.Configuration.add(Configuration.java:716)
at org.hibernate.cfg.Configuration.addInputStream(Configuration.java:551)
at org.hibernate.cfg.Configuration.addResource(Configuration.java:613)
... 9 more
！映射文件中存在属性值与持久化类字段名称不一致

警告: Could not obtain connection metadata
java.sql.SQLRecoverableException: 无法从套接字读取更多的数据
at oracle.jdbc.driver.T4CMAREngine.unmarshalUB1(T4CMAREngine.java:1200)
at oracle.jdbc.driver.T4CMAREngine.unmarshalSB1(T4CMAREngine.java:1155)
at oracle.jdbc.driver.T4C8TTIpro.receive(T4C8TTIpro.java:128)
at oracle.jdbc.driver.T4CConnection.connect(T4CConnection.java:1064)
。。。。。
！

四月 06, 2016 11:28:37 上午 org.hibernate.util.JDBCExceptionReporter logExceptions
警告: SQL Error: 2289, SQLState: 42000
四月 06, 2016 11:28:37 上午 org.hibernate.util.JDBCExceptionReporter logExceptions
严重: ORA-02289: 序列不存在
！当generator主键生成策略被指定为为native(即由Hibernate根据底层数据库自行判断生成策略时)

信息: Mapping collection: house.entity.District.streets -> street
org.hibernate.MappingException: Repeated column in mapping for entity: house.entity.Street column: district_id (should be mapped with insert="false" update="false")
at org.hibernate.mapping.PersistentClass.checkColumnDuplication(PersistentClass.java:670)
at org.hibernate.mapping.PersistentClass.checkPropertyColumnDuplication(PersistentClass.java:692)
.......
！数据库列与持久化类的字段数据类型映射错误


Struts2
？An error has occurred. See error log for more details.
Path must include project and resource name: /struts-default.xml
！


type Exception report
message 
description The server encountered an internal error () that prevented it from fulfilling this request.
exception 
java.lang.NullPointerException
test.struts.UserStruts.execute(UserStruts.java:18)
sun.reflect.NativeMethodAccessorImpl.invoke0(Native Method)
sun.reflect.NativeMethodAccessorImpl.invoke(NativeMethodAccessorImpl.java:57)
sun.reflect.DelegatingMethodAccessorImpl.invoke(DelegatingMethodAccessorImpl.java:43)
java.lang.reflect.Method.invoke(Method.java:606)
ognl.OgnlRuntime.invokeMethod(OgnlRuntime.java:871)
ognl.OgnlRuntime.callAppropriateMethod(OgnlRuntime.java:1294)
ognl.ObjectMethodAccessor.callMethod(ObjectMethodAccessor.java:68)
com.opensymphony.xwork2.ognl.accessor.XWorkMethodAccessor.callMethodWithDebugInfo(XWorkMethodAccessor.java:117)
com.opensymphony.xwork2.ognl.accessor.XWorkMethodAccessor.callMethod(XWorkMethodAccessor.java:108)
ognl.OgnlRuntime.callMethod(OgnlRuntime.java:1370)
ognl.ASTMethod.getValueBody(ASTMethod.java:90)
ognl.SimpleNode.evaluateGetValueBody(SimpleNode.java:212)
ognl.SimpleNode.getValue(SimpleNode.java:258)
ognl.Ognl.getValue(Ognl.java:494)
ognl.Ognl.getValue(Ognl.java:458)
！

2016/4/21 星期四 20:05
HTTP Status 500 - 

--------------------------------------------------------------------------------
type Exception report
message 
description The server encountered an internal error () that prevented it from fulfilling this request.
exception 
java.lang.ClassCastException: java.lang.Class cannot be cast to java.lang.reflect.ParameterizedType
house.dao.impl.BaseDao.<init>(BaseDao.java:17)
house.dao.impl.UserDaoImpl.<init>(UserDaoImpl.java:7)
house.biz.impl.UserBizImpl.<init>(UserBizImpl.java:7)
house.servlet.LoginServlet.doPost(LoginServlet.java:24)
javax.servlet.http.HttpServlet.service(HttpServlet.java:641)
javax.servlet.http.HttpServlet.service(HttpServlet.java:722)
note The full stack trace of the root cause is available in the Apache Tomcat/7.0.27 logs.
！

2016/4/29 星期五 表单验证
HTTP Status 404 - No result defined for action test.struts.RegisterAction and result input
--------------------------------------------------------------------------------
type Status report
message No result defined for action test.struts.RegisterAction and result input
description The requested resource (No result defined for action test.struts.RegisterAction and result input) is not available.
！struts配置文件中没有配置input结果视图
...
<result name="input">.....</result>
2016/4/29 星期五
！当web项目配置文件包括框架配置文件被修改时，无需重新部署项目，只需重启web容器服务即可。
！当视图层代码被修改时，只需重载页面即可。
！当java源码、action或者servlet代码被修改时，需要停止服务后重新部署web项目。

2016/4/29 星期五 
？Struts配置文件package元素属性配置
<package name="" namespace="" extends="" >
.....
</package>
name <!-- 指定包名，包名的命名方式是随意的，因为这只是为了方便被其它配置文件引用；如果不需要被引用，则可以将它的值设置为default。-->
extends <!-- -->

<!-- 命名空间的值的命名方式并不是随意的，如果视图文件位于Web项目下的根目录下，则可以省略或者将它设置为/。-->
<!-- 否则，命名空间namespace属性的值必须与视图页面文件所在的目录名称一致。 -->
namespace=""

2016/5/4 星期三
log4j:WARN No appenders could be found for logger (com.opensymphony.xwork2.util.fs.DefaultFileManagerFactory).
log4j:WARN Please initialize the log4j system properly.
log4j:WARN See http://logging.apache.org/log4j/1.2/faq.html#noconfig for more info.
！一些框架需要通过log4j来支持日志输出，但是在项目中却没有对log4j进行配置
在项目中添加log4j的引用
log4j配置文件:log4j.properties

2016/5/6 星期五
Struts提供的内部验证框架无法正常使用
！使用struts表单标签时如果将validatde的属性值设为true,则会开启客户端验证
！在高一点版本的struts框架中，如果开启了客户端验证，则表单元素的action属性值必须合法，否则web容器会抛出一个strem closed的异常。
2016/5/26 星期四  
严重: Exception starting filter struts2  
Unable to load configuration. - bean -  
jar:file:/G:/DeveLop/Server/Tomcat7/webapps/MaterSaleMgr/WEB-
INF/lib/struts2-core-2.3.28.1.jar!/struts-default.xml:92:179  
at org.apache.struts2.dispatcher.Dispatcher.init(Dispatcher.java:496)  
at org.apache.struts2.dispatcher.ng.InitOperations.ini
2016/5/27 星期五  
The hierarchy of the type Charpter132 is inconsistent  
private Logger logger = Logger.getLogger(this.getClass());  
@Override  
public void before(Method arg0,Object[] arg1,Object arg2) throws Throwable{  
logger.info("调用"+arg2+"的"+arg0.getName()+"方法");  
}  
！
iBatis  
？org.apache.ibatis.exceptions.PersistenceException:  
### Error querying database. Cause:
org.apache.ibatis.executor.ExecutorException: Executor was closed.  
### Cause: org.apache.ibatis.executor.ExecutorException: Executor was closed.  
！
vim:set ft=markdown:
