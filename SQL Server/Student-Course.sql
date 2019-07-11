create table student2(
sid int PRIMARY KEY,
sname varchar(10)
);
insert into student2 values(100,'XYZ');
insert into student2 values(101,'ABC');
insert into student2 values(102,'LMN');
insert into student2 values(103,'PQR');

select * from student2;

create table course(
cid int PRIMARY KEY,
cname varchar(10)
);
insert into course values(1,'Java');
insert into course values(2,'C/C++');
insert into course values(3,'Python');
select * from course;

create table student_course_map(
id int PRIMARY KEY,
studentid int FOREIGN KEY references student2(sid),
courseid int FOREIGN KEY references course(cid)
);
insert into student_course_map values(11,100,1);
insert into student_course_map values(12,100,3);
insert into student_course_map values(13,102,1);
insert into student_course_map values(14,102,2);
select * from student_course_map
