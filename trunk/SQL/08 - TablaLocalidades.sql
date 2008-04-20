/*
   Domingo, 20 de Abril de 2008 02:43:00 p.m.
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
COMMIT
BEGIN TRANSACTION
CREATE TABLE dbo.Localidades
	(
	IdLocalidad int NOT NULL,
	Nombre nvarchar(150) NOT NULL,
	[Default] bit NOT NULL,
	IdProvincia int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Localidades ADD CONSTRAINT
	PK_Localidades PRIMARY KEY CLUSTERED 
	(
	IdLocalidad
	) ON [PRIMARY]

GO
ALTER TABLE dbo.Localidades ADD CONSTRAINT
	FK_Localidades_Provincias FOREIGN KEY
	(
	IdProvincia
	) REFERENCES dbo.Provincias
	(
	IdProvincia
	)
GO
COMMIT
