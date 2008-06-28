create PROCEDURE dbo.EventosControl_SetFechaGeneracion 

AS

declare @reg int
select @reg=count(*) from eventosControl
if (@reg=0)
	insert into eventosControl values (getdate())
else
	update eventosControl Set UltimaFechaGeneracion=getDate()
	