use [SuperMark]
go
--insert into [States]([StatesName])
--select '�Ϸ��˻�' union
--select '�Ƿ��˻�' union
--select '�����˻�' 
--go
insert into [UserInfo]([CustomerId],[CustomerPassword],[CustomerType],[Score],[StatusId])
select '��̳�','922xs','����',2000,3 union
select '������','xdls2','��',500,3 union
select '��˽�','lls3','��ʯ��',5000,1 
go
