connect System
create tablespace Project
datafile 'G:\Temp\Data\Oracle\Project.dat' size 30M autoextend off;

create user tmp identified by tmp
default tablespace Project;

grant connect,resource to tmp;

connect tmp/tmp
/* 用户信息表 vote_user */
create table vote_user
(
vu_user_id nvarchar2(100) not null primary key,vu_user_name nvarchar2(50) not null,
vu_password nvarchar2(50) not null
)
tablespace Project;

insert into vote_user(vu_user_id,vu_user_name,vu_password) values('vo_001','admin','admin_root');

/* 投票内容表 vote_subject */
create table vote_subject
(
vs_id number(4) not null primary key,vs_title nvarchar2(200) not null,
vs_type number(2) default 1 not null
)
tablespace Project;
create sequence seq_vs_id 
start with 1 increment by 1 maxvalue 200 nocycle nocache;

insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'你心里最好的下载工具',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'你心里做好的输入法',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'你心里最好的网络聊天工具',1);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'你最赞的修图工具',1);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'你心中最好的杀毒软件工具',1);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'你心里最好的阅读工具',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'你心里最好的社交软件',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'你心里最好的浏览器',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'你心里最好的文本编辑器',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'你心里最好的操作系统',1);

/* 投票选项表 vote_option */
create table vote_option
(
vo_id number(4) not null primary key,vo_option nvarchar2(100) not null,
vs_id number(4) not null,vo_order number(4)
)
tablespace Project;
create sequence seq_vo_id 
start with 1 increment by 1 maxvalue 200 nocycle nocache;

alter table vote_option add constraint FK_vs_vo_id foreign key(vs_id) references vote_subject(vs_id);

insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'迅雷',2);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'搜狗输入法',3);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'ICQ',4);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'PS',5）;
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'360',6);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'91Reader',7);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'未知',8);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'FireFox',9);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'VIM',10);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'Fedora',11);

/* 投票取值表vote_item */
create table vote_item 
(
vi_id number(4) not null primary key,vo_id number(4) not null,
vs_id number(4) not null,vu_user_id nvarchar2(100) not null
)
tablespace Project;
create sequence seq_vi_id 
start with 1 increment by 1 maxvalue 200 nocycle nocache;

alter table vote_item 
add constraint FK_vo_vi_id foreign key(vo_id) references vote_option(vo_id);

alter table vote_item 
add constraint FK_vs_vi_id foreign key(vs_id) references vote_subject(vs_id);

alter table vote_item
add constraint FK_vu_vi_id foreign key(vu_user_id) references vote_user(vu_user_id);

--insert into vote_item(vi_id,vo_id,vs_id,vu_user_id) values(1,1,1,'vo_001');
insert into vote_item(vi_id,vo_id,vs_id,vu_user_id) values(seq_vi_id.nextval,2,2,'vo_001');
insert into vote_item(vi_id,vo_id,vs_id,vu_user_id) values(seq_vi_id.nextval,3,3,'vo_001');
insert into vote_item(vi_id,vo_id,vs_id,vu_user_id) values(seq_vi_id.nextval,4,4,'vo_001');
insert into vote_item(vi_id,vo_id,vs_id,vu_user_id) values(seq_vi_id.nextval,5,5,'vo_001');
insert into vote_item(vi_id,vo_id,vs_id,vu_user_id) values(seq_vi_id.nextval,6,6,'vo_001');
insert into vote_item(vi_id,vo_id,vs_id,vu_user_id) values(seq_vi_id.nextval,7,7,'vo_001');
insert into vote_item(vi_id,vo_id,vs_id,vu_user_id) values(seq_vi_id.nextval,8,8,'vo_001');
insert into vote_item(vi_id,vo_id,vs_id,vu_user_id) values(seq_vi_id.nextval,9,9,'vo_001');
insert into vote_item(vi_id,vo_id,vs_id,vu_user_id) values(seq_vi_id.nextval,10,10,'vo_001');

connect System
create tablespace Project
datafile 'G:\Temp\Data\Oracle\Project.dat' size 30M autoextend off;

create user tmp identified by tmp
default tablespace Project;

grant connect,resource to tmp;

connect tmp/tmp
/* 鐢ㄦ埛淇℃伅琛� vote_user */
create table vote_user
(
vu_user_id nvarchar2(100) not null primary key,vu_user_name nvarchar2(50) not null,
vu_password nvarchar2(50) not null
)
tablespace Project;

insert into vote_user(vu_user_id,vu_user_name,vu_password) values('vo_001','admin','admin_root');

/* 鎶曠エ鍐呭琛� vote_subject */
create table vote_subject
(
vs_id number(4) not null primary key,vs_title nvarchar2(200) not null,
vs_type number(2) default 1 not null
)
tablespace Project;
create sequence seq_vs_id 
start with 1 increment by 1 maxvalue 200 nocycle nocache;

insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'浣犲績閲屾渶濂界殑涓嬭浇宸ュ叿',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'浣犲績閲屽仛濂界殑杈撳叆娉�',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'浣犲績閲屾渶濂界殑缃戠粶鑱婂ぉ宸ュ叿',1);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'浣犳渶璧炵殑淇浘宸ュ叿',1);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'浣犲績涓渶濂界殑鏉�姣掕蒋浠跺伐鍏�',1);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'浣犲績閲屾渶濂界殑闃呰宸ュ叿',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'浣犲績閲屾渶濂界殑绀句氦杞欢',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'浣犲績閲屾渶濂界殑娴忚鍣�',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'浣犲績閲屾渶濂界殑鏂囨湰缂栬緫鍣�',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'浣犲績閲屾渶濂界殑鎿嶄綔绯荤粺',1);

/* 鎶曠エ閫夐」琛� vote_option */
create table vote_option
(
vo_id number(4) not null primary key,vo_option nvarchar2(100) not null,
vs_id number(4) not null,vo_order number(4)
)
tablespace Project;
create sequence seq_vo_id 
start with 1 increment by 1 maxvalue 200 nocycle nocache;

alter table vote_option add constraint FK_vs_vo_id foreign key(vs_id) references vote_subject(vs_id);

insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'杩呴浄',2);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'鎼滅嫍杈撳叆娉�',3);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'ICQ',4);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'PS',5锛�;
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'360',6);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'91Reader',7);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'鏈煡',8);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'FireFox',9);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'VIM',10);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'Fedora',11);

/* 鎶曠エ鍙栧�艰〃vote_item */
create table vote_item 
(
vi_id number(4) not null primary key,vo_id number(4) not null,
vs_id number(4) not null,vu_user_id nvarchar2(100) not null
)
tablespace Project;
create sequence seq_vi_id 
start with 1 increment by 1 maxvalue 200 nocycle nocache;

alter table vote_item 
add constraint FK_vo_vi_id foreign key(vo_id) references vote_option(vo_id);

alter table vote_item 
add constraint FK_vs_vi_id foreign key(vs_id) references vote_subject(vs_id);

alter table vote_item
add constraint FK_vu_vi_id foreign key(vu_user_id) references vote_user(vu_user_id);

--insert into vote_item(vi_id,vo_id,vs_id,vu_user_id) values(1,1,1,'vo_001');
insert into vote_item(vi_id,vo_id,vs_id,vu_user_id) values(seq_vi_id.nextval,2,2,'vo_001');
insert into vote_item(vi_id,vo_id,vs_id,vu_user_id) values(seq_vi_id.nextval,3,3,'vo_001');
insert into vote_item(vi_id,vo_id,vs_id,vu_user_id) values(seq_vi_id.nextval,4,4,'vo_001');
insert into vote_item(vi_id,vo_id,vs_id,vu_user_id) values(seq_vi_id.nextval,5,5,'vo_001');
insert into vote_item(vi_id,vo_id,vs_id,vu_user_id) values(seq_vi_id.nextval,6,6,'vo_001');
insert into vote_item(vi_id,vo_id,vs_id,vu_user_id) values(seq_vi_id.nextval,7,7,'vo_001');
insert into vote_item(vi_id,vo_id,vs_id,vu_user_id) values(seq_vi_id.nextval,8,8,'vo_001');
insert into vote_item(vi_id,vo_id,vs_id,vu_user_id) values(seq_vi_id.nextval,9,9,'vo_001');
insert into vote_item(vi_id,vo_id,vs_id,vu_user_id) values(seq_vi_id.nextval,10,10,'vo_001');

connect System
create tablespace Project
datafile 'G:\Temp\Data\Oracle\Project.dat' size 30M autoextend off;

create user tmp identified by tmp
default tablespace Project;

grant connect,resource to tmp;

connect tmp/tmp
/* 閻€劍鍩涙穱鈩冧紖鐞�