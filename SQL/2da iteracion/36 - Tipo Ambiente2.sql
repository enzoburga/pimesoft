/*
   lunes, 26 de mayo de 200811:11:00 p.m.
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
CREATE TABLE dbo.Tmp_TiposAmbiente
	(
	IdTipoambiente int NOT NULL IDENTITY (1, 1),
	Nombre nvarchar(50) NOT NULL,
	Codigo int NOT NULL
	)  ON [PRIMARY]
GO
SET IDENTITY_INSERT dbo.Tmp_TiposAmbiente ON
GO
IF EXISTS(SELECT * FROM dbo.TiposAmbiente)
	 EXEC('INSERT INTO dbo.Tmp_TiposAmbiente (IdTipoambiente, Nombre)
		SELECT IdTipoambiente, Nombre FROM dbo.TiposAmbiente WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_TiposAmbiente OFF
GO
ALTER TABLE dbo.MedidasAmbientesPropiedad
	DROP CONSTRAINT FK_MedidasAmbientesPropiedad_TiposAmbiente
GO
DROP TABLE dbo.TiposAmbiente
GO
EXECUTE sp_rename N'dbo.Tmp_TiposAmbiente', N'TiposAmbiente', 'OBJECT' 
GO
ALTER TABLE dbo.TiposAmbiente ADD CONSTRAINT
	PK_TiposAmbiente PRIMARY KEY CLUSTERED 
	(
	IdTipoambiente
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.MedidasAmbientesPropiedad ADD CONSTRAINT
	FK_MedidasAmbientesPropiedad_TiposAmbiente FOREIGN KEY
	(
	IdTipoAmbiente
	) REFERENCES dbo.TiposAmbiente
	(
	IdTipoambiente
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
