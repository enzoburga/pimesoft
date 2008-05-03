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
ALTER TABLE dbo.Pagos
	DROP CONSTRAINT FK_Pagos_Monedas
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Pagos
	DROP CONSTRAINT FK_Pagos_Contratos
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Pagos
	(
	IdPago int NOT NULL IDENTITY (1, 1),
	IdContrato int NOT NULL,
	Importe decimal(18, 0) NOT NULL,
	IdMoneda int NOT NULL,
	Anulado bit NOT NULL,
	FechaPago datetime NOT NULL,
	MesCancelado int NOT NULL,
	FechaAlta datetime NOT NULL,
	AnioPagado int NOT NULL
	)  ON [PRIMARY]
GO
SET IDENTITY_INSERT dbo.Tmp_Pagos ON
GO
IF EXISTS(SELECT * FROM dbo.Pagos)
	 EXEC('INSERT INTO dbo.Tmp_Pagos (IdPago, IdContrato, Importe, IdMoneda, Anulado, FechaPago, MesCancelado, FechaAlta, AnioPagado)
		SELECT IdPago, IdContrato, Importe, IdMoneda, Anulado, FechaPago, MesCancelado, FechaAlta, CONVERT(int, AnioPagado) FROM dbo.Pagos WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Pagos OFF
GO
DROP TABLE dbo.Pagos
GO
EXECUTE sp_rename N'dbo.Tmp_Pagos', N'Pagos', 'OBJECT' 
GO
ALTER TABLE dbo.Pagos ADD CONSTRAINT
	PK_Pagos PRIMARY KEY CLUSTERED 
	(
	IdPago
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Pagos ADD CONSTRAINT
	FK_Pagos_Contratos FOREIGN KEY
	(
	IdContrato
	) REFERENCES dbo.Contratos
	(
	IdContrato
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Pagos ADD CONSTRAINT
	FK_Pagos_Monedas FOREIGN KEY
	(
	IdMoneda
	) REFERENCES dbo.Monedas
	(
	IdMoneda
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
