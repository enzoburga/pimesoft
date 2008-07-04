/*
   jueves, 03 de julio de 200811:27:58 p.m.
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
CREATE TABLE dbo.Reportes
	(
	Encabezado image NOT NULL,
	PiePagina image NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Inmobiliaria
	(
	Nombre nvarchar(200) NOT NULL,
	Telefono nvarchar(50) NOT NULL,
	Fax nvarchar(50) NOT NULL,
	Calle nvarchar(200) NOT NULL,
	Numero nvarchar(50) NOT NULL,
	Piso nvarchar(2) NOT NULL,
	Depto nvarchar(3) NOT NULL,
	CodigoPostal nvarchar(10) NOT NULL,
	DireccionWeb nvarchar(250) NOT NULL
	)  ON [PRIMARY]
GO
COMMIT
