CREATE TABLE [dbo].[Formadores]
(
	[cod] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [formador] NCHAR(20) NOT NULL, 
    [curso] NCHAR(30) NOT NULL, 
    [numero_tlf] INT NOT NULL, 
    [numero_BI] NCHAR(15) NOT NULL
)
