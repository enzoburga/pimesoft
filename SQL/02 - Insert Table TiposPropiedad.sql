/*
   Domingo, 13 de Abril de 2008 05:02:08 p.m.
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
ALTER TABLE dbo.CategoriasPropiedad ADD CONSTRAINT
	PK_CategoriasPropiedad PRIMARY KEY CLUSTERED 
	(
	IdCategoria
	) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
CREATE TABLE dbo.TiposPropiedad
	(
	IdTipoPropiedad int NOT NULL,
	Nombre nvarchar(150) NOT NULL,
	IdCategoria int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.TiposPropiedad ADD CONSTRAINT
	PK_TiposPropiedad PRIMARY KEY CLUSTERED 
	(
	IdTipoPropiedad
	) ON [PRIMARY]

GO
ALTER TABLE dbo.TiposPropiedad ADD CONSTRAINT
	FK_TiposPropiedad_CategoriasPropiedad FOREIGN KEY
	(
	IdCategoria
	) REFERENCES dbo.CategoriasPropiedad
	(
	IdCategoria
	)
GO
COMMIT
