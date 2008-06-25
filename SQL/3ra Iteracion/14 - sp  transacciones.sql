CREATE PROCEDURE dbo.Transaccion_Desactivar 
(
	@IdTransaccion int
)
AS


update transaccion set activa=0 where idtransaccion=@IdTransaccion

select @@rowcount

