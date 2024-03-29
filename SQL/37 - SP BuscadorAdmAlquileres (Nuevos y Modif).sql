
GO
/****** Object:  StoredProcedure [dbo].[AdmAlquileres_RecuperarPorDireccion]    Script Date: 05/01/2008 00:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[AdmAlquileres_RecuperarPorDireccion]
(
	@Calle nvarchar(200),
	@Numero int
)
AS	
	
SELECT     
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
		,co.Vigente
		,aa.IdContacto
FROM
	Alquileres a,
	Propiedades p,
	Contratos co,
	AdmAlquileres aa
WHERE	
	p.IdPropiedad = a.IdPropiedad and
	p.Calle like  '%' + @Calle + '%' And p.NumeroPostal = @Numero and
	p.IdPropiedad = aa.IdPropiedad and
	co.IdPropiedad = p.IdPropiedad and
	co.Vigente = 1



GO
/****** Object:  StoredProcedure [dbo].[AdmAlquileres_RecuperarPorEstadoPropiedad]    Script Date: 05/01/2008 00:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[AdmAlquileres_RecuperarPorEstadoPropiedad]
(
	@IdEstadoPropiedad int
)
AS	
	
SELECT 
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
		,co.Vigente
		,aa.IdContacto
FROM  
	Propiedades p,
	Alquileres a,
	AdmAlquileres aa,
	Contratos co
WHERE
	p.IdPropiedad = a.IdPropiedad and
	p.IdEstadoPropiedad = @IdEstadoPropiedad and
	p.IdPropiedad = aa.IdPropiedad and
	co.IdPropiedad = p.IdPropiedad and
	co.Vigente = 1


GO
/****** Object:  StoredProcedure [dbo].[AdmAlquileres_RecuperarPorEstadoYTipoPropiedad]    Script Date: 05/01/2008 00:23:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[AdmAlquileres_RecuperarPorEstadoYTipoPropiedad]
(
	@IdEstadoPropiedad int,
	@IdTipoPropiedad int
)
AS	
	
SELECT
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
		,co.Vigente
		,aa.IdContacto
FROM         
	Propiedades p,
	Alquileres a,
	AdmAlquileres aa,
	Contratos co
WHERE
	p.IdPropiedad = a.IdPropiedad and
	p.IdEstadoPropiedad = @IdEstadoPropiedad and
	p.idTipoPropiedad = @IdTipoPropiedad and
	p.IdPropiedad = aa.IdPropiedad and
	co.IdPropiedad = p.IdPropiedad and
	co.Vigente = 1

GO
/****** Object:  StoredProcedure [dbo].[AdmAlquileres_RecuperarPorNombreInquilino]    Script Date: 05/01/2008 00:23:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


alter PROCEDURE [dbo].[AdmAlquileres_RecuperarPorNombreInquilino]
	
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
		,co.Vigente
		,aa.IdContacto
from Inquilinos i , Clientes c, Contratos co, AdmAlquileres aa
where 
	i.IdCliente = c.IdCliente and
	(c.Nombres Like '%'+@Cadena+'%' or c.Apellido like '%'+@Cadena+'%') and
	co.IdInquilino = i.IdCliente and
	aa.IdPropiedad = co.IdPropiedad and
	co.Vigente = 1
GO
/****** Object:  StoredProcedure [dbo].[AdmAlquileres_RecuperarPorTipoPropiedad]    Script Date: 05/01/2008 00:23:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[AdmAlquileres_RecuperarPorTipoPropiedad]
(
	@IdTipoPropiedad int
)
AS	
	
SELECT
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
		,co.Vigente
		,aa.IdContacto
FROM         
	Propiedades p,
	Alquileres a,
	AdmAlquileres aa,
	Contratos co
WHERE
	p.IdPropiedad = a.IdPropiedad and
	p.idTipoPropiedad = @IdTipoPropiedad and
	p.IdPropiedad = aa.IdPropiedad and
	co.IdPropiedad = p.IdPropiedad and
	co.Vigente = 1
GO
/****** Object:  StoredProcedure [dbo].[AdmAlquileres_RecuperarTodos]    Script Date: 05/01/2008 00:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


alter PROCEDURE [dbo].[AdmAlquileres_RecuperarTodos]

	
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
		,co.Vigente
		,aa.IdContacto
from Contratos co, AdmAlquileres aa
where 
	aa.IdPropiedad = co.IdPropiedad and
	co.Vigente = 1
	


