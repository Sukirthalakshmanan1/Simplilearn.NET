create database customer
use customer
create table UserInfo(UserId int primary key,Email varchar(20),passwords varchar(20))
insert into UserInfo values(1,'suki123@gmail.com','abcd123')
select * from UserInfo

create table custinfo(logid int primary key,customer_email varchar(20),customer_name varchar(20),log_status varchar(20),descriptions varchar(20))
insert into custinfo values(1,'suki123@gmail.com','suki','done','laptop')
select *from custinfo