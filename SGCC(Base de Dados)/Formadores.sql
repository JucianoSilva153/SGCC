CREATE TABLE [dbo].[Formadores]
(
	[cod] INT NOT NULL PRIMARY KEY, 
    [formador] NCHAR(20) NOT NULL, 
    [curso] NCHAR(30) NOT NULL, 
    [numero_tlf] INT NOT NULL
)
