set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

alter PROCEDURE [dbo].[PropiedadesAlquileres_RecuperarTodasSinOfrecer] 

(
	@IdPedido int
)
AS
	
	
SELECT     Propiedades.IdPropiedad, Propiedades.CantidadAmbientes, Propiedades.Codigo, Propiedades.IdTipoPropiedad, Propiedades.IdEstadoPropiedad, 
                      Propiedades.EnumEstadoProp, Propiedades.IdPropietario, Propiedades.IdPais, Propiedades.IdProvincia, Propiedades.IdLocalidad, 
                      Propiedades.IdBarrio, Propiedades.Calle, Propiedades.NumeroPostal, Propiedades.Depto, Propiedades.Piso, Propiedades.CodigoPostal, 
                      Propiedades.CalleEntre1, Propiedades.CalleEntre2, Propiedades.ValorMercadoImporte, Propiedades.ValorMercadoMoneda, 
                      Propiedades.ValorPublicacionImporte, Propiedades.ValorPublicacionMoneda, Propiedades.Observaciones, Propiedades.EsOtraInmobiliaria, 
                      Propiedades.MetrosCubiertos, Propiedades.MetrosSemicubiertos, Propiedades.MetrosLibres, Propiedades.TerrenoMetros, 
                      Propiedades.TerrenoFondo, Propiedades.TerrenosFrente, Propiedades.Orientacion, Propiedades.CantidadBanos, Propiedades.CantidadCocheras, 
                      Propiedades.CantidadDomritorios, Propiedades.CantidadPlantas, Propiedades.IdDepartamentoDisposicion, Propiedades.EsAptoProfesional, 
                      Propiedades.DeptoCantidadPisos, Propiedades.DeptoDepartamentosPorPiso, Propiedades.CantidadAscensores, 
                      Propiedades.CantidadAscensoresServicio, Propiedades.IdTipoZona, Propiedades.Fos, Propiedades.Fot, Propiedades.Zonificacion, 
                      Propiedades.MetrosContruibles
FROM         Propiedades INNER JOIN
                      Alquileres ON Propiedades.IdPropiedad = Alquileres.IdPropiedad
Where 
	Propiedades.IdPropiedad not in (select IdPropiedad from dbo.PropiedadesOfrecidasXPedido where IdPedido = @IdPedido)

/*********************************************************************************/

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go


ALTER PROCEDURE [dbo].[PropiedadesVentas_RecuperarTodasSinOfrecer] 

(
	@IdPedido int
)
AS
	
	
SELECT     Propiedades.IdPropiedad, Propiedades.CantidadAmbientes, Propiedades.Codigo, Propiedades.IdTipoPropiedad, Propiedades.IdEstadoPropiedad, 
                      Propiedades.EnumEstadoProp, Propiedades.IdPropietario, Propiedades.IdPais, Propiedades.IdProvincia, Propiedades.IdLocalidad, 
                      Propiedades.IdBarrio, Propiedades.Calle, Propiedades.NumeroPostal, Propiedades.Depto, Propiedades.Piso, Propiedades.CodigoPostal, 
                      Propiedades.CalleEntre1, Propiedades.CalleEntre2, Propiedades.ValorMercadoImporte, Propiedades.ValorMercadoMoneda, 
                      Propiedades.ValorPublicacionImporte, Propiedades.ValorPublicacionMoneda, Propiedades.Observaciones, Propiedades.EsOtraInmobiliaria, 
                      Propiedades.MetrosCubiertos, Propiedades.MetrosSemicubiertos, Propiedades.MetrosLibres, Propiedades.TerrenoMetros, 
                      Propiedades.TerrenoFondo, Propiedades.TerrenosFrente, Propiedades.Orientacion, Propiedades.CantidadBanos, Propiedades.CantidadCocheras, 
                      Propiedades.CantidadDomritorios, Propiedades.CantidadPlantas, Propiedades.IdDepartamentoDisposicion, Propiedades.EsAptoProfesional, 
                      Propiedades.DeptoCantidadPisos, Propiedades.DeptoDepartamentosPorPiso, Propiedades.CantidadAscensores, 
                      Propiedades.CantidadAscensoresServicio, Propiedades.IdTipoZona, Propiedades.Fos, Propiedades.Fot, Propiedades.Zonificacion, 
                      Propiedades.MetrosContruibles
FROM         Propiedades INNER JOIN
                      Ventas ON Propiedades.IdPropiedad = Ventas.IdPropiedad
Where 
	Propiedades.IdPropiedad not in (select IdPropiedad from dbo.PropiedadesOfrecidasXPedido where IdPedido = @IdPedido)

