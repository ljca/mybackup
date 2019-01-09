connect System
create tablespace Project
datafile 'G:\Temp\Data\Oracle\Project.dat' size 30M autoextend off;

create user tmp identified by tmp
default tablespace Project;

grant connect,resource to tmp;

connect tmp/tmp
/* ÓÃ»§ĞÅÏ¢±í vote_user */
create table vote_user
(
vu_user_id nvarchar2(100) not null primary key,vu_user_name nvarchar2(50) not null,
vu_password nvarchar2(50) not null
)
tablespace Project;

insert into vote_user(vu_user_id,vu_user_name,vu_password) values('vo_001','admin','admin_root');

/* Í¶Æ±ÄÚÈİ±í vote_subject */
create table vote_subject
(
vs_id number(4) not null primary key,vs_title nvarchar2(200) not null,
vs_type number(2) default 1 not null
)
tablespace Project;
create sequence seq_vs_id 
start with 1 increment by 1 maxvalue 200 nocycle nocache;

insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'ÄãĞÄÀï×îºÃµÄÏÂÔØ¹¤¾ß',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'ÄãĞÄÀï×öºÃµÄÊäÈë·¨',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'ÄãĞÄÀï×îºÃµÄÍøÂçÁÄÌì¹¤¾ß',1);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'Äã×îÔŞµÄĞŞÍ¼¹¤¾ß',1);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'ÄãĞÄÖĞ×îºÃµÄÉ±¶¾Èí¼ş¹¤¾ß',1);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'ÄãĞÄÀï×îºÃµÄÔÄ¶Á¹¤¾ß',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'ÄãĞÄÀï×îºÃµÄÉç½»Èí¼ş',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'ÄãĞÄÀï×îºÃµÄä¯ÀÀÆ÷',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'ÄãĞÄÀï×îºÃµÄÎÄ±¾±à¼­Æ÷',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'ÄãĞÄÀï×îºÃµÄ²Ù×÷ÏµÍ³',1);

/* Í¶Æ±Ñ¡Ïî±í vote_option */
create table vote_option
(
vo_id number(4) not null primary key,vo_option nvarchar2(100) not null,
vs_id number(4) not null,vo_order number(4)
)
tablespace Project;
create sequence seq_vo_id 
start with 1 increment by 1 maxvalue 200 nocycle nocache;

alter table vote_option add constraint FK_vs_vo_id foreign key(vs_id) references vote_subject(vs_id);

insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'Ñ¸À×',2);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'ËÑ¹·ÊäÈë·¨',3);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'ICQ',4);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'PS',5£©;
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'360',6);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'91Reader',7);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'Î´Öª',8);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'FireFox',9);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'VIM',10);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'Fedora',11);

/* Í¶Æ±È¡Öµ±ívote_item */
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
/* ç”¨æˆ·ä¿¡æ¯è¡¨ vote_user */
create table vote_user
(
vu_user_id nvarchar2(100) not null primary key,vu_user_name nvarchar2(50) not null,
vu_password nvarchar2(50) not null
)
tablespace Project;

insert into vote_user(vu_user_id,vu_user_name,vu_password) values('vo_001','admin','admin_root');

/* æŠ•ç¥¨å†…å®¹è¡¨ vote_subject */
create table vote_subject
(
vs_id number(4) not null primary key,vs_title nvarchar2(200) not null,
vs_type number(2) default 1 not null
)
tablespace Project;
create sequence seq_vs_id 
start with 1 increment by 1 maxvalue 200 nocycle nocache;

insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'ä½ å¿ƒé‡Œæœ€å¥½çš„ä¸‹è½½å·¥å…·',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'ä½ å¿ƒé‡Œåšå¥½çš„è¾“å…¥æ³•',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'ä½ å¿ƒé‡Œæœ€å¥½çš„ç½‘ç»œèŠå¤©å·¥å…·',1);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'ä½ æœ€èµçš„ä¿®å›¾å·¥å…·',1);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'ä½ å¿ƒä¸­æœ€å¥½çš„æ€æ¯’è½¯ä»¶å·¥å…·',1);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'ä½ å¿ƒé‡Œæœ€å¥½çš„é˜…è¯»å·¥å…·',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'ä½ å¿ƒé‡Œæœ€å¥½çš„ç¤¾äº¤è½¯ä»¶',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'ä½ å¿ƒé‡Œæœ€å¥½çš„æµè§ˆå™¨',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'ä½ å¿ƒé‡Œæœ€å¥½çš„æ–‡æœ¬ç¼–è¾‘å™¨',2);
insert into vote_subject(vs_id,vs_title,vs_type) values(seq_vs_id.nextval,'ä½ å¿ƒé‡Œæœ€å¥½çš„æ“ä½œç³»ç»Ÿ',1);

/* æŠ•ç¥¨é€‰é¡¹è¡¨ vote_option */
create table vote_option
(
vo_id number(4) not null primary key,vo_option nvarchar2(100) not null,
vs_id number(4) not null,vo_order number(4)
)
tablespace Project;
create sequence seq_vo_id 
start with 1 increment by 1 maxvalue 200 nocycle nocache;

alter table vote_option add constraint FK_vs_vo_id foreign key(vs_id) references vote_subject(vs_id);

insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'è¿…é›·',2);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'æœç‹—è¾“å…¥æ³•',3);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'ICQ',4);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'PS',5ï¼‰;
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'360',6);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'91Reader',7);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'æœªçŸ¥',8);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'FireFox',9);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'VIM',10);
insert into vote_option(vo_id,vo_option,vs_id) values(seq_vo_id.nextval,'Fedora',11);

/* æŠ•ç¥¨å–å€¼è¡¨vote_item */
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
/* é¢ã„¦åŸ›æ·‡â„ƒä¼…ç›