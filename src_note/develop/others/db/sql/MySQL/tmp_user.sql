use `tmp`;
drop table if exists `tmp`.`tmp_user`;
create table `tmp_user`
(
`id` int(20) primary key auto_increment,
`uname` varchar(30) comment '用户名',
`upwd` varchar(50) comment '用户密码'
);
insert into `tmp_user`(`uname`,`upwd`) 
values
('root','root'),('admin','admin'),('tmp','tmp');
