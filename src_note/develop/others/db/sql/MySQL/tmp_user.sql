use `tmp`;
drop table if exists `tmp`.`tmp_user`;
create table `tmp_user`
(
`id` int(20) primary key auto_increment,
`uname` varchar(30) comment '�û���',
`upwd` varchar(50) comment '�û�����'
);
insert into `tmp_user`(`uname`,`upwd`) 
values
('root','root'),('admin','admin'),('tmp','tmp');
