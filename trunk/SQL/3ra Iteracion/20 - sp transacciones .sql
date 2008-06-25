crate PROCEDURE dbo.Transacciones_RecuperarActivaPorPropiedad 

	(
		@IdPropiedad int
	)

AS


SELECT     top 1   Transaccion.IdTransaccion, Transaccion.TipoTransaccion, Transaccion.Fecha, TransaccionesPropiedad.IdPropiedad, 
                         TransaccionesPropiedad.TypePropopiedad
FROM            Transaccion INNER JOIN
                         TransaccionesPropiedad ON Transaccion.IdTransaccion = TransaccionesPropiedad.IdTransaccion
WHERE        (TransaccionesPropiedad.IdPropiedad = @IdPropiedad) AND (Transaccion.Activa = 1)
order by fecha desc