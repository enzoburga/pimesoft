
GO
/****** Object:  StoredProcedure [dbo].[Pedidos_RecuperarTodos]    Script Date: 05/19/2008 00:30:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pedidos_RecuperarTodos] 

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
	  ,cat.Nombre as NombreCategoria
  FROM Pedidos p, CategoriasPropiedad cat
where cat.IdCategoria =* p.IdCategoria
GO
/****** Object:  StoredProcedure [dbo].[Pedidos_RecuperarPorNombreContacto]    Script Date: 05/19/2008 00:30:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pedidos_RecuperarPorNombreContacto] 
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
      ,cat.Nombre as NombreCategoria
  FROM Pedidos p, ClientesPedido cp , Clientes c, CategoriasPropiedad cat
  WHERE
  	cp.IdCliente = c.IdCliente and
	(c.Nombres Like '%'+@Cadena+'%' or c.Apellido like '%'+@Cadena+'%') and
	c.IdCliente = p.IdCliente and
	cat.IdCategoria =* p.IdCategoria
GO
/****** Object:  StoredProcedure [dbo].[Pedido_Guardar]    Script Date: 05/19/2008 00:30:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pedido_Guardar] 
	
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
                    @IdMoneda int
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
           ,[IdMoneda])
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
            @IdMoneda)

select @@identity
GO
/****** Object:  StoredProcedure [dbo].[Pedido_Actualizar]    Script Date: 05/19/2008 00:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pedido_Actualizar] 
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
                    @IdMoneda int
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
 WHERE IdPedido = @IdPedido
 
 select @@rowcount