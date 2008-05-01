
GO
/****** Object:  StoredProcedure [dbo].[Contratos_RecuperarPorAdmAlquiler]    Script Date: 05/01/2008 18:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Contratos_RecuperarPorAdmAlquiler] 
	(
	@IdAdmAlquiler int
	)
AS
SELECT [IdContrato]
      ,[IdInquilino]
      ,[IdPropiedad]
      ,[FechaInicio]
      ,[FechaVencimiento]
      ,[MontoCuota]
      ,[IdMonedaMonto]
      ,[MontoDeposito]
      ,[IdMonedaDeposito]
      ,[DiaVencimientoCuota]
      ,[IdContratoAnterior]
      ,[FechaCancelacion]
      ,[Observaciones]
      ,[Vigente]
  FROM [dbo].[Contratos]
where IdPropiedad = @IdAdmAlquiler


GO
/****** Object:  StoredProcedure [dbo].[Pagos_RecuperarPorContrato]    Script Date: 05/01/2008 18:55:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pagos_RecuperarPorContrato] 
	
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
  FROM [dbo].[Pagos]
where IdContrato = @IdContrato and Anulado = 0


GO
/****** Object:  StoredProcedure [dbo].[Pago_Guardar]    Script Date: 05/01/2008 18:55:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pago_Guardar]
	
	(
		@Anulado bit, 
		@FechaPago datetime, 
		@IdContrato int, 
		@Importe decimal(18,0), 
		@IdMoneda int, 
		@MesCancelado int,
		@FechaAlta datetime
	)
	
AS
INSERT INTO[dbo].[Pagos]
           ([IdContrato]
           ,[Importe]
           ,[IdMoneda]
           ,[Anulado]
           ,[FechaPago]
           ,[MesCancelado]
           ,[FechaAlta])
     VALUES
           (@IdContrato
           ,@Importe
           ,@IdMoneda
           ,@Anulado
           ,@FechaPago
           ,@MesCancelado
           ,@FechaAlta)
           
select @@identity


GO
/****** Object:  StoredProcedure [dbo].[Pago_Anular]    Script Date: 05/01/2008 18:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pago_Anular] 

	(
	@IdPago int
	)
AS
UPDATE Pagos
Set Anulado = 1
WHERE IdPago = @IdPago


GO
/****** Object:  StoredProcedure [dbo].[Pago_Actualizar]    Script Date: 05/01/2008 18:55:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pago_Actualizar]
	
	(
		@IdPago int,
		@Anulado bit, 
		@FechaPago datetime, 
		@IdContrato int, 
		@Importe decimal(18,0), 
		@IdMoneda int, 
		@MesCancelado int,
		@FechaAlta datetime
		
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
 WHERE IdPago = @IdPago
 
 select @@rowcount

