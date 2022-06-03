CREATE TABLE [dbo].[RelatorioEntrada]
(
	[codRelatorio] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [inscricoes] INT NULL, 
    [mensalidade] INT NULL, 
    [cartao] INT NULL, 
    [certficado] INT NULL, 
    [curso] NCHAR(30) NULL, 
    [hora] NCHAR(20) NOT NULL, 
    [operador] NCHAR(20) NOT NULL, 
    [data] DATE NOT NULL, 
    [valorEntrada] INT NULL
)
