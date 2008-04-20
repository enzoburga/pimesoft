ALTER PROCEDURE dbo.TiposPropiedad_RecuperarTodos 

AS
	SELECT     IdTipoPropiedad, Nombre, IdCategoria
	FROM         TiposPropiedad
;

ALTER PROCEDURE dbo.Paises_RecuperarTodos 

AS

SELECT     IdPais, Nombre, [Default]
FROM         Paises

;

ALTER PROCEDURE dbo.Provincias_RecuperarTodas 

AS

SELECT     IdProvincia, Nombre, [Default], IdPais
FROM         Provincias

;

ALTER PROCEDURE dbo.Localidades_RecuperarTodas 

AS
	SELECT     IdLocalidad, Nombre, [Default], IdProvincia
	FROM         Localidades

;

ALTER PROCEDURE dbo.Barrios_RecuperarTodos 

AS

SELECT     IdBarrio, Nombre, [Default], IdLocalidad
FROM         Barrios