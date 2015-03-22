CREATE PROCEDURE [dbo].[Add_Update_Contracts]
@isAdd int ,
@ID int ,
@Start_Date Date ,
@End_Date Date , 
@Second_Party_ID varchar(20) ,
@Second_Party_Type varchar(10),
@Content varchar(max)
AS 
BEGIN

if(@isAdd = 1)
	 INSERT INTO Contracts(ID , Start_Date , End_Date , SecondPartyID , SecondPartyType , Contract_Content)
	 VALUES (@ID , @Start_Date , @End_Date , @Second_Party_ID , @Second_Party_Type , @Content ) ;

else if(@isAdd = 2)
BEGIN
	 UPDATE Contracts SET  Start_Date = @Start_Date , End_Date = @End_Date , SecondPartyID = @Second_Party_ID
	 , SecondPartyType = @Second_Party_Type , Contract_Content = @Content 
	 WHERE  ID = @ID;
END
else if(@isAdd = 3)
	 DELETE FROM Contracts WHERE ID = @ID ;

END