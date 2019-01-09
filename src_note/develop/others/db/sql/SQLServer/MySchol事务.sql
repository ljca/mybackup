use MySchool
go

begin transaction
declare @No int
set @No = 0

insert into Student(StudentName,LoginPwd,Sex,IdentityCard,GradeId,BronDate)
values('','','true','',1,'')
set @No = @No + @@ERROR
insert into Student(StudentName,LoginPwd,Sex,IdentityCard,GradeId,BronDate)
values('','','false','',2,'')
set @No = @No + @@ERROR
insert into Student(StudentName,LoginPwd,Sex,IdentityCard,GradeId,BronDate)
values('','','true','',3,'')
set @No = @No + @@ERROR
insert into Student(StudentName,LoginPwd,Sex,IdentityCard,GradeId,BronDate)
values('','','false','',3,'')
set @No = @No + @@ERROR
insert into Student(StudentName,LoginPwd,Sex,IdentityCard,GradeId,BronDate)
values('','','true','',2,'')
set @No = @No + @@ERROR
insert into Student(StudentName,LoginPwd,Sex,IdentityCard,GradeId,BronDate)
values('','','false','',1,'')
set @No = @No + @@ERROR
insert into Student(StudentName,LoginPwd,Sex,IdentityCard,GradeId,BronDate)
values('','','true','',2,'')
set @No = @No + @@ERROR
if @No = 0
begin
commit transaction
print ''
select * from Student
end
else 
rollback transaction
print ''
select * from Student