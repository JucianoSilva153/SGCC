CREATE TABLE [dbo].[FormandoPropinas]
(
	[cod_pagamento] INT NOT NULL PRIMARY KEY, 
    [cod_formando] INT FOREIGN KEY REFERENCES [dbo].[Formandos](cod_formando) NULL, 
    [cod_propina] INT FOREIGN KEY REFERENCES [dbo].[Propinas](cod_propina) NULL
)
