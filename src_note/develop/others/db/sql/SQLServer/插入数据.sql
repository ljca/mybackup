use House
go

/* ������Ϣ��������� */
insert into hos_district(DName)
select '������' union
select '������' union
select '������' union
select '������'
go

/* �ֵ���Ϣ�������Ϣ */
insert into hos_street(SName,SDID)
select '��Ȫׯ',1 union
select '���ݽ�',2 union
select '����',3 union
select '����',4 union
select '����',4 union
select '�йش�',3
go

/* �������ͱ�������� */
insert into hos_type(HTName)
select '����һ��' union
select '����һ��' union
select 'һ��һ��'
go

/* �ͻ���Ϣ��������� */
insert into sys_user(UName,UPASSWORD)
select '����','kskhsih' union
select '����','kskhsih' union
select '����','kskhsih' union
select '����Ȼ','kskhsih' union
select '�Ŷ�ѩ','kskhsih' union
select '�','kskhsih'
go

/* ��������Ϣ��������� */
insert into hos_house([UID],[SID],HTID,PRICE,TOPIC,HTIME,CONTENTS)
select 1,1,1,1000,'�йش�','1995-2-4','�йش�һ����' union
select 2,2,2,2000,'����','1995-2-4','�����ܶ���ʳ' union
select 3,3,3,3000,'����','1995-2-4','�����ܶ���ʳ' union
select 4,4,3,4000,'��ȫׯ����','1995-2-4','��ȫׯ����һ����' 
go
