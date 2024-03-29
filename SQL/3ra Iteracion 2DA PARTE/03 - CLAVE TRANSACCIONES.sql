/*
   viernes, 27 de junio de 200804:41:10 p.m.
   Usuario: sa
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
ALTER TABLE dbo.Transaccion
	DROP CONSTRAINT FK_Transaccion_TransaccionesPropiedad
GO
ALTER TABLE dbo.Transaccion
	DROP CONSTRAINT FK_Transaccion_TransaccionesFoto
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.TransaccionesFoto ADD CONSTRAINT
	FK_TransaccionesFoto_Transaccion FOREIGN KEY
	(
	IdTransaccion
	) REFERENCES dbo.Transaccion
	(
	IdTransaccion
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.TransaccionesPropiedad ADD CONSTRAINT
	FK_TransaccionesPropiedad_Transaccion FOREIGN KEY
	(
	IdTransaccion
	) REFERENCES dbo.Transaccion
	(
	IdTransaccion
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
