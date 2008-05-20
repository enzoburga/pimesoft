set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

ALTER PROCEDURE [dbo].[Pedidos_RecuperarTodos] 

AS
SELECT p.[IdPedido]
      ,p.[CantidadAmbientesFinal]
      ,p.[CantidadAmbientesInicial]
      ,p.[IdCategoria]
      ,p.[IdCliente]
      ,p.[Disposicion]
      ,p.[EnumEstado]
      ,p.[EsAptoProfesional]
      ,p.[IdEstadoPropiedad]
      ,p.[EstadoPropiedad]
      ,p.[MetrosConstruiblesFinal]
      ,p.[MetrosConstruiblesInicial]
      ,p.[MetrosCubiertosFinal]
      ,p.[MetrosCubiertosInicial]
      ,p.[MetrosTerrenoFinal]
      ,p.[MetrosTerrenoInicial]
      ,p.[IdTipoPropiedad]
      ,p.[TipoZona]
      ,p.[IdBarrio]
      ,p.[IdLocalidad]
      ,p.[IdPais]
      ,p.[IdProvincia]
      ,p.[ImporteFinal]
      ,p.[ImporteInicial]
      ,p.[IdMoneda]
	  ,p.Observaciones
	  ,p.Activo
	  ,cat.Nombre as NombreCategoria
  FROM Pedidos p, CategoriasPropiedad cat
where cat.IdCategoria =* p.IdCategoria


/********************************************************************/

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

ALTER PROCEDURE [dbo].[Pedidos_RecuperarPorNombreContacto] 
	(
	@Cadena nvarchar(50)
	)
AS
SELECT p.[IdPedido]
      ,p.[CantidadAmbientesFinal]
      ,p.[CantidadAmbientesInicial]
      ,p.[IdCategoria]
      ,p.[IdCliente]
      ,p.[Disposicion]
      ,p.[EnumEstado]
      ,p.[EsAptoProfesional]
      ,p.[IdEstadoPropiedad]
      ,p.[EstadoPropiedad]
      ,p.[MetrosConstruiblesFinal]
      ,p.[MetrosConstruiblesInicial]
      ,p.[MetrosCubiertosFinal]
      ,p.[MetrosCubiertosInicial]
      ,p.[MetrosTerrenoFinal]
      ,p.[MetrosTerrenoInicial]
      ,p.[IdTipoPropiedad]
      ,p.[TipoZona]
      ,p.[IdBarrio]
      ,p.[IdLocalidad]
      ,p.[IdPais]
      ,p.[IdProvincia]
      ,p.[ImporteFinal]
      ,p.[ImporteInicial]
      ,p.[IdMoneda]
	  ,p.Observaciones
	  ,p.Activo
      ,cat.Nombre as NombreCategoria
  FROM Pedidos p, ClientesPedido cp , Clientes c, CategoriasPropiedad cat
  WHERE
  	cp.IdCliente = c.IdCliente and
	(c.Nombres Like '%'+@Cadena+'%' or c.Apellido like '%'+@Cadena+'%') and
	c.IdCliente = p.IdCliente and
	cat.IdCategoria =* p.IdCategoria


/************************************************************************************/

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

ALTER PROCEDURE [dbo].[Pedido_Guardar] 
	
	(
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
					@Activo bit
	)
	
AS
INSERT INTO [dbo].[Pedidos]
           ([CantidadAmbientesFinal]
           ,[CantidadAmbientesInicial]
           ,[IdCategoria]
           ,[IdCliente]
           ,[Disposicion]
           ,[EnumEstado]
           ,[EsAptoProfesional]
           ,[IdEstadoPropiedad]
           ,[EstadoPropiedad]
           ,[MetrosConstruiblesFinal]
           ,[MetrosConstruiblesInicial]
           ,[MetrosCubiertosFinal]
           ,[MetrosCubiertosInicial]
           ,[MetrosTerrenoFinal]
           ,[MetrosTerrenoInicial]
           ,[IdTipoPropiedad]
           ,[TipoZona]
           ,[IdBarrio]
           ,[IdLocalidad]
           ,[IdPais]
           ,[IdProvincia]
           ,[ImporteFinal]
           ,[ImporteInicial]
           ,[IdMoneda]
		   ,Observaciones
		   ,Activo	)
     VALUES
           (@CantidadAmbientesFinal,
            @CantidadAmbientesInicial,
            @IdCategoria,
            @IdCliente,
            @Disposicion,
            @EnumEstado,
            @EsAptoProfesional,
            @IdEstadoPropiedad,
            @EstadoPropiedad,
            @MetrosConstruiblesFinal,
            @MetrosConstruiblesInicial,
            @MetrosCubiertosFinal ,
            @MetrosCubiertosInicial,
            @MetrosTerrenoFinal ,
            @MetrosTerrenoInicial,
            @IdTipoPropiedad,
            @TipoZona,
            @IdBarrio,
            @IdLocalidad,
            @IdPais,
            @IdProvincia,
            @ImporteFinal,
            @ImporteInicial,
            @IdMoneda,
			@Observaciones,
			@Activo)

select @@identity

/**************************************************************************************/

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
					@Activo bit
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
 WHERE IdPedido = @IdPedido
 
 select @@rowcount
