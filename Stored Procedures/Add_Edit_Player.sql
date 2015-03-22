CREATE PROCEDURE Add_Update_Player
	@isAdd int , 
	@FName varchar(20),
	@MINT varchar(1),
	@LName varchar(20),
	@Adrees varchar(50),
	@E_Mail varchar(50),
	@Mobile varchar(12),
	@Home_Phone varchar(12),
	@Nationality varchar(20),
	@BDATE date,
	@Kit_Number varchar(20),
	@Position varchar(3),
	@Height float,
	@Weight float

AS
BEGIN
	if(@isAdd = 1)	
		INSERT INTO Player (Fname , Minit , Lname , Player.Address , E_Mail , Mobile , Home_Phone , Nationality , Bdate , Kit_Number
					, Position , Height , Player.Weight)	VALUES
					(@FName , @MINT , @LName , @Adrees , @E_Mail , @Mobile , @Home_Phone , @Nationality , @BDATE , @Kit_Number
					, @Position , @Height , @Weight);



	else if(@isAdd = 2)
			UPDATE Player
			SET Fname = @FName , Minit = @MINT , @LName = @LName , Address = @Adrees , E_Mail = @E_Mail , Mobile = @Mobile 
				, Home_Phone = @Home_Phone , Nationality = @Nationality , Bdate = @BDATE , Position = @Position
				, Height = @Height , Weight = @Weight
				WHERE Player.Kit_Number = @Kit_Number;



	else if(@isAdd = 3)
		DELETE FROM Player WHERE Player.Kit_Number=@Kit_Number;
END