create database HCL;
USE HCL;

create table student
(sid int,
sname varchar(20),
city varchar(20));

insert into student values(1,'Rahul','Aurangabad');
insert into student values(2,'Suraj','Mumbai');
select sid, sname from student;
select* from student;



create table book(bname varchar(20), author varchar(20), pages int);
insert into book values('5.Someone','Chetan Bhagat',270) 
insert into book values('The Alchemist','Paulo Coelho',163) 
select* from book;

create table actor(name varchar(20), movie varchar(25), genre varchar(20));
insert into actor values('Varun Dhawan','Jug Jug Jiyo','Comedy');
insert into actor values('Kartik Aryan','Bhool Bhulaiyya 2','Horror Comedy');
insert into actor values('Akshay Kumar','Samrat Prithviraj','Historic');
select* from actor;