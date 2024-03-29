/*
   viernes, 02 de mayo de 200821:29:13
   User: 
   Server: Pieza\SQLEXPRESS
   Database: Pime2
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
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
ALTER TABLE dbo.Contratos
	DROP CONSTRAINT FK_Contratos_Monedas
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Contratos
	DROP COLUMN MontoCuota, IdMonedaMonto
GO
COMMIT
