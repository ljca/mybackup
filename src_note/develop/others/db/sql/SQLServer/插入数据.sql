use House
go

/* 区县信息表插入数据 */
insert into hos_district(DName)
select '海锭区' union
select '西城区' union
select '东城区' union
select '朝阳区'
go

/* 街道信息表插入信息 */
insert into hos_street(SName,SDID)
select '万泉庄',1 union
select '苏州街',2 union
select '东单',3 union
select '西四',4 union
select '东四',4 union
select '中关村',3
go

/* 房屋类型表插入数据 */
insert into hos_type(HTName)
select '两室一厅' union
select '两室一卫' union
select '一室一厅'
go

/* 客户信息表插入数据 */
insert into sys_user(UName,UPASSWORD)
select '张三','kskhsih' union
select '李四','kskhsih' union
select '王鑫','kskhsih' union
select '将依然','kskhsih' union
select '张冬雪','kskhsih' union
select '李剑','kskhsih'
go

/* 出租屋信息表插入数据 */
insert into hos_house([UID],[SID],HTID,PRICE,TOPIC,HTIME,CONTENTS)
select 1,1,1,1000,'中关村','1995-2-4','中关村一条街' union
select 2,2,2,2000,'东单','1995-2-4','东单很多美食' union
select 3,3,3,3000,'东单','1995-2-4','东单很多美食' union
select 4,4,3,4000,'万全庄附近','1995-2-4','万全庄附近一条街' 
go
