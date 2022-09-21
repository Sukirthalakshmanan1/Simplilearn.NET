--1
create database Library_System

go
use Library_System
go
sp_help

go
create table Member
(
Member_Id	NUMERIC(5) 	,
Member_Name	Char(25),	 
Acc_Open_Date	Date	,
Max_Books_Allowed	NUMERIC(2),
Penalty_Amount	NUMERIC(7,2)
)

GO
create table Book(
Book_No	NUMERIC(6) 	,
Book_Name		VarChar(30),	
Author	Char(30),	
Cost	NUMERIC(7,2),
Category	Char(10))

go
create table Issue(Lib_Issue_Id	NUMERIC(10) ,
Book_No	NUMERIC(6)	,
Member_Id	NUMERIC(5)	,
Issue_Date	Date	,
Return_date	Date)
--2
go
EXEC sp_help 'dbo.Member';  
EXEC sp_help 'dbo.BOOK';  
EXEC sp_help 'dbo.Issue';  
--3
go
ALTER TABLE Issue Add Comments char(100)
--4
go
ALTER TABLE Member
  ALTER COLUMN Member_Name CHAR(30) 
--5
go
ALTER TABLE Issue Add Reference char(30)
--6
go
ALTER TABLE Issue DROP COLUMN Reference
--7
go
sp_rename Issue , Lib_Issue

--8
go
insert into Member values (1,'Richa Sharma','10-Dec-05',5	,50)
--select SYSDATETIME()
insert into Member values (2,'Garima Sen',(cast(GetDate() as Date))	,3,	Null)
insert into Member values (3,'sam','10-Jan-2020'	,3,	45)
insert into Member values (4,'Ram','12-oct-2015'	,Null,	Null)
insert into Member values (5,'Raj','21-july-2012'	,13,	70)
insert into Member values (6,'Guhan',SYSDATETIME()	,30,	170)

go
select * from Member
go
DELETE FROM Member WHERE Member_Id=3
--9
go
ALTER TABLE Member
  ALTER COLUMN Member_Name CHAR(20) 
 --10
go
insert into Member values (7,'Gowri',SYSDATETIME()	,110,	170)
--Msg 8115, Level 16, State 8, Line 62 Arithmetic overflow error converting int to data type numeric. The statement has been terminated.
--11
go
create table Member101
(
Member_Id	NUMERIC(5) 	,
Member_Name	Char(25),	 
Acc_Open_Date	Date	,
Max_Books_Allowed	NUMERIC(2),
Penalty_Amount	NUMERIC(7,2)
)
--12
go

insert into Book values (101,'Let us C'	,'Denis Ritchie',450,'System')
insert into Book values (102	,'Oracle – Complete Ref'	,'Loni'	,550	,'Database')
insert into Book values (103	,'Mastering SQL'	,'Loni',	250	,'Database') 
insert into Book values (104,	'PL SQL-Ref',	'Scott Urman'	,750	,'Database')
go
select * from Book

go
select * from Member101
go
--14
create table Book101(
Book_No	NUMERIC(6) 	,
Book_Name		VarChar(30),	
Author	Char(30),	
Cost	NUMERIC(7,2),
Category	Char(10))
--15
go
INSERT INTO Book101 SELECT * FROM Book
--16
--17
go
select * from Book101
--18
insert into Book values (105,  'National Geographic', 'Adis Scott', 1000,  'Science')
select * from Book
--19
--20
go
UPDATE Book SET Cost=300, Category='RDBMS' where Book_No=103
--21
go
sp_rename 'Lib_Issue' , 'Issue'

--drop table Issue
--22
insert into Issue values (7001	,101	,1	,'10-Dec-06',NULL,'This is Issue table')
insert into Issue values (7002	,102	,2	,'25-Dec-06',NULL,'This is Issue table')
insert into Issue values (7003	,104	,1	,'15-Jan-06',NULL,'This is Issue table'	)
insert into Issue values (7004	,101	,1	,'04-07-06'	,NULL,'This is Issue table')
insert into Issue values (7005	,104	,2	,'15-06-06',NULL,'This is Issue table'	)
insert into Issue values (7006	,101	,3	,'18-Feb-06'	,NULL,'This is Issue table')
select* from Issue
go
DELETE FROM Issue WHERE Lib_Issue_Id=7003
--23
insert into Issue values (7007	,104	,2	,'15-Nov-06','15-oct-2022','This is Issue table'	)
insert into Issue values (7010	,101	,3	,'18-Feb-06'	,NULL,'This is Issue table')
---24
Update Issue
set Return_Date= DATEADD(Day,15,Issue_Date)
where Lib_Issue_Id IN(7004,7005)
select * from Issue


---25
go
UPDATE MEMBER SET PENALTY_AMOUNT=100 WHERE MEMBER_NAME='GARIMA Sen';
select * from Member
--26
go
DELETE FROM ISSUE WHERE MEMBER_ID=1 AND ISSUE_DATE<'10-DEC-06';
--27
go
DELETE FROM BOOK WHERE CATEGORY!='RDBMS' AND CATEGORY!='DATABASE';
--28
go
drop table Member101
--29
drop table Book101
--30,31
SELECT * FROM INFORMATION_SCHEMA.TABLES;
GO
select * from Member 
------set 2---------
--1
select * from Member where Year(Acc_Open_Date) = 2006
--2
SELECT * FROM BOOK WHERE AUTHOR='LONI' AND COST < 600
--3
go
SELECT * FROM ISSUE WHERE RETURN_DATE IS NULL 
--4
go
UPDATE ISSUE SET RETURN_DATE='31-DEC-06'
WHERE RETURN_DATE=NULL AND (LIB_ISSUE_ID!=7005 OR LIB_ISSUE_ID!=7006)

select * from Issue
--5
go
select* from Issue where Datediff( Day,Issue_Date,Return_Date) >30


--6
go
select * FROM book WHERE cost BETWEEN 500 AND 750
go
select * from Book
--7
go
SELECT * FROM BOOK WHERE category in ('Science', 'Database','Fiction','Management');
--8
go
SELECT * FROM Member ORDER BY penalty_amount DESC;
--9
go
select * from book order by category asc,cost desc
--10
go
select * from book where book_name like'%SQL%'
--11
go
SELECT * FROM MEMBER where MEMBER_NAME like'R%'OR 
MEMBER_NAME LIKE'G%' AND MEMBER_NAME LIKE '%I%'

--12
--13
SELECT BOOK_NO, CONCAT('IS WRRITTEN ', 'BY') " ---------------- ", AUTHOR AS NAME
FROM BOOK
--14
--17

--18
SELECT LIB_ISSUE_ID,ISSUE_DATE,RETURN_DATE,DateDiff(Day,ISSUE_DATE,RETURN_DATE) as "NO OF DAYS" FROM ISSUE;
--19
select * from Member Order by Acc_Open_Date;
--20
SELECT COUNT(BOOK_NO) as count_books FROM ISSUE WHERE MEMBER_ID=101;
--21
SELECT SUM(PENALTY_AMOUNT)as sum FROM MEMBER;
--22
SELECT SUM(COST) as cost FROM BOOK WHERE CATEGORY='DATABASE';
--23
select min(cost)from book
--24
go
SELECT MIN(ISSUE_DATE)as 'firstbook_issued' FROM ISSUE;

select * from issue order by issue_date 

--25
SELECT MAX(ISSUE_DATE) FROM ISSUE
--26
select avg(Cost)as average from Book where Category='Database'
select * from book
---set 3----
---1)	List the various categories and count of books in each category.
select Category ,count(Book_No) as Bookcount from Book group by Category

--2)	List the book_No and the number of times the book is issued in the descending order of count.
SELECT B.BOOK_NO,COUNT(I.BOOK_NO) as 'No of times book issued' FROM BOOK B,ISSUE I WHERE (B.BOOK_NO=I.BOOK_NO) GROUP BY B.BOOK_NO;

--3)	Find the maximum, minimum, total and average penalty amount in the member table.
SELECT MAX(PENALTY_AMOUNT) as 'Max penalty',MIN(PENALTY_AMOUNT) as 'min penalty',SUM(PENALTY_AMOUNT) as 'Total penalty', AVG(PENALTY_AMOUNT) as'Avg penalty' FROM MEMBER;

--4)	Display the member id and the no of books for each member that has issued more then 2 books.
SELECT M.MEMBER_ID,COUNT(I.MEMBER_ID) FROM MEMBER M,ISSUE I WHERE (M.MEMBER_ID=I.MEMBER_ID) GROUP BY M.MEMBER_ID;

--5)	Display the member id, book no and no of times the same book is issued by the member in the descending order of count.
SELECT I.MEMBER_ID,B.BOOK_NO,COUNT(I.BOOK_NO) as count FROM ISSUE I,BOOK B WHERE I.BOOK_NO IN(B.BOOK_NO) GROUP BY I.MEMBER_ID,B.BOOK_NO

--6)	Display the month and no of books issued each month in the descending order of count.
SELECT format(ISSUE_DATE,'MONTH'),COUNT(BOOK_NO) FROM ISSUE GROUP BY format(ISSUE_DATE,'MONTH')ORDER BY 2 DESC

--7)	List the book_no of all the books that are not issued to any  member so far. 
SELECT BOOK_NO FROM BOOK WHERE BOOK_NO NOT IN(SELECT BOOK_NO FROM ISSUE);
select * from Member

--8)	List all the member id that exist in member table and has also at least one book issued by them. 
SELECT MEMBER_ID FROM MEMBER WHERE MEMBER_ID IN(SELECT MEMBER_ID FROM ISSUE)

--9)	List the member ID with highest and lowest no of books issued. 
select member_id from Member 

--10)	List all the Issue_details for books issued in December and July without using any arithmetic, Logical or comparison operator.
SELECT * FROM ISSUE WHERE format(ISSUE_DATE,'MM') IN('12','07');

--11)	 List the Book_No, Book_Name and Issue_date for all the books that are issued in month of December and belong to category Database.
SELECT B.BOOK_NO,B.BOOK_NAME,I.ISSUE_DATE FROM BOOK B,ISSUE I WHERE format(ISSUE_DATE,'MM') IN('12') AND B.BOOK_NO=I.BOOK_NO AND CATEGORY='DATABASE';

--12)	 List the Member Id, Member Name and No of books Issued in the descending order of the count.
SELECT I.MEMBER_ID,M.MEMBER_NAME,COUNT(I.BOOK_NO)FROM MEMBER M,ISSUE I WHERE I.MEMBER_ID=M.MEMBER_ID GROUP BY I.MEMBER_ID,M.MEMBER_NAME ORDER BY 3 DESC;

--13)	List the Book No, Book Name, Issue_date and Return_Date for all the books issued by Richa Sharma.
SELECT B.BOOK_NO,B.BOOK_NAME,I.ISSUE_DATE,I.RETURN_DATE FROM Book B,Member M,Issue I WHERE (M.MEMBER_NAME='Richa Sharma' AND I.BOOK_NO=B.BOOK_NO AND I.MEMBER_ID=M.MEMBER_ID)

--14)	List the details of all the members that have issued books in Database category.
SELECT M.MEMBER_ID,M.MEMBER_NAME,B.CATEGORY FROM MEMBER M,BOOK B,ISSUE I WHERE B.CATEGORY='DATABASE' AND M.MEMBER_ID=I.MEMBER_ID AND B.BOOK_NO=I.BOOK_NO

--15)	List all the books that have highest price in their own category.
SELECT CATEGORY, MAX(COST) FROM BOOK GROUP BY CATEGORY

--16)	List all the Issue_Details where Issue_date is not within the Acc_open_date and Return_date for that member.
SELECT M.ACC_OPEN_DATE,I.BOOK_NO,I.MEMBER_ID,I.ISSUE_DATE,I.RETURN_DATE FROM MEMBER M,ISSUE I WHERE (I.ISSUE_DATE NOT BETWEEN M.ACC_OPEN_DATE AND I.RETURN_DATE) AND I.MEMBER_ID=M.MEMBER_ID

--17)	List all the members that have not issued a single book so far.
SELECT DISTINCT M.MEMBER_ID,M.MEMBER_NAME FROM MEMBER M,ISSUE WHERE M.MEMBER_ID NOT IN(SELECT MEMBER_ID FROM Issue)

--18)	List all the Members where No of books Issued exceeds the Max No of books allowed.
SELECT MEMBER_ID,MEMBER_NAME FROM MEMBER
WHERE(SELECT COUNT(I.BOOK_NO) FROM ISSUE I,BOOK B,MEMBER M
WHERE I.BOOK_NO=B.BOOK_NO AND I.MEMBER_ID=M.MEMBER_ID)>Max_Books_Allowed
GROUP BY MEMBER_ID,MEMBER_NAME

--19)	List all the members that have issued the same book as issued by Garima.
select * from member where Member_Name='Garima'
--20)	List the Book_Name, Price of all the books that are not returned for more then 30 days.
select I.Member_Id,B.Book_Name,Cost,I.Issue_Date,I.Return_date from Issue I,Book B where B.Book_No=I.Book_No and Datediff( Day,Issue_Date,Return_Date) >30

--21)	List all the authors and book_name that has more then 1 book written by them.
--22)	List the Member ID, Member Name of the people that have issued the highest and the lowest no of books.
--23)	List the details of highest 3 priced books.
--24)	List the total cost of all the books that are currently issued but not returned.
--25)	List the details of the book that has been issued maximum no of times
