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
	DROP CONSTRAINT FK_Contratos_AdmAlquileres
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Contratos
	DROP CONSTRAINT FK_Contratos_Monedas
GO
ALTER TABLE dbo.Contratos
	DROP CONSTRAINT FK_Contratos_Monedas1
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Contratos
	DROP CONSTRAINT FK_Contratos_Inquilinos
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Contratos
	(
	IdContrato int NOT NULL IDENTITY (1, 1),
	IdInquilino int NULL,
	IdPropiedad int NOT NULL,
	FechaInicio datetime NOT NULL,
	FechaVencimiento datetime NOT NULL,
	MontoCuota decimal(18, 0) NOT NULL,
	IdMonedaMonto int NOT NULL,
	MontoDeposito decimal(18, 0) NOT NULL,
	IdMonedaDeposito int NOT NULL,
	DiaVencimientoCuota tinyint NOT NULL,
	IdContratoAnterior int NULL,
	FechaCancelacion datetime NULL,
	Observaciones nvarchar(200) NULL,
	Vigente bit NOT NULL
	)  ON [PRIMARY]
GO
SET IDENTITY_INSERT dbo.Tmp_Contratos ON
GO
IF EXISTS(SELECT * FROM dbo.Contratos)
	 EXEC('INSERT INTO dbo.Tmp_Contratos (IdContrato, IdInquilino, IdPropiedad, FechaInicio, FechaVencimiento, MontoCuota, IdMonedaMonto, MontoDeposito, IdMonedaDeposito, DiaVencimientoCuota, IdContratoAnterior, FechaCancelacion, Observaciones)
		SELECT IdContrato, IdInquilino, IdPropiedad, FechaInicio, FechaVencimiento, MontoCuota, IdMonedaMonto, MontoDeposito, IdMonedaDeposito, DiaVencimientoCuota, IdContratoAnterior, FechaCancelacion, Observaciones FROM dbo.Contratos WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Contratos OFF
GO
ALTER TABLE dbo.Contratos
	DROP CONSTRAINT FK_Contratos_Contratos
GO
DROP TABLE dbo.Contratos
GO
EXECUTE sp_rename N'dbo.Tmp_Contratos', N'Contratos', 'OBJECT' 
GO
ALTER TABLE dbo.Contratos ADD CONSTRAINT
	PK_Contratos PRIMARY KEY CLUSTERED 
	(
	IdContrato
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Contratos ADD CONSTRAINT
	FK_Contratos_Inquilinos FOREIGN KEY
	(
	IdInquilino
	) REFERENCES dbo.Inquilinos
	(
	IdCliente
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Contratos ADD CONSTRAINT
	FK_Contratos_Monedas FOREIGN KEY
	(
	IdMonedaMonto
	) REFERENCES dbo.Monedas
	(
	IdMoneda
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Contratos ADD CONSTRAINT
	FK_Contratos_Monedas1 FOREIGN KEY
	(
	IdMonedaDeposito
	) REFERENCES dbo.Monedas
	(
	IdMoneda
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Contratos ADD CONSTRAINT
	FK_Contratos_Contratos FOREIGN KEY
	(
	IdContratoAnterior
	) REFERENCES dbo.Contratos
	(
	IdContrato
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Contratos ADD CONSTRAINT
	FK_Contratos_AdmAlquileres FOREIGN KEY
	(
	IdPropiedad
	) REFERENCES dbo.AdmAlquileres
	(
	IdPropiedad
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT