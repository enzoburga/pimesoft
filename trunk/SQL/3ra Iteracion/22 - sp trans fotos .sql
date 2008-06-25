create PROCEDURE dbo.Transaccion_CrearTransFoto 
(
	@IdPropiedad int,
	@IdTipoTrans int,
	@Fecha datetime,
	@IdFoto int
)

AS

declare @id int

	
insert into Transaccion values (@IdTipoTrans, @Fecha, 1)
set @id = @@IDENTITY
insert into TransaccionesFoto values (@id, @IdFoto, @IdPropiedad)


select @id



;


create PROCEDURE dbo.Transacciones_RecuperarTransaccionesPropiedadesFotoPendientes 

AS


SELECT        Transaccion.IdTransaccion, Transaccion.TipoTransaccion, Transaccion.Fecha, TransaccionesFoto.IdFoto, TransaccionesFoto.IdPropiedad
FROM            Transaccion INNER JOIN
                         TransaccionesFoto ON Transaccion.IdTransaccion = TransaccionesFoto.IdTransaccion
WHERE        (Transaccion.Activa = 1)

;

create PROCEDURE dbo.Propiedades_RecuperarFoto
(
	@IdFoto int
)

AS

SELECT        IdFoto, Foto, Descripcion, EsFachada
FROM            GaleriaFotos
WHERE        (IdFoto = @IdFoto)