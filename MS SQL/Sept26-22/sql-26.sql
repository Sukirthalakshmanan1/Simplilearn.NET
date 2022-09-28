select * from Book
select * from Member
create table users (userid varchar(10),password varchar(20));
select * from users
CREATE PROCEDURE [dbo].[UpdateEmployeeDetails]

      @p_name1 varchar(20),

       @p_id1 int
AS

BEGIN

    

      UPDATE  Member SET member_name = @p_name1

      WHERE member_id=@p_id1

END

CREATE FUNCTION [dbo].fn_Emplist
()
RETURNS TABLE AS RETURN
(
	SELECT * from Book
)