ALTER PROCEDURE dbo.Transaccion_CrearTransFoto 
(
	@IdPropiedad int,
	@IdTipoTrans int,
	@Fecha datetime,
	@IdFoto int
)

AS

declare @id int

update Transaccion Set Activa=0 Where IdTransaccion in
(
SELECT        Transaccion.IdTransaccion
FROM            Transaccion INNER JOIN
                         TransaccionesFoto ON Transaccion.IdTransaccion = TransaccionesFoto.IdTransaccion
WHERE        (TransaccionesFoto.IdFoto = @IdFoto) AND (Transaccion.Activa = 1)
)
	
insert into Transaccion values (@IdTipoTrans, @Fecha, 1)
set @id = @@IDENTITY
insert into TransaccionesFoto values (@id, @IdFoto, @IdPropiedad)


select @id