/*
   Domingo, 20 de Abril de 2008 03:50:25 p.m.
   Usuario: 
   Servidor: EMILIOMOVIL
   Base de datos: InmobiliariaDb
   Aplicación: MS SQLEM - Data Tools
*/

BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
COMMIT
BEGIN TRANSACTION
COMMIT
BEGIN TRANSACTION
COMMIT
BEGIN TRANSACTION
COMMIT
BEGIN TRANSACTION
COMMIT
BEGIN TRANSACTION
COMMIT
BEGIN TRANSACTION
COMMIT
BEGIN TRANSACTION
CREATE TABLE dbo.Propiedades
	(
	IdPropiedad int NOT NULL IDENTITY (1, 1),
	CantidadAmbientes decimal(18, 0) NOT NULL,
	Codigo nvarchar(8) NOT NULL,
	IdTipoPropiedad int NOT NULL,
	IdEstadoPropiedad int NOT NULL,
	EnumEstadoProp int NOT NULL,
	IdPropietario int NULL,
	IdPais int NOT NULL,
	IdProvincia int NOT NULL,
	IdLocalidad int NOT NULL,
	IdBarrio int NOT NULL,
	Calle nvarchar(200) NOT NULL,
	NumeroPostal int NOT NULL,
	Depto nvarchar(5) NULL,
	Piso nvarchar(5) NULL,
	CodigoPostal nvarchar(10) NULL,
	CalleEntre1 nvarchar(200) NULL,
	CalleEntre2 nvarchar(200) NULL,
	ValorMercadoImporte decimal(18, 0) NOT NULL,
	ValorMercadoMoneda int NOT NULL,
	ValorPublicacionImporte decimal(18, 0) NOT NULL,
	ValorPublicacionMoneda int NOT NULL,
	Observaciones text NULL,
	EsOtraInmobiliaria bit NOT NULL,
	MetrosCubiertos decimal(18, 0) NOT NULL,
	MetrosSemicubiertos decimal(18, 0) NOT NULL,
	MetrosLibres decimal(18, 0) NOT NULL,
	TerrenoMetros decimal(18, 0) NOT NULL,
	TerrenoFondo decimal(18, 0) NOT NULL,
	TerrenosFrente decimal(18, 0) NOT NULL,
	Orientacion nvarchar(50) NOT NULL,
	CantidadBanos int NOT NULL,
	CantidadCocheras int NOT NULL,
	CantidadDomritorios int NOT NULL,
	CantidadPlantas int NOT NULL,
	IdDepartamentoDisposicion int NOT NULL,
	EsAptoProfesional bit NULL,
	DeptoCantidadPisos int NULL,
	DeptoDepartamentosPorPiso int NULL,
	CantidadAscensores int NULL,
	CantidadAscensoresServicio int NULL,
	IdTipoZona int NULL,
	Fos nvarchar(50) NULL,
	Fot nvarchar(50) NULL,
	Zonificacion nvarchar(50) NULL,
	MetrosContruibles int NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Propiedades ADD CONSTRAINT
	PK_Propiedades PRIMARY KEY CLUSTERED 
	(
	IdPropiedad
	) ON [PRIMARY]

GO
ALTER TABLE dbo.Propiedades ADD CONSTRAINT
	FK_Propiedades_TiposPropiedad FOREIGN KEY
	(
	IdTipoPropiedad
	) REFERENCES dbo.TiposPropiedad
	(
	IdTipoPropiedad
	)
GO
ALTER TABLE dbo.Propiedades ADD CONSTRAINT
	FK_Propiedades_EstadosPropiedad FOREIGN KEY
	(
	IdEstadoPropiedad
	) REFERENCES dbo.EstadosPropiedad
	(
	IdEstadoPropiedad
	)
GO
ALTER TABLE dbo.Propiedades ADD CONSTRAINT
	FK_Propiedades_Paises FOREIGN KEY
	(
	IdPais
	) REFERENCES dbo.Paises
	(
	IdPais
	)
GO
ALTER TABLE dbo.Propiedades ADD CONSTRAINT
	FK_Propiedades_Provincias FOREIGN KEY
	(
	IdProvincia
	) REFERENCES dbo.Provincias
	(
	IdProvincia
	)
GO
ALTER TABLE dbo.Propiedades ADD CONSTRAINT
	FK_Propiedades_Localidades FOREIGN KEY
	(
	IdLocalidad
	) REFERENCES dbo.Localidades
	(
	IdLocalidad
	)
GO
ALTER TABLE dbo.Propiedades ADD CONSTRAINT
	FK_Propiedades_Barrios FOREIGN KEY
	(
	IdBarrio
	) REFERENCES dbo.Barrios
	(
	IdBarrio
	)
GO
ALTER TABLE dbo.Propiedades ADD CONSTRAINT
	FK_Propiedades_Monedas FOREIGN KEY
	(
	ValorMercadoMoneda
	) REFERENCES dbo.Monedas
	(
	IdMoneda
	)
GO
ALTER TABLE dbo.Propiedades ADD CONSTRAINT
	FK_Propiedades_Monedas1 FOREIGN KEY
	(
	ValorPublicacionMoneda
	) REFERENCES dbo.Monedas
	(
	IdMoneda
	)
GO
COMMIT
