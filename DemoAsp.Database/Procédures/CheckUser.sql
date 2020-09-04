CREATE PROCEDURE [dbo].[CheckUser]
	@Email nvarchar(320),
	@Passwd varchar(20)
AS
Begin
	SELECT Id, LastName, FirstName, Email, Role
	from [User] 
	where Email = @Email and Passwd = HASHBYTES('SHA2_512', dbo.GetPreSalt() + @Passwd + dbo.GetPostSalt());
End
