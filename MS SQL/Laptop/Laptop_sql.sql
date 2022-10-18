create database Ecommerce;
create table laptop(
laptop_id int,
laptop_name varchar(30),
cost int,
Descr varchar(100)
)
insert into laptop values(1,'Lenova',35000,'8 GB RAM-i3 processor')

CREATE PROCEDURE [dbo].[Update]

      @p_id int,
	  @p_name varchar(20),
	  @p_cost int,
	  @p_des varchar(100)

AS

BEGIN

    

      UPDATE  laptop SET laptop_name = @p_name,cost=@p_cost,Descr=@p_des
	

      WHERE laptop_id=@p_id

END

CREATE PROCEDURE [dbo].sp_Delete
	@p_id int
	
AS
	Delete from laptop
	where laptop_id=@p_id;
RETURN 0

Create PROCEDURE [dbo].sp_Find
	 @p_id int,
	  @p_name varchar(20) output,
	  @p_cost int output,
	  @p_des varchar(100) output

	

AS
	SELECT
	@p_name=laptop_name,@p_cost=cost,@p_des=Descr
	from laptop	where laptop_id=@p_id;

RETURN 0