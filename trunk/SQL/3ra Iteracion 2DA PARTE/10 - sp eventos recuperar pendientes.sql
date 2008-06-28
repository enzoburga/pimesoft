create PROCEDURE dbo.Eventos_RecuperarEventosPendientes 

AS

SELECT        IdEvento, FechaGeneracion, Descripcion, FechaVencimiento, Activo, IdRelacion, IdTipoEvento
FROM            Eventos
WHERE        (Activo = 1)