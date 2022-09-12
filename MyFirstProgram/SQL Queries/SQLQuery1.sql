use HCL;
drop table student;

create table student
(sid int primary key,
name varchar(20) not null,
mobile bigint unique,
city varchar(20) default 'Pune');
insert into student values(101,'Rahul',9503440762,'Aurangabad');
select* from student;