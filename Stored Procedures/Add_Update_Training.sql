CREATE PROCEDURE [dbo].[Add_Update_Training]
@isAdd int ,
@ID int ,
@Date DateTime ,
@Period float , 
@PlayGround varchar(20) ,
@Country varchar(20),
@Type int 
AS 
BEGIN

if(@isAdd = 1)
	 INSERT INTO Training (ID ,Training_Date , Training_Period , Play_Ground , Country , TrainingType)
	 VALUES (@ID ,@Date , @Period , @PlayGround , @Country , @Type ) ;

else if(@isAdd = 2)
BEGIN
	 UPDATE Training SET Training_Date = @Date , Training_Period = @Period , Play_Ground = @PlayGround , Country = @Country
	 , TrainingType = @Type 
	 WHERE  ID = @ID;
END
else if(@isAdd = 3)
	 DELETE FROM Training WHERE ID = @ID ;

END