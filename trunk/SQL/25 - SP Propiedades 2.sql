ALTER PROCEDURE dbo.Propiedades_MedidadasAmbiente_Insertar 
(
	@Ancho decimal,
	@Largo decimal,
	@Ambiente nvarchar(200),
	@IdTipoPiso int,
	@IdPropiedad int
)
AS


insert into MedidasAmbientesPropiedad values (@Ancho,@Largo,@Ambiente,@IdTipoPiso,@IdPropiedad)

select  @@identity

;

ALTER PROCEDURE dbo.Propiedades_MedidadasAmbiente_Eliminar
(
	@IdMedida int
)
AS

delete from MedidasAmbientesPropiedad where idambiente=@IdMedida


select  @@rowcount

;

ALTER PROCEDURE dbo.MedidasAmbientes_RecuperarPorPropiedad 
(
	@IdPropiedad int
)

AS


SELECT      IdAmbiente,MedidasAmbientesPropiedad.Ancho, MedidasAmbientesPropiedad.Largo, MedidasAmbientesPropiedad.Ambiente, TiposDePiso.IdTipoPiso, 
                      TiposDePiso.Nombre
FROM         MedidasAmbientesPropiedad INNER JOIN
                      TiposDePiso ON MedidasAmbientesPropiedad.IdTipoPiso = TiposDePiso.IdTipoPiso
                      Where IdPropiedad = @IdPropiedad