CREATE PROCEDURE [dbo].[RegisterUser]
	@LastName nvarchar(50),
	@FirstName nvarchar(50),
	@Email nvarchar(320),
	@Passwd varchar(20)
AS
Begin
	Insert into [User] ([LastName], [FirstName], [Email], [Passwd])
	Values (@LastName, @FirstName, @Email, HASHBYTES('SHA2_512', dbo.GetPreSalt() + @Passwd + dbo.GetPostSalt()));
End
