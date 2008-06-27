/*
   viernes, 27 de junio de 200804:37:59 p.m.
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
ALTER TABLE dbo.TransaccionesFoto
	DROP CONSTRAINT FK_TransaccionesFoto_Transaccion
GO
ALTER TABLE dbo.Transaccion
	DROP CONSTRAINT FK_Transaccion_TransaccionesPropiedad
GO
ALTER TABLE dbo.TransaccionesPropiedad
	DROP CONSTRAINT FK_TransaccionesPropiedad_Transaccion
GO
COMMIT
BEGIN TRANSACTION
GO
COMMIT
BEGIN TRANSACTION
GO
COMMIT
