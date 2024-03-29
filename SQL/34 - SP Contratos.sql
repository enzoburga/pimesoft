
GO
/****** Object:  StoredProcedure [dbo].[Contrato_Actualizar]    Script Date: 04/30/2008 00:21:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Contrato_Actualizar]
	(
			@IdContrato int
		   ,@IdInquilino int
           ,@IdPropiedad int
           ,@FechaInicio datetime
           ,@FechaVencimiento datetime
           ,@MontoCuota decimal(18,0)
           ,@IdMonedaMonto int
           ,@MontoDeposito decimal(18,0)
           ,@IdMonedaDeposito int
           ,@DiaVencimientoCuota tinyint
           ,@IdContratoAnterior int
           ,@FechaCancelacion datetime	
           ,@Observaciones nvarchar (400)
	)
	
AS
	/* SET NOCOUNT ON */ 
	RETURN
UPDATE [dbo].[Contratos]
SET

           [IdInquilino]= @IdInquilino 
           ,[IdPropiedad] = @IdPropiedad 
           ,[FechaInicio] = @FechaInicio 
           ,[FechaVencimiento] = @FechaVencimiento 
           ,[MontoCuota] = @MontoCuota 
           ,[IdMonedaMonto] = @IdMonedaMonto 
           ,[MontoDeposito] = @MontoDeposito 
           ,[IdMonedaDeposito] = @IdMonedaDeposito 
           ,[DiaVencimientoCuota] = @DiaVencimientoCuota 
           ,[IdContratoAnterior] = @IdContratoAnterior 
           ,[FechaCancelacion] = @FechaCancelacion 
           ,[Observaciones] = @Observaciones 
           WHERE IdContrato =@IdContrato

           
           select @@ROWCOUNT


GO
/****** Object:  StoredProcedure [dbo].[Contrato_Guardar]    Script Date: 04/30/2008 00:21:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Contrato_Guardar]	
	(
			@IdInquilino int
           ,@IdPropiedad int
           ,@FechaInicio datetime
           ,@FechaVencimiento datetime
           ,@MontoCuota decimal(18,0)
           ,@IdMonedaMonto int
           ,@MontoDeposito decimal(18,0)
           ,@IdMonedaDeposito int
           ,@DiaVencimientoCuota tinyint
           ,@IdContratoAnterior int
           ,@FechaCancelacion datetime	
           ,@Observaciones nvarchar (400)
	)
	
AS

INSERT INTO [dbo].[Contratos]
           ([IdInquilino]
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
           ,[Observaciones])
     VALUES
           (
            @IdInquilino 
           ,@IdPropiedad 
           ,@FechaInicio 
           ,@FechaVencimiento 
           ,@MontoCuota 
           ,@IdMonedaMonto 
           ,@MontoDeposito 
           ,@IdMonedaDeposito 
           ,@DiaVencimientoCuota 
           ,@IdContratoAnterior 
           ,@FechaCancelacion 	
           ,@Observaciones )
           
           select @@IDENTITY
