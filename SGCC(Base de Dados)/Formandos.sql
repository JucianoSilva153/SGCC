CREATE TABLE [dbo].[Formandos]
(
	[cod_formando] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [formando] NCHAR(30) NOT NULL,
    [curso] NCHAR(30) NOT NULL, 
    [numero_tlf] INT NOT NULL,  
    [sexo] NCHAR(10) NOT NULL, 
    [numeroBI] NCHAR(15) NOT NULL, 
    [numeroPassaporte] NCHAR(20) NOT NULL, 
    [naturalidade] NCHAR(15) NOT NULL, 
    [moradaProvincia] NCHAR(15) NOT NULL, 
    [periodo] NCHAR(10) NOT NULL, 
    [data] NCHAR(10) NOT NULL, 
    [horario] NCHAR(10) NOT NULL, 
    [pagamentoCert] NCHAR(15) NOT NULL, 
    [mensalidade] NCHAR(10) NULL, 
    [mensalidadeAt] NCHAR(30) NULL
)
