CREATE PROCEDURE [dbo].[Add_Edit_Delete_User]
@Parameter int ,
@Username varchar(100) ,
@PassWord varchar(24) ,
@Name	  varchar(100) ,
@Type	  varchar(30)
AS
BEGIN
if(@Parameter=1)
	INSERT INTO User_Login (UserName , Pass_Word , Name__ , User__Type) VALUES (@Username , @PassWord , @Name , @Type);
else if(@Parameter =2)
	UPDATE User_Login SET Pass_Word = @PassWord , Name__=@Name , User__Type = @Type
	WHERE UserName = @Username ;
else if(@Parameter=3)
	DELETE FROM User_Login WHERE UserName = @Username ;
END