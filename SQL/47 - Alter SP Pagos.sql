set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

ALTER PROCEDURE [dbo].[Pago_Guardar]
	
	(
		@Anulado bit, 
		@FechaPago datetime, 
		@IdContrato int, 
		@Importe decimal(18,0), 
		@IdMoneda int, 
		@MesCancelado int,
		@FechaAlta datetime,
		@AnioPagado int
	)
	
AS
INSERT INTO[dbo].[Pagos]
           ([IdContrato]
           ,[Importe]
           ,[IdMoneda]
           ,[Anulado]
           ,[FechaPago]
           ,[MesCancelado]
           ,[FechaAlta]
		   ,[AnioPagado])
     VALUES
           (@IdContrato
           ,@Importe
           ,@IdMoneda
           ,@Anulado
           ,@FechaPago
           ,@MesCancelado
           ,@FechaAlta
			, @AnioPagado)
           
select @@identity

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

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

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

ALTER PROCEDURE [dbo].[Pago_Actualizar]
	
	(
		@IdPago int,
		@Anulado bit, 
		@FechaPago datetime, 
		@IdContrato int, 
		@Importe decimal(18,0), 
		@IdMoneda int, 
		@MesCancelado int,
		@FechaAlta datetime,
		@AnioPagado int
		
	)
	
AS
UPDATE [dbo].[Pagos]
   SET [IdContrato] = @IdContrato
      ,[Importe] = @Importe
      ,[IdMoneda] = @IdMoneda
      ,[Anulado] = @Anulado
      ,[FechaPago] = @FechaPago
      ,[MesCancelado] = @MesCancelado
      ,[FechaAlta] = @FechaAlta
	  ,[AnioPagado] = @AnioPagado
 WHERE IdPago = @IdPago
 
 select @@rowcount
