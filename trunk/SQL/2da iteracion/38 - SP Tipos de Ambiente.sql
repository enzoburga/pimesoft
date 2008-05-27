CREATE PROCEDURE dbo.Propiedades_TiposDeAmbiente_RecuperarTodos 

AS



SELECT        IdTipoambiente, Nombre, Codigo
FROM            TiposAmbiente

;


ALTER PROCEDURE dbo.Propiedades_MedidadasAmbiente_Insertar 
(
	@Ancho decimal(18,2),
	@Largo decimal(18,2),
	@Ambiente nvarchar(200),
	@IdTipoPiso int,
	@IdPropiedad int,
	@IdTipoAmbiente int
)
AS


insert into MedidasAmbientesPropiedad values (@Ancho,@Largo,@Ambiente,@IdTipoPiso,@IdPropiedad, @IdTipoAmbiente)

select  @@identity



;

ALTER PROCEDURE dbo.MedidasAmbientes_RecuperarPorPropiedad 
(
	@IdPropiedad int
)

AS


SELECT        MedidasAmbientesPropiedad.IdAmbiente, MedidasAmbientesPropiedad.Ancho, MedidasAmbientesPropiedad.Largo, MedidasAmbientesPropiedad.Ambiente, 
                         TiposDePiso.IdTipoPiso, TiposDePiso.Nombre, TiposAmbiente.IdTipoambiente, TiposAmbiente.Nombre AS NombreTipoAmbiente, 
                         TiposAmbiente.Codigo
FROM            MedidasAmbientesPropiedad INNER JOIN
                         TiposDePiso ON MedidasAmbientesPropiedad.IdTipoPiso = TiposDePiso.IdTipoPiso LEFT OUTER JOIN
                         TiposAmbiente ON MedidasAmbientesPropiedad.IdTipoAmbiente = TiposAmbiente.IdTipoambiente
WHERE        (MedidasAmbientesPropiedad.IdPropiedad = @IdPropiedad)

