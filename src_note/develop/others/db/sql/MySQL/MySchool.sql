/* MySchool数据库 */
create database if not exists MySchool;
use MySchool;

/* 年级表grade,被课程表subject,学生信息表student引用 */
create table if not exists grade
(
gradeId int not null auto_increment comment '年级编号',
gradeName varchar(50) comment '年级名称',
constraint grade_pk primary key(gradeId)
);

insert into grade(gradeName)
values ('S1'),('S2'),('Y2');

/* 学生信息表student，引用年级表grade,被成绩表results引用 */
create table if not exists student
(
stuId int auto_increment not null,
stuNo varchar(50) not null comment '学号',
loginPwd varchar(20) default '123456' comment '登录密码',
stuName varchar(25) not null comment '学生姓名',
sex varchar(2) not null comment '性别',
gradeId int not null comment '年级编号，外键，引用年级表',
phone varchar(255) comment '手机',
address varchar(255) default '学生宿舍',
bornDate DateTime comment '出生日期',
email varchar(255) comment '电子邮件地址',
constraint student_pk primary key(stuId,stuNo),

constraint student_grade_fk foreign key(gradeId) references grade(gradeId)
);

insert into student(stuNo,loginPwd,stuName,sex,gradeId,phone,address,bornDate,email)
values('17114062547','512xie36','许XX','男',3,'18215564716','武兴花园9栋2单元604','1995-06-20','k_y_z_s@yeah.net');


/* 课程表subject，引用年级表grade,被成绩表results引用 */
create table if not exists subject
(
subId int not null auto_increment comment '课程编号',
subName varchar(20) comment '课程表',
classHour int comment '学时',
gradeId int not null comment '年级编号，外键',
constraint subject_pk primary key(subId),

constraint grade_subject_fk foreign key(gradeId) references grade(gradeId)
);

insert into subject(subName,classHour,gradeId)
values('使用Java理解程序逻辑',3,1),('C#语言和数据库技术基础',3,1),('使用HTML&CSS开发商业站点',2,1),('使用C#开发数据库应用系统',2,1),
('优化MySchool数据库设计',2,2),('JavaScript&jQuery',3,2),('.NET',3,2);


/* 成绩表results */
create table if not exists results
(
resId int not null auto_increment comment '成绩编号，自增列',
stuId int not null comment  '学生Id，外键，引用学生信息表主键',
subId int not null comment '课程编号，外键，引用课程表主键',
stuResult int comment '学生成绩',
examDate Date comment '考试时间',
constraint results_pk primary key(resId),

constraint stu_results_fk foreign key(stuId) references student(stuId),

constraint subject_results_fk foreign key(subId) references subject(subId)
);

insert into results(stuId,subId,stuResult,examDate)
values(1,1,70,'2015-06-12');

