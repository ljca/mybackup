use MySchool
go

/* ������ڱ��s1��ѧ����¼�������ı�Ÿ���Ϊs2 */

if exists(select StudentName from Student 
where GradeId = (
select GradeId from Grade
where GradeId = 'S1')
)
begin
update Student set GradeId = 'S2'
end
/* ���򣬲�ѯȫ����ѧ����¼ */
/*
else 
begin 
select StudentNo,StudentName,GradeId from Student
end 
go
*/

/*
select ���� = StudentName,
���Գɼ� = case 
when Examcount > 0 then ExamCount 
else 0
end
from Student
where SutdentName = ''
*/

/* �Ӳ�ѯ���Գ������κα��ʽ�е��κ�λ�� */
select StudentName as ѧ������,
(select SubjectName from [Subject]) as �γ�����,
(select GradeName from Grade) as �꼶
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












