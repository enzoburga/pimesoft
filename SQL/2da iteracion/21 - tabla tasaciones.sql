/*
   martes, 20 de mayo de 200811:52:56 p.m.
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
CREATE TABLE dbo.Tasaciones
	(
	IdTasacion int NOT NULL IDENTITY (1, 1),
	IdPropiedad int NOT NULL,
	Fecha datetime NOT NULL,
	ImporteValorReal decimal(18, 2) NOT NULL,
	ImporteValorPublicacion decimal(18, 2) NOT NULL,
	IdMonedaValorReal int NOT NULL,
	IdMonedaValorPublicacion int NOT NULL,
	Comentarios text NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tasaciones ADD CONSTRAINT
	PK_Tasaciones PRIMARY KEY CLUSTERED 
	(
	IdTasacion
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Tasaciones ADD CONSTRAINT
	FK_Tasaciones_Propiedades FOREIGN KEY
	(
	IdPropiedad
	) REFERENCES dbo.Propiedades
	(
	IdPropiedad
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Tasaciones ADD CONSTRAINT
	FK_Tasaciones_Monedas FOREIGN KEY
	(
	IdMonedaValorReal
	) REFERENCES dbo.Monedas
	(
	IdMoneda
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Tasaciones ADD CONSTRAINT
	FK_Tasaciones_Monedas1 FOREIGN KEY
	(
	IdMonedaValorPublicacion
	) REFERENCES dbo.Monedas
	(
	IdMoneda
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
