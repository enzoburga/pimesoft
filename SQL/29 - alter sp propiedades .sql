alter PROCEDURE dbo.Propiedades_MedidadasAmbiente_Insertar 
(
	@Ancho decimal(18,1),
	@Largo decimal(18,1),
	@Ambiente nvarchar(200),
	@IdTipoPiso int,
	@IdPropiedad int
)
AS


insert into MedidasAmbientesPropiedad values (@Ancho,@Largo,@Ambiente,@IdTipoPiso,@IdPropiedad)

select  @@identity

GO

alter PROCEDURE dbo.Propiedades_Actualizar
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
        @MetrosCubiertos decimal(18,1),
        @MetrosLibres decimal(18,1),
        @MetrosSemicubiertos decimal(18,1),
        @Fondo decimal(18,1) ,
        @Frente decimal(18,1),
        @Metros decimal(18,1),
        @MetrosConstruibles decimal(18,1),
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
        @Zonificacion nvarchar(50)
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
	                         MetrosContruibles = @MetrosConstruibles
	                         
	           where IdPropiedad = @IdPropiedad


select @@rowcount

GO

alter PROCEDURE dbo.Propiedades_Crear 
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
        @MetrosCubiertos decimal(18,1),
        @MetrosLibres decimal(18,1),
        @MetrosSemicubiertos decimal(18,1),
        @Fondo decimal(18,1) ,
        @Frente decimal(18,1),
        @Metros decimal(18,1),
        @MetrosConstruibles decimal(18,1),
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
        @Zonificacion nvarchar(50)
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
	                         MetrosContruibles)
values (@CantidadAmbientes,'',@IdTipoPropiedad,@IdEstadoPropiedad,@EnumEstado,@IdCliente,
@IdPais,@IdProvincia,@IdLocalidad,@IdBarrio,@Calle,@Numero,@Depto,@Piso,@CodigoPostal,@CalleEntre1,@CalleEntre2,
@ValorMercadoImporte,@ValorMercadoIdMoneda,@ValorPublicacionImporte,@ValorPublicacionIdMoneda,'',@EsOtraInmobiliaria,
@MetrosCubiertos,@MetrosSemicubiertos,@MetrosLibres,@Metros,@Fondo,@Frente,@Orientacion,@CantidadBaños,@CantidadCocheras,
@CantidadDormitorios,@CantidadPlantas,@Disposicion,@EsAptoProfesional,@CantidadPisos,@DepartamentosPorPiso,@CantidadAscensores,
@CantidadAscensoresServicio,@TipoZona,@Fos,@Fot,@Zonificacion,@MetrosConstruibles)



select @@IDENTITY
