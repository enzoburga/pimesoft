
/****** Object:  StoredProcedure [dbo].[UbicacionesCartel_RecuperarTodas]    Script Date: 05/26/2008 22:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UbicacionesCartel_RecuperarTodas] 
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
select IdUbicacionCartel , Descripcion from UbicacionesCartel


/****************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Carteles_RecuperarTodos] 

AS
SELECT [IdCartel]
      ,[IdPropiedad]
      ,[Activo]
      ,[Ancho]
      ,[Alto]
      ,[FechaAlta]
      ,[FechaVencimiento]
      ,[TipoCartel]
      ,IdUbicacionCartel
  FROM [dbo].[Carteles]
GO

SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO



/********************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Carteles_RecuperarPorPropiedad] 
(
	@IdPropiedad int
)
AS
SELECT [IdCartel]
      ,[IdPropiedad]
      ,[Activo]
      ,[Ancho]
      ,[Alto]
      ,[FechaAlta]
      ,[FechaVencimiento]
      ,[TipoCartel]
      ,IdUbicacionCartel
  FROM [dbo].[Carteles]
  where 
	IdPropiedad = @IdPropiedad
GO

SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO


/****** Object:  StoredProcedure [dbo].[Carteles_Guardar]    Script Date: 05/26/2008 22:33:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter PROCEDURE [dbo].[Carteles_Guardar] 
(
	@Activo bit,
	@Alto int,
	@Ancho int,
	@FechaAlta datetime,
	@FechaVencimiento datetime,
	@IdPropiedad int,
	@TipoCartel nvarchar(50),
	@IdUbicacionCartel int

)
AS
INSERT INTO [dbo].[Carteles]
           ([IdPropiedad]
           ,[Activo]
           ,[Ancho]
           ,[Alto]
           ,[FechaAlta]
           ,[FechaVencimiento]
           ,[TipoCartel]
           ,[IdUbicacionCartel])
     VALUES
           (@IdPropiedad
           ,@Activo
           ,@Ancho
           ,@Alto
           ,@FechaAlta
           ,@FechaVencimiento
           ,@TipoCartel
           ,@IdUbicacionCartel)
           
           select @@identity
/****** Object:  StoredProcedure [dbo].[Carteles_Actualizar]    Script Date: 05/26/2008 22:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter PROCEDURE [dbo].[Carteles_Actualizar] 
(
	@IdCartel int,
	@Activo bit,
	@Alto int,
	@Ancho int,
	@FechaAlta datetime,
	@FechaVencimiento datetime,
	@IdPropiedad int,
	@TipoCartel nvarchar(50),
	@IdUbicacionCartel int
	
)
AS


UPDATE [dbo].[Carteles]
   SET [IdPropiedad] = @IdPropiedad
      ,[Activo] = @Activo
      ,[Ancho] = @Ancho
      ,[Alto] = @Alto
      ,[FechaAlta] = @FechaAlta
      ,[FechaVencimiento] = @FechaVencimiento
      ,[TipoCartel] = @TipoCartel
      ,[IdUbicacionCartel] = @IdUbicacionCartel
 WHERE IdCartel = @IdCartel
 
     select @@rowcount
 
