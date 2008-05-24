/*
   jueves, 22 de mayo de 200807:49:15 p.m.
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
COMMIT
BEGIN TRANSACTION
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.EventoVisita
	(
	IdEvento int NOT NULL,
	IdVisita int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.EventoVisita ADD CONSTRAINT
	PK_EventoVisita PRIMARY KEY CLUSTERED 
	(
	IdEvento
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.EventoVisita ADD CONSTRAINT
	FK_EventoVisita_Eventos FOREIGN KEY
	(
	IdEvento
	) REFERENCES dbo.Eventos
	(
	IdEvento
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.EventoVisita ADD CONSTRAINT
	FK_EventoVisita_VisitasPropiedad FOREIGN KEY
	(
	IdVisita
	) REFERENCES dbo.VisitasPropiedad
	(
	IdVisita
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
