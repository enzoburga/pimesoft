/*
   sábado, 21 de junio de 200803:30:02 p.m.
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
CREATE TABLE dbo.TipoTransaccion
	(
	IdTipoTrans int NOT NULL,
	Descripcion nvarchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.TipoTransaccion ADD CONSTRAINT
	PK_TipoTransaccion PRIMARY KEY CLUSTERED 
	(
	IdTipoTrans
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Transaccion ADD CONSTRAINT
	FK_Transaccion_TipoTransaccion FOREIGN KEY
	(
	TipoTransaccion
	) REFERENCES dbo.TipoTransaccion
	(
	IdTipoTrans
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
