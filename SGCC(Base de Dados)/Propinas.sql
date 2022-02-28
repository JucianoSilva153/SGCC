CREATE TABLE [dbo].[Propinas]
(
	[cod_propina] INT NOT NULL PRIMARY KEY, 
    [aluno] NCHAR(20) NOT NULL, 
    [mesPropina] NVARCHAR(20) NOT NULL, 
    [janeiro] NCHAR(10) NULL, 
    [feveiro] NCHAR(10) NULL, 
    [marco] NCHAR(10) NULL, 
    [abril] NCHAR(10) NULL, 
    [maio] NCHAR(10) NULL, 
    [junho] NCHAR(10) NULL, 
    [julho] NCHAR(10) NULL, 
    [agosto] NCHAR(10) NULL, 
    [setembro] NCHAR(10) NULL, 
    [outubro] NCHAR(10) NULL, 
    [novembro] NCHAR(10) NULL, 
    [dezembro] NCHAR(10) NULL, 
    [periodo] NCHAR(10) NULL, 
    [data] NCHAR(10) NULL, 
    [horario] NCHAR(10) NULL   
)
