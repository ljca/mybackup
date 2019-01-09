--������Ϣ��
/*
if exists(select table_name from user_tables where table_name = 'users') then
  begin
    drop table users;
  end
*/
create table users
(
  id number(4) not null,
  name varchar2(50) not null,
  password nvarchar2(50),telephone nvarchar2(15),
  username nvarchar2(50),isadmin nvarchar2(5),
  primary key(id)
);

--���ⷿ����
--drop table types;
create table types
(
  id number(4) not null,name nvarchar2(50) not null,primary key(id)
);

--���ر�
--drop table "district";
create table district
(
  id number(4) not null,name nvarchar2(50) not null,primary key(id)
);

--�ֵ����ֱ�
--drop table street;
create table street
(
  id number(4) not null,name nvarchar2(50) not null,district_id number(4) not null,
  primary key(id),
  constraint FK_district_id foreign key(district_id) references district(id)
);

--�����¼��
--drop table house;
create table house
(
  id number(4) not null,
  title varchar2(50),description varchar2(255),
  price number(6),pubdate date,
  area number(4),contact varchar2(100),
  user_id number(4) not null,type_id number(4) not null,
  street_id number(4) not null,
  primary key(id),
  constraint
  FK_user_id foreign key(user_id) references users(id)
);

ALTER TABLE house add constraint 
FK_type_id foreign key(type_id) references types(id), FK_street_id foreign key(street_id) references street(id);

--������Ϣ
insert into users(id,name,username,password,telephone,isadmin) values(1,'����','zs','555555','90020200209','1');

--���ⷿ����
insert into types values(1,'����һ��');
insert into types values(2,'����һ������');
insert into types values(3,'����һ��');
insert into types values(4,'һ��һ��һ��');
insert into types values(5,'����һ��');

--����
insert into district values(1,'������');
insert into district values(2,'������');
insert into district values(3,'������');
insert into district values(4,'������');
insert into district values(5,'������');
insert into district values(6,'��̨��');
insert into district values(7,'ʯ��ɽ��');
insert into district values(8,'������');
insert into district values(9,'��������');
insert into district values(10,'��ͷ����');
insert into district values(11,'��ɽ��');
insert into district values(12,'ͨ����');
insert into district values(13,'˳����');
insert into district values(14,'��ƽ��');
insert into district values(15,'������');
insert into district values(16,'������');
insert into district values(17,'ƽ����');
insert into district values(18,'������');
insert into district values(19,'������');
--�ֵ�
insert into street(id,name,district_id) values(1,'�����Žֵ�',1);
insert into street(id,name,district_id) values(2,'�����Žֵ�',1);
insert into street(id,name,district_id) values(3,'�����Žֵ�',1);
insert into street(id,name,district_id) values(4,'��ֱ�Žֵ�',1);
insert into street(id,name,district_id) values(5,'�����Žֵ�',1);

insert into street(id,name,district_id) values(6,'��ƽ��ֵ�',1);
insert into street(id,name,district_id) values(7,'�����Žֵ�',1);
insert into street(id,name,district_id) values(8,'�����ڽֵ�',1);
insert into street(id,name,district_id) values(9,'��ɽ�ֵ�',1);
insert into street(id,name,district_id) values(10,'���Ľֵ�',1);

/* ��̳�ֵ� ��ʤ�ֵ� �½ֿڽֵ� �������ֵֽ� չ��·�ֵ� ʲɲ���ֵ� ���ڽֵֽ� */

insert into street(id,name,district_id) values(11,'��̳�ֵ�',2);
insert into street(id,name,district_id) values(12,'��ʤ�ֵ�',2);
insert into street(id,name,district_id) values(13,'�½ֿڽֵ�',2);
insert into street(id,name,district_id) values(14,'�������ֵֽ�',2);
insert into street(id,name,district_id) values(15,'չ��·�ֵ�',2);
insert into street(id,name,district_id) values(16,'ʲɲ���ֵ�',2);
insert into street(id,name,district_id) values(17,'���ڽֵֽ�',2);

--���ݳ����¼
insert into house(id,title,price,area,user_id,type_id,street_id) values(1,'��԰ס�����⣬��������ѯ',1500,100,1,1,1);

commit;


