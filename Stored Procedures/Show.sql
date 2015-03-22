CREATE PROCEDURE [dbo].[Show]
@Parameter int
AS
BEGIN
	if(@Parameter = 1)
	SELECT Fname AS 'First Name' , Minit AS 'Middle Name' , Lname AS'Last Name' , Kit_Number AS'Kit Number' ,
		   Position , Player.Address , E_Mail AS 'e-mail' , Mobile , Home_Phone AS 'Home Phone' , Bdate AS'Birth date' ,
		   Nationality , Height , Player.Weight 
		   FROM Player ;
	else if(@Parameter = 2)
		SELECT Fname AS 'First Name' , Minit AS 'Middle Name' , Lname AS'Last Name' , Bdate AS'Birth date' ,
		   ESSN , Address , E_Mail AS 'e-mail' , Mobile , Home_Phone AS 'Home Phone' ,
		   Job_ID,Nationality   
		   FROM Employee;
	else if(@Parameter = 3)
		 SELECT Match_Date AS 'Match Date' , Opponent , Comp_ID AS 'Championship' , Stadium ,
		 Match_Result AS 'Result' FROM Matches;
	else if(@Parameter = 4)
		SELECT Training.ID , Training_Date AS 'Date' , Training_Period AS 'Period' ,  TrainingType AS
		'Type' , Country ,Play_Ground AS 'Play Ground' 
		FROM Training;
	else if(@Parameter = 5)
		 SELECT Competition_par_In.ID , Competition_par_In.Start_Date AS 'Start Date' , Close_Date AS 'END Date' , Teams_number AS 'Number Of Teams',
		  Winner , Comp_Type_ID AS 'Championship Type ID' , Name , Country 
		 FROM Competition_par_In
		 JOIN Competition_Type
		 ON Comp_Type_ID = Competition_Type.ID;

	else if(@Parameter = 6)
		 SELECT ID , Inj_Date AS 'Date' , IsHealed AS 'Healed' , Player_Kit_No AS 'Injured Player', 
		 Injury_Type_ID AS 'Injuty Type' , Doctor_ID AS 'Doctor'
		 FROM Injuries;
		 

	else if(@Parameter = 7)
		SELECT ID , Start_Date AS 'Start_Time' , End_Date AS 'End Time' , SecondPartyID AS ' Second Party ID' ,
		SecondPartyType AS 'Second Party Type', Contract_Content AS 'Content'
		FROM Contracts;

	else if(@Parameter = 8)
		 SELECT Company_ID AS 'ID' , Company_Name AS 'Name' , Type_Of_Activity AS 'Actitvity' , Our_Agents_Id AS 'Our Agent',
		 Address , E_Mail AS 'e-mail' , Contact_Agent_ID AS 'Contact Agent'
		 FROM Companies ; 

	else if(@Parameter = 9)
		 SELECT UserName , Pass_Word AS 'Password' , Name__ AS'Name', User__Type AS'Type'
		 FROM User_Login ;

	else if(@Parameter = 10)
		 SELECT ID , Name , Describtion , Mngr_Job_ID AS 'Manager Job' FROM Job;

	else if(@Parameter = 11)
		 SELECT ID , Name , Com_Type AS 'Type' FROM Competition_Type;

	else if(@Parameter = 12)
		 SELECT ID , Name , Describtion FROM Injury_Type;

	else if(@Parameter = 13)
		SELECT ID , Name , Describtion FROM Training_Type;

	else if(@Parameter = 14)
		SELECT ID , Player_Kit_Number AS 'Player' , Measure_Date AS 'Date' ,Attacking ,Defending ,
		 Finishing , Top_Speed AS'Top Speed', Acceleration AS'Acceleration' , Goal_Keeping AS 'Goal Keeping' , 
		 Team_Work AS'Team Work',Kick_Power AS'Kick Power'
		 FROM Performance
		 ORDER BY Measure_Date;

	else if(@Parameter = 15)
		 SELECT ID AS 'Number' , UserName AS 'Username' , Activity , ACt_Date AS 'Date - Time'
		 FROM Admin_Lookup;
END