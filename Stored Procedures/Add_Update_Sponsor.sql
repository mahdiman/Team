CREATE PROCEDURE Add_Update_Sponsor
@isAdd int ,
@ID varchar(20) ,
@Name varchar(30) , 
@Activity varchar(50) ,
@Our_Agent varchar(11),
@Address varchar(50),
@E_Mail varchar(50),
@Contact_Agent varchar(11) 
AS 
BEGIN

if(@isAdd = 1)
	 INSERT INTO Companies (Company_ID , Company_Name , Type_Of_Activity , Our_Agents_Id , Address , E_Mail , Contact_Agent_ID)
	 VALUES (@ID , @Name , @Activity , @Our_Agent , @Address , @E_Mail , @Contact_Agent ) ;

else if(@isAdd = 2)
BEGIN
	 UPDATE Companies SET  Company_Name = @Name , Type_Of_Activity = @Activity , Our_Agents_Id = @Our_Agent
	 , Address = @Address , E_Mail = @E_Mail , Contact_Agent_ID = @Contact_Agent 
	 WHERE Company_ID = @ID ;
END
else if(@isAdd = 3)
	 DELETE FROM Companies WHERE Company_ID = @ID ;

END