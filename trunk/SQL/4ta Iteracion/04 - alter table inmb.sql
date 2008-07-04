/*
   viernes, 04 de julio de 200812:08:19 a.m.
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
CREATE TABLE dbo.Tmp_Inmobiliaria
	(
	Nombre nvarchar(200) NOT NULL,
	Telefono nvarchar(50) NOT NULL,
	Fax nvarchar(50) NOT NULL,
	Calle nvarchar(200) NOT NULL,
	Numero int NOT NULL,
	Piso nvarchar(2) NOT NULL,
	Depto nvarchar(3) NOT NULL,
	CodigoPostal nvarchar(10) NOT NULL,
	DireccionWeb nvarchar(250) NOT NULL
	)  ON [PRIMARY]
GO
IF EXISTS(SELECT * FROM dbo.Inmobiliaria)
	 EXEC('INSERT INTO dbo.Tmp_Inmobiliaria (Nombre, Telefono, Fax, Calle, Numero, Piso, Depto, CodigoPostal, DireccionWeb)
		SELECT Nombre, Telefono, Fax, Calle, CONVERT(int, Numero), Piso, Depto, CodigoPostal, DireccionWeb FROM dbo.Inmobiliaria WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.Inmobiliaria
GO
EXECUTE sp_rename N'dbo.Tmp_Inmobiliaria', N'Inmobiliaria', 'OBJECT' 
GO
COMMIT
