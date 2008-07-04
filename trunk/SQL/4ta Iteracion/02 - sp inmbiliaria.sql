
create PROCEDURE dbo.Inmobiliaria_RecuperarDatos

AS


SELECT  top 1      Nombre, Telefono, Fax, Calle, Numero, Piso, Depto, CodigoPostal, DireccionWeb
FROM            Inmobiliaria