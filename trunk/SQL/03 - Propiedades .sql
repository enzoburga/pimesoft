ALTER PROCEDURE dbo.CategoriasPropiedad_RecuperarTodas 

AS

SELECT     IdCategoria, Nombre
FROM         CategoriasPropiedad 

;
ALTER PROCEDURE dbo.TiposPropiedad_RecuperarPorCategoria 
(
	@IdCategoria int
)
AS

SELECT     IdTipoPropiedad, Nombre
FROM         TiposPropiedad
WHERE     (IdCategoria = @IdCategoria)
;


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
CREATE TABLE dbo.EstadosPropiedad
	(
	IdEstadoPropiedad int NOT NULL,
	Nombre nvarchar(150) NOT NULL,
	TipoClasePropiedad nvarchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.EstadosPropiedad ADD CONSTRAINT
	PK_EstadosPropiedad PRIMARY KEY CLUSTERED 
	(
	IdEstadoPropiedad
	) ON [PRIMARY]

GO
COMMIT
;

ALTER PROCEDURE dbo.EstadosPropiedad_RecuperarPorClase 	
(
	@Clase nvarchar(50)
)
	
AS

SELECT     IdEstadoPropiedad, Nombre
FROM         EstadosPropiedad
WHERE     (TipoClasePropiedad = @Clase)