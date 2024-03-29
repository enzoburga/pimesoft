set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go




ALTER PROCEDURE [dbo].[AdmAlquileres_RecuperarPorCodigoPropiedad]
(
	@IdPropiedad int
)
AS	
	
SELECT     
		co.[IdContrato]
		,co.[IdInquilino]
		,co.[IdPropiedad]
		,co.[FechaInicio]
		,co.[FechaVencimiento]
		,co.[MontoDeposito]
		,co.[IdMonedaDeposito]
		,co.[DiaVencimientoCuota]
		,co.[IdContratoAnterior]
		,co.[FechaCancelacion]
		,co.[Observaciones]
		,co.Vigente
		,aa.IdContacto
FROM

	Contratos co,
	AdmAlquileres aa
WHERE	
	@IdPropiedad = aa.IdPropiedad and
	co.IdPropiedad = aa.IdPropiedad and
	co.Vigente = 1

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go



ALTER PROCEDURE [dbo].[AdmAlquileres_RecuperarPorDireccion]
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


set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go



ALTER PROCEDURE [dbo].[AdmAlquileres_RecuperarPorEstadoPropiedad]
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

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go



ALTER PROCEDURE [dbo].[AdmAlquileres_RecuperarPorEstadoYTipoPropiedad]
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


set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go



ALTER PROCEDURE [dbo].[AdmAlquileres_RecuperarPorNombreInquilino]
	
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

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go



ALTER PROCEDURE [dbo].[AdmAlquileres_RecuperarPorTipoPropiedad]
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

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go



ALTER PROCEDURE [dbo].[AdmAlquileres_RecuperarTodos]

	
AS
select		
		co.[IdContrato]
		,co.[IdInquilino]
		,co.[IdPropiedad]
		,co.[FechaInicio]
		,co.[FechaVencimiento]
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
	










