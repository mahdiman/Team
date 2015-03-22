CREATE PROCEDURE Add_Update_Training_Type
@isAdd int ,
@ID int ,
@Name varchar(20) ,
@Describtion varchar(200) 
AS 
BEGIN

if(@isAdd = 1)
	 INSERT INTO Training_Type(ID , Name , Describtion)
	 VALUES (@ID , @Name , @Describtion ) ;

else if(@isAdd = 2)
	 UPDATE Training_Type SET  Name = @Name , Describtion = @Describtion 
	 WHERE ID = @ID ;

else if(@isAdd = 3)
	 DELETE FROM Training_Type WHERE ID = @ID ;

END