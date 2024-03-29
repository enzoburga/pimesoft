
/****** Object:  StoredProcedure [dbo].[Carteles_RecuperarTodos]    Script Date: 05/25/2008 23:21:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Carteles_RecuperarTodos] 

AS
SELECT [IdCartel]
      ,[IdPropiedad]
      ,[Activo]
      ,[Ancho]
      ,[Alto]
      ,[FechaAlta]
      ,[FechaVencimiento]
      ,[TipoCartel]
  FROM [dbo].[Carteles]

/****** Object:  StoredProcedure [dbo].[Carteles_RecuperarPorPropiedad]    Script Date: 05/25/2008 23:21:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Carteles_RecuperarPorPropiedad] 
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
  FROM [dbo].[Carteles]
  where 
	IdPropiedad = @IdPropiedad

/****** Object:  StoredProcedure [dbo].[Carteles_Guardar]    Script Date: 05/25/2008 23:21:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Carteles_Guardar] 
(
	@Activo bit,
	@Alto int,
	@Ancho int,
	@FechaAlta datetime,
	@FechaVencimiento datetime,
	@IdPropiedad int,
	@TipoCartel nvarchar(50)

)
AS
INSERT INTO [dbo].[Carteles]
           ([IdPropiedad]
           ,[Activo]
           ,[Ancho]
           ,[Alto]
           ,[FechaAlta]
           ,[FechaVencimiento]
           ,[TipoCartel])
     VALUES
           (@IdPropiedad
           ,@Activo
           ,@Ancho
           ,@Alto
           ,@FechaAlta
           ,@FechaVencimiento
           ,@TipoCartel)
           
           select @@identity
/****** Object:  StoredProcedure [dbo].[Carteles_Actualizar]    Script Date: 05/25/2008 23:20:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Carteles_Actualizar] 
(
	@IdCartel int,
	@Activo bit,
	@Alto int,
	@Ancho int,
	@FechaAlta datetime,
	@FechaVencimiento datetime,
	@IdPropiedad int,
	@TipoCartel nvarchar(50)
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
 WHERE IdCartel = @IdCartel
 
     select @@rowcount
 
