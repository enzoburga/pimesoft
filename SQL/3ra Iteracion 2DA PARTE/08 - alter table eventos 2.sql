/*
   sábado, 28 de junio de 200802:05:34 a.m.
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
CREATE TABLE dbo.Tmp_Eventos
	(
	IdEvento int NOT NULL IDENTITY (1, 1),
	FechaGeneracion datetime NOT NULL,
	Descripcion nvarchar(500) NOT NULL,
	FechaVencimiento datetime NULL,
	Activo bit NOT NULL,
	IdRelacion int NOT NULL,
	IdTipoEvento int NOT NULL
	)  ON [PRIMARY]
GO
SET IDENTITY_INSERT dbo.Tmp_Eventos ON
GO
IF EXISTS(SELECT * FROM dbo.Eventos)
	 EXEC('INSERT INTO dbo.Tmp_Eventos (IdEvento, FechaGeneracion, Descripcion, FechaVencimiento, Activo, IdRelacion)
		SELECT IdEvento, FechaGeneracion, Descripcion, FechaVencimiento, Activo, IdRelacion FROM dbo.Eventos WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Eventos OFF
GO
DROP TABLE dbo.Eventos
GO
EXECUTE sp_rename N'dbo.Tmp_Eventos', N'Eventos', 'OBJECT' 
GO
ALTER TABLE dbo.Eventos ADD CONSTRAINT
	PK_Eventos PRIMARY KEY CLUSTERED 
	(
	IdEvento
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
