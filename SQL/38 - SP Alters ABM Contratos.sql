
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Contrato_Actualizar]
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
			,@Vigente bit
	)
	
AS
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
			,Vigente = @Vigente
           WHERE IdContrato =@IdContrato

           
           select @@ROWCOUNT
GO

SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO




/*******************************************************************/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Contrato_Guardar]	
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
			, @Vigente bit
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
           ,[Observaciones]
			, Vigente)
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
           ,@Observaciones 
			, @Vigente)
           
           select @@IDENTITY
GO

SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO

