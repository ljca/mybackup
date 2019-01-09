--房客信息表
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

--出租房类型
--drop table types;
create table types
(
  id number(4) not null,name nvarchar2(50) not null,primary key(id)
);

--区县表
--drop table "district";
create table district
(
  id number(4) not null,name nvarchar2(50) not null,primary key(id)
);

--街道划分表
--drop table street;
create table street
(
  id number(4) not null,name nvarchar2(50) not null,district_id number(4) not null,
  primary key(id),
  constraint FK_district_id foreign key(district_id) references district(id)
);

--出租记录表
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

--房客信息
insert into users(id,name,username,password,telephone,isadmin) values(1,'张三','zs','555555','90020200209','1');

--出租房类型
insert into types values(1,'三室一厅');
insert into types values(2,'三室一厅两卫');
insert into types values(3,'三室一卫');
insert into types values(4,'一室一厅一卫');
insert into types values(5,'两室一厅');

--区县
insert into district values(1,'东城区');
insert into district values(2,'西城区');
insert into district values(3,'崇文区');
insert into district values(4,'宣武区');
insert into district values(5,'朝阳区');
insert into district values(6,'丰台区');
insert into district values(7,'石景山区');
insert into district values(8,'海淀区');
insert into district values(9,'万柳地区');
insert into district values(10,'门头沟区');
insert into district values(11,'房山区');
insert into district values(12,'通州区');
insert into district values(13,'顺义区');
insert into district values(14,'昌平区');
insert into district values(15,'大兴区');
insert into district values(16,'怀柔区');
insert into district values(17,'平谷区');
insert into district values(18,'延庆县');
insert into district values(19,'密云县');
--街道
insert into street(id,name,district_id) values(1,'安定门街道',1);
insert into street(id,name,district_id) values(2,'建国门街道',1);
insert into street(id,name,district_id) values(3,'朝阳门街道',1);
insert into street(id,name,district_id) values(4,'东直门街道',1);
insert into street(id,name,district_id) values(5,'东华门街道',1);

insert into street(id,name,district_id) values(6,'和平里街道',1);
insert into street(id,name,district_id) values(7,'北新桥街道',1);
insert into street(id,name,district_id) values(8,'交道口街道',1);
insert into street(id,name,district_id) values(9,'景山街道',1);
insert into street(id,name,district_id) values(10,'东四街道',1);

/* 月坛街道 德胜街道 新街口街道 西长安街街道 展览路街道 什刹海街道 金融街街道 */

insert into street(id,name,district_id) values(11,'月坛街道',2);
insert into street(id,name,district_id) values(12,'德胜街道',2);
insert into street(id,name,district_id) values(13,'新街口街道',2);
insert into street(id,name,district_id) values(14,'西长安街街道',2);
insert into street(id,name,district_id) values(15,'展览路街道',2);
insert into street(id,name,district_id) values(16,'什刹海街道',2);
insert into street(id,name,district_id) values(17,'金融街街道',2);

--房屋出租记录
insert into house(id,title,price,area,user_id,type_id,street_id) values(1,'花园住房出租，有意者详询',1500,100,1,1,1);

commit;


