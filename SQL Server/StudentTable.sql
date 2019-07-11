create table student(
  roll_no int NOT NULL PRIMARY KEY,
  firstname varchar(20),
  lastname varchar(20),
  cgpa float
)
select * from student
insert into student values(121,'ABC','XYZ',9.5);
insert into student values(122,'KMN','XYZ',8.5);
insert into student values(123,'LMN','XYZ',7.5);

select * from student
update student set lastname='PQR' where roll_no=123;
select * from student

select * from student where cgpa>8.0;

create table department(
dno int PRIMARY KEY NOT NULL,
 dname varchar(20),
location varchar(20)
);

insert into department values(10,'Sales','Mumbai');
insert into department values(20,'Marketing','Pune');
select * from department;

create table employee(
eno int PRIMARY KEY,
ename varchar(20),
salary int,
deptno int FOREIGN KEY references department(dno)
);

insert into employee values(101,'ABC',10000,10);
insert into employee values(102,'XYZ',10000,20);
insert into employee values(103,'LMN',20000,10);

select * from employee

