CREATE PROCEDURE dbo.Propiedades_RecuperarPublicaciones 
(
	@IdPropiedad int
)
AS



SELECT        IdPublicacion, IdPropiedad, Fecha, Medio, Detalles, IdMoneda, Importe
FROM            Publicaciones
WHERE        (IdPublicacion = @IdPropiedad)

;

CREATE PROCEDURE dbo.Propiedades_CrearPublicacion
(
	@IdPropiedad int, 
	@Fecha datetime, 
	@Medio nvarchar(50), 
	@Detalles text, 
	@IdMoneda int, 
	@Importe decimal
)
AS


insert into Publicaciones values (@IdPropiedad, @Fecha, @Medio, @Detalles, @IdMoneda, @Importe)

select @@identity

;

create PROCEDURE dbo.Propiedades_ActualizarPublicacion
(
	@IdPublicacion int, 
	@Fecha datetime, 
	@Medio nvarchar(50), 
	@Detalles text, 
	@IdMoneda int, 
	@Importe decimal
)
AS


update Publicaciones set Fecha=@Fecha, medio=@Medio, detalles=@Detalles, idmoneda=@IdMoneda, importe=@Importe
where idpublicacion = @IdPublicacion

select @@rowcount

;


CREATE PROCEDURE dbo.Propiedades_EliminarPublicacion 
(
	@IdPublicacion int
	)
AS

delete from publicaciones where idpublicacion = @IdPublicacion
select @@rowcount