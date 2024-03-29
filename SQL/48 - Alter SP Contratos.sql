set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go


ALTER PROCEDURE [dbo].[Contrato_Guardar]	
	(
			@IdInquilino int
           ,@IdPropiedad int
           ,@FechaInicio datetime
           ,@FechaVencimiento datetime
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
           ,@MontoDeposito 
           ,@IdMonedaDeposito 
           ,@DiaVencimientoCuota 
           ,@IdContratoAnterior 
           ,@FechaCancelacion 	
           ,@Observaciones 
			, @Vigente)
           
           select @@IDENTITY


set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go


ALTER PROCEDURE [dbo].[Contratos_RecuperarPorAdmAlquiler] 
	(
	@IdAdmAlquiler int
	)
AS
SELECT [IdContrato]
      ,[IdInquilino]
      ,[IdPropiedad]
      ,[FechaInicio]
      ,[FechaVencimiento]
      ,[MontoDeposito]
      ,[IdMonedaDeposito]
      ,[DiaVencimientoCuota]
      ,[IdContratoAnterior]
      ,[FechaCancelacion]
      ,[Observaciones]
      ,[Vigente]
  FROM [dbo].[Contratos]
where IdPropiedad = @IdAdmAlquiler


set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go


ALTER PROCEDURE [dbo].[Contrato_Actualizar]
	(
			@IdContrato int
		   ,@IdInquilino int
           ,@IdPropiedad int
           ,@FechaInicio datetime
           ,@FechaVencimiento datetime
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
           ,[MontoDeposito] = @MontoDeposito 
           ,[IdMonedaDeposito] = @IdMonedaDeposito 
           ,[DiaVencimientoCuota] = @DiaVencimientoCuota 
           ,[IdContratoAnterior] = @IdContratoAnterior 
           ,[FechaCancelacion] = @FechaCancelacion 
           ,[Observaciones] = @Observaciones 
			,Vigente = @Vigente
           WHERE IdContrato =@IdContrato

           
           select @@ROWCOUNT


