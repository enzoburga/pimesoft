/*
   lunes, 28 de abril de 200812:10:05 a.m.
   Usuario: 
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
ALTER TABLE dbo.Propiedades
	DROP CONSTRAINT FK_Propiedades_Monedas
GO
ALTER TABLE dbo.Propiedades
	DROP CONSTRAINT FK_Propiedades_Monedas1
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Propiedades
	DROP CONSTRAINT FK_Propiedades_Barrios
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Propiedades
	DROP CONSTRAINT FK_Propiedades_Localidades
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Propiedades
	DROP CONSTRAINT FK_Propiedades_Provincias
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Propiedades
	DROP CONSTRAINT FK_Propiedades_Paises
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Propiedades
	DROP CONSTRAINT FK_Propiedades_EstadosPropiedad
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Propiedades
	DROP CONSTRAINT FK_Propiedades_TiposPropiedad
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Propiedades
	DROP CONSTRAINT FK_Propiedades_Clientes
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Propiedades
	(
	IdPropiedad int NOT NULL IDENTITY (1, 1),
	CantidadAmbientes decimal(18, 1) NOT NULL,
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
	Depto nvarchar(5) NOT NULL,
	Piso nvarchar(5) NOT NULL,
	CodigoPostal nvarchar(10) NOT NULL,
	CalleEntre1 nvarchar(200) NOT NULL,
	CalleEntre2 nvarchar(200) NOT NULL,
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
SET IDENTITY_INSERT dbo.Tmp_Propiedades ON
GO
IF EXISTS(SELECT * FROM dbo.Propiedades)
	 EXEC('INSERT INTO dbo.Tmp_Propiedades (IdPropiedad, CantidadAmbientes, Codigo, IdTipoPropiedad, IdEstadoPropiedad, EnumEstadoProp, IdPropietario, IdPais, IdProvincia, IdLocalidad, IdBarrio, Calle, NumeroPostal, Depto, Piso, CodigoPostal, CalleEntre1, CalleEntre2, ValorMercadoImporte, ValorMercadoMoneda, ValorPublicacionImporte, ValorPublicacionMoneda, Observaciones, EsOtraInmobiliaria, MetrosCubiertos, MetrosSemicubiertos, MetrosLibres, TerrenoMetros, TerrenoFondo, TerrenosFrente, Orientacion, CantidadBanos, CantidadCocheras, CantidadDomritorios, CantidadPlantas, IdDepartamentoDisposicion, EsAptoProfesional, DeptoCantidadPisos, DeptoDepartamentosPorPiso, CantidadAscensores, CantidadAscensoresServicio, IdTipoZona, Fos, Fot, Zonificacion, MetrosContruibles)
		SELECT IdPropiedad, CantidadAmbientes, Codigo, IdTipoPropiedad, IdEstadoPropiedad, EnumEstadoProp, IdPropietario, IdPais, IdProvincia, IdLocalidad, IdBarrio, Calle, NumeroPostal, Depto, Piso, CodigoPostal, CalleEntre1, CalleEntre2, ValorMercadoImporte, ValorMercadoMoneda, ValorPublicacionImporte, ValorPublicacionMoneda, Observaciones, EsOtraInmobiliaria, MetrosCubiertos, MetrosSemicubiertos, MetrosLibres, TerrenoMetros, TerrenoFondo, TerrenosFrente, Orientacion, CantidadBanos, CantidadCocheras, CantidadDomritorios, CantidadPlantas, IdDepartamentoDisposicion, EsAptoProfesional, DeptoCantidadPisos, DeptoDepartamentosPorPiso, CantidadAscensores, CantidadAscensoresServicio, IdTipoZona, Fos, Fot, Zonificacion, MetrosContruibles FROM dbo.Propiedades WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Propiedades OFF
GO
ALTER TABLE dbo.Alquileres
	DROP CONSTRAINT FK_Alquileres_Propiedades
GO
ALTER TABLE dbo.Ventas
	DROP CONSTRAINT FK_Ventas_Propiedades
GO
ALTER TABLE dbo.MedidasAmbientesPropiedad
	DROP CONSTRAINT FK_MedidasAmbientesPropiedad_Propiedades
GO
DROP TABLE dbo.Propiedades
GO
EXECUTE sp_rename N'dbo.Tmp_Propiedades', N'Propiedades', 'OBJECT' 
GO
ALTER TABLE dbo.Propiedades ADD CONSTRAINT
	PK_Propiedades PRIMARY KEY CLUSTERED 
	(
	IdPropiedad
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

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
ALTER TABLE dbo.Propiedades WITH NOCHECK ADD CONSTRAINT
	FK_Propiedades_TiposPropiedad FOREIGN KEY
	(
	IdTipoPropiedad
	) REFERENCES dbo.TiposPropiedad
	(
	IdTipoPropiedad
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Propiedades WITH NOCHECK ADD CONSTRAINT
	FK_Propiedades_EstadosPropiedad FOREIGN KEY
	(
	IdEstadoPropiedad
	) REFERENCES dbo.EstadosPropiedad
	(
	IdEstadoPropiedad
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Propiedades WITH NOCHECK ADD CONSTRAINT
	FK_Propiedades_Paises FOREIGN KEY
	(
	IdPais
	) REFERENCES dbo.Paises
	(
	IdPais
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Propiedades WITH NOCHECK ADD CONSTRAINT
	FK_Propiedades_Provincias FOREIGN KEY
	(
	IdProvincia
	) REFERENCES dbo.Provincias
	(
	IdProvincia
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Propiedades WITH NOCHECK ADD CONSTRAINT
	FK_Propiedades_Localidades FOREIGN KEY
	(
	IdLocalidad
	) REFERENCES dbo.Localidades
	(
	IdLocalidad
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Propiedades WITH NOCHECK ADD CONSTRAINT
	FK_Propiedades_Barrios FOREIGN KEY
	(
	IdBarrio
	) REFERENCES dbo.Barrios
	(
	IdBarrio
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Propiedades WITH NOCHECK ADD CONSTRAINT
	FK_Propiedades_Monedas FOREIGN KEY
	(
	ValorMercadoMoneda
	) REFERENCES dbo.Monedas
	(
	IdMoneda
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Propiedades WITH NOCHECK ADD CONSTRAINT
	FK_Propiedades_Monedas1 FOREIGN KEY
	(
	ValorPublicacionMoneda
	) REFERENCES dbo.Monedas
	(
	IdMoneda
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.MedidasAmbientesPropiedad WITH NOCHECK ADD CONSTRAINT
	FK_MedidasAmbientesPropiedad_Propiedades FOREIGN KEY
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
ALTER TABLE dbo.Ventas WITH NOCHECK ADD CONSTRAINT
	FK_Ventas_Propiedades FOREIGN KEY
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
ALTER TABLE dbo.Alquileres WITH NOCHECK ADD CONSTRAINT
	FK_Alquileres_Propiedades FOREIGN KEY
	(
	IdPropiedad
	) REFERENCES dbo.Propiedades
	(
	IdPropiedad
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
