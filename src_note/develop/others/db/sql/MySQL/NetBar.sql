/* 网吧计费数据库 */
create database if not exists NetBar;
use NetBar;

/* 上网卡表 */
drop table if exists card;
create table if not exists card
(

cardId varchar(10) not null,
passWord varchar(50) default '123456',
balance int default 0 comment '卡上余额',
userName varchar(50) default 'kyzs',
constraint card_pk primary key(cardId)
);
truncate table card;

insert into card(cardId,passWord,balance,userName)
values
('c1','123456',5,'kyzs1'),
('c2','123456',5,'kyzs2'),
('c3','123456',5,'kyzs3'),
('c4','123456',5,'kyzs4'),
('c5','123456',5,'kyzs5'),
('c6','123456',5,'kyzs6'),
('c7','123456',5,'kyzs7'),
('c8','123456',5,'kyzs8'),
('c9','123456',5,'kyzs9'),
('c10','123456',5,'kyzs10'),
('c11','123456',5,'kyzs11'),
('c12','123456',5,'kyzs12'),
('c13','123456',5,'kyzs13'),
('c14','123456',5,'kyzs14'),
('c15','123456',5,'kyzs15'),
('c16','123456',5,'kyzs16'),
('c17','123456',5,'kyzs17'),
('c18','123456',5,'kyzs18'),
('c19','123456',5,'kyzs19'),
('c20','123456',5,'kyzs20'),
('c21','123456',5,'kyzs21'),
('c22','123456',5,'kyzs22'),
('c23','123456',5,'kyzs23'),
('c24','123456',5,'kyzs24'),
('c25','123456',5,'kyzs25'),
('c26','123456',5,'kyzs26'),
('c27','123456',5,'kyzs27'),
('c28','123456',5,'kyzs28'),
('c29','123456',5,'kyzs29'),
('c30','123456',5,'kyzs30'),
('c31','123456',5,'kyzs31')
;


/* 计算机表 */
drop table if exists computer;
create table if not exists computer
(
computerId varchar(10) not null comment '计算机编号',
onUse varchar(1) not null comment '是否正在使用',
note varchar(100) comment '备注信息',
constraint computer_pk primary key(computerId)
);

-- truncate table computer;
delete from computer;
insert into computer(computerId,onUse,note)
values
('d1','是','正在使用中，勿扰！'),
('d2','是','正在使用中，勿扰！'),
('d3','是','正在使用中，勿扰！'),
('d4','是','正在使用中，勿扰！'),
('d5','是','正在使用中，勿扰！'),
('d6','是','正在使用中，勿扰！'),
('d7','是','正在使用中，勿扰！'),
('d8','是','正在使用中，勿扰！'),
('d9','是','正在使用中，勿扰！'),
('d10','是','正在使用中，勿扰！'),
('d11','是','正在使用中，勿扰！'),
('d12','是','正在使用中，勿扰！'),
('d13','是','正在使用中，勿扰！'),
('d14','是','正在使用中，勿扰！'),
('d15','是','正在使用中，勿扰！'),
('d16','是','正在使用中，勿扰！'),
('d17','是','正在使用中，勿扰！'),
('d18','是','正在使用中，勿扰！'),
('d19','是','正在使用中，勿扰！'),
('d20','是','正在使用中，勿扰！'),
('d21','是','正在使用中，勿扰！'),
('d22','是','正在使用中，勿扰！'),
('d23','是','正在使用中，勿扰！'),
('d24','是','正在使用中，勿扰！'),
('d25','是','正在使用中，勿扰！'),
('d26','是','正在使用中，勿扰！'),
('d27','是','正在使用中，勿扰！'),
('d28','是','正在使用中，勿扰！'),
('d29','是','正在使用中，勿扰！'),
('d30','是','正在使用中，勿扰！'),
('d31','是','正在使用中，勿扰！'),
('d32','是','正在使用中，勿扰！'),
('d33','是','正在使用中，勿扰！'),
('d34','是','正在使用中，勿扰！'),
('d35','是','正在使用中，勿扰！'),
('d36','是','正在使用中，勿扰！'),
('d37','是','正在使用中，勿扰！'),
('d38','是','正在使用中，勿扰！'),
('d39','是','正在使用中，勿扰！'),
('d40','是','正在使用中，勿扰！')
;


/* 上机信息表,引用计算机表computer */
drop table if exists record;
create table if not exists record
(
recId int not null auto_increment comment '',
cardId varchar(10) not null,
computerId varchar(10) not null comment '计算机编号，引用计算机表',
beginTime Date comment '开始时间', 
endTime Date,
fee numeric comment '上机费用',
constraint record_pk primary key(recId),

constraint computer_record_fk foreign key(computerId) references computer(computerId)
);

delete from record;
insert into record(cardId,computerId,beginTime,endTime)
values
('c1','d1','2014-09-20 20:00','2014-09-20 22:00'),
('c2','d2','2014-09-20 17:00','2014-09-20 22:00'),
('c3','d3','2034-09-20 09:00','2034-09-20 22:00'),
('c4','d4','2014-09-20 18:00','2014-09-20 22:00'),
('c5','d5','2014-8-2 15:00','2014-8-2 18:00')
;

