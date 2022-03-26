CREATE TABLE [dbo].[RelatorioSaida]
(
	[codRelatorio] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [pagamentoEnergia] NCHAR(20) NOT NULL, 
    [combustivelGerador] NCHAR(20) NOT NULL, 
    [compraTinteiro] NCHAR(20) NOT NULL, 
    [compraResmaPapeis] NCHAR(20) NOT NULL, 
    [devolucoes] NCHAR(20) NOT NULL, 
    [compraDe] NCHAR(20) NOT NULL, 
    [outrasSaidasDe] NCHAR(20) NOT NULL, 
    [valorTotalPago] NCHAR(20) NOT NULL, 
    [horas] NCHAR(10) NOT NULL, 
    [operador] NCHAR(20) NOT NULL
)
