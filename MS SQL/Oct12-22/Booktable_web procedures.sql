create database Web;
use Web;
create table book(
book_id int,
book_name varchar(10),
book_author varchar(20)
);


CREATE PROCEDURE [dbo].sp_Deletestudent
	@p_id int
	
AS
	Delete from book
	where book_id=@p_id;
RETURN 0
--find student
Alter PROCEDURE [dbo].sp_Findstudent
	@p_stuid int,@p_stuclass varchar(20) output,
	  @p_name varchar(20) output

	

AS
	SELECT
	@p_name=book_name ,@p_stuclass=book_author
	from book	where book_id=@p_stuid;

RETURN 0


Alter PROCEDURE [dbo].[Updatestudent]

      @p_stuid int,
	  @p_stuname varchar(50),
	  @p_stuclass varchar(20)

AS

BEGIN

    

      UPDATE  book SET book_name = @p_stuname,
	  book_author=@p_stuclass
	

      WHERE book_id=@p_stuid

END

