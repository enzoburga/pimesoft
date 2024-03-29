/*
   sábado, 24 de mayo de 200817:56:43
   User: 
   Server: Pieza\SQLEXPRESS
   Database: InmobiliariaDb2
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
ALTER TABLE dbo.Clientes
	DROP CONSTRAINT FK_Clientes_Provincias
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Clientes
	DROP CONSTRAINT FK_Clientes_Paises
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Clientes
	DROP CONSTRAINT FK_Clientes_Localidades
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Clientes
	DROP CONSTRAINT FK_Clientes_Barrios
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Clientes
	(
	Nombres nvarchar(50) NOT NULL,
	Apellido nvarchar(50) NOT NULL,
	IdCliente int NOT NULL IDENTITY (1, 1),
	NroDocumento nvarchar(20) NULL,
	TipoDocumento int NULL,
	TelefonoParticular nvarchar(50) NULL,
	TelefonoTrabajo nvarchar(50) NULL,
	TelefonoCelular nvarchar(50) NULL,
	Observaciones nvarchar(200) NULL,
	FechaNacimiento datetime NULL,
	Email nvarchar(50) NULL,
	Calle nvarchar(50) NULL,
	Numero int NULL,
	Depto nvarchar(2) NULL,
	Piso nvarchar(2) NULL,
	CodigoPostal nvarchar(50) NULL,
	CalleEntre1 nvarchar(50) NULL,
	CalleEntre2 nvarchar(50) NULL,
	IdBarrio int NULL,
	IdProvincia int NULL,
	IdPais int NULL,
	IdLocalidad int NULL
	)  ON [PRIMARY]
GO
SET IDENTITY_INSERT dbo.Tmp_Clientes ON
GO
IF EXISTS(SELECT * FROM dbo.Clientes)
	 EXEC('INSERT INTO dbo.Tmp_Clientes (Nombres, Apellido, IdCliente, NroDocumento, TipoDocumento, TelefonoParticular, TelefonoTrabajo, TelefonoCelular, Observaciones, FechaNacimiento, Email, Calle, Numero, Depto, Piso, CodigoPostal, CalleEntre1, CalleEntre2, IdBarrio, IdProvincia, IdPais, IdLocalidad)
		SELECT Nombres, Apellido, IdCliente, NroDocumento, TipoDocumento, CONVERT(nvarchar(50), TelefonoParticular), CONVERT(nvarchar(50), TelefonoTrabajo), CONVERT(nvarchar(50), TelefonoCelular), Observaciones, FechaNacimiento, Email, Calle, Numero, Depto, Piso, CodigoPostal, CalleEntre1, CalleEntre2, IdBarrio, IdProvincia, IdPais, IdLocalidad FROM dbo.Clientes WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Clientes OFF
GO
ALTER TABLE dbo.Propietarios
	DROP CONSTRAINT FK_Propietarios_Clientes
GO
ALTER TABLE dbo.Inquilinos
	DROP CONSTRAINT FK_Inquilinos_Clientes
GO
ALTER TABLE dbo.ClientesPedido
	DROP CONSTRAINT FK_ClientesPedido_ClientesPedido
GO
ALTER TABLE dbo.Propiedades
	DROP CONSTRAINT FK_Propiedades_Clientes
GO
DROP TABLE dbo.Clientes
GO
EXECUTE sp_rename N'dbo.Tmp_Clientes', N'Clientes', 'OBJECT' 
GO
ALTER TABLE dbo.Clientes ADD CONSTRAINT
	PK_Clientes PRIMARY KEY CLUSTERED 
	(
	IdCliente
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Clientes ADD CONSTRAINT
	FK_Clientes_Barrios FOREIGN KEY
	(
	IdBarrio
	) REFERENCES dbo.Barrios
	(
	IdBarrio
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Clientes ADD CONSTRAINT
	FK_Clientes_Localidades FOREIGN KEY
	(
	IdLocalidad
	) REFERENCES dbo.Localidades
	(
	IdLocalidad
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Clientes ADD CONSTRAINT
	FK_Clientes_Paises FOREIGN KEY
	(
	IdPais
	) REFERENCES dbo.Paises
	(
	IdPais
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Clientes ADD CONSTRAINT
	FK_Clientes_Provincias FOREIGN KEY
	(
	IdProvincia
	) REFERENCES dbo.Provincias
	(
	IdProvincia
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
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
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ClientesPedido ADD CONSTRAINT
	FK_ClientesPedido_ClientesPedido FOREIGN KEY
	(
	IdCliente
	) REFERENCES dbo.Clientes
	(
	IdCliente
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Inquilinos ADD CONSTRAINT
	FK_Inquilinos_Clientes FOREIGN KEY
	(
	IdCliente
	) REFERENCES dbo.Clientes
	(
	IdCliente
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Propietarios ADD CONSTRAINT
	FK_Propietarios_Clientes FOREIGN KEY
	(
	IdCliente
	) REFERENCES dbo.Clientes
	(
	IdCliente
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
