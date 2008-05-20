USE [InmobiliariaDb]
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_RecuperarVisitas]    Fecha de la secuencia de comandos: 05/20/2008 00:27:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Propiedades_RecuperarVisitas] 
(
	@IdPropiedad int
)
AS



SELECT        IdVisita, TimpoAlarma, FechaHora, Realizada, Visita, Telefono, Comentario, ConAlarma, IdPropiedad
FROM            VisitasPropiedad
WHERE        (IdPropiedad = @IdPropiedad)
order by FechaHora