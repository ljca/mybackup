use Student
go
if exists(select * from sys.objects where name='usp_querystudent')
drop proc usp_querystudent
go

create proc usp_querystudent
@stuid nvarchar(50),@stuname nvarchar(50),@stuage int
as
insert into student(stu_id,stu_name,stu_age) values(@stuid,@stuname,@stuage)
select * from student
go

if exists(select * from sys.objects where name='usp_querystudent')
declare  @a nvarchar(50)  = 'xx'
declare @b nvarchar(50) ='xxx'
declare @c int = 23
exec usp_querystudent @a,@b,@c



