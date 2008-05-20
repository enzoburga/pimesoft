/*
   martes, 20 de mayo de 200801:36:36 a.m.
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
CREATE TABLE dbo.Publicaciones
	(
	IdPublicacion int NOT NULL IDENTITY (1, 1),
	IdPropiedad int NOT NULL,
	Fecha datetime NOT NULL,
	Medio nvarchar(50) NOT NULL,
	Detalles text NOT NULL,
	IdMoneda int NOT NULL,
	Importe decimal(18, 2) NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Publicaciones ADD CONSTRAINT
	PK_Publicaciones PRIMARY KEY CLUSTERED 
	(
	IdPublicacion
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Publicaciones ADD CONSTRAINT
	FK_Publicaciones_Propiedades FOREIGN KEY
	(
	IdPropiedad
	) REFERENCES dbo.Propiedades
	(
	IdPropiedad
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Publicaciones ADD CONSTRAINT
	FK_Publicaciones_Monedas FOREIGN KEY
	(
	IdMoneda
	) REFERENCES dbo.Monedas
	(
	IdMoneda
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
