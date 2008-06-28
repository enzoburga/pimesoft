create PROCEDURE dbo.EventosControl_SelectUltimaFechaGeneracion 

AS

select top 1 UltimaFechaGeneracion from eventosControl
