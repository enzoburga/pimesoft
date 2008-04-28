ALTER PROCEDURE dbo.PropiedadesAlquileres_RecuperarTodas 
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
;

ALTER PROCEDURE dbo.PropiedadesAlquileres_RecuperarPorDireccion
(
	@Calle nvarchar(200),
	@Numero int
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
                      where Calle like  '%' + @Calle + '%' And NumeroPostal = @Numero

;

ALTER PROCEDURE dbo.PropiedadesAlquileres_RecuperarPorEstado
(
	@IdEstadoPropiedad int
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
                      where IdEstadoPropiedad = @IdEstadoPropiedad

;

ALTER PROCEDURE dbo.PropiedadesAlquileres_RecuperarPorEstadoYtipo
(
	@IdEstadoPropiedad int,
	@IdTipoPropiedad int
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
                      where IdEstadoPropiedad = @IdEstadoPropiedad
						and idTipoPropiedad = @IdTipoPropiedad
;

ALTER PROCEDURE dbo.PropiedadesAlquileres_RecuperarPorTipo
(
	@IdTipoPropiedad int
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
                      where IdTipoPropiedad = @IdTipoPropiedad


;

ALTER PROCEDURE dbo.Propiedades_CrearAlquiler
(
       @IdPropiedad INT
)
AS



insert into 	Alquileres values (@IdPropiedad)




select @@ROWCOUNT
