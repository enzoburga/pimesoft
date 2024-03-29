
ALTER PROCEDURE dbo.Propiedades_Crear 
(
		@IdPropiedad int,
        @CantidadAmbientes decimal(18,1),
        @CantidadAscensores int,
        @CantidadAscensoresServicio int,
        @CantidadBa�os int,
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
	


insert into Propiedades (IdPropiedad, CantidadAmbientes, Codigo, IdTipoPropiedad, IdEstadoPropiedad, EnumEstadoProp, IdPropietario, 
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
values (@IdPropiedad, @CantidadAmbientes,'',@IdTipoPropiedad,@IdEstadoPropiedad,@EnumEstado,@IdCliente,
@IdPais,@IdProvincia,@IdLocalidad,@IdBarrio,@Calle,@Numero,@Depto,@Piso,@CodigoPostal,@CalleEntre1,@CalleEntre2,
@ValorMercadoImporte,@ValorMercadoIdMoneda,@ValorPublicacionImporte,@ValorPublicacionIdMoneda,@Descripcion,@EsOtraInmobiliaria,
@MetrosCubiertos,@MetrosSemicubiertos,@MetrosLibres,@Metros,@Fondo,@Frente,@Orientacion,@CantidadBa�os,@CantidadCocheras,
@CantidadDormitorios,@CantidadPlantas,@Disposicion,@EsAptoProfesional,@CantidadPisos,@DepartamentosPorPiso,@CantidadAscensores,
@CantidadAscensoresServicio,@TipoZona,@Fos,@Fot,@Zonificacion,@MetrosConstruibles, @Antiguedad, @IdInmobiliariaExterna, @ValorExpensas)



select @@ROWCOUNT