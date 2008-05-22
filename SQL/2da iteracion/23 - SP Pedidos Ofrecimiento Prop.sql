
GO
/****** Object:  StoredProcedure [dbo].[PropiedadesAlquileres_RecuperarTodasOfrecidas]    Script Date: 05/22/2008 02:03:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[PropiedadesAlquileres_RecuperarTodasOfrecidas] 

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
                      p.MetrosContruibles
FROM         
	Propiedades p, 
    Alquileres a,
	PropiedadesOfrecidasXPedido po
 
Where 
	p.IdPropiedad =  a.IdPropiedad and
	p.IdPropiedad = po.IdPropiedad and
	po.IdPedido = @IdPedido



/*****************************************/

/****** Object:  StoredProcedure [dbo].[PropiedadesVentas_RecuperarTodasOfrecidas]    Script Date: 05/22/2008 02:03:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[PropiedadesVentas_RecuperarTodasOfrecidas] 

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
                      p.MetrosContruibles
FROM         
	Propiedades p, 
    Ventas v,
	PropiedadesOfrecidasXPedido po
 
Where 
	p.IdPropiedad =  v.IdPropiedad and
	v.IdPropiedad = po.IdPropiedad and
	po.IdPedido = @IdPedido



/***********************************************/


GO
/****** Object:  StoredProcedure [dbo].[Pedido_MarcarPropiedadOfrecida]    Script Date: 05/22/2008 02:04:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Pedido_MarcarPropiedadOfrecida] 

	(
	@IdPropiedad int ,
	@IdPedido int
	)
AS
INSERT INTO [dbo].[PropiedadesOfrecidasXPedido]
           ([IdPedido]
           ,[IdPropiedad])
     VALUES
           (@IdPedido
           ,@IdPropiedad)
           
select @@rowcount