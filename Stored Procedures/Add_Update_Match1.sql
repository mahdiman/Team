CREATE PROCEDURE Add_Update_Match1
@isAdd int ,
@Date datetime ,
@Opponent varchar(20) ,
@Stadium varchar(30) ,
@Match_Result varchar(5)

AS 
BEGIN

if(@isAdd = 1)
	 INSERT INTO Matches (Match_Date , Opponent , Stadium , Match_Result)
	 VALUES (@Date , @Opponent , @Stadium , @Match_Result) ;

else if(@isAdd = 2)
	 UPDATE Matches SET   Opponent = @Opponent , Match_Result =
	 @Match_Result
	 WHERE Match_Date = @Date ;

else if(@isAdd = 3)
	 DELETE FROM Matches WHERE Match_Date = @Date ;

END