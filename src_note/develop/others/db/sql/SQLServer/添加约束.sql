use Library
go

/* ������� */

/* ͼ����Ϣ������ ͼ���� */
alter table Book 
add constraint PK_BID primary key(BID)
go

/* ������Ϣ������ ���߱�� */
alter table Reader 
add constraint PK_RID primary key(RID)
go

/* ͼ����ı����� ���߱��-ͼ����-�������� */
alter table Borrow
add constraint PK_RID_BID primary key(RID,BID,LendDate)
go

/* �����¼������ ���߱��-ͼ����-�������� */
alter table Penalty 
add constraint PK_RID_BID_Pdate primary key(RID,BID,PDate)
go

print '* ��������ɹ���*'

/* ������ */

/* ͼ����ı���� ͼ����ı�-������Ϣ�����߱�� */
alter table Borrow
add constraint FK_RID_R Foreign key(RID) references Reader(RID)
go

/* ͼ����ı���� ͼ����ı�-ͼ����Ϣ��,ͼ���� */
alter table Borrow 
add constraint FK_BID_B Foreign key(BID) references Book(BID)
go

/* �����¼����� �����¼��-������Ϣ��,���߱�� */
alter table Penalty
add constraint FK_RID_RID Foreign key(RID) references Reader(RID)
go

/* �����¼����� �����¼��-ͼ����Ϣ��,ͼ���� */
alter table Penalty
add constraint FK_BID_BID Foreign key(BID) references Book(BID)
go

print '* �����ӳɹ���*'

/* ��ѯ������� */
select * from sysobjects
where xtype='F'
go

