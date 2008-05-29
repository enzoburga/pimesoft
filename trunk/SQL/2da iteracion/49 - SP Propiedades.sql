
ALTER PROCEDURE [dbo].[Propiedad_RecuperarPorId] 

(
	@IdPropiedad int
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
                      Propiedades.MetrosContruibles, Propiedades.Antiguedad,
						inm.IdInmobiliaria, inm.Nombre as NombreInmobiliaria, inm.Telefono as TelefonoInmobiliaria,
						inm.Contacto as ContactoInmobiliaria, Propiedades.ValorExpensas 
FROM         Propiedades , InmobiliariasExternas inm
WHERE IdPropiedad = @IdPropiedad and Propiedades.IdInmobiliariaExterna *= inm.Idinmobiliaria

;



ALTER PROCEDURE dbo.Propiedades_Actualizar
(
	@IdPropiedad int,
    @CantidadAmbientes decimal(18,1),
        @CantidadAscensores int,
        @CantidadAscensoresServicio int,
        @CantidadBaños int,
        @CantidadCocheras int,
        @CantidadDormitorios int,
        @CantidadPisos int,
        @CantidadPlantas int,
        @DepartamentosPorPiso int,
        @Calle nvarchar(200),
        @CalleEntre1 nvarchar(200),
        @CalleEntre2 nvarchar(200),
        @CodigoPostal nvarchar(10),
        @Depto nvarchar(5),
        @Numero int,
        @Piso nvarchar(5),
        @Disposicion int,
        @EnumEstado int,
        @EsAptoProfesional bit,
        @EsOtraInmobiliaria bit,
        @IdEstadoPropiedad int,
        @Fos nvarchar(50),
        @Fot nvarchar(50),
        @MetrosCubiertos decimal(18,2),
        @MetrosLibres decimal(18,2),
        @MetrosSemicubiertos decimal(18,2),
        @Fondo decimal(18,2) ,
        @Frente decimal(18,2),
        @Metros decimal(18,2),
        @MetrosConstruibles decimal(18,2),
        @Orientacion nvarchar(50),
        @IdCliente int,
        @IdTipoPropiedad int,
        @TipoZona int,
        @IdBarrio int,
        @IdLocalidad int,
        @IdPais int,
        @IdProvincia int,
        @ValorMercadoImporte decimal,
        @ValorMercadoIdMoneda int,
        @ValorPublicacionImporte decimal,
        @ValorPublicacionIdMoneda int,
        @Zonificacion nvarchar(50),
        @Descripcion text,
        @Antiguedad int,
        @IdInmobiliariaExterna int,
        @ValorExpensas decimal(18,2)
)
AS
	
update Propiedades Set 
CantidadAmbientes= @CantidadAmbientes, IdTipoPropiedad=@IdTipoPropiedad , IdEstadoPropiedad= @IdEstadoPropiedad, EnumEstadoProp= @EnumEstado, IdPropietario=@IdCliente , 
							IdPais=@IdPais , IdProvincia=@IdProvincia , IdLocalidad= @IdLocalidad, IdBarrio=@IdBarrio , Calle= @Calle, 
	                         NumeroPostal= @Numero, Depto= @Depto, Piso= @Piso, CodigoPostal=@CodigoPostal , CalleEntre1=@CalleEntre1 , CalleEntre2= @CalleEntre2, 
	                         ValorMercadoImporte=@ValorMercadoImporte , ValorMercadoMoneda=@ValorMercadoIdMoneda , ValorPublicacionImporte=@ValorPublicacionImporte , 
	                         ValorPublicacionMoneda= @ValorPublicacionIdMoneda,EsOtraInmobiliaria= @EsOtraInmobiliaria, 
	                         MetrosCubiertos= @MetrosCubiertos, MetrosSemicubiertos= @MetrosSemicubiertos, MetrosLibres= @MetrosLibres, TerrenoMetros=@Metros , TerrenoFondo= @Fondo, 
	                         TerrenosFrente=@Frente , Orientacion=@Orientacion , CantidadBanos= @CantidadBaños, CantidadCocheras= @CantidadCocheras, 
	                         CantidadDomritorios=@CantidadDormitorios , CantidadPlantas=@CantidadPlantas , IdDepartamentoDisposicion= @Disposicion, EsAptoProfesional=@EsAptoProfesional , 
	                         DeptoCantidadPisos=@CantidadPisos , DeptoDepartamentosPorPiso=@DepartamentosPorPiso , CantidadAscensores=@CantidadAscensores , 
	                         CantidadAscensoresServicio=@CantidadAscensoresServicio , IdTipoZona=@TipoZona , Fos=@Fos , Fot=@Fot , Zonificacion= @Zonificacion, 
	                         MetrosContruibles = @MetrosConstruibles, Observaciones=@Descripcion, Antiguedad=@Antiguedad,
	                         ValorExpensas=@ValorExpensas, IdInmobiliariaExterna=@IdInmobiliariaExterna
	           where IdPropiedad = @IdPropiedad


select @@rowcount


;

ALTER PROCEDURE dbo.Propiedades_Crear 
(
        @CantidadAmbientes decimal(18,1),
        @CantidadAscensores int,
        @CantidadAscensoresServicio int,
        @CantidadBaños int,
        @CantidadCocheras int,
        @CantidadDormitorios int,
        @CantidadPisos int,
        @CantidadPlantas int,
        @DepartamentosPorPiso int,
        @Calle nvarchar(200),
        @CalleEntre1 nvarchar(200),
        @CalleEntre2 nvarchar(200),
        @CodigoPostal nvarchar(10),
        @Depto nvarchar(5),
        @Numero int,
        @Piso nvarchar(5),
        @Disposicion int,
        @EnumEstado int,
        @EsAptoProfesional bit,
        @EsOtraInmobiliaria bit,
        @IdEstadoPropiedad int,
        @Fos nvarchar(50),
        @Fot nvarchar(50),
        @MetrosCubiertos decimal(18,2),
        @MetrosLibres decimal(18,2),
        @MetrosSemicubiertos decimal(18,2),
        @Fondo decimal(18,2) ,
        @Frente decimal(18,2),
        @Metros decimal(18,2),
        @MetrosConstruibles decimal(18,2),
        @Orientacion nvarchar(50),
        @IdCliente int,
        @IdTipoPropiedad int,
        @TipoZona int,
        @IdBarrio int,
        @IdLocalidad int,
        @IdPais int,
        @IdProvincia int,
        @ValorMercadoImporte decimal,
        @ValorMercadoIdMoneda int,
        @ValorPublicacionImporte decimal,
        @ValorPublicacionIdMoneda int,
        @Zonificacion nvarchar(50),
        @Descripcion text,
        @Antiguedad int,
        @IdInmobiliariaExterna int,
        @ValorExpensas decimal(18,2)
)
AS
	


insert into Propiedades (CantidadAmbientes, Codigo, IdTipoPropiedad, IdEstadoPropiedad, EnumEstadoProp, IdPropietario, 
							IdPais, IdProvincia, IdLocalidad, IdBarrio, Calle, 
	                         NumeroPostal, Depto, Piso, CodigoPostal, CalleEntre1, CalleEntre2, 
	                         ValorMercadoImporte, ValorMercadoMoneda, ValorPublicacionImporte, 
	                         ValorPublicacionMoneda, Observaciones, EsOtraInmobiliaria, 
	                         MetrosCubiertos, MetrosSemicubiertos, MetrosLibres, TerrenoMetros, TerrenoFondo, 
	                         TerrenosFrente, Orientacion, CantidadBanos, CantidadCocheras, 
	                         CantidadDomritorios, CantidadPlantas, IdDepartamentoDisposicion, EsAptoProfesional, 
	                         DeptoCantidadPisos, DeptoDepartamentosPorPiso, CantidadAscensores, 
	                         CantidadAscensoresServicio, IdTipoZona, Fos, Fot, Zonificacion, 
	                         MetrosContruibles, Antiguedad, IdInmobiliariaExterna, ValorExpensas)
values (@CantidadAmbientes,'',@IdTipoPropiedad,@IdEstadoPropiedad,@EnumEstado,@IdCliente,
@IdPais,@IdProvincia,@IdLocalidad,@IdBarrio,@Calle,@Numero,@Depto,@Piso,@CodigoPostal,@CalleEntre1,@CalleEntre2,
@ValorMercadoImporte,@ValorMercadoIdMoneda,@ValorPublicacionImporte,@ValorPublicacionIdMoneda,@Descripcion,@EsOtraInmobiliaria,
@MetrosCubiertos,@MetrosSemicubiertos,@MetrosLibres,@Metros,@Fondo,@Frente,@Orientacion,@CantidadBaños,@CantidadCocheras,
@CantidadDormitorios,@CantidadPlantas,@Disposicion,@EsAptoProfesional,@CantidadPisos,@DepartamentosPorPiso,@CantidadAscensores,
@CantidadAscensoresServicio,@TipoZona,@Fos,@Fot,@Zonificacion,@MetrosConstruibles, @Antiguedad, @IdInmobiliariaExterna, @ValorExpensas)



select @@IDENTITY

