CREATE TABLE [dbo].[Cursos]
(
	[cod] INT NOT NULL IDENTITY(1,1) PRIMARY KEY , 
    [curso] NCHAR(30) NOT NULL, 
    [n_formandos] INT NOT NULL, 
    [formador] NCHAR(20) NULL, 
    [data_inicio] NCHAR(20) NOT NULL
)
