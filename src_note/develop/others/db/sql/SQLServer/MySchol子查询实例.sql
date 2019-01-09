use MySchool
go

/* 如果存在编号s1的学生记录，则将它的编号更新为s2 */

if exists(select StudentName from Student 
where GradeId = (
select GradeId from Grade
where GradeId = 'S1')
)
begin
update Student set GradeId = 'S2'
end
/* 否则，查询全部的学生记录 */
/*
else 
begin 
select StudentNo,StudentName,GradeId from Student
end 
go
*/

/*
select 名字 = StudentName,
考试成绩 = case 
when Examcount > 0 then ExamCount 
else 0
end
from Student
where SutdentName = ''
*/

/* 子查询可以出现在任何表达式中的任何位置 */
select StudentName as 学生姓名,
(select SubjectName from [Subject]) as 课程名称,
(select GradeName from Grade) as 年级
from Student
go

/*
select 



from Result 
inner join Subject on (Subject.SubjectNo = Result.SubjectNo)
inner join Stuent on Result.StudentNo = Result.StudentNo
where Result.ExamDate = (

select Max()

)

*/












