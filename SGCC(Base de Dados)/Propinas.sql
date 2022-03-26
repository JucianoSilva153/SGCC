CREATE TABLE [dbo].[Propinas]
(
	[cod_propina] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [formando]  NCHAR(20) NULL,
    [periodo] NCHAR(10) NULL, 
    [data] NCHAR(10) NULL, 
    [horario] NCHAR(10) NULL, 
    [mesPago] NCHAR(10) NOT NULL, 
    --[mensalidade] NCHAR(10) NOT NULL  FOREIGN KEY REFERENCES [dbo].[Formandos](mensalidade)
)
