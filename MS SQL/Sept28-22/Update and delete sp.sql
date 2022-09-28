CREATE PROCEDURE [dbo].[Updatebookdetails]

      @p_name1 varchar(20),

       @p_id1 int
AS

BEGIN

    

      UPDATE  book SET BookName = @p_name1

      WHERE BookID=@p_id1

END

CREATE PROCEDURE [dbo].[DeleteBook]
	@p_id int
	
AS
BEGIN
	Delete from Book
	where BookID=@p_id;
END