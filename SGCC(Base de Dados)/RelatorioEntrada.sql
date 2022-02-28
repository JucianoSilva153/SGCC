CREATE TABLE [dbo].[RelatorioEntrada]
(
	[codRelatorio] INT NOT NULL PRIMARY KEY, 
    [inscricoes] NCHAR(20) NOT NULL, 
    [mensalidade] NCHAR(20) NOT NULL, 
    [cartão] NCHAR(20) NOT NULL, 
    [certficado] NCHAR(20) NOT NULL, 
    [curso] NCHAR(30) NOT NULL, 
    [hora] NCHAR(10) NOT NULL, 
    [operador] NCHAR(20) NOT NULL, 
    [data] NCHAR(10) NOT NULL
)
