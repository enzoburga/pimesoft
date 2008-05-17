CREATE PROCEDURE dbo.Propiedades_RecuperarVisitas 
(
	@IdPropiedad int
)
AS



SELECT        IdVisita, TimpoAlarma, FechaHora, Realizada, Visita, Telefono, Comentario, ConAlarma, IdPropiedad
FROM            VisitasPropiedad
WHERE        (IdPropiedad = @IdPropiedad)

;

