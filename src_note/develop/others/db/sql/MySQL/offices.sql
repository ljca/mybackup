create database if not exists company;
use company if exists company;

create table if not exists offices
(
officeCode int(10) constraint pk_offices primary key not null,
city int(11) not null,
address varchar(50),
country varchar(50) not null,
postalCode varchar(25),
--constraint pk_oCode primary key(officeCode),
constraint uq_pCode unique(postalCode)
);

create table if not exists employees
(
employeeNumber int(11) auto_increment not null,
lastName varchar(50),firstName varchar(50),
mobile varchar(25) not null,
officeCode int(10) not null,
jobTitle varchar(50) not null,
birth datetime not null,
note varchar(255),sex varchar(5),
constraint pk_number primary key(employeeNumber),
constraint uq_mobile unique(mobile),
constraint fk_o_emp foreign key(officeCode) references offices(officeCode)
);