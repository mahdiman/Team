CREATE PROCEDURE Login_Func
@username VARCHAR(100) ,
@password VARCHAR(16)
AS
BEGIN
SELECT * FROM User_Login WHERE User_Login.UserName = @username AND User_Login.Pass_Word = @password ;
END