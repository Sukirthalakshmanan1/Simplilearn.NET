Create Database InstituteManagementSystem
go

CREATE TABLE course
   (COURSEID int primary key, 
	COURSENAME VARCHAR(20), 
	DEPTID VARCHAR(4), 
	DURATION int
   )
Create table student
(
stuid int primary key,
name varchar(40),
crsid int foreign key references course(courseid)
)


create table Exam
(examid int primary key,
crsid int foreign key references course(courseid),
studid int foreign key references student(stuid),
marks int
)