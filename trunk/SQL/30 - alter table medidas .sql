/*
   lunes, 28 de abril de 200807:33:26 a.m.
   Usuario: 
   Servidor: EMILIOMOVILHP\SQLEXPRESS
   Base de datos: InmobiliariaDb
   Aplicación: 
*/

/* Para evitar posibles problemas de pérdida de datos, debe revisar esta secuencia de comandos detalladamente antes de ejecutarla fuera del contexto del diseñador de base de datos.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.MedidasAmbientesPropiedad
	DROP CONSTRAINT FK_MedidasAmbientesPropiedad_TiposDePiso
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.MedidasAmbientesPropiedad
	DROP CONSTRAINT FK_MedidasAmbientesPropiedad_Propiedades
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_MedidasAmbientesPropiedad
	(
	IdAmbiente int NOT NULL IDENTITY (1, 1),
	Ancho decimal(18, 1) NOT NULL,
	Largo decimal(18, 1) NOT NULL,
	Ambiente nvarchar(150) NOT NULL,
	IdTipoPiso int NOT NULL,
	IdPropiedad int NOT NULL
	)  ON [PRIMARY]
GO
SET IDENTITY_INSERT dbo.Tmp_MedidasAmbientesPropiedad ON
GO
IF EXISTS(SELECT * FROM dbo.MedidasAmbientesPropiedad)
	 EXEC('INSERT INTO dbo.Tmp_MedidasAmbientesPropiedad (IdAmbiente, Ancho, Largo, Ambiente, IdTipoPiso, IdPropiedad)
		SELECT IdAmbiente, Ancho, Largo, Ambiente, IdTipoPiso, IdPropiedad FROM dbo.MedidasAmbientesPropiedad WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_MedidasAmbientesPropiedad OFF
GO
DROP TABLE dbo.MedidasAmbientesPropiedad
GO
EXECUTE sp_rename N'dbo.Tmp_MedidasAmbientesPropiedad', N'MedidasAmbientesPropiedad', 'OBJECT' 
GO
ALTER TABLE dbo.MedidasAmbientesPropiedad ADD CONSTRAINT
	PK_MedidasAmbientesPropiedad PRIMARY KEY CLUSTERED 
	(
	IdAmbiente
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.MedidasAmbientesPropiedad WITH NOCHECK ADD CONSTRAINT
	FK_MedidasAmbientesPropiedad_Propiedades FOREIGN KEY
	(
	IdPropiedad
	) REFERENCES dbo.Propiedades
	(
	IdPropiedad
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.MedidasAmbientesPropiedad ADD CONSTRAINT
	FK_MedidasAmbientesPropiedad_TiposDePiso FOREIGN KEY
	(
	IdTipoPiso
	) REFERENCES dbo.TiposDePiso
	(
	IdTipoPiso
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
