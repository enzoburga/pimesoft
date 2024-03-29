/*
   martes, 27 de mayo de 200802:04:56 a.m.
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
CREATE TABLE dbo.InmobiliariasExternas
	(
	IdInmobiliaria int NOT NULL IDENTITY (1, 1),
	Nombre nvarchar(100) NOT NULL,
	Telefono nvarchar(100) NOT NULL,
	Contacto nvarchar(100) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.InmobiliariasExternas ADD CONSTRAINT
	PK_InmobiliariasExternas PRIMARY KEY CLUSTERED 
	(
	IdInmobiliaria
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Propiedades ADD
	IdInmobiliariaExterna int NULL
GO
ALTER TABLE dbo.Propiedades ADD CONSTRAINT
	FK_Propiedades_InmobiliariasExternas FOREIGN KEY
	(
	IdInmobiliariaExterna
	) REFERENCES dbo.InmobiliariasExternas
	(
	IdInmobiliaria
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
