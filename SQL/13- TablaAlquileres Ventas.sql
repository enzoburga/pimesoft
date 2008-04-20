/*
   Domingo, 20 de Abril de 2008 03:55:23 p.m.
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
CREATE TABLE dbo.Alquileres
	(
	IdPropiedad int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Alquileres ADD CONSTRAINT
	PK_Alquileres PRIMARY KEY CLUSTERED 
	(
	IdPropiedad
	) ON [PRIMARY]

GO
ALTER TABLE dbo.Alquileres ADD CONSTRAINT
	FK_Alquileres_Propiedades FOREIGN KEY
	(
	IdPropiedad
	) REFERENCES dbo.Propiedades
	(
	IdPropiedad
	)
GO
COMMIT
BEGIN TRANSACTION
CREATE TABLE dbo.Ventas
	(
	IdPropiedad int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Ventas ADD CONSTRAINT
	PK_Ventas PRIMARY KEY CLUSTERED 
	(
	IdPropiedad
	) ON [PRIMARY]

GO
ALTER TABLE dbo.Ventas ADD CONSTRAINT
	FK_Ventas_Propiedades FOREIGN KEY
	(
	IdPropiedad
	) REFERENCES dbo.Propiedades
	(
	IdPropiedad
	)
GO
COMMIT
