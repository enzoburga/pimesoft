/*
   Domingo, 20 de Abril de 2008 02:44:43 p.m.
   Usuario: 
   Servidor: EMILIOMOVIL
   Base de datos: InmobiliariaDb
   Aplicación: MS SQLEM - Data Tools
*/

BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
CREATE TABLE dbo.Tmp_Paises
	(
	IdPais int NOT NULL,
	Nombre nvarchar(150) NOT NULL,
	[Default] bit NOT NULL
	)  ON [PRIMARY]
GO
IF EXISTS(SELECT * FROM dbo.Paises)
	 EXEC('INSERT INTO dbo.Tmp_Paises (IdPais, Nombre)
		SELECT IdPais, Nombre FROM dbo.Paises TABLOCKX')
GO
ALTER TABLE dbo.Provincias
	DROP CONSTRAINT FK_Provincias_Paises
GO
DROP TABLE dbo.Paises
GO
EXECUTE sp_rename N'dbo.Tmp_Paises', N'Paises', 'OBJECT'
GO
ALTER TABLE dbo.Paises ADD CONSTRAINT
	PK_Paises PRIMARY KEY CLUSTERED 
	(
	IdPais
	) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
ALTER TABLE dbo.Provincias WITH NOCHECK ADD CONSTRAINT
	FK_Provincias_Paises FOREIGN KEY
	(
	IdPais
	) REFERENCES dbo.Paises
	(
	IdPais
	)
GO
COMMIT
