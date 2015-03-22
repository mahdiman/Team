CREATE PROCEDURE [dbo].[Add_Update_Performance]
@isAdd int ,
@ID int ,
@Attacking int ,
@Defending int ,
@Finishing int , 
@Top_Speed int ,
@Acceleration int,
@Goal_Keeping int,
@Team_Work int,
@Kick_Power int,
@Measure_Date date,
@Kit varchar(20) 
AS 
BEGIN

if(@isAdd = 1)
	 INSERT INTO Performance(ID ,Attacking ,Defending , Finishing , Top_Speed , Acceleration , Goal_Keeping , Team_Work,
	 Kick_Power, Measure_Date , Player_Kit_Number)
	 VALUES (@ID ,@Attacking ,@Defending , @Finishing , @Top_Speed , @Acceleration , @Goal_Keeping , @Team_Work ,
	 @Kick_Power , @Measure_Date , @Kit ) ;

else if(@isAdd = 2)
BEGIN
	 UPDATE Performance SET Measure_Date = @Measure_Date , Player_Kit_Number = @Kit ,Attacking = @Attacking , Defending = @Defending , Finishing = @Finishing , Top_Speed = @Top_Speed
	 , Acceleration = @Acceleration , Goal_Keeping = @Goal_Keeping , Team_Work = @Team_Work , Kick_Power = @Kick_Power 
	 WHERE ID = @ID ;
END
else if(@isAdd = 3)
	 DELETE FROM Performance WHERE ID = @ID ;

END