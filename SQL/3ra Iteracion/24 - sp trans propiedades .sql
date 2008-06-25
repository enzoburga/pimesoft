create PROCEDURE dbo.Transacciones_RecuperarTransaccionesPropiedadesPendientesPorProp 
(
	@IdPropiedad int
)
AS


SELECT        Transaccion.IdTransaccion, Transaccion.TipoTransaccion, Transaccion.Fecha, TransaccionesPropiedad.IdPropiedad, 
                         TransaccionesPropiedad.TypePropopiedad
FROM            Transaccion INNER JOIN
                         TransaccionesPropiedad ON Transaccion.IdTransaccion = TransaccionesPropiedad.IdTransaccion
WHERE        (Transaccion.Activa = 1) And (TransaccionesPropiedad.IdPropiedad = @IdPropiedad)

;


create PROCEDURE dbo.Transacciones_RecuperarTransaccionesPropiedadesFotoPendientesPorProp 
(
	@IdPropiedad int
)
AS


SELECT        Transaccion.IdTransaccion, Transaccion.TipoTransaccion, Transaccion.Fecha, TransaccionesFoto.IdFoto, TransaccionesFoto.IdPropiedad
FROM            Transaccion INNER JOIN
                         TransaccionesFoto ON Transaccion.IdTransaccion = TransaccionesFoto.IdTransaccion
WHERE        (Transaccion.Activa = 1) And (TransaccionesFoto.IdPropiedad = @IdPropiedad)