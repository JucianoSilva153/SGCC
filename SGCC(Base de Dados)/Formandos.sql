CREATE TABLE [dbo].[Formandos]
(
	[cod_formando] INT NOT NULL PRIMARY KEY,
    [formando] NCHAR(30) NOT NULL,
    [curso] NCHAR(30) NOT NULL, 
    [numero_tlf] INT NOT NULL, 
    [filiacaoMae] NCHAR(30) NOT NULL, 
    [filiacaoPai] NCHAR(30) NOT NULL, 
    [sexo] NCHAR(10) NOT NULL, 
    [numeroBI] NCHAR(15) NOT NULL, 
    [numeroPassaporte] NCHAR(20) NOT NULL, 
    [naturalidade] NCHAR(15) NOT NULL, 
    [moradaMunicipio] NCHAR(15) NOT NULL, 
    [moradaProvincia] NCHAR(15) NOT NULL, 
    [periodo] NCHAR(10) NOT NULL, 
    [data] NCHAR(10) NOT NULL, 
    [horario] NCHAR(10) NOT NULL, 
    [inicioCurso] NCHAR(20) NOT NULL, 
    [fonte] NCHAR(20) NOT NULL, 
    [valorInscricao] NUMERIC(20, 2) NOT NULL, 
    [pagamentoCert] NCHAR(15) NOT NULL, 
    [mensalidade] NCHAR(10) NULL
)
