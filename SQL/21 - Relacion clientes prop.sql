/*
   miércoles, 23 de abril de 200808:29:49 a.m.
   User: sa
   Server: EMILIOMOVILHP\SQLEXPRESS
   Database: InmobiliariaDb
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
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Propiedades ADD CONSTRAINT
	FK_Propiedades_Clientes FOREIGN KEY
	(
	IdPropietario
	) REFERENCES dbo.Clientes
	(
	IdCliente
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
