create datebase if not exists Customer;

use Customer if exists Customer;

create table if not exists NationalityInfo 
(
  nationalityId Integer(4) primary key increment not null,
  nationality varchar(50) not null
);


create table if not exists CustomerInfo
(
  id Integer(4) primary key increment not null,
  name varchar(50) not null,
  sex bit(1) not null,nationalityId Integer(4) not null,
  certificate varchar(50) not null comment '证件类别',
  certificateNum varchar(20) not null,
  address varchar(255),company varchar(50) comment '单位',
  matter varchar(200) default '出差' comment '事由',
  constraint FK_nationId foreign key(nationalityId) references Nationality(nationalityId)

);

insert into Nationality(nationlity) values('中国'),('日本'),('英国'),('美国'),('瑞典'),('新加坡'),('德国'),('俄罗斯'),('挪威'),('加拿大');

insert into CustomerInfo(name,sex,certificate,certificateNum,nationalityId,address,company,matter)
values
('张三',1,'身份证','9292020202202022',1,'未知地址','未知单位','出差'),
('李四',2,'身份证','9292020202202022',2,'未知地址','未知单位','出差'),
('过某',1,'身份证','9292020202202022',3,'未知地址','未知单位','出差'),
('辛某',2,'身份证','9292020202202022',4,'未知地址','未知单位','出差'),
('祝某',1,'身份证','9292020202202022',6,'未知地址','未知单位','出差'),
('向某',2,'身份证','9292020202202022',7,'未知地址','未知单位','出差'),
('徐某',1,'身份证','9292020202202022',8,'未知地址','未知单位','出差'),
('谢某',2,'身份证','9292020202202022',9,'未知地址','未知单位','出差'),
('刘某',1,'身份证','9292020202202022',10,'未知地址','未知单位','出差'),
('王某',2,'身份证','9292020202202022',1,'未知地址','未知单位','出差'),
('小灰',1,'身份证','9292020202202022',1,'未知地址','未知单位','出差'),
;

