create database library
go

use library
go
create table Member
(
Member_Id	NUMERIC(5) primary key	,
Member_Name	Char(25),	 
Acc_Open_Date	Date	,
Max_Books_Allowed	NUMERIC(2),
Penalty_Amount	NUMERIC(7,2)
)
GO
create table Book(
Book_No	NUMERIC(6)	,
Book_Name		VarChar(30),	
Author	Char(30),	
Cost	NUMERIC(7,2),
Category	Char(10))


go
create table Issue(Lib_Issue_Id	NUMERIC(10) primary key	,
Book_No	NUMERIC(6)	,
Member_Id	NUMERIC(5)	,
Issue_Date	Date	,
Return_date	Date)
go
drop table Issue

go
create table Issue(Lib_Issue_Id	NUMERIC(10) primary key	,
Book_No	NUMERIC(6)	,
Member_Id	NUMERIC(5)	,
Issue_Date	Date	,
Return_date	Date)

GO
alter table Issue
add foreign key(Book_No) references Book(Book_No)
go
drop table Book

GO
create table Book(
Book_No	NUMERIC(6) primary key	,
Book_Name		VarChar(30),	
Author	Char(30),	
Cost	NUMERIC(7,2),
Category	Char(10))

GO
alter table Issue
add foreign key(Book_No) references Book(Book_No)

