
GO
/****** Object:  StoredProcedure [dbo].[AdmAlquiler_Actualizar]    Script Date: 04/30/2008 00:19:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AdmAlquiler_Actualizar]
	(
	@IdPropiedad int,
	@IdContacto int
	)
AS
UPDATE [dbo].[AdmAlquileres]
SET
[IdContacto] = @IdContacto
where IdPropiedad = @IdPropiedad

select @@rowcount

/*************************************************************************************/

GO
/****** Object:  StoredProcedure [dbo].[AdmAlquiler_Guardar]    Script Date: 04/30/2008 00:19:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[AdmAlquiler_Guardar] 

	(
	@IdPropiedad int,
	@IdContacto int
	)
AS
INSERT INTO [dbo].[AdmAlquileres]
           ([IdPropiedad]
           ,[IdContacto])
     VALUES
           (	@IdPropiedad ,
				@IdContacto )

select @@rowcount

/*************************************************************************************/

GO
/****** Object:  StoredProcedure [dbo].[AdmAlquileres_RecuperarPorNombreInquilino]    Script Date: 04/30/2008 00:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AdmAlquileres_RecuperarPorNombreInquilino]
	
	(
	@Cadena nvarchar(15)
	)
	
AS
select		
		co.[IdContrato]
		,co.[IdInquilino]
		,co.[IdPropiedad]
		,co.[FechaInicio]
		,co.[FechaVencimiento]
		,co.[MontoCuota]
		,co.[IdMonedaMonto]
		,co.[MontoDeposito]
		,co.[IdMonedaDeposito]
		,co.[DiaVencimientoCuota]
		,co.[IdContratoAnterior]
		,co.[FechaCancelacion]
		,co.[Observaciones]
		,aa.IdContacto
from Inquilinos i , Clientes c, Contratos co, AdmAlquileres aa
where 
	i.IdCliente = c.IdCliente and
	(c.Nombres Like '%'+@Cadena+'%' or c.Apellido like '%'+@Cadena+'%') and
	co.IdInquilino = i.IdCliente and
	aa.IdPropiedad = co.IdPropiedad
	
/*************************************************************************************/

GO
/****** Object:  StoredProcedure [dbo].[AdmAlquileres_RecuperarTodos]    Script Date: 04/30/2008 00:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AdmAlquileres_RecuperarTodos]

	
AS
select		
		co.[IdContrato]
		,co.[IdInquilino]
		,co.[IdPropiedad]
		,co.[FechaInicio]
		,co.[FechaVencimiento]
		,co.[MontoCuota]
		,co.[IdMonedaMonto]
		,co.[MontoDeposito]
		,co.[IdMonedaDeposito]
		,co.[DiaVencimientoCuota]
		,co.[IdContratoAnterior]
		,co.[FechaCancelacion]
		,co.[Observaciones]
		,aa.IdContacto
from Contratos co, AdmAlquileres aa
where 
	aa.IdPropiedad = co.IdPropiedad
	

