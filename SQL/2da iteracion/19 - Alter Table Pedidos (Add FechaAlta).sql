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
ALTER TABLE dbo.Pedidos
	DROP CONSTRAINT FK_Pedidos_TiposPropiedad
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Pedidos
	DROP CONSTRAINT FK_Pedidos_Provincias
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Pedidos
	DROP CONSTRAINT FK_Pedidos_Paises
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Pedidos
	DROP CONSTRAINT FK_Pedidos_Monedas1
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Pedidos
	DROP CONSTRAINT FK_Pedidos_Localidades
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Pedidos
	DROP CONSTRAINT FK_Pedidos_EstadosPropiedad
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Pedidos
	DROP CONSTRAINT FK_Pedidos_ClientesPedido
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Pedidos
	DROP CONSTRAINT FK_Pedidos_CategoriasPropiedad
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Pedidos
	DROP CONSTRAINT FK_Pedidos_Barrios
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Pedidos
	(
	IdPedido int NOT NULL IDENTITY (1, 1),
	CantidadAmbientesFinal decimal(18, 1) NULL,
	CantidadAmbientesInicial decimal(18, 1) NULL,
	IdCategoria int NULL,
	IdCliente int NOT NULL,
	Disposicion int NULL,
	EnumEstado int NULL,
	EsAptoProfesional bit NULL,
	IdEstadoPropiedad int NULL,
	EstadoPropiedad nvarchar(50) NULL,
	MetrosConstruiblesFinal int NULL,
	MetrosConstruiblesInicial int NULL,
	MetrosCubiertosFinal int NULL,
	MetrosCubiertosInicial int NULL,
	MetrosTerrenoFinal int NULL,
	MetrosTerrenoInicial int NULL,
	IdTipoPropiedad int NULL,
	TipoZona int NULL,
	IdBarrio int NULL,
	IdLocalidad int NULL,
	IdPais int NULL,
	IdProvincia int NULL,
	ImporteFinal decimal(18, 0) NULL,
	ImporteInicial decimal(18, 0) NULL,
	IdMoneda int NULL,
	Observaciones nvarchar(500) NOT NULL,
	Activo bit NOT NULL,
	FechaAlta datetime NOT NULL
	)  ON [PRIMARY]
GO
SET IDENTITY_INSERT dbo.Tmp_Pedidos ON
GO
IF EXISTS(SELECT * FROM dbo.Pedidos)
	 EXEC('INSERT INTO dbo.Tmp_Pedidos (IdPedido, CantidadAmbientesFinal, CantidadAmbientesInicial, IdCategoria, IdCliente, Disposicion, EnumEstado, EsAptoProfesional, IdEstadoPropiedad, EstadoPropiedad, MetrosConstruiblesFinal, MetrosConstruiblesInicial, MetrosCubiertosFinal, MetrosCubiertosInicial, MetrosTerrenoFinal, MetrosTerrenoInicial, IdTipoPropiedad, TipoZona, IdBarrio, IdLocalidad, IdPais, IdProvincia, ImporteFinal, ImporteInicial, IdMoneda, Observaciones, Activo, FechaAlta)
		SELECT IdPedido, CantidadAmbientesFinal, CantidadAmbientesInicial, IdCategoria, IdCliente, Disposicion, EnumEstado, EsAptoProfesional, IdEstadoPropiedad, EstadoPropiedad, MetrosConstruiblesFinal, MetrosConstruiblesInicial, MetrosCubiertosFinal, MetrosCubiertosInicial, MetrosTerrenoFinal, MetrosTerrenoInicial, IdTipoPropiedad, TipoZona, IdBarrio, IdLocalidad, IdPais, IdProvincia, ImporteFinal, ImporteInicial, IdMoneda, Observaciones, Activo, FechaAlta FROM dbo.Pedidos WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Pedidos OFF
GO
ALTER TABLE dbo.Pedidos
	DROP CONSTRAINT FK_Pedidos_Pedidos
GO
ALTER TABLE dbo.PropiedadesOfrecidasXPedido
	DROP CONSTRAINT FK_PropiedadesOfrecidasXPedido_Pedidos
GO
DROP TABLE dbo.Pedidos
GO
EXECUTE sp_rename N'dbo.Tmp_Pedidos', N'Pedidos', 'OBJECT' 
GO
ALTER TABLE dbo.Pedidos ADD CONSTRAINT
	PK_Pedidos PRIMARY KEY CLUSTERED 
	(
	IdPedido
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Pedidos ADD CONSTRAINT
	FK_Pedidos_Barrios FOREIGN KEY
	(
	IdBarrio
	) REFERENCES dbo.Barrios
	(
	IdBarrio
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Pedidos ADD CONSTRAINT
	FK_Pedidos_CategoriasPropiedad FOREIGN KEY
	(
	IdCategoria
	) REFERENCES dbo.CategoriasPropiedad
	(
	IdCategoria
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Pedidos ADD CONSTRAINT
	FK_Pedidos_ClientesPedido FOREIGN KEY
	(
	IdCliente
	) REFERENCES dbo.ClientesPedido
	(
	IdCliente
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Pedidos ADD CONSTRAINT
	FK_Pedidos_EstadosPropiedad FOREIGN KEY
	(
	IdEstadoPropiedad
	) REFERENCES dbo.EstadosPropiedad
	(
	IdEstadoPropiedad
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Pedidos ADD CONSTRAINT
	FK_Pedidos_Localidades FOREIGN KEY
	(
	IdLocalidad
	) REFERENCES dbo.Localidades
	(
	IdLocalidad
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Pedidos ADD CONSTRAINT
	FK_Pedidos_Monedas1 FOREIGN KEY
	(
	IdMoneda
	) REFERENCES dbo.Monedas
	(
	IdMoneda
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Pedidos ADD CONSTRAINT
	FK_Pedidos_Paises FOREIGN KEY
	(
	IdPais
	) REFERENCES dbo.Paises
	(
	IdPais
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Pedidos ADD CONSTRAINT
	FK_Pedidos_Provincias FOREIGN KEY
	(
	IdProvincia
	) REFERENCES dbo.Provincias
	(
	IdProvincia
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Pedidos ADD CONSTRAINT
	FK_Pedidos_TiposPropiedad FOREIGN KEY
	(
	IdTipoPropiedad
	) REFERENCES dbo.TiposPropiedad
	(
	IdTipoPropiedad
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Pedidos ADD CONSTRAINT
	FK_Pedidos_Pedidos FOREIGN KEY
	(
	IdPedido
	) REFERENCES dbo.Pedidos
	(
	IdPedido
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.PropiedadesOfrecidasXPedido ADD CONSTRAINT
	FK_PropiedadesOfrecidasXPedido_Pedidos FOREIGN KEY
	(
	IdPedido
	) REFERENCES dbo.Pedidos
	(
	IdPedido
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
