/* 转载自manfred_xu-chinaunix博客 */
分类： mysql/postgresql
1. sql存储过程概述
在大型数据库系统中，存储过程和触发器具有很重要的作用。无论是存储过程还是触发器，都是sql 语句和流程控制语句的集合。就本质而言，触发器也是一种存储过程。存储过程在运算时生成执行方式，所以，以后对其再运行时其执行速度很快。sql server 2000 不仅提供了用户自定义存储过程的功能，而且也提供了许多可作为工具使用的系统存储过程


1.1概念
存储过程（stored procedure）是一组为了完成特定功能的sql 语句集，经编译后存储在数据库。用户通过指定存储过程的名字并给出参数（如果该存储过程带有参数）来执行它。

在sql server 的系列版本中存储过程分为两类：系统提供的存储过程和用户自定义存储过程。系统过程主要存储在master 数据库中并以sp_为前缀，并且系统存储过程主要是从系统表中获取信息，从而为系统管理员管理sql server 提供支持。通过系统存储过程，ms sql server 中的许多管理性或信息性的活动（如了解数据库对象、数据库信息）都可以被顺利有效地完成。尽管这些系统存储过程被放在master 数据库中，但是仍可以在其它数据库中对其进行调用，在调用时不必在存储过程名前加上数据库名。而且当创建一个新数据库时，一些系统存储过程会在新数据库中被自动创建。用户自定义存储过程是由用户创建并能完成某一特定功能（如查询用户所需数据信息）的存储过程。在本章中所涉及到的存储过程主要是指用户自定义存储过程。


1.2 存储过程优点
当利用ms sql server 创建一个应用程序时，transaction-sql 是一种主要的编程语言。若运用transaction-sql 来进行编程，有两种方法。其一是，在本地存储transaction- sql 程序，并创建应用程序向sql server 发送命令来对结果进行处理。其二是，可以把部分用transaction-sql 编写的程序作为存储过程存储在sql server 中，并创建应用程序来调用存储过程，对数据结果进行处理存储过程能够通过接收参数向调用者返回结果集，结果集的格式由调用者确定；返回状态值给调用者，指明调用是成功或是失败；包括针对数据库的操作语句，并且可以在一个存储过程中调用另一存储过程。 

我们通常更偏爱于使用第二种方法，即在sql server 中使用存储过程而不是在客户计算机上调用transaction-sql 编写的一段程序，原因在于存储过程具有以下优点：
1） 存储过程允许标准组件式编程

存储过程在被创建以后可以在程序中被多次调用，而不必重新编写该存储过程的sql 语句。而且数据库专业人员可随时对存储过程进行修改，但对应用程序源代码毫无影响（因为应用程序源代码只包含存储过程的调用语句），从而极大地提高了程序的可移植性。

（2） 存储过程能够实现较快的执行速度

如果某一操作包含大量的transaction-sql 代码或分别被多次执行，那么存储过程要比批处理的执行速度快很多。因为存储过程是预编译的，在首次运行一个存储过程时，查询优化器对其进行分析、优化，并给出最终被存在系统表中的执行计划。而批处理的transaction- sql 语句在每次运行时都要进行编译和优化，因此速度相对要慢一些。

（3） 存储过程能够减少网络流量

对于同一个针对数据数据库对象的操作（如查询、修改），如果这一操作所涉及到的 transaction-sql 语句被组织成一存储过程，那么当在客户计算机上调用该存储过程时，网络中传送的只是该调用语句，否则将是多条sql 语句，从而大大增加了网络流量，降低网络负载。

（4） 存储过程可被作为一种安全机制来充分利用

系统管理员通过对执行某一存储过程的权限进行限制，从而能够实现对相应的数据访问权限的限制，避免非授权用户对数据的访问，保证数据的安全。（我们将在14 章“sqlserver 的用户和安全性管理”中对存储过程的这一应用作更为清晰的介绍）

注意：存储过程虽然既有参数又有返回值，但是它与函数不同。存储过程的返回值只是指明执行是否成功，并且它不能像函数那样被直接调用，也就是在调用存储过程时，在存储过程名字前一定要有exec保留字。


2. 基本语法 2.1 创建存储过程
create procedure sp_name //sp_name 自己给存储过程去的名称

begin

……

end


create proc dbo.存储过程名
存储过程参数
as
执行语句
return
执行存储过程
go


eg:
-- 要创建存储过程的数据库
use test
-- 判断要创建的存储过程名是否存在
if exists(select name from sysobjects where name='csp_addinfo' and
type='p')
-- 删除存储过程
drop procedure dbo.csp_addinfo
go
-- 创建存储过程
create proc dbo.csp_addinfo
-- 存储过程参数
@username varchar(16),
@pwd varchar(50),
@age smallint,
@*** varchar(6)
as
-- 存储过程语句体
insert into uname (username,pwd,age,***)
values (@username,@pwd,@age,@***)
return
-- 执行
go
-- 执行存储过程
exec csp_addinfo 'junn.a','123456',20,'男'

新存储过程的名称。过程名必须符合标识符规则，且对于数据库及其所有者必须唯一。
　　要创建局部临时过程，可以在 procedure_name 前面加一个编号符 (#procedure_name)，要创建全局临时过程，可以在 procedure_name 前面加两个编号符 (##procedure_name)。完整的名称（包括 # 或 ##）不能超过 128 个字符。指定过程所有者的名称是可选的。



2.2 调用存储过程
call procedure sp-name （）

注意：存储过程名称后面必须加括号，哪怕该存储过程没有参数传递

1）第一种方法: 使用output参数

use adventureworks;
go
if object_id ( 'production.usp_getlist', 'p' ) is not null
drop procedure production.usp_getlist;
go
create procedure production.usp_getlist
@product varchar(40)
, @maxprice money
, @compareprice money output
, @listprice money out
as
select p.name as product, p.listprice as 'list price'
from production.product p
join production.productsubcategory s
on p.productsubcategoryid = s.productsubcategoryid
where s.name like @product and p.listprice < @maxprice;
-- populate the output variable @listprice.
set @listprice = (select max(p.listprice)
from production.product p
join production.productsubcategory s
on p.productsubcategoryid = s.productsubcategoryid
where s.name like @product and p.listprice < @maxprice);
-- populate the output variable @compareprice.
set @compareprice = @maxprice;
go
--另一个存储过程调用的时候:
create proc test
as
declare @compareprice money, @cost money
execute production.usp_getlist '%bikes%', 700,
@compareprice out,
@cost output
if @cost <= @compareprice
begin
print 'these products can be purchased for less than
$'+rtrim(cast(@compareprice as varchar(20)))+'.'
end
else
print 'the prices for all products in this category exceed
$'+ rtrim(cast(@compareprice as varchar(20)))+'.'

2）第二种方法:创建一个临时表
create proc getusername
as
begin
select 'username'
end
create table #temptable (username nvarchar(50))
insert into #temptable(username)
exec getusername
select #temptable
--用完之后要把临时表清空
drop table #temptable--需要注意的是，这种方法不能嵌套。例如：
procedure a 
begin 
... 
insert #table exec b 
end 

procedure b 
begin 
... 
insert #table exec c 
select * from #table 
end 

procedure c 
begin 
... 
select * from sometable 
end
--这里ａ调ｂ的结果集，而ｂ中也有这样的应用ｂ调了ｃ的结果集，这是不允许的，
--会报“insert exec 语句不能嵌套”错误。在实际应用中要避免这类应用的发生。
3）第三种方法:声明一个变量,用exec(@sql)执行:

2.3 删除存储过程、
drop procedure sp_name//

注意：不能在一个存储过程中删除另一个存储过程，只能调用另一个存储过程

2.4 查看存储过程信息
1.show procedure status
显示数据库中所有存储的存储过程基本信息，包括所属数据库，存储过程名称，创建时间等

2.show create procedure sp_name
显示某一个mysql存储过程的详细信息


2.5注释
mysql存储过程可使用两种风格的注释
双横杠：--

该风格一般用于单行注释
c风格：/* 注释内容 */ 一般用于多行注释

2.6循环语句 2.6.1 if
if 条件

begin
执行语句
end

else

begin
执行语句
end


if @d = 1

begin

-- 打印
print '正确'
end
else begin
print '错误'
end




2.6.2 多条件选择语句
sql 里的多条件选择语句.



declare @iret int, @pkdisp varchar(20)
set @iret = 1
select @iret = 
case
when @pkdisp = '一' then 1
when @pkdisp = '二' then 2
when @pkdisp = '三' then 3
when @pkdisp = '四' then 4
when @pkdisp = '五' then 5
else 100
end



2.6.3 循环语句


while 条件 begin 
执行语句
end


eg: create procedure [dbo].[p_testwhilr]
as
declare @i int
set @i = 1
while @i<1000000 begin
set @i=@i+1
end
-- 打印
print @i
exec [dbo].[p_testwhilr]

3. 参数变量 3.1变量及定义




自定义变量：declare a int ; set a=100; 可用以下语句代替：declare a int default 100;

变量分为用户变量和系统变量，系统变量又分为会话和全局级变量

用户变量：用户变量名一般以@开头，滥用用户变量会导致程序难以理解及管理

-- 变量的声明,sql里面声明变量时必须在变量前加@符号
declare @i int

-- 变量的赋值，变量赋值时变量前必须加set
set @i = 30

-- 声明多个变量
declare @s varchar(10),@a int


3.2 运算符 3.2.1算术运算符
+ 加 set var1=2+2; 4
- 减 set var2=3-2; 1
* 乘 set var3=3*2; 6
/ 除 set var4=10/3; 3.3333
div 整除 set var5=10 div 3; 3
% 取模 set var6=10%3 ; 1


3.2.2比较运算符

> 大于 1>2 false
< 小于 2<1 false
<= 小于等于 2<=2 true
>= 大于等于 3>=2 true
between 在两值之间 5 between 1 and 10 true
not between 不在两值之间 5 not between 1 and 10 false
in 在集合中 5 in (1,2,3,4) false
not in 不在集合中 5 not in (1,2,3,4) true
= 等于 2=3 false
<>, != 不等于 2<>3 false
<=> 严格比较两个null值是否相等 null<=>null true
like 简单模式匹配 "guy harrison" like "guy%" true
regexp 正则式匹配 "guy harrison" regexp "[gg]reg" false
is null 为空 0 is null false
is not null 不为空 0 is not null true

3.逻辑运算符

4.位运算符
| 或
& 与
<< 左移位
>> 右移位
~ 非(单目运算，按位取反)


4. 输入输出 （不详）
mysql存储过程的参数用在存储过程的定义，共有三种参数类型,in,out,inout
create procedure|function([[in |out |inout ] 参数名 数据类形...])

in 输入参数
表示该参数的值必须在调用存储过程时指定，在存储过程中修改该参数的值不能被返回，为默认值

out 输出参数
该值可在存储过程内部被改变，并可返回

inout 输入输出参数
调用时指定，并且可被改变和返回




--创建存储过程求最大值

create procedure [dbo].[p_max]

@a int, -- 输入

@b int, -- 输入

@returnc int output --输出

as


if (@a>@b)

set @returnc =@a

else

set @returnc =@b



-- 调用

declare @returnc int

exec p_max 2,3,@returnc output

select @returnc


5. 函数库

mysql存储过程基本函数包括：字符串类型，数值类型，日期类型


5.1字符串类

charset(str) //返回字串字符集
concat (string2 [,… ]) //连接字串
instr (string ,substring ) //返回substring首次在string中出现的位置,不存在返回0
lcase (string2 ) //转换成小写
left (string2 ,length ) //从string2中的左边起取length个字符
length (string ) //string长度
load_file (file_name ) //从文件读取内容
locate (substring , string [,start_position ] ) 同instr,但可指定开始位置
lpad (string2 ,length ,pad ) //重复用pad加在string开头,直到字串长度为length
ltrim (string2 ) //去除前端空格
repeat (string2 ,count ) //重复count次
replace (str ,search_str ,replace_str ) //在str中用replace_str替换search_str
rpad (string2 ,length ,pad) //在str后用pad补充,直到长度为length
rtrim (string2 ) //去除后端空格
strcmp (string1 ,string2 ) //逐字符比较两字串大小,
substring (str , position [,length ]) //从str的position开始,取length个字符,
注：mysql中处理字符串时，默认第一个字符下标为1，即参数position必须大于等于1
mysql> select substring(’abcd’,0,2);
+———————–+
| substring(’abcd’,0,2) |
+———————–+
| |
+———————–+
1 row in set (0.00 sec)

mysql> select substring(’abcd’,1,2);
+———————–+
| substring(’abcd’,1,2) |
+———————–+
| ab |
+———————–+
1 row in set (0.02 sec)

trim([[both|leading|trailing] [padding] from]string2) //去除指定位置的指定字符
ucase (string2 ) //转换成大写
right(string2,length) //取string2最后length个字符
space(count) //生成count个空格

5.2 数值类型
abs (number2 ) //绝对值
bin (decimal_number ) //十进制转二进制
ceiling (number2 ) //向上取整
conv(number2,from_base,to_base) //进制转换
floor (number2 ) //向下取整
format (number,decimal_places ) //保留小数位数
hex (decimalnumber ) //转十六进制
注：hex()中可传入字符串，则返回其asc-11码，如hex(’def’)返回4142143
也可以传入十进制整数，返回其十六进制编码，如hex(25)返回19
least (number , number2 [,..]) //求最小值
mod (numerator ,denominator ) //求余
power (number ,power ) //求指数
rand([seed]) //随机数
round (number [,decimals ]) //四舍五入,decimals为小数位数]

注：返回类型并非均为整数，如：

(1)默认变为整形值
mysql> select round(1.23);
+————-+
| round(1.23) |
+————-+
| 1 |
+————-+
1 row in set (0.00 sec)

mysql> select round(1.56);
+————-+
| round(1.56) |
+————-+
| 2 |
+————-+
1 row in set (0.00 sec)

(2)可以设定小数位数，返回浮点型数据

mysql> select round(1.567,2);
+—————-+
| round(1.567,2) |
+—————-+
| 1.57 |
+—————-+
1 row in set (0.00 sec)

sign (number2 ) //返回符号,正负或0
sqrt(number2) //开平方

5.3日期类型
addtime (date2 ,time_interval ) //将time_interval加到date2
convert_tz (datetime2 ,fromtz ,totz ) //转换时区
current_date ( ) //当前日期
current_time ( ) //当前时间
current_timestamp ( ) //当前时间戳
date (datetime ) //返回datetime的日期部分
date_add (date2 , interval d_value d_type ) //在date2中加上日期或时间
date_format (datetime ,formatcodes ) //使用formatcodes格式显示datetime
date_sub (date2 , interval d_value d_type ) //在date2上减去一个时间
datediff (date1 ,date2 ) //两个日期差
day (date ) //返回日期的天
dayname (date ) //英文星期
dayofweek (date ) //星期(1-7) ,1为星期天
dayofyear (date ) //一年中的第几天
extract (interval_name from date ) //从date中提取日期的指定部分
makedate (year ,day ) //给出年及年中的第几天,生成日期串
maketime (hour ,minute ,second ) //生成时间串
monthname (date ) //英文月份名
now ( ) //当前时间
sec_to_time (seconds ) //秒数转成时间
str_to_date (string ,format ) //字串转成时间,以format格式显示
timediff (datetime1 ,datetime2 ) //两个时间差
time_to_sec (time ) //时间转秒数]
week (date_time [,start_of_week ]) //第几周
year (datetime ) //年份
dayofmonth(datetime) //月的第几天
hour(datetime) //小时
last_day(date) //date的月的最后日期
microsecond(datetime) //微秒
month(datetime) //月
minute(datetime) //分

注：可用在interval中的类型：day ,day_hour ,day_minute ,day_second ,hour ,hour_minute ,hour_second ,minute ,minute_second,month ,second ,year
declare variable_name [,variable_name...] datatype [default value]; 
其中，datatype为mysql的数据类型，如:int, float, date, varchar(length)

例：

declare l_int int unsigned default 4000000; 
declare l_numeric numeric(8,2) default 9.95; 
declare l_date date default '1999-12-31'; 
declare l_datetime datetime default '1999-12-31 23:59:59';
declare l_varchar varchar(255) default 'this will not be padded';

6. 存储过程的应用






sql存储过程进行分页的方法: 
存储过程: 
create procedure p_splitpage 
@sql nvarchar(4000), --要执行的sql语句 
@page int=1, --要显示的页码 
@pagesize int, --每页的大小 
@pagecount int=0 out, --总页数 
@recordcount int=0 out --总记录数 
as 
set nocount on 
declare @p1 int 
exec sp_cursoropen @p1 output,@sql,@scrollopt=1,@ccopt=1,@rowcount=@pagecount output 
set @recordcount = @pagecount 
select @pagecount=ceiling(1.0*@pagecount/@pagesize) 
,@page=(@page-1)*@pagesize+1 
exec sp_cursorfetch @p1,16,@page,@pagesize 
exec sp_cursorclose @p1 
go 
asp页面的内容 
sql = "select id, c_s_name from tabnews where deleted<>1 order by id desc" 
page = cint(page_get) 
if page_post<>""then 
page = cint(page_post) 
end if 
if not page > 0 then 
page = 1 
end if 
pagesize=20’每页的条数 
set cmd = server.createobject("adodb.command") 
cmd.activeconnection = conn 
cmd.commandtype = 4 
cmd.commandtext = "p_splitpage" 
cmd.parameters.append cmd.createparameter("@sql",8,1, 4000, sql) 
cmd.parameters.append cmd.createparameter("@page",4,1, 4, page) 
cmd.parameters.append cmd.createparameter("@pagesize",4,1, 4, pagesize) 
cmd.parameters.append cmd.createparameter("@pagecount",4,2, 4, pagecount) 
cmd.parameters.append cmd.createparameter("@recordcount",4,2, 4, recordcount) 
set rs = cmd.execute 
set rs = rs.nextrecordset 
pagecount = cmd.parameters("@pagecount").value 
recordcount = cmd.parameters("@recordcount").value 
if pagecount = 0 then pagecount = 1 
if page>pagecount then 
response.redirect("?page="&pagecount) 
end if 
set rs = cmd.execute 


游标

1. 概念
游标(cursor)它使户可逐行访问由sql server返回的结果集。

使用游标(cursor)的一个主要的原因就是把集合操作转换成单个记录处理方式。用sql语言从数据库中检索数据后，结果放在内存的一块区域中，且结果往往是一个含有多个记录的集合。游标机制允许用户在sql server内逐行地访问这些记录，按照用户自己的意愿来显示和处理这些记录。

2. 游标的优点
从游标定义可以得到游标的如下优点，这些优点使游标在实际应用中发挥了重要作用：
1）允许程序对由查询语句select返回的行集合中的每一行执行相同或不同的操作，而不是对整个行集合执行同一个操作。
2）提供对基于游标位置的表中的行进行删除和更新的能力。
3）游标实际上作为面向集合的数据库管理系统（rdbms）和面向行的程序设计之间的桥梁，使这两种处理方式通过游标沟通起来。

3．游标的使用
讲了这个多游标的优点，现在我们就亲自来揭开游标的神秘的面纱。

使用游标的顺序： 声名游标、打开游标、读取数据、关闭游标、删除游标

create procedure pk_test
as
--声明个变量
declare @o_id nvarchar(20)
declare @a_salary float
--声明一个游标mycursor，
declare mycursor cursor for select o_id,a_salary from addsalary
--打开游标
open mycursor
--从游标里取出数据(select语句中参数的个数必须要和从游标取出的变量名相同)赋值到我们刚才声明的个变量中
fetch next from mycursor into @o_id,@a_salary
/*//判断游标的状态
//0 fetch语句成功
//-1 fetch语句失败或此行不在结果集中
//-2被提取的行不存在*/
--循环 一次次读取 游标，得到@o_id,@a_salary的值
while (@@fetch_status=0)
--开始读执
begin
--将@o_id,@a_salary 当做一个已知量，随便使用。
--显示出我们每次用游标取出的值
print '游标成功取出一条数据'
print @o_id
print @a_salary
--用游标去取下一条记录
fetch next from mycursor into @o_id,@a_salary
end
--关闭游标
close mycursor
--撤销游标
deallocate mycursor
go
top 的使用

select top 5 lngworkid,strworkname,strexechumanname,strbegindate

from worklist where lngexechumanid= @lnguserid

取出 使用sql语句得到的记录的 前5行