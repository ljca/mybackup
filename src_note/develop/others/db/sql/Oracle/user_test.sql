create table tmp
(
id number not null primary key,name varchar2(10) not null,
"score" number not null
);

insert into tmp(id,name,"score") values(1,'����',80);
insert into tmp(id,name,"score") values(2,'����',70);
insert into tmp(id,name,"score") values(3,'����',50);
insert into tmp(id,name,"score") values(4,'����B',60);
insert into tmp(id,name,"score") values(5,'����B',70);
insert into tmp(id,name,"score") values(6,'����B',80);
insert into tmp(id,name,"score") values(7,'·�˼�',90);
commit;
select * from tmp;
