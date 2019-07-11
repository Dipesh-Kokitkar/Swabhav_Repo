create table collage(
cid int PRIMARY KEY,
cname varchar(20),
clocation varchar(20)
);

select * from collage

insert into collage values(1000,'VIT','Mumbai');

create table departments (
d_id int PRIMARY KEY,
dname varchar(20),
collageid int FOREIGN KEY references collage(cid)
);

insert into departments values(101,'CMPN',1000);
insert into departments values(102,'INFT',1000);
insert into departments values(103,'EXTC',1000);
select * from departments

create table professor(
pid int PRIMARY KEY,
pname varchar(20),
deptid int FOREIGN KEY references departments(d_id),
collageid int FOREIGN KEY references collage(cid)
);
insert into professor values(111,'Akash',101,1000);
insert into professor values(112,'Dhurv',102,1000);
insert into professor values(113,'Brijesh',101,1000);
select * from professor

create table students(
rollno int PRIMARY KEY,
sname varchar(20),
deptid int FOREIGN KEY references departments(d_id),
collageid int FOREIGN KEY references collage(cid)
);
insert into students values(1,'ABC',101,1000);
insert into students values(2,'XYZ',102,1000);
insert into students values(3,'LMN',101,1000);

select * from students

