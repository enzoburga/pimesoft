/*
   sábado, 21 de junio de 200803:28:20 p.m.
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
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.TransaccionesPropiedad
	(
	IdTransaccion int NOT NULL,
	IdPropiedad int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.TransaccionesPropiedad ADD CONSTRAINT
	PK_TransaccionesPropiedad PRIMARY KEY CLUSTERED 
	(
	IdTransaccion
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.TransaccionesPropiedad ADD CONSTRAINT
	FK_TransaccionesPropiedad_Propiedades FOREIGN KEY
	(
	IdPropiedad
	) REFERENCES dbo.Propiedades
	(
	IdPropiedad
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Transaccion ADD CONSTRAINT
	FK_Transaccion_TransaccionesPropiedad FOREIGN KEY
	(
	IdTransaccion
	) REFERENCES dbo.TransaccionesPropiedad
	(
	IdTransaccion
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
