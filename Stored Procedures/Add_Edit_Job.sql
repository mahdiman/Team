CREATE PROCEDURE ADD_EDIT_DELETE_Job
@Parameter int , 
@ID int ,
@Name varchar(20),
@Describtion varchar(50),
@MngrJobID int
AS
BEGIN
if(@Parameter = 1)
INSERT INTO Job (ID , Name , Describtion , Mngr_Job_ID) VALUES (@ID , @Name , @Describtion , @MngrJobID);
else if(@Parameter = 2)
UPDATE Job SET ID = @ID , Name = @Name , Describtion = @Describtion , Mngr_Job_ID = @MngrJobID;
else if(@Parameter = 3)
DELETE FROM Job WHERE ID = @ID ;
END