ALTER PROCEDURE dbo.Propiedades_RecuperarTasaciones
(
	@IdPropiedad int
)
AS

SELECT        IdTasacion, IdPropiedad, Fecha, ImporteValorReal, ImporteValorPublicacion, IdMonedaValorReal, IdMonedaValorPublicacion, Comentarios
FROM            Tasaciones
WHERE        (IdPropiedad = @IdPropiedad)

;

CREATE PROCEDURE dbo.Propiedades_CrearTasacion 
(
	@IdPropiedad int,
	@Fecha datetime,
	@ImporteReal decimal,
	@ImportePublicacion decimal,
	@IdMonedaReal int,
	@IdMonedaPublicacion int,
	@Comentarios text

)
AS

insert into Tasaciones values (@IdPropiedad,@Fecha,@ImporteReal,@ImportePublicacion,@IdMonedaReal,@IdMonedaPublicacion,@Comentarios)

select @@identity

;

CREATE PROCEDURE dbo.Propiedades_ModificarTasacion 
(
	@IdTasacion int,
	@Fecha datetime,
	@ImporteReal decimal,
	@ImportePublicacion decimal,
	@IdMonedaReal int,
	@IdMonedaPublicacion int,
	@Comentarios text

)
AS


update Tasaciones set 
Fecha=@Fecha,
ImporteValorReal=@ImporteReal,
ImporteValorPublicacion=@ImportePublicacion,
IdMonedaValorReal=@IdMonedaReal,
IdMonedaValorPublicacion=@IdMonedaPublicacion,
Comentarios=@Comentarios
where idtasacion = @IdTasacion

select @@rowcount

;

create PROCEDURE dbo.Propiedades_EliminarTasacion 
(
	@IdTasacion int
)
AS


delete from tasaciones where idtasacion=@idtasacion

