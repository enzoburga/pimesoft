create PROCEDURE dbo.Propiedades_GuardarFoto 
(
	@IdPropiedad int,
	@EsFachada bit,
	@Descripcion nvarchar(50),
	@Foto image
)

AS

insert into GaleriaFotos values (@IdPropiedad,@Foto,@EsFachada,@Descripcion)


select @@identity
GO
create PROCEDURE dbo.Propiedades_EliminarFoto 
(
	@IdFoto int
)

AS

delete from GaleriaFotos where idfoto = @IdFoto


select @@rowcount
GO

create PROCEDURE dbo.Propiedades_RecuperarGaleria 
(
	@IdPropiedad int
)

AS

SELECT        IdFoto, Foto, Descripcion, EsFachada
FROM            GaleriaFotos
WHERE        (IdPropiedad = @IdPropiedad)