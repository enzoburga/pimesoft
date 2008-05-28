set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go


ALTER PROCEDURE [dbo].[Pedido_Actualizar] 
	(
					@IdPedido int,
					@CantidadAmbientesFinal decimal(18,1),
                    @CantidadAmbientesInicial decimal(18,1),
                    @IdCategoria int,
                    @IdCliente int ,
                    @Disposicion int,
                    @EnumEstado int,
                    @EsAptoProfesional bit,
                    @IdEstadoPropiedad int,
                    @EstadoPropiedad nvarchar(50),
                    @MetrosConstruiblesFinal int,
                    @MetrosConstruiblesInicial int,
                    @MetrosCubiertosFinal int, 
                    @MetrosCubiertosInicial int,
                    @MetrosTerrenoFinal int, 
                    @MetrosTerrenoInicial int,
                    @IdTipoPropiedad int,
                    @TipoZona int,
                    @IdBarrio int,
                    @IdLocalidad int,
                    @IdPais int,
                    @IdProvincia int,
                    @ImporteFinal int,
                    @ImporteInicial int,
                    @IdMoneda int,
					@Observaciones nvarchar(500),
					@Activo bit,
					@FechaAlta datetime
	)
AS
UPDATE [dbo].[Pedidos]
   SET [CantidadAmbientesFinal] = @CantidadAmbientesFinal
      ,[CantidadAmbientesInicial] = @CantidadAmbientesInicial
      ,[IdCategoria] = @IdCategoria
      ,[IdCliente] = @IdCliente
      ,[Disposicion] =  @Disposicion
      ,[EnumEstado] = @EnumEstado
      ,[EsAptoProfesional] = @EsAptoProfesional
      ,[IdEstadoPropiedad] = @IdEstadoPropiedad
      ,[EstadoPropiedad] = @EstadoPropiedad
      ,[MetrosConstruiblesFinal] = @MetrosConstruiblesFinal
      ,[MetrosConstruiblesInicial] = @MetrosConstruiblesInicial
      ,[MetrosCubiertosFinal] = @MetrosCubiertosFinal 
      ,[MetrosCubiertosInicial] = @MetrosCubiertosInicial
      ,[MetrosTerrenoFinal] = @MetrosTerrenoFinal 
      ,[MetrosTerrenoInicial] = @MetrosTerrenoInicial
      ,[IdTipoPropiedad] = @IdTipoPropiedad
      ,[TipoZona] = @TipoZona
      ,[IdBarrio] = @IdBarrio
      ,[IdLocalidad] = @IdLocalidad
      ,[IdPais] = @IdPais
      ,[IdProvincia] = @IdProvincia
      ,[ImporteFinal] = @ImporteFinal
      ,[ImporteInicial] = @ImporteInicial
      ,[IdMoneda] = @IdMoneda
	  ,[Observaciones] = @Observaciones
	  ,[Activo] = @Activo
	  ,[FechaAlta] = @FechaAlta
 WHERE IdPedido = @IdPedido
 
 select @@rowcount

