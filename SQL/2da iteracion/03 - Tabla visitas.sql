/*
   sábado, 17 de mayo de 200805:16:55 p.m.
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
CREATE TABLE dbo.VisitasPropiedad
	(
	IdVisita int NOT NULL IDENTITY (1, 1),
	TimpoAlarma bigint NOT NULL,
	FechaHora datetime NOT NULL,
	Realizada bit NOT NULL,
	Visita nvarchar(50) NOT NULL,
	Telefono nvarchar(50) NOT NULL,
	Comentario text NOT NULL,
	ConAlarma bit NOT NULL,
	IdPropiedad int NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.VisitasPropiedad ADD CONSTRAINT
	PK_VisitasPropiedad PRIMARY KEY CLUSTERED 
	(
	IdVisita
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.VisitasPropiedad ADD CONSTRAINT
	FK_VisitasPropiedad_Propiedades FOREIGN KEY
	(
	IdPropiedad
	) REFERENCES dbo.Propiedades
	(
	IdPropiedad
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
