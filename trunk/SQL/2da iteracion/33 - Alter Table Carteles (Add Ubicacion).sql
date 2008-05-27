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
ALTER TABLE dbo.Carteles
	DROP CONSTRAINT FK_Carteles_UbicacionesCartel
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Carteles
	DROP CONSTRAINT FK_Carteles_Propiedades
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Carteles
	(
	IdCartel int NOT NULL IDENTITY (1, 1),
	IdPropiedad int NOT NULL,
	Activo bit NOT NULL,
	Ancho int NOT NULL,
	Alto int NULL,
	FechaAlta datetime NOT NULL,
	FechaVencimiento datetime NULL,
	TipoCartel nvarchar(50) NULL,
	IdUbicacionCartel int NULL
	)  ON [PRIMARY]
GO
SET IDENTITY_INSERT dbo.Tmp_Carteles ON
GO
IF EXISTS(SELECT * FROM dbo.Carteles)
	 EXEC('INSERT INTO dbo.Tmp_Carteles (IdCartel, IdPropiedad, Activo, Ancho, Alto, FechaAlta, FechaVencimiento, TipoCartel)
		SELECT IdCartel, IdPropiedad, Activo, Ancho, Alto, FechaAlta, FechaVencimiento, TipoCartel FROM dbo.Carteles WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Carteles OFF
GO
DROP TABLE dbo.Carteles
GO
EXECUTE sp_rename N'dbo.Tmp_Carteles', N'Carteles', 'OBJECT' 
GO
ALTER TABLE dbo.Carteles ADD CONSTRAINT
	PK_Carteles PRIMARY KEY CLUSTERED 
	(
	IdCartel
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Carteles ADD CONSTRAINT
	FK_Carteles_Propiedades FOREIGN KEY
	(
	IdPropiedad
	) REFERENCES dbo.Propiedades
	(
	IdPropiedad
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Carteles ADD CONSTRAINT
	FK_Carteles_UbicacionesCartel FOREIGN KEY
	(
	IdUbicacionCartel
	) REFERENCES dbo.UbicacionesCartel
	(
	IdUbicacionCartel
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
