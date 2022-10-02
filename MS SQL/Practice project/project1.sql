create database School;
use School;
go
sp_help
go
create table student(student_id int primary key,student_name varchar(25),student_class int check(student_class<=12))
create table subjects(subjects_id int primary key,subjects_name varchar(25))
create table class(class_roomno int primary key,class_strength int)
go
create index student_index on student(student_id,student_name,student_class)
create index subjects_index on subjects(subjects_id,subjects_name)
create index class_index on class(class_roomno,class_strength)

go
EXEC sp_help 'dbo.student';  
EXEC sp_help 'dbo.subjects';  
EXEC sp_help 'dbo.class';  
go
insert into student values(1,'Sri',12)
insert into student values(2,'sai',1)
insert into student values(3,'Raj',1)
insert into student values(4,'Ram',10)
insert into student values(5,'krish',10)

insert into subjects values(111,'computer science')
insert into subjects values(112,'english')
insert into subjects values(113,'Physics')
insert into subjects values(114,'science')
insert into subjects values(115,'Networking')

insert into class values(1,35)
insert into class values(2,20)
insert into class values(3,34)
insert into class values(4,54)
insert into class values(5,50)

select* from student
select* from subjects
select* from class

