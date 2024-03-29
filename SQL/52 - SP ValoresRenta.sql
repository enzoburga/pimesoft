GO
/****** Object:  StoredProcedure [dbo].[ValorRenta_Actualizar]    Script Date: 05/03/2008 03:14:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ValorRenta_Actualizar]
	
	(
		@IdValorRenta int,
		@Importe decimal(18,0), 
		@IdMoneda int, 
		@MesDesde int, 
		@AnioDesde int, 
		@MesHasta int, 
		@AnioHasta int
	)
	
AS
UPDATE [dbo].[ValoresRenta]
   SET 
       [IdMoneda] = @IdMoneda
      ,[Importe] = @Importe
      ,[AnioDesde] = @AnioDesde
      ,[AnioHasta] = @AnioHasta
      ,[MesDesde] = @MesDesde
      ,[MesHasta] = @MesHasta
WHERE IdValorRenta = @IdValorRenta
          
          select @@rowcount

GO
/****** Object:  StoredProcedure [dbo].[ValorRenta_Eliminar]    Script Date: 05/03/2008 03:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ValorRenta_Eliminar]
	
	(
		@IdValorRenta int
	)
	
AS
delete [dbo].[ValoresRenta]
WHERE IdValorRenta = @IdValorRenta
          
          select @@rowcount

GO
/****** Object:  StoredProcedure [dbo].[ValorRenta_Guardar]    Script Date: 05/03/2008 03:14:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ValorRenta_Guardar] 
	
	(
		@IdContrato int, 
		@Importe decimal(18,0), 
		@IdMoneda int, 
		@MesDesde int, 
		@AnioDesde int, 
		@MesHasta int, 
		@AnioHasta int
	)
	
AS
INSERT INTO [dbo].[ValoresRenta]
           (
            [IdContrato]
           ,[IdMoneda]
           ,[Importe]
           ,[AnioDesde]
           ,[AnioHasta]
           ,[MesDesde]
           ,[MesHasta])
     VALUES
           (
           @IdContrato
           ,@IdMoneda
           ,@Importe
           ,@AnioDesde
           ,@AnioHasta
           ,@MesDesde
           ,@MesHasta)
          
          select @@identity
GO
/****** Object:  StoredProcedure [dbo].[ValoresRenta_RecuperarPorContrato]    Script Date: 05/03/2008 03:14:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[ValoresRenta_RecuperarPorContrato]
	
	(
		@IdContrato int
	)
	
AS
SELECT [IdValorRenta]
      ,[IdContrato]
      ,[IdMoneda]
      ,[Importe]
      ,[AnioDesde]
      ,[AnioHasta]
      ,[MesDesde]
      ,[MesHasta]
  FROM [dbo].[ValoresRenta]
WHERE IdContrato = @IdContrato