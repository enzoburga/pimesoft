CREATE PROCEDURE dbo.Propiedades_SelectProxId 

AS

select max(IdPropiedad)+1 from Propiedades
