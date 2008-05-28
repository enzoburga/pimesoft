
GO
/****** Object:  StoredProcedure [dbo].[PropiedadesVentas_RecuperarTodasOfrecidas]    Script Date: 05/27/2008 21:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




alter PROCEDURE [dbo].[PropiedadesVentas_RecuperarTodasOfrecidas] 

(
	@IdPedido int
)
AS
	
	
SELECT     p.IdPropiedad, p.CantidadAmbientes, p.Codigo, p.IdTipoPropiedad, p.IdEstadoPropiedad, 
                      p.EnumEstadoProp, p.IdPropietario, p.IdPais, p.IdProvincia, p.IdLocalidad, 
                      p.IdBarrio, p.Calle, p.NumeroPostal, p.Depto, p.Piso, p.CodigoPostal, 
                      p.CalleEntre1, p.CalleEntre2, p.ValorMercadoImporte, p.ValorMercadoMoneda, 
                      p.ValorPublicacionImporte, p.ValorPublicacionMoneda, p.Observaciones, p.EsOtraInmobiliaria, 
                      p.MetrosCubiertos, p.MetrosSemicubiertos, p.MetrosLibres, p.TerrenoMetros, 
                      p.TerrenoFondo, p.TerrenosFrente, p.Orientacion, p.CantidadBanos, p.CantidadCocheras, 
                      p.CantidadDomritorios, p.CantidadPlantas, p.IdDepartamentoDisposicion, p.EsAptoProfesional, 
                      p.DeptoCantidadPisos, p.DeptoDepartamentosPorPiso, p.CantidadAscensores, 
                      p.CantidadAscensoresServicio, p.IdTipoZona, p.Fos, p.Fot, p.Zonificacion, 
                      p.MetrosContruibles, p.Antiguedad
FROM         
	Propiedades p, 
    Ventas v,
	PropiedadesOfrecidasXPedido po
 
Where 
	p.IdPropiedad =  v.IdPropiedad and
	v.IdPropiedad = po.IdPropiedad and
	po.IdPedido = @IdPedido




