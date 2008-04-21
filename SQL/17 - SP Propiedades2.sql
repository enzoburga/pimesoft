ALTER PROCEDURE dbo.MedidasAmbientes_RecuperarPorPropiedad 
(
	@IdPropiedad int
)

AS


SELECT     MedidasAmbientesPropiedad.Ancho, MedidasAmbientesPropiedad.Largo, MedidasAmbientesPropiedad.Ambiente, TiposDePiso.IdTipoPiso, 
                      TiposDePiso.Nombre
FROM         MedidasAmbientesPropiedad INNER JOIN
                      TiposDePiso ON MedidasAmbientesPropiedad.IdTipoPiso = TiposDePiso.IdTipoPiso

;
