CREATE PROCEDURE Add_Update_Injuries
@isAdd int ,
@ID int ,
@Player_Kit_No varchar(20) , 
@Injury_Type_ID int ,
@IsHealed varchar(1),
@Doctor_ID varchar(11),
@Date Date 
AS 
BEGIN

if(@isAdd = 1)
	 INSERT INTO Injuries(ID , Player_Kit_No , Injury_Type_ID , IsHealed , Doctor_ID , Inj_Date)
	 VALUES (@ID , @Player_Kit_No , @Injury_Type_ID , @IsHealed , @Doctor_ID , @Date ) ;

else if(@isAdd = 2)
BEGIN
	 UPDATE Injuries SET  Player_Kit_No = @Player_Kit_No , Injury_Type_ID = @Injury_Type_ID , IsHealed = @IsHealed
	 , Doctor_ID = @Doctor_ID , Inj_Date = @Date 
	 WHERE ID = @ID ;
END
else if(@isAdd = 3)
	 DELETE FROM Injuries WHERE ID = @ID ;

END