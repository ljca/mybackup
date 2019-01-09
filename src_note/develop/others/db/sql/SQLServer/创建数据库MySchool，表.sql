/*
/* 创建数据库MySchool */
create database MySchool
on
(
name='MySchool_data',filename='H:\DataBase\MySchool\MySchool_data.mdf',filegrowth=15%,size=5mb,maxsize=100mb
)
log on
(
name='MySchool_log',filename='H:\DataBase\MySchool\MySchool_log.ldf',filegrowth=1mb,size=2mb
)
go
*/
use MySchool
go

/*
/* 创建学生信息表 */
create table Student
(
StudentNo int not null,LoginPwd nvarchar(50) not null,
StudentName nvarchar(50) not null,Sex bit not null,
GradeId int not null,Phone varchar(50),[Address] nvarchar(255),
BronDate datetime not null,Email varchar(50),IdentityCard varchar(18) not null
)
go

/* 创建课程表 */
create table [Subject]
(
 SubjectNo int identity(1,1) not null,SubjectName nvarchar(50),
 ClassHour int,GradeId int 
)
go
k
/* 创建年级表 */
create table Grade 
(
GradeId int identity(1,1) not null,
GradeName nvarchar(50) not null
)
go

/* 创建成绩表 */
create table Result 
(
StudentNo int not null,SubjectNo int not null,ExamDAte datetime not null,
StudentResult int not null
)
go
*/

alter table Student
add constraint PK_StudentNo primary key(StudentNo)
go

alter table Grade 
add constraint PK_GradeId primary key(GradeId)
go

alter table [Subject] 
add constraint PK_SubjectNo primary key(SubjectNo)
go

alter table Student 
add constraint UQ_IdentityCard unique(IdentityCard)
go

alter table Student
add constraint DF_Address default('地址不详') for [Address]
go

alter table Student
add constraint CK_BrowDate check(BrowDate >= '1980-01-01')
go

alter table Result 
add constraint FK_StudentNo foreign key(StudentNo) references Student(StudentNo)
go

use MySchool
go

/* 向学生表中插入数据 */
insert into Student
(StudentNo,LoginPwd,StudentName,Sex,
GradeId,Phone,[Address],BronDate,Email)
select '','','','','','','','' union
select '','','','','','','','' union
select '','','','','','','','' union
select '','','','','','','','' union
select '','','','','','','','' union
select '','','','','','','','' union
select '','','','','','','',''
go

/* 向成绩表中插入数据 */


/* 向课程表中插入数据 */



/* 向年级表中插入数据 */


select * from sysobjects
--where xtype=''
go