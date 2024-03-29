set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go


create PROCEDURE [dbo].[PropiedadesVentas_RecuperarPorId]
(
	@IdPropiedad int
)
AS	
	
SELECT        Propiedades.PublicarSinPrecio, Propiedades.IdPropiedad, Propiedades.CantidadAmbientes, Propiedades.Codigo, Propiedades.IdTipoPropiedad, Propiedades.IdEstadoPropiedad, 
                         Propiedades.EnumEstadoProp, Propiedades.IdPropietario, Propiedades.IdPais, Propiedades.IdProvincia, Propiedades.IdLocalidad, Propiedades.IdBarrio, 
                         Propiedades.Calle, Propiedades.NumeroPostal, Propiedades.Depto, Propiedades.Piso, Propiedades.CodigoPostal, Propiedades.CalleEntre1, 
                         Propiedades.CalleEntre2, Propiedades.ValorMercadoImporte, Propiedades.ValorMercadoMoneda, Propiedades.ValorPublicacionImporte, 
                         Propiedades.ValorPublicacionMoneda, Propiedades.Observaciones, Propiedades.EsOtraInmobiliaria, Propiedades.MetrosCubiertos, 
                         Propiedades.MetrosSemicubiertos, Propiedades.MetrosLibres, Propiedades.TerrenoMetros, Propiedades.TerrenoFondo, Propiedades.TerrenosFrente, 
                         Propiedades.Orientacion, Propiedades.CantidadBanos, Propiedades.CantidadCocheras, Propiedades.CantidadDomritorios, Propiedades.CantidadPlantas, 
                         Propiedades.IdDepartamentoDisposicion, Propiedades.EsAptoProfesional, Propiedades.DeptoCantidadPisos, Propiedades.DeptoDepartamentosPorPiso, 
                         Propiedades.CantidadAscensores, Propiedades.CantidadAscensoresServicio, Propiedades.IdTipoZona, Propiedades.Fos, Propiedades.Fot, 
                         Propiedades.Zonificacion, Propiedades.MetrosContruibles, Propiedades.Antiguedad, inm.IdInmobiliaria, inm.Nombre AS NombreInmobiliaria, 
                         inm.Telefono AS TelefonoInmobiliaria, inm.Contacto AS ContactoInmobiliaria, Propiedades.ValorExpensas, Propiedades.CuartoHerramientas, 
                         Propiedades.Baulera, Propiedades.Playroom, Propiedades.Terraza, Propiedades.Balcon, Propiedades.Parrilla, Propiedades.Quincho, 
                         Propiedades.Dependencia, Propiedades.Lavadero, Propiedades.Piscina, Propiedades.Patio, Propiedades.Jardin
FROM         Propiedades , Ventas , InmobiliariasExternas inm
where 
	Propiedades.IdPropiedad = Ventas.IdPropiedad and
	Ventas.IdPropiedad = @IdPropiedad and
	Propiedades.IdInmobiliariaExterna *= inm.IdInmobiliaria


