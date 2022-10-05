create database login;
use login;
drop table login_table;
create table login_table(userid varchar(50),
password varchar(50));


create proc [dbo].[sp_login]
(
@userid varchar(50), @password varchar(50)
)
as
begin
Select * from login_table where userid=@userid and password=@password
end;
GO
drop table Book;
create table Book(Bookid int ,Bookname varchar(50),cost int)
insert into Book values(1,'Harry potter',500)
drop table Issue;
create table Issue(Issueid int ,userid varchar(50),Bookid int,Issue_date varchar(50),Return_date varchar(50))
