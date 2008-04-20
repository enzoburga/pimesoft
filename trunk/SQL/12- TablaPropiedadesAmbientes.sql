/*
   Domingo, 20 de Abril de 2008 03:53:41 p.m.
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
COMMIT
BEGIN TRANSACTION
CREATE TABLE dbo.MedidasAmbientesPropiedad
	(
	IdAmbiente int NOT NULL IDENTITY (1, 1),
	Ancho decimal(18, 0) NOT NULL,
	Largo decimal(18, 0) NOT NULL,
	Ambiente nvarchar(150) NOT NULL,
	IdTipoPiso int NOT NULL,
	IdPropiedad int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.MedidasAmbientesPropiedad ADD CONSTRAINT
	PK_MedidasAmbientesPropiedad PRIMARY KEY CLUSTERED 
	(
	IdAmbiente
	) ON [PRIMARY]

GO
ALTER TABLE dbo.MedidasAmbientesPropiedad ADD CONSTRAINT
	FK_MedidasAmbientesPropiedad_Propiedades FOREIGN KEY
	(
	IdPropiedad
	) REFERENCES dbo.Propiedades
	(
	IdPropiedad
	)
GO
ALTER TABLE dbo.MedidasAmbientesPropiedad ADD CONSTRAINT
	FK_MedidasAmbientesPropiedad_TiposDePiso FOREIGN KEY
	(
	IdTipoPiso
	) REFERENCES dbo.TiposDePiso
	(
	IdTipoPiso
	)
GO
COMMIT
