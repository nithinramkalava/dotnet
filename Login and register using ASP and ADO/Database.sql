CREATE TABLE [dbo].[Users]
(
	[username] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [password] NVARCHAR(50) NOT NULL, 
    [email] NVARCHAR(50) NOT NULL, 
    [phno] NVARCHAR(50) NOT NULL
)
