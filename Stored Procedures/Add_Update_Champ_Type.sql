CREATE PROCEDURE [dbo].[Add_Update_Competition_Type]
@isAdd int ,
@ID int ,
@Name varchar(50) ,
@Type varchar(10) 
AS 
BEGIN

if(@isAdd = 1)
	 INSERT INTO Competition_Type(ID , Name , Com_Type)
	 VALUES (@ID , @Name , @Type ) ;

else if(@isAdd = 2)
	 UPDATE Competition_Type SET  Name = @Name , Com_Type = @Type 
	 WHERE ID = @ID ;

else if(@isAdd = 3)
	 DELETE FROM Competition_Type WHERE ID = @ID ;

END