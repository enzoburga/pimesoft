USE [InmobiliariaDb]
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_RecuperarPublicaciones]    Fecha de la secuencia de comandos: 05/20/2008 19:05:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Propiedades_RecuperarPublicaciones] 
(
	@IdPropiedad int
)
AS



SELECT        IdPublicacion, IdPropiedad, Fecha, Medio, Detalles, IdMoneda, Importe
FROM            Publicaciones
WHERE        (IdPropiedad = @IdPropiedad)