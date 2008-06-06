
ALTER PROCEDURE [dbo].[Pagos_RecuperarPorContrato] 
	
	(
	@IdContrato int 
	)
	
AS
SELECT [IdPago]
      ,[IdContrato]
      ,[Importe]
      ,[IdMoneda]
      ,[Anulado]
	  ,[MesCancelado]
	  ,[FechaPago]	
	  ,[FechaAlta]
	  ,[AnioPagado]
  FROM [dbo].[Pagos]
where IdContrato = @IdContrato and Anulado = 0
order by AnioPagado, MesCancelado asc

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON


go

ALTER PROCEDURE [dbo].[ValoresRenta_RecuperarPorContrato]
	
	(
		@IdContrato int
	)
	
AS
SELECT [IdValorRenta]
      ,[IdContrato]
      ,[IdMoneda]
      ,[Importe]
      ,[AnioDesde]
      ,[AnioHasta]
      ,[MesDesde]
      ,[MesHasta]
  FROM [dbo].[ValoresRenta]
WHERE IdContrato = @IdContrato
order by AnioDesde, MesDesde asc