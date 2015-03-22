CREATE PROCEDURE [dbo].[Add_Update_Comp_Par_In]
@isAdd int ,
@ID int ,
@Start_Date Date ,
@End_Date Date , 
@Teams_Number int ,
@Country varchar(20),
@Winner varchar(20),
@Type int 
AS 
BEGIN

if(@isAdd = 1)
	 INSERT INTO Competition_par_In(ID ,Start_Date , Close_Date , Teams_number , Country , Winner , Comp_Type_ID)
	 VALUES (@ID ,@Start_Date , @End_Date , @Teams_Number , @Country , @Winner , @Type ) ;

else if(@isAdd = 2)
BEGIN
	 UPDATE Competition_par_In SET Start_Date = @Start_Date , Close_Date = @End_Date , Teams_number = @Teams_Number , Country = @Country
	 , Comp_Type_ID = @Type 
	 WHERE ID = @ID ;
END
else if(@isAdd = 3)
	 DELETE FROM Competition_par_In WHERE ID = @ID ;

END