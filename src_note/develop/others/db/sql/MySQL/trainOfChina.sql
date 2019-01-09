/* 铁路列车数据库 */
create database if not exists train;
use train;


/* 列车基本信息表trainInfo,被列车调度信息表引用 */
create table if not exists trainInfo
(
tNumber varchar(16) not null comment '车次',
tFrom varchar(20) not null comment '起点站',
tDest varchar(20) not null comment '终点站',
tDistance int comment '起点站到终点站的里程',
tStartTime DateTime comment '始发时间',
tEndTime DateTime comment '到站时间',
tDay int default 1 comment '旅行总时间',
tSpeed int default 120 comment '列车速度，千米/时',
tUnitPrice double default 0.7 comment '票价',
constraint trainInfo_pk primary key(tNumber)
);

delete from trainInfo;
-- truncate table trainInfo;
# 插入数据
insert into trainInfo(tNumber,tFrom,tDest,tDistance,tstartTime,tEndTime,tDay,tSpeed,tUnitPrice)
values
('K12','石家庄','武汉',1233,'13:00:00','1:00',2,140,1.4),
('K181','长沙','北京',1850,'22:14:00','06:40:00',1,120,0.7)
;

/* 列车调度信息表trainScheduler */
create table if not exists trainScheduler(
sNumber varchar(16) not null comment '调度编号，外键，引用基本信息表主键',
sDate DateTime not null comment '发车时间',
sCondutor varchar(20) comment '值班列车长',
sSeatNumber int comment '可销售硬座数',
sLineNumber int comment '可销售硬卧数',
sVisaNumber int comment '可销售软卧数',
constraint trainScheduler_pk primary key(sNumber,sDate),

constraint trainInfo_Scheduler_fk foreign key(sNumber) references trainInfo(tNumber)
);
truncate table if exists trainScheduler;
insert into trainScheduler(sNumber,sDate,sCondutor,sSeatNumber,sLineNumber,sVisaNumber )
values
('K181','2013-05-06','张亮',0,0,0);

