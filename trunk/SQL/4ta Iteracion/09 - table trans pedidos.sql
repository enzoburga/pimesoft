/*
   sábado, 05 de julio de 200808:56:46 a.m.
   Usuario: sa
   Servidor: EMILIOMOVILHP\SQLEXPRESS
   Base de datos: InmobiliariaDbProduccion
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
CREATE TABLE dbo.TransaccionesPedido
	(
	IdTransaccion int NOT NULL,
	IdPedido int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.TransaccionesPedido ADD CONSTRAINT
	PK_TransaccionesPedido PRIMARY KEY CLUSTERED 
	(
	IdTransaccion
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.TransaccionesPedido ADD CONSTRAINT
	FK_TransaccionesPedido_Transaccion FOREIGN KEY
	(
	IdTransaccion
	) REFERENCES dbo.Transaccion
	(
	IdTransaccion
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
