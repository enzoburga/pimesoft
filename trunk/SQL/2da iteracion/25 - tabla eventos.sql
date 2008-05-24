/*
   jueves, 22 de mayo de 200807:35:48 p.m.
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
CREATE TABLE dbo.Eventos
	(
	IdEvento int NOT NULL IDENTITY (1, 1),
	FechaGeneracion datetime NOT NULL,
	Descripcion nvarchar(500) NOT NULL,
	FechaVencimiento datetime NOT NULL,
	Activo bit NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Eventos ADD CONSTRAINT
	PK_Eventos PRIMARY KEY CLUSTERED 
	(
	IdEvento
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
