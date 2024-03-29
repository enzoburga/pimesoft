set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go



create PROCEDURE [dbo].[AdmAlquileres_RecuperarPorCodigoPropiedad]
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

	Contratos co,
	AdmAlquileres aa
WHERE	
	@IdPropiedad = aa.IdPropiedad and
	co.IdPropiedad = aa.IdPropiedad and
	co.Vigente = 1




