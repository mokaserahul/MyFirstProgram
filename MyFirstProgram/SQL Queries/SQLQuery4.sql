create table trainer
(tid int primary key,
tname varchar(30),
experience int);

create table batch
(bid int primary key,
bname varchar(30),
tid int
foreign key(tid) references trainer(tid)
on delete set null on update cascade);

create table student
(sid int primary key,
sname varchar(30),
batchid int,
foreign key(batchid) references batch(bid)
on delete set null on update cascade);
insert into trainer values(103,'Jayshree mam',8);
insert into trainer values(101,'Deepa mam',9);
insert into trainer values(102,'Kalyani mam',9);
select* from trainer;

insert into batch values(3,'Wipro',102);
insert into batch values(2,'Wishtree',103);
insert into batch values(1,'HCL',101);
select* from batch;

insert into student values(204,'Avinash',2);
insert into student values(201,'Rahul',1);
insert into student values(202,'Suraj',1);
insert into student values(203,'Vishal',1);
select* from student;
