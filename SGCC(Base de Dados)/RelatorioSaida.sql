CREATE TABLE [dbo].[RelatorioSaida]
(
	[codRelatorio] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [pagamentoEnergia] INT NOT NULL, 
    [combustivelGerador] INT NOT NULL, 
    [compraTinteiro] INT NOT NULL, 
    [compraResmaPapeis] INT NOT NULL, 
    [devolucoes] INT NOT NULL, 
    [compraDe] INT NOT NULL, 
    [outrasSaidasDe] INT NOT NULL, 
    [horas] NCHAR(10) NOT NULL, 
    [data] NCHAR(10) NOT NULL,
    [operador] NCHAR(20) NOT NULL
)
