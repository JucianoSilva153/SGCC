CREATE TABLE [dbo].[Conta]
(
	[cod] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [usuario] NCHAR(20) NOT NULL, 
    [senha] NCHAR(50) NOT NULL, 
    [tipo] NCHAR(20) NOT NULL
)
