use Library
go

/* ͼ����Ϣ������¼ */
insert into Book(BID,BName,Author,PubComp,Bcount,Price)
select 'ISBN_2012_3s','����������������߹���','���ھ��׵���','δ֪',20,'2' union
select 'ISBN_922SP','���ƻ�','����','δ֪',20,'1'
go

/* ������Ϣ������¼ */
insert into Reader(RID,RName,LendNum)
select 'so2','��������',2 union 
select 'ysl2','��ľ�괺',3
go

/* ͼ����ı�����¼ */
insert into Borrow(RID,BID,LendDate)
select 'ysl2','ISBN_2012_3s','2012-1-1' union
select 'so2','ISBN_922SP','2013-2-1'
go

/* �����¼������¼ */
insert into Penalty(RID,BID,PDate,PType,Amount)
select 'so2','ISBN_922SP','2012-12-04',2,'20' union
select 'ysl2','ISBN_2012_3s','2013-2-5',3,'50'
go


