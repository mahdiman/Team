CREATE PROCEDURE [dbo].[Add_Update_Employee]
	@isAdd int , 
	@FName varchar(20),
	@MINIT varchar(1),
	@LName varchar(20),
	@Bdate varchar(50),
	@ESSN varchar(50),
	@Address varchar(50),
	@E_Mail varchar(50) ,
	@Mobile varchar(12),
	@Home_Phone varchar(12),
	@Nationality varchar(20),
	@Job_ID int

AS
BEGIN
	if(@isAdd = 1)	
		INSERT INTO Employee(Fname , Minit , Lname , Employee.Bdate , ESSN , Employee.Address , E_Mail , Mobile , Home_Phone , Nationality
					, Job_ID)	VALUES
					(@FName , @MINIT , @LName , @Bdate , @ESSN , @Address , @E_Mail , @Mobile , @Home_Phone , @Nationality , @Job_ID);



	else if(@isAdd = 2)
			UPDATE Employee
			SET Fname = @FName , Minit = @MINIT , @LName = @LName , Address = @Address , E_Mail = @E_Mail , Mobile = @Mobile 
				, Home_Phone = @Home_Phone , Nationality = @Nationality , Bdate = @BDATE , Job_ID = @Job_ID
				WHERE ESSN = @ESSN;



	else if(@isAdd = 3)
		DELETE FROM Employee WHERE ESSN = @ESSN;
END