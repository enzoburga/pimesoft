/*
   lunes, 26 de mayo de 200811:03:29 p.m.
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
CREATE TABLE dbo.TiposAmbiente
	(
	IdTipoambiente int NOT NULL IDENTITY (1, 1),
	Nombre nvarchar(50) NOT NULL
	)  ON [PRIMARY]
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
ALTER TABLE dbo.MedidasAmbientesPropiedad ADD
	IdTipoAmbiente int NULL
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
