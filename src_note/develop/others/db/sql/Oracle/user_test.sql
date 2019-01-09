create table tmp
(
id number not null primary key,name varchar2(10) not null,
"score" number not null
);

insert into tmp(id,name,"score") values(1,'张三',80);
insert into tmp(id,name,"score") values(2,'李四',70);
insert into tmp(id,name,"score") values(3,'王五',50);
insert into tmp(id,name,"score") values(4,'张三B',60);
insert into tmp(id,name,"score") values(5,'李四B',70);
insert into tmp(id,name,"score") values(6,'王五B',80);
insert into tmp(id,name,"score") values(7,'路人甲',90);
commit;
select * from tmp;
