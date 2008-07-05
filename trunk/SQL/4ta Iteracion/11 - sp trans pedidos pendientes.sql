
create PROCEDURE dbo.Transacciones_RecuperarTransaccionesPedidoPendientes

AS


SELECT        Transaccion.IdTransaccion, Transaccion.TipoTransaccion, Transaccion.Fecha, Transaccion.Activa, TransaccionesPedido.IdPedido
FROM            Transaccion INNER JOIN
                         TransaccionesPedido ON Transaccion.IdTransaccion = TransaccionesPedido.IdTransaccion
WHERE        (Transaccion.Activa = 1)