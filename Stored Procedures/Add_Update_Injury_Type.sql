CREATE PROCEDURE Add_Update_Injury_Type
@isAdd int ,
@ID int ,
@Name varchar(50) ,
@Describtion varchar(10) 
AS 
BEGIN

if(@isAdd = 1)
	 INSERT INTO Injury_Type(ID , Name , Describtion)
	 VALUES (@ID , @Name , @Describtion ) ;

else if(@isAdd = 2)
	 UPDATE Injury_Type SET  Name = @Name , Describtion = @Describtion 
	 WHERE ID = @ID ;

else if(@isAdd = 3)
	 DELETE FROM Injury_Type WHERE ID = @ID ;

END