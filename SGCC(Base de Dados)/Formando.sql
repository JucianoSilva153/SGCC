﻿CREATE TABLE [dbo].[Formando]
(
	[numeroFormando] INT NOT NULL PRIMARY KEY, 
    [formando] NCHAR(30) NULL, 
    [curso] NCHAR(30) NULL, 
    [numero_tlf] INT NOT NULL, 
    [filiacaoMae] NCHAR(30) NOT NULL, 
    [filiacaoPai] NCHAR(30) NOT NULL, 
    [sexo] NCHAR(10) NOT NULL, 
    [numeroBI] NCHAR(15) NOT NULL, 
    [numeroPassaporte] NCHAR(20) NOT NULL, 
    [naturalidade] NCHAR(15) NOT NULL, 
    [moradaMunicipio] NCHAR(15) NOT NULL, 
    [moradaBairro] NCHAR(15) NOT NULL, 
    [periodo] NCHAR(10) NOT NULL, 
    [data] NCHAR(10) NOT NULL, 
    [horario] NCHAR(10) NOT NULL, 
    [inicioCurso] NCHAR(10) NOT NULL, 
    --Fonte indica, como o formando ouvio falar da instituição
    [fonte] NCHAR(20) NOT NULL, 
    [valorInscricao] NUMERIC(20, 2) NOT NULL
)
