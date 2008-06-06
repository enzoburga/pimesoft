USE [InmobiliariaDb]
GO
/****** Objeto:  Table [dbo].[TiposAmbiente]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposAmbiente](
	[IdTipoambiente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Codigo] [int] NOT NULL,
 CONSTRAINT [PK_TiposAmbiente] PRIMARY KEY CLUSTERED 
(
	[IdTipoambiente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_MedidadasAmbiente_Insertar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Propiedades_MedidadasAmbiente_Insertar] 
(
	@Ancho decimal(18,2),
	@Largo decimal(18,2),
	@Ambiente nvarchar(200),
	@IdTipoPiso int,
	@IdPropiedad int,
	@IdTipoAmbiente int
)
AS


insert into MedidasAmbientesPropiedad values (@Ancho,@Largo,@Ambiente,@IdTipoPiso,@IdPropiedad, @IdTipoAmbiente)

select  @@identity
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_MedidadasAmbiente_Eliminar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Propiedades_MedidadasAmbiente_Eliminar]
(
	@IdMedida int
)
AS

delete from MedidasAmbientesPropiedad where idambiente=@IdMedida


select  @@rowcount
GO
/****** Objeto:  Table [dbo].[LicenciasPorTerminal]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LicenciasPorTerminal](
	[IdTerminal] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Licencia] [nvarchar](500) NOT NULL
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[CategoriasPropiedad]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriasPropiedad](
	[IdCategoria] [int] NOT NULL,
	[Nombre] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_CategoriasPropiedad] PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[EstadosPropiedad]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadosPropiedad](
	[IdEstadoPropiedad] [int] NOT NULL,
	[Nombre] [nvarchar](150) NOT NULL,
	[TipoClasePropiedad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EstadosPropiedad] PRIMARY KEY CLUSTERED 
(
	[IdEstadoPropiedad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[InmobiliariasExternas]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InmobiliariasExternas](
	[IdInmobiliaria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Telefono] [nvarchar](100) NOT NULL,
	[Contacto] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_InmobiliariasExternas] PRIMARY KEY CLUSTERED 
(
	[IdInmobiliaria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[Monedas]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Monedas](
	[IdMoneda] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Simbolo] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Monedas] PRIMARY KEY CLUSTERED 
(
	[IdMoneda] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[TiposDePiso]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposDePiso](
	[IdTipoPiso] [int] NOT NULL,
	[Nombre] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_TiposDePiso] PRIMARY KEY CLUSTERED 
(
	[IdTipoPiso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[Paises]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paises](
	[IdPais] [int] NOT NULL,
	[Nombre] [nvarchar](150) NOT NULL,
	[Default] [bit] NOT NULL,
 CONSTRAINT [PK_Paises] PRIMARY KEY CLUSTERED 
(
	[IdPais] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[Eventos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eventos](
	[IdEvento] [int] IDENTITY(1,1) NOT NULL,
	[FechaGeneracion] [datetime] NOT NULL,
	[Descripcion] [nvarchar](500) NOT NULL,
	[FechaVencimiento] [datetime] NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Eventos] PRIMARY KEY CLUSTERED 
(
	[IdEvento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  StoredProcedure [dbo].[Pago_Anular]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pago_Anular] 

	(
	@IdPago int
	)
AS
UPDATE Pagos
Set Anulado = 1
WHERE IdPago = @IdPago
GO
/****** Objeto:  Table [dbo].[Smtp]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Smtp](
	[AutenticacionSmtp] [bit] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Host] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](10) NOT NULL,
	[Puerto] [int] NOT NULL,
	[SSL] [bit] NOT NULL,
	[UserName] [nchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Objeto:  StoredProcedure [dbo].[Cliente_RecuperarPorId]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Cliente_RecuperarPorId] 
	
	(
	@IdCliente int
	)
	
AS
SELECT [Nombres]
      ,[Apellido]
      ,[IdCliente]
      ,[NroDocumento]
      ,[TipoDocumento]
      ,[TelefonoParticular]
      ,[TelefonoTrabajo]
      ,[TelefonoCelular]
      ,[Observaciones]
      ,[FechaNacimiento]
      ,[Email]
      ,[Calle]
      ,[Numero]
      ,[Depto]
      ,[Piso]
      ,[CodigoPostal]
      ,[CalleEntre1]
      ,[CalleEntre2]
      ,[IdBarrio]
      ,[IdProvincia]
      ,[IdPais]
      ,[IdLocalidad]
  FROM [dbo].[Clientes]
  Where [IdCliente] = @IdCliente
GO
/****** Objeto:  StoredProcedure [dbo].[Carteles_RecuperarPorPropiedad]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Carteles_RecuperarPorPropiedad] 
(
	@IdPropiedad int
)
AS
SELECT [IdCartel]
      ,[IdPropiedad]
      ,[Activo]
      ,[Ancho]
      ,[Alto]
      ,[FechaAlta]
      ,[FechaVencimiento]
      ,[TipoCartel]
      ,IdUbicacionCartel
  FROM [dbo].[Carteles]
  where 
	IdPropiedad = @IdPropiedad
GO
/****** Objeto:  StoredProcedure [dbo].[Carteles_Guardar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Carteles_Guardar] 
(
	@Activo bit,
	@Alto int,
	@Ancho int,
	@FechaAlta datetime,
	@FechaVencimiento datetime,
	@IdPropiedad int,
	@TipoCartel nvarchar(50),
	@IdUbicacionCartel int

)
AS
INSERT INTO [dbo].[Carteles]
           ([IdPropiedad]
           ,[Activo]
           ,[Ancho]
           ,[Alto]
           ,[FechaAlta]
           ,[FechaVencimiento]
           ,[TipoCartel]
           ,[IdUbicacionCartel])
     VALUES
           (@IdPropiedad
           ,@Activo
           ,@Ancho
           ,@Alto
           ,@FechaAlta
           ,@FechaVencimiento
           ,@TipoCartel
           ,@IdUbicacionCartel)
           
           select @@identity
/****** Object:  StoredProcedure [dbo].[Carteles_Actualizar]    Script Date: 05/26/2008 22:32:57 ******/
SET ANSI_NULLS ON
GO
/****** Objeto:  StoredProcedure [dbo].[Carteles_Actualizar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Carteles_Actualizar] 
(
	@IdCartel int,
	@Activo bit,
	@Alto int,
	@Ancho int,
	@FechaAlta datetime,
	@FechaVencimiento datetime,
	@IdPropiedad int,
	@TipoCartel nvarchar(50),
	@IdUbicacionCartel int
	
)
AS


UPDATE [dbo].[Carteles]
   SET [IdPropiedad] = @IdPropiedad
      ,[Activo] = @Activo
      ,[Ancho] = @Ancho
      ,[Alto] = @Alto
      ,[FechaAlta] = @FechaAlta
      ,[FechaVencimiento] = @FechaVencimiento
      ,[TipoCartel] = @TipoCartel
      ,[IdUbicacionCartel] = @IdUbicacionCartel
 WHERE IdCartel = @IdCartel
 
     select @@rowcount
GO
/****** Objeto:  Table [dbo].[UbicacionesCartel]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UbicacionesCartel](
	[IdUbicacionCartel] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_UbicacionesCartel] PRIMARY KEY CLUSTERED 
(
	[IdUbicacionCartel] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  StoredProcedure [dbo].[Carteles_RecuperarTodos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Carteles_RecuperarTodos] 

AS
SELECT [IdCartel]
      ,[IdPropiedad]
      ,[Activo]
      ,[Ancho]
      ,[Alto]
      ,[FechaAlta]
      ,[FechaVencimiento]
      ,[TipoCartel]
      ,IdUbicacionCartel
  FROM [dbo].[Carteles]
GO
/****** Objeto:  Table [dbo].[Contratos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contratos](
	[IdContrato] [int] IDENTITY(1,1) NOT NULL,
	[IdInquilino] [int] NULL,
	[IdPropiedad] [int] NOT NULL,
	[FechaInicio] [datetime] NOT NULL,
	[FechaVencimiento] [datetime] NOT NULL,
	[MontoDeposito] [decimal](18, 0) NOT NULL,
	[IdMonedaDeposito] [int] NOT NULL,
	[DiaVencimientoCuota] [tinyint] NOT NULL,
	[IdContratoAnterior] [int] NULL,
	[FechaCancelacion] [datetime] NULL,
	[Observaciones] [nvarchar](200) NULL,
	[Vigente] [bit] NOT NULL,
 CONSTRAINT [PK_Contratos] PRIMARY KEY CLUSTERED 
(
	[IdContrato] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[MedidasAmbientesPropiedad]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedidasAmbientesPropiedad](
	[IdAmbiente] [int] IDENTITY(1,1) NOT NULL,
	[Ancho] [decimal](18, 2) NOT NULL,
	[Largo] [decimal](18, 2) NOT NULL,
	[Ambiente] [nvarchar](150) NOT NULL,
	[IdTipoPiso] [int] NOT NULL,
	[IdPropiedad] [int] NOT NULL,
	[IdTipoAmbiente] [int] NULL,
 CONSTRAINT [PK_MedidasAmbientesPropiedad] PRIMARY KEY CLUSTERED 
(
	[IdAmbiente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[EventoVisita]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventoVisita](
	[IdEvento] [int] NOT NULL,
	[IdVisita] [int] NOT NULL,
 CONSTRAINT [PK_EventoVisita] PRIMARY KEY CLUSTERED 
(
	[IdEvento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[Carteles]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carteles](
	[IdCartel] [int] IDENTITY(1,1) NOT NULL,
	[IdPropiedad] [int] NOT NULL,
	[Activo] [bit] NOT NULL,
	[Ancho] [int] NOT NULL,
	[Alto] [int] NULL,
	[FechaAlta] [datetime] NOT NULL,
	[FechaVencimiento] [datetime] NULL,
	[TipoCartel] [nvarchar](50) NULL,
	[IdUbicacionCartel] [int] NULL,
 CONSTRAINT [PK_Carteles] PRIMARY KEY CLUSTERED 
(
	[IdCartel] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[VisitasPropiedad]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VisitasPropiedad](
	[IdVisita] [int] IDENTITY(1,1) NOT NULL,
	[TimpoAlarma] [bigint] NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[Realizada] [bit] NOT NULL,
	[Visita] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](50) NOT NULL,
	[Comentario] [text] NOT NULL,
	[ConAlarma] [bit] NOT NULL,
	[IdPropiedad] [int] NOT NULL,
 CONSTRAINT [PK_VisitasPropiedad] PRIMARY KEY CLUSTERED 
(
	[IdVisita] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[NotasPropiedad]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotasPropiedad](
	[IdNota] [int] IDENTITY(1,1) NOT NULL,
	[IdPropiedad] [int] NOT NULL,
	[Nota] [text] NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_NotasPropiedad] PRIMARY KEY CLUSTERED 
(
	[IdNota] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[Tasaciones]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tasaciones](
	[IdTasacion] [int] IDENTITY(1,1) NOT NULL,
	[IdPropiedad] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[ImporteValorReal] [decimal](18, 2) NOT NULL,
	[ImporteValorPublicacion] [decimal](18, 2) NOT NULL,
	[IdMonedaValorReal] [int] NOT NULL,
	[IdMonedaValorPublicacion] [int] NOT NULL,
	[Comentarios] [text] NOT NULL,
 CONSTRAINT [PK_Tasaciones] PRIMARY KEY CLUSTERED 
(
	[IdTasacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[PropiedadesOfrecidasXPedido]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PropiedadesOfrecidasXPedido](
	[IdPedido] [int] NOT NULL,
	[IdPropiedad] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[Llamados]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Llamados](
	[IdLlamado] [int] IDENTITY(1,1) NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[Contacto] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](50) NOT NULL,
	[Comentarios] [text] NOT NULL,
	[IdPropiedad] [int] NOT NULL,
 CONSTRAINT [PK_Llamados] PRIMARY KEY CLUSTERED 
(
	[IdLlamado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[Publicaciones]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publicaciones](
	[IdPublicacion] [int] IDENTITY(1,1) NOT NULL,
	[IdPropiedad] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Medio] [nvarchar](50) NOT NULL,
	[Detalles] [text] NOT NULL,
	[IdMoneda] [int] NOT NULL,
	[Importe] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Publicaciones] PRIMARY KEY CLUSTERED 
(
	[IdPublicacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[GaleriaFotos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GaleriaFotos](
	[IdPropiedad] [int] NOT NULL,
	[IdFoto] [int] IDENTITY(1,1) NOT NULL,
	[Foto] [image] NOT NULL,
	[EsFachada] [bit] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_GaleriaFotos] PRIMARY KEY CLUSTERED 
(
	[IdFoto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[Alquileres]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alquileres](
	[IdPropiedad] [int] NOT NULL,
 CONSTRAINT [PK_Alquileres] PRIMARY KEY CLUSTERED 
(
	[IdPropiedad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[Ventas]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[IdPropiedad] [int] NOT NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[IdPropiedad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[Pedidos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedidos](
	[IdPedido] [int] IDENTITY(1,1) NOT NULL,
	[CantidadAmbientesFinal] [decimal](18, 1) NULL,
	[CantidadAmbientesInicial] [decimal](18, 1) NULL,
	[IdCategoria] [int] NULL,
	[IdCliente] [int] NOT NULL,
	[Disposicion] [int] NULL,
	[EnumEstado] [int] NULL,
	[EsAptoProfesional] [bit] NULL,
	[IdEstadoPropiedad] [int] NULL,
	[EstadoPropiedad] [nvarchar](50) NULL,
	[MetrosConstruiblesFinal] [int] NULL,
	[MetrosConstruiblesInicial] [int] NULL,
	[MetrosCubiertosFinal] [int] NULL,
	[MetrosCubiertosInicial] [int] NULL,
	[MetrosTerrenoFinal] [int] NULL,
	[MetrosTerrenoInicial] [int] NULL,
	[IdTipoPropiedad] [int] NULL,
	[TipoZona] [int] NULL,
	[IdBarrio] [int] NULL,
	[IdLocalidad] [int] NULL,
	[IdPais] [int] NULL,
	[IdProvincia] [int] NULL,
	[ImporteFinal] [decimal](18, 0) NULL,
	[ImporteInicial] [decimal](18, 0) NULL,
	[IdMoneda] [int] NULL,
	[Observaciones] [nvarchar](500) NOT NULL,
	[Activo] [bit] NOT NULL,
	[FechaAlta] [datetime] NOT NULL,
 CONSTRAINT [PK_Pedidos] PRIMARY KEY CLUSTERED 
(
	[IdPedido] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[TiposPropiedad]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposPropiedad](
	[IdTipoPropiedad] [int] NOT NULL,
	[Nombre] [nvarchar](150) NOT NULL,
	[IdCategoria] [int] NOT NULL,
 CONSTRAINT [PK_TiposPropiedad] PRIMARY KEY CLUSTERED 
(
	[IdTipoPropiedad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[Propiedades]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Propiedades](
	[IdPropiedad] [int] IDENTITY(1,1) NOT NULL,
	[CantidadAmbientes] [decimal](18, 1) NOT NULL,
	[Codigo] [nvarchar](8) NOT NULL,
	[IdTipoPropiedad] [int] NOT NULL,
	[IdEstadoPropiedad] [int] NOT NULL,
	[EnumEstadoProp] [int] NOT NULL,
	[IdPropietario] [int] NULL,
	[IdPais] [int] NOT NULL,
	[IdProvincia] [int] NOT NULL,
	[IdLocalidad] [int] NOT NULL,
	[IdBarrio] [int] NOT NULL,
	[Calle] [nvarchar](200) NOT NULL,
	[NumeroPostal] [int] NOT NULL,
	[Depto] [nvarchar](5) NOT NULL,
	[Piso] [nvarchar](5) NOT NULL,
	[CodigoPostal] [nvarchar](10) NOT NULL,
	[CalleEntre1] [nvarchar](200) NOT NULL,
	[CalleEntre2] [nvarchar](200) NOT NULL,
	[ValorMercadoImporte] [decimal](18, 0) NOT NULL,
	[ValorMercadoMoneda] [int] NOT NULL,
	[ValorPublicacionImporte] [decimal](18, 0) NOT NULL,
	[ValorPublicacionMoneda] [int] NOT NULL,
	[Observaciones] [text] NULL,
	[EsOtraInmobiliaria] [bit] NOT NULL,
	[MetrosCubiertos] [decimal](18, 2) NOT NULL,
	[MetrosSemicubiertos] [decimal](18, 2) NOT NULL,
	[MetrosLibres] [decimal](18, 2) NOT NULL,
	[TerrenoMetros] [decimal](18, 2) NOT NULL,
	[TerrenoFondo] [decimal](18, 2) NULL,
	[TerrenosFrente] [decimal](18, 2) NOT NULL,
	[Orientacion] [nvarchar](50) NOT NULL,
	[CantidadBanos] [int] NOT NULL,
	[CantidadCocheras] [int] NOT NULL,
	[CantidadDomritorios] [int] NOT NULL,
	[CantidadPlantas] [int] NOT NULL,
	[IdDepartamentoDisposicion] [int] NOT NULL,
	[EsAptoProfesional] [bit] NULL,
	[DeptoCantidadPisos] [int] NULL,
	[DeptoDepartamentosPorPiso] [int] NULL,
	[CantidadAscensores] [int] NULL,
	[CantidadAscensoresServicio] [int] NULL,
	[IdTipoZona] [int] NULL,
	[Fos] [nvarchar](50) NULL,
	[Fot] [nvarchar](50) NULL,
	[Zonificacion] [nvarchar](50) NULL,
	[MetrosContruibles] [int] NULL,
	[Antiguedad] [int] NULL,
	[IdInmobiliariaExterna] [int] NULL,
	[ValorExpensas] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Propiedades] PRIMARY KEY CLUSTERED 
(
	[IdPropiedad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[Pagos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagos](
	[IdPago] [int] IDENTITY(1,1) NOT NULL,
	[IdContrato] [int] NOT NULL,
	[Importe] [decimal](18, 0) NOT NULL,
	[IdMoneda] [int] NOT NULL,
	[Anulado] [bit] NOT NULL,
	[FechaPago] [datetime] NOT NULL,
	[MesCancelado] [int] NOT NULL,
	[FechaAlta] [datetime] NOT NULL,
	[AnioPagado] [int] NOT NULL,
 CONSTRAINT [PK_Pagos] PRIMARY KEY CLUSTERED 
(
	[IdPago] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[ValoresRenta]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ValoresRenta](
	[IdValorRenta] [int] IDENTITY(1,1) NOT NULL,
	[IdContrato] [int] NOT NULL,
	[IdMoneda] [int] NOT NULL,
	[Importe] [decimal](18, 0) NOT NULL,
	[AnioDesde] [int] NOT NULL,
	[AnioHasta] [int] NOT NULL,
	[MesDesde] [int] NOT NULL,
	[MesHasta] [int] NOT NULL,
 CONSTRAINT [PK_ValoresRenta] PRIMARY KEY CLUSTERED 
(
	[IdValorRenta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[Localidades]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidades](
	[IdLocalidad] [int] NOT NULL,
	[Nombre] [nvarchar](150) NOT NULL,
	[Default] [bit] NOT NULL,
	[IdProvincia] [int] NOT NULL,
 CONSTRAINT [PK_Localidades] PRIMARY KEY CLUSTERED 
(
	[IdLocalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[Clientes]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Nombres] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[NroDocumento] [nvarchar](20) NULL,
	[TipoDocumento] [int] NULL,
	[TelefonoParticular] [nvarchar](50) NULL,
	[TelefonoTrabajo] [nvarchar](50) NULL,
	[TelefonoCelular] [nvarchar](50) NULL,
	[Observaciones] [nvarchar](200) NULL,
	[FechaNacimiento] [datetime] NULL,
	[Email] [nvarchar](50) NULL,
	[Calle] [nvarchar](50) NULL,
	[Numero] [int] NULL,
	[Depto] [nvarchar](2) NULL,
	[Piso] [nvarchar](2) NULL,
	[CodigoPostal] [nvarchar](50) NULL,
	[CalleEntre1] [nvarchar](50) NULL,
	[CalleEntre2] [nvarchar](50) NULL,
	[IdBarrio] [int] NULL,
	[IdProvincia] [int] NULL,
	[IdPais] [int] NULL,
	[IdLocalidad] [int] NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[Barrios]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barrios](
	[IdBarrio] [int] NOT NULL,
	[Nombre] [nvarchar](150) NOT NULL,
	[Default] [bit] NOT NULL,
	[IdLocalidad] [int] NOT NULL,
 CONSTRAINT [PK_Barrios] PRIMARY KEY CLUSTERED 
(
	[IdBarrio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[Provincias]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincias](
	[IdProvincia] [int] NOT NULL,
	[Nombre] [nvarchar](150) NOT NULL,
	[Default] [bit] NOT NULL,
	[IdPais] [int] NOT NULL,
 CONSTRAINT [PK_Provincias] PRIMARY KEY CLUSTERED 
(
	[IdProvincia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[AdmAlquileres]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdmAlquileres](
	[IdPropiedad] [int] NOT NULL,
	[IdContacto] [int] NULL,
 CONSTRAINT [PK_AdmAlquileres] PRIMARY KEY CLUSTERED 
(
	[IdPropiedad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[Propietarios]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Propietarios](
	[IdCliente] [int] NOT NULL,
 CONSTRAINT [PK_Propietarios] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[ClientesPedido]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientesPedido](
	[IdCliente] [int] NOT NULL,
 CONSTRAINT [PK_ClientesPedido] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  Table [dbo].[Inquilinos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inquilinos](
	[IdCliente] [int] NOT NULL,
 CONSTRAINT [PK_Inquilinos] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto:  StoredProcedure [dbo].[Inquilino_Guardar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Inquilino_Guardar] 
	
	(
	@IdInquilino int
	)
	
AS
insert into Inquilinos (IdCliente) values (@IdInquilino)
SELECT @@ROWCOUNT
GO
/****** Objeto:  StoredProcedure [dbo].[AdmAlquileres_RecuperarPorNombreInquilino]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AdmAlquileres_RecuperarPorNombreInquilino]
	
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
GO
/****** Objeto:  StoredProcedure [dbo].[Inquilinos_RecuperarTodos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Inquilinos_RecuperarTodos]
	
AS
select
			c.[IdCliente]
		   ,c.[Nombres]
           ,c.[Apellido]
           ,c.[NroDocumento]
           ,c.[TipoDocumento]
           ,c.[TelefonoParticular]
           ,c.[TelefonoTrabajo]
           ,c.[TelefonoCelular]
           ,c.[Observaciones]
           ,c.[FechaNacimiento]
           ,c.[Email]
           ,c.[Calle]
           ,c.[Numero]
           ,c.[Depto]
           ,c.[Piso]
           ,c.[CodigoPostal]
           ,c.[CalleEntre1]
           ,c.[CalleEntre2]
           ,c.[IdBarrio]
           ,c.[IdProvincia]
           ,c.[IdPais]
           ,c.[IdLocalidad] 
from Inquilinos i , Clientes c
where i.IdCliente = c.IdCliente
GO
/****** Objeto:  StoredProcedure [dbo].[Inquilinos_RecuperarPorNombre]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Inquilinos_RecuperarPorNombre]
	
	(
	@Cadena nvarchar(15)
	)
	
AS
select		
			c.[IdCliente]
		   ,c.[Nombres]
           ,c.[Apellido]
           ,c.[NroDocumento]
           ,c.[TipoDocumento]
           ,c.[TelefonoParticular]
           ,c.[TelefonoTrabajo]
           ,c.[TelefonoCelular]
           ,c.[Observaciones]
           ,c.[FechaNacimiento]
           ,c.[Email]
           ,c.[Calle]
           ,c.[Numero]
           ,c.[Depto]
           ,c.[Piso]
           ,c.[CodigoPostal]
           ,c.[CalleEntre1]
           ,c.[CalleEntre2]
           ,c.[IdBarrio]
           ,c.[IdProvincia]
           ,c.[IdPais]
           ,c.[IdLocalidad] 
from Inquilinos i , Clientes c
where i.IdCliente = c.IdCliente and (c.Nombres Like '%'+@Cadena+'%' or c.Apellido like '%'+@Cadena+'%')
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_TiposDeAmbiente_RecuperarTodos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Propiedades_TiposDeAmbiente_RecuperarTodos] 

AS



SELECT        IdTipoambiente, Nombre, Codigo
FROM            TiposAmbiente
GO
/****** Objeto:  StoredProcedure [dbo].[MedidasAmbientes_RecuperarPorPropiedad]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MedidasAmbientes_RecuperarPorPropiedad] 
(
	@IdPropiedad int
)

AS


SELECT        MedidasAmbientesPropiedad.IdAmbiente, MedidasAmbientesPropiedad.Ancho, MedidasAmbientesPropiedad.Largo, MedidasAmbientesPropiedad.Ambiente, 
                         TiposDePiso.IdTipoPiso, TiposDePiso.Nombre, TiposAmbiente.IdTipoambiente, TiposAmbiente.Nombre AS NombreTipoAmbiente, 
                         TiposAmbiente.Codigo
FROM            MedidasAmbientesPropiedad INNER JOIN
                         TiposDePiso ON MedidasAmbientesPropiedad.IdTipoPiso = TiposDePiso.IdTipoPiso LEFT OUTER JOIN
                         TiposAmbiente ON MedidasAmbientesPropiedad.IdTipoAmbiente = TiposAmbiente.IdTipoambiente
WHERE        (MedidasAmbientesPropiedad.IdPropiedad = @IdPropiedad)
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_RecuperarNotas]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Propiedades_RecuperarNotas] 
(
	@IdPropiedad int
)
AS


SELECT        IdNota, IdPropiedad, Nota, Fecha
FROM            NotasPropiedad
WHERE        (IdPropiedad = @IdPropiedad)
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_EliminarNota]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Propiedades_EliminarNota]
(
	@IdNota int
)
AS


delete from notaspropiedad where idnota=@IdNota

select @@rowcount
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_InsertarNota]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Propiedades_InsertarNota]
(
	@IdPropiedad int,
	@Nota text,
	@Fecha datetime
)
AS


insert into notaspropiedad (idpropiedad, nota, fecha) values (	@IdPropiedad,@Nota,@Fecha )


select @@identity
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_RecuperarVisitas]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Propiedades_RecuperarVisitas] 
(
	@IdPropiedad int
)
AS



SELECT        IdVisita, TimpoAlarma, FechaHora, Realizada, Visita, Telefono, Comentario, ConAlarma, IdPropiedad
FROM            VisitasPropiedad
WHERE        (IdPropiedad = @IdPropiedad)
order by FechaHora
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_GuardarVisita]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Propiedades_GuardarVisita]
(
	@TimpoAlarma bigint,
	@FechaHora datetime,
	@Realizada bit,
	@Visita nvarchar(50),
	@Telefono nvarchar(50),
	@Comentario text,
	@ConAlarma bit,
	@IdPropiedad int
)
AS



insert into VisitasPropiedad (TimpoAlarma, FechaHora, Realizada, Visita, Telefono, Comentario, ConAlarma, IdPropiedad)
values (@TimpoAlarma, @FechaHora, @Realizada, @Visita, @Telefono, @Comentario, @ConAlarma, @IdPropiedad)

select @@identity
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_ActualizarVisita]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Propiedades_ActualizarVisita]
(
	@TimpoAlarma bigint,
	@FechaHora datetime,
	@Realizada bit,
	@Visita nvarchar(50),
	@Telefono nvarchar(50),
	@Comentario text,
	@ConAlarma bit,
	@IdVisita int
)
AS

update VisitasPropiedad set
TimpoAlarma=@TimpoAlarma, 
FechaHora=@FechaHora, 
Realizada=@Realizada, 
Visita=@Visita, 
Telefono=@Telefono, 
Comentario=@Comentario, 
ConAlarma=@ConAlarma

where IdVisita = @IdVisita

select @@rowcount
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_EliminarVisita]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Propiedades_EliminarVisita]
(
	
	@IdVisita int
)
AS

delete from VisitasPropiedad where idvisita=@IdVisita

select @@rowcount
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_Crear]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Propiedades_Crear] 
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
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_Actualizar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Propiedades_Actualizar]
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
GO
/****** Objeto:  StoredProcedure [dbo].[PropiedadesVentas_RecuperarPorTipo]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PropiedadesVentas_RecuperarPorTipo]
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
                      Propiedades.MetrosContruibles, Propiedades.Antiguedad
FROM         Propiedades INNER JOIN
                      Ventas ON Propiedades.IdPropiedad = Ventas.IdPropiedad
                      where IdTipoPropiedad = @IdTipoPropiedad
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedad_RecuperarPorId]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Propiedad_RecuperarPorId] 

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
GO
/****** Objeto:  StoredProcedure [dbo].[PropiedadesAlquileres_RecuperarPorEstadoYtipo]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PropiedadesAlquileres_RecuperarPorEstadoYtipo]
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
                      Propiedades.MetrosContruibles, Propiedades.Antiguedad
FROM         Propiedades INNER JOIN
                      Alquileres ON Propiedades.IdPropiedad = Alquileres.IdPropiedad
                      where IdEstadoPropiedad = @IdEstadoPropiedad
						and idTipoPropiedad = @IdTipoPropiedad
GO
/****** Objeto:  StoredProcedure [dbo].[PropiedadesAlquileres_RecuperarPorTipo]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PropiedadesAlquileres_RecuperarPorTipo]
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
                      Propiedades.MetrosContruibles, Propiedades.Antiguedad
FROM         Propiedades INNER JOIN
                      Alquileres ON Propiedades.IdPropiedad = Alquileres.IdPropiedad
                      where IdTipoPropiedad = @IdTipoPropiedad
GO
/****** Objeto:  StoredProcedure [dbo].[PropiedadesAlquileres_RecuperarPorEstado]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PropiedadesAlquileres_RecuperarPorEstado]
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
                      Propiedades.MetrosContruibles, Propiedades.Antiguedad
FROM         Propiedades INNER JOIN
                      Alquileres ON Propiedades.IdPropiedad = Alquileres.IdPropiedad
                      where IdEstadoPropiedad = @IdEstadoPropiedad
GO
/****** Objeto:  StoredProcedure [dbo].[PropiedadesAlquileres_RecuperarPorDireccion]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PropiedadesAlquileres_RecuperarPorDireccion]
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
                      Propiedades.MetrosContruibles, Propiedades.Antiguedad
FROM         Propiedades INNER JOIN
                      Alquileres ON Propiedades.IdPropiedad = Alquileres.IdPropiedad
                      where (Calle like  '%' + @Calle + '%') And (NumeroPostal = @Numero)
				Or (Calle like  '%' + @Calle + '%')
GO
/****** Objeto:  StoredProcedure [dbo].[PropiedadesAlquileres_RecuperarTodas]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PropiedadesAlquileres_RecuperarTodas] 
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
                      Propiedades.MetrosContruibles, Propiedades.Antiguedad
FROM         Propiedades INNER JOIN
                      Alquileres ON Propiedades.IdPropiedad = Alquileres.IdPropiedad
GO
/****** Objeto:  StoredProcedure [dbo].[PropiedadesVentas_RecuperarPorDireccion]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PropiedadesVentas_RecuperarPorDireccion]
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
                      Propiedades.MetrosContruibles, Propiedades.Antiguedad
FROM         Propiedades INNER JOIN
                      Ventas ON Propiedades.IdPropiedad = Ventas.IdPropiedad
                      where (Calle like  '%' + @Calle + '%') And (NumeroPostal = @Numero)
				Or (Calle like  '%' + @Calle + '%')
GO
/****** Objeto:  StoredProcedure [dbo].[PropiedadesVentas_RecuperarPorEstado]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PropiedadesVentas_RecuperarPorEstado]
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
                      Propiedades.MetrosContruibles, Propiedades.Antiguedad
FROM         Propiedades INNER JOIN
                      Ventas ON Propiedades.IdPropiedad = Ventas.IdPropiedad
                      where IdEstadoPropiedad = @IdEstadoPropiedad
GO
/****** Objeto:  StoredProcedure [dbo].[PropiedadesVentas_RecuperarPorEstadoYtipo]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PropiedadesVentas_RecuperarPorEstadoYtipo]
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
                      Propiedades.MetrosContruibles, Propiedades.Antiguedad
FROM         Propiedades INNER JOIN
                      Ventas ON Propiedades.IdPropiedad = Ventas.IdPropiedad
                      where IdEstadoPropiedad = @IdEstadoPropiedad
						and idTipoPropiedad = @IdTipoPropiedad
GO
/****** Objeto:  StoredProcedure [dbo].[PropiedadesAlquileres_RecuperarTodasOfrecidas]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
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
                      p.MetrosContruibles, p.antiguedad
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
/****** Objeto:  StoredProcedure [dbo].[PropiedadesVentas_RecuperarTodasOfrecidas]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
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
                      p.MetrosContruibles, p.Antiguedad
FROM         
	Propiedades p, 
    Ventas v,
	PropiedadesOfrecidasXPedido po
 
Where 
	p.IdPropiedad =  v.IdPropiedad and
	v.IdPropiedad = po.IdPropiedad and
	po.IdPedido = @IdPedido
GO
/****** Objeto:  StoredProcedure [dbo].[PropiedadesVentas_RecuperarTodas]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PropiedadesVentas_RecuperarTodas] 
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
                      Propiedades.MetrosContruibles, Propiedades.Antiguedad
FROM         Propiedades INNER JOIN
                      Ventas ON Propiedades.IdPropiedad = Ventas.IdPropiedad
GO
/****** Objeto:  StoredProcedure [dbo].[PropiedadesAlquileres_RecuperarTodasSinOfrecer]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PropiedadesAlquileres_RecuperarTodasSinOfrecer] 

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
                      Propiedades.MetrosContruibles, Propiedades.Antiguedad
FROM         Propiedades INNER JOIN
                      Alquileres ON Propiedades.IdPropiedad = Alquileres.IdPropiedad
Where 
	Propiedades.IdPropiedad not in (select IdPropiedad from dbo.PropiedadesOfrecidasXPedido where IdPedido = @IdPedido)

/*********************************************************************************/

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Objeto:  StoredProcedure [dbo].[PropiedadesVentas_RecuperarTodasSinOfrecer]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PropiedadesVentas_RecuperarTodasSinOfrecer] 

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
                      Propiedades.MetrosContruibles, Propiedades.Antiguedad
FROM         Propiedades INNER JOIN
                      Ventas ON Propiedades.IdPropiedad = Ventas.IdPropiedad
Where 
	Propiedades.IdPropiedad not in (select IdPropiedad from dbo.PropiedadesOfrecidasXPedido where IdPedido = @IdPedido)
GO
/****** Objeto:  StoredProcedure [dbo].[Pedidos_RecuperarPorNombreContacto]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pedidos_RecuperarPorNombreContacto] 
	(
	@Cadena nvarchar(50)
	)
AS
SELECT p.[IdPedido]
      ,p.[CantidadAmbientesFinal]
      ,p.[CantidadAmbientesInicial]
      ,p.[IdCategoria]
      ,p.[IdCliente]
      ,p.[Disposicion]
      ,p.[EnumEstado]
      ,p.[EsAptoProfesional]
      ,p.[IdEstadoPropiedad]
      ,p.[EstadoPropiedad]
      ,p.[MetrosConstruiblesFinal]
      ,p.[MetrosConstruiblesInicial]
      ,p.[MetrosCubiertosFinal]
      ,p.[MetrosCubiertosInicial]
      ,p.[MetrosTerrenoFinal]
      ,p.[MetrosTerrenoInicial]
      ,p.[IdTipoPropiedad]
      ,p.[TipoZona]
      ,p.[IdBarrio]
      ,p.[IdLocalidad]
      ,p.[IdPais]
      ,p.[IdProvincia]
      ,p.[ImporteFinal]
      ,p.[ImporteInicial]
      ,p.[IdMoneda]
	  ,p.Observaciones
	  ,p.Activo
	  ,p.FechaAlta
      ,cat.Nombre as NombreCategoria
  FROM Pedidos p, ClientesPedido cp , Clientes c, CategoriasPropiedad cat
  WHERE
  	cp.IdCliente = c.IdCliente and
	(c.Nombres Like '%'+@Cadena+'%' or c.Apellido like '%'+@Cadena+'%') and
	c.IdCliente = p.IdCliente and
	cat.IdCategoria =* p.IdCategoria


/************************************************************************************/

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON




/*************************************************************************/

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Objeto:  StoredProcedure [dbo].[ClientesPedido_RecuperarTodos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[ClientesPedido_RecuperarTodos]
	
AS
select
			c.[IdCliente]
		   ,c.[Nombres]
           ,c.[Apellido]
           ,c.[NroDocumento]
           ,c.[TipoDocumento]
           ,c.[TelefonoParticular]
           ,c.[TelefonoTrabajo]
           ,c.[TelefonoCelular]
           ,c.[Observaciones]
           ,c.[FechaNacimiento]
           ,c.[Email]
           ,c.[Calle]
           ,c.[Numero]
           ,c.[Depto]
           ,c.[Piso]
           ,c.[CodigoPostal]
           ,c.[CalleEntre1]
           ,c.[CalleEntre2]
           ,c.[IdBarrio]
           ,c.[IdProvincia]
           ,c.[IdPais]
           ,c.[IdLocalidad] 
from ClientesPedido cp , Clientes c
where cp.IdCliente = c.IdCliente
GO
/****** Objeto:  StoredProcedure [dbo].[ClientesPedido_RecuperarPorNombre]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[ClientesPedido_RecuperarPorNombre]
	
	(
	@Cadena nvarchar(15)
	)
	
AS
select		
			c.[IdCliente]
		   ,c.[Nombres]
           ,c.[Apellido]
           ,c.[NroDocumento]
           ,c.[TipoDocumento]
           ,c.[TelefonoParticular]
           ,c.[TelefonoTrabajo]
           ,c.[TelefonoCelular]
           ,c.[Observaciones]
           ,c.[FechaNacimiento]
           ,c.[Email]
           ,c.[Calle]
           ,c.[Numero]
           ,c.[Depto]
           ,c.[Piso]
           ,c.[CodigoPostal]
           ,c.[CalleEntre1]
           ,c.[CalleEntre2]
           ,c.[IdBarrio]
           ,c.[IdProvincia]
           ,c.[IdPais]
           ,c.[IdLocalidad] 
from ClientesPedido p , Clientes c
where p.IdCliente = c.IdCliente and (c.Nombres Like '%'+@Cadena+'%' or c.Apellido like '%'+@Cadena+'%')
GO
/****** Objeto:  StoredProcedure [dbo].[ClientePedido_Guardar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[ClientePedido_Guardar] 
	
	(
	@IdClientePedido int
	)
	
AS
insert into ClientesPedido (IdCliente) values (@IdClientePedido)
SELECT @@ROWCOUNT
GO
/****** Objeto:  StoredProcedure [dbo].[CategoriasPropiedad_RecuperarTodas]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CategoriasPropiedad_RecuperarTodas] 

AS

SELECT     IdCategoria, Nombre
FROM         CategoriasPropiedad
GO
/****** Objeto:  StoredProcedure [dbo].[Pedidos_RecuperarTodos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pedidos_RecuperarTodos] 

AS
SELECT p.[IdPedido]
      ,p.[CantidadAmbientesFinal]
      ,p.[CantidadAmbientesInicial]
      ,p.[IdCategoria]
      ,p.[IdCliente]
      ,p.[Disposicion]
      ,p.[EnumEstado]
      ,p.[EsAptoProfesional]
      ,p.[IdEstadoPropiedad]
      ,p.[EstadoPropiedad]
      ,p.[MetrosConstruiblesFinal]
      ,p.[MetrosConstruiblesInicial]
      ,p.[MetrosCubiertosFinal]
      ,p.[MetrosCubiertosInicial]
      ,p.[MetrosTerrenoFinal]
      ,p.[MetrosTerrenoInicial]
      ,p.[IdTipoPropiedad]
      ,p.[TipoZona]
      ,p.[IdBarrio]
      ,p.[IdLocalidad]
      ,p.[IdPais]
      ,p.[IdProvincia]
      ,p.[ImporteFinal]
      ,p.[ImporteInicial]
      ,p.[IdMoneda]
	  ,p.Observaciones
	  ,p.Activo
	  ,p.FechaAlta
	  ,cat.Nombre as NombreCategoria
  FROM Pedidos p, CategoriasPropiedad cat
where cat.IdCategoria =* p.IdCategoria


/********************************************************************/

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Objeto:  StoredProcedure [dbo].[Pedidos_RecuperarTodosSinOfrecer]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Pedidos_RecuperarTodosSinOfrecer] 
(
	@IdPropiedad int
)
AS
SELECT p.[IdPedido]
      ,p.[CantidadAmbientesFinal]
      ,p.[CantidadAmbientesInicial]
      ,p.[IdCategoria]
      ,p.[IdCliente]
      ,p.[Disposicion]
      ,p.[EnumEstado]
      ,p.[EsAptoProfesional]
      ,p.[IdEstadoPropiedad]
      ,p.[EstadoPropiedad]
      ,p.[MetrosConstruiblesFinal]
      ,p.[MetrosConstruiblesInicial]
      ,p.[MetrosCubiertosFinal]
      ,p.[MetrosCubiertosInicial]
      ,p.[MetrosTerrenoFinal]
      ,p.[MetrosTerrenoInicial]
      ,p.[IdTipoPropiedad]
      ,p.[TipoZona]
      ,p.[IdBarrio]
      ,p.[IdLocalidad]
      ,p.[IdPais]
      ,p.[IdProvincia]
      ,p.[ImporteFinal]
      ,p.[ImporteInicial]
      ,p.[IdMoneda]
	  ,p.Observaciones
	  ,p.Activo
	  ,p.FechaAlta
	  ,cat.Nombre as NombreCategoria
  FROM Pedidos p, CategoriasPropiedad cat
where cat.IdCategoria =* p.IdCategoria and @IdPropiedad not in (select IdPropiedad from PropiedadesOfrecidasXPedido where IdPedido = p.IdPedido)

/********************************************************************/

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Objeto:  StoredProcedure [dbo].[TiposPropiedad_RecuperarTodos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposPropiedad_RecuperarTodos] 

AS
	SELECT     IdTipoPropiedad, Nombre, IdCategoria
	FROM         TiposPropiedad
GO
/****** Objeto:  StoredProcedure [dbo].[TiposPropiedad_RecuperarPorCategoria]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposPropiedad_RecuperarPorCategoria] 
(
	@IdCategoria int
)
AS

SELECT     IdTipoPropiedad, Nombre
FROM         TiposPropiedad
WHERE     (IdCategoria = @IdCategoria)
GO
/****** Objeto:  StoredProcedure [dbo].[EstadosPropiedad_RecuperarPorClase]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EstadosPropiedad_RecuperarPorClase] 	
(
	@Clase nvarchar(50)
)
	
AS

SELECT     IdEstadoPropiedad, Nombre
FROM         EstadosPropiedad
WHERE     (TipoClasePropiedad = @Clase)
GO
/****** Objeto:  StoredProcedure [dbo].[InmobiliariaExterna_Actualizar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[InmobiliariaExterna_Actualizar]
(
	@Nombre nvarchar(100),
	@Telefono nvarchar(100),
	@Contacto nvarchar(100),
	@IdInmobiliaria int
)
AS


update inmobiliariasExternas set nombre= @Nombre, telefono=@Telefono, contacto=@Contacto
where idinmobiliaria = @IdInmobiliaria


select @@rowcount
GO
/****** Objeto:  StoredProcedure [dbo].[InmobiliariaExterna_RecuperarTodas]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[InmobiliariaExterna_RecuperarTodas]

AS



select nombre, telefono, contacto, idinmobiliaria from inmobiliariasExternas
GO
/****** Objeto:  StoredProcedure [dbo].[InmobiliariaExterna_Insertar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InmobiliariaExterna_Insertar] 
(
	@Nombre nvarchar(100),
	@Telefono nvarchar(100),
	@Contacto nvarchar(100)
)
AS

insert into inmobiliariasExternas values (@Nombre, @Telefono, @Contacto)

select @@identity
GO
/****** Objeto:  StoredProcedure [dbo].[TiposDePiso_RecuperarTodos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposDePiso_RecuperarTodos] 

AS


SELECT        IdTipoPiso, Nombre
FROM            TiposDePiso
GO
/****** Objeto:  StoredProcedure [dbo].[Provincias_RecuperarTodas]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Provincias_RecuperarTodas] 

AS

SELECT     IdProvincia, Nombre, [Default], IdPais
FROM         Provincias order by idprovincia
GO
/****** Objeto:  StoredProcedure [dbo].[Localidades_RecuperarTodas]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Localidades_RecuperarTodas] 

AS
	SELECT     IdLocalidad, Nombre, [Default], IdProvincia
	FROM         Localidades order by nombre
GO
/****** Objeto:  StoredProcedure [dbo].[Barrios_RecuperarTodos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Barrios_RecuperarTodos] 

AS

SELECT     IdBarrio, Nombre, [Default], IdLocalidad
FROM         Barrios order by nombre
GO
/****** Objeto:  StoredProcedure [dbo].[Paises_RecuperarTodos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Paises_RecuperarTodos] 

AS

SELECT     IdPais, Nombre, [Default]
FROM         Paises
GO
/****** Objeto:  StoredProcedure [dbo].[Pedido_MarcarPropiedadOfrecida]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
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
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_RecuperarLlamados]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Propiedades_RecuperarLlamados] 
(
	@IdPropiedad int
)
AS


SELECT        IdLlamado, FechaHora, Contacto, Telefono, Comentarios, IdPropiedad
FROM            Llamados
WHERE        (IdPropiedad = @IdPropiedad)
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_CrearLlamado]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Propiedades_CrearLlamado]
(
	@IdPropiedad int,
	@FechaHora datetime,
	@Contacto nvarchar(50),
	@Telefono nvarchar(50),
	@Comentarios text
)
AS



insert into Llamados values (@FechaHora,@Contacto,@Telefono,@Comentarios,@IdPropiedad)

select @@identity
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_ActualizarLlamado]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Propiedades_ActualizarLlamado]
(
	@IdLlamado int,
	@FechaHora datetime,
	@Contacto nvarchar(50),
	@Telefono nvarchar(50),
	@Comentarios text
)
AS

update llamados set FechaHora=@FechaHora, Contacto=@Contacto, Telefono=@Telefono, Comentarios=@Comentarios
where idllamado=@IdLlamado

select @@rowcount
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_EliminarLlamado]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Propiedades_EliminarLlamado]
(
	@IdLlamado int
)
AS


delete from llamados where idllamado = @IdLlamado


select @@rowcount
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_EliminarPublicacion]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Propiedades_EliminarPublicacion] 
(
	@IdPublicacion int
	)
AS

delete from publicaciones where idpublicacion = @IdPublicacion
select @@rowcount
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_CrearPublicacion]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Propiedades_CrearPublicacion]
(
	@IdPropiedad int, 
	@Fecha datetime, 
	@Medio nvarchar(50), 
	@Detalles text, 
	@IdMoneda int, 
	@Importe decimal
)
AS


insert into Publicaciones values (@IdPropiedad, @Fecha, @Medio, @Detalles, @IdMoneda, @Importe)

select @@identity
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_RecuperarPublicaciones]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Propiedades_RecuperarPublicaciones] 
(
	@IdPropiedad int
)
AS



SELECT        IdPublicacion, IdPropiedad, Fecha, Medio, Detalles, IdMoneda, Importe
FROM            Publicaciones
WHERE        (IdPropiedad = @IdPropiedad)
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_ActualizarPublicacion]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Propiedades_ActualizarPublicacion]
(
	@IdPublicacion int, 
	@Fecha datetime, 
	@Medio nvarchar(50), 
	@Detalles text, 
	@IdMoneda int, 
	@Importe decimal
)
AS


update Publicaciones set Fecha=@Fecha, medio=@Medio, detalles=@Detalles, idmoneda=@IdMoneda, importe=@Importe
where idpublicacion = @IdPublicacion

select @@rowcount
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_EliminarFoto]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Propiedades_EliminarFoto] 
(
	@IdFoto int
)

AS

delete from GaleriaFotos where idfoto = @IdFoto


select @@rowcount
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_GuardarFoto]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Propiedades_GuardarFoto] 
(
	@IdPropiedad int,
	@EsFachada bit,
	@Descripcion nvarchar(50),
	@Foto image
)

AS

insert into GaleriaFotos values (@IdPropiedad,@Foto,@EsFachada,@Descripcion)


select @@identity
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_RecuperarGaleria]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Propiedades_RecuperarGaleria] 
(
	@IdPropiedad int
)

AS

SELECT        IdFoto, Foto, Descripcion, EsFachada
FROM            GaleriaFotos
WHERE        (IdPropiedad = @IdPropiedad)
GO
/****** Objeto:  StoredProcedure [dbo].[AdmAlquileres_RecuperarPorEstadoPropiedad]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AdmAlquileres_RecuperarPorEstadoPropiedad]
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
GO
/****** Objeto:  StoredProcedure [dbo].[AdmAlquileres_RecuperarPorDireccion]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AdmAlquileres_RecuperarPorDireccion]
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
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_CrearAlquiler]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Propiedades_CrearAlquiler]
(
       @IdPropiedad INT
)
AS



insert into 	Alquileres values (@IdPropiedad)




select @@ROWCOUNT
GO
/****** Objeto:  StoredProcedure [dbo].[AdmAlquileres_RecuperarPorEstadoYTipoPropiedad]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AdmAlquileres_RecuperarPorEstadoYTipoPropiedad]
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
GO
/****** Objeto:  StoredProcedure [dbo].[AdmAlquileres_RecuperarPorTipoPropiedad]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AdmAlquileres_RecuperarPorTipoPropiedad]
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
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_CrearVenta]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Propiedades_CrearVenta]
(
       @IdPropiedad INT
)
AS



insert into 	Ventas values (@IdPropiedad)




select @@ROWCOUNT
GO
/****** Objeto:  StoredProcedure [dbo].[Pedido_Actualizar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pedido_Actualizar] 
	(
					@IdPedido int,
					@CantidadAmbientesFinal decimal(18,1),
                    @CantidadAmbientesInicial decimal(18,1),
                    @IdCategoria int,
                    @IdCliente int ,
                    @Disposicion int,
                    @EnumEstado int,
                    @EsAptoProfesional bit,
                    @IdEstadoPropiedad int,
                    @EstadoPropiedad nvarchar(50),
                    @MetrosConstruiblesFinal int,
                    @MetrosConstruiblesInicial int,
                    @MetrosCubiertosFinal int, 
                    @MetrosCubiertosInicial int,
                    @MetrosTerrenoFinal int, 
                    @MetrosTerrenoInicial int,
                    @IdTipoPropiedad int,
                    @TipoZona int,
                    @IdBarrio int,
                    @IdLocalidad int,
                    @IdPais int,
                    @IdProvincia int,
                    @ImporteFinal int,
                    @ImporteInicial int,
                    @IdMoneda int,
					@Observaciones nvarchar(500),
					@Activo bit,
					@FechaAlta datetime
	)
AS
UPDATE [dbo].[Pedidos]
   SET [CantidadAmbientesFinal] = @CantidadAmbientesFinal
      ,[CantidadAmbientesInicial] = @CantidadAmbientesInicial
      ,[IdCategoria] = @IdCategoria
      ,[IdCliente] = @IdCliente
      ,[Disposicion] =  @Disposicion
      ,[EnumEstado] = @EnumEstado
      ,[EsAptoProfesional] = @EsAptoProfesional
      ,[IdEstadoPropiedad] = @IdEstadoPropiedad
      ,[EstadoPropiedad] = @EstadoPropiedad
      ,[MetrosConstruiblesFinal] = @MetrosConstruiblesFinal
      ,[MetrosConstruiblesInicial] = @MetrosConstruiblesInicial
      ,[MetrosCubiertosFinal] = @MetrosCubiertosFinal 
      ,[MetrosCubiertosInicial] = @MetrosCubiertosInicial
      ,[MetrosTerrenoFinal] = @MetrosTerrenoFinal 
      ,[MetrosTerrenoInicial] = @MetrosTerrenoInicial
      ,[IdTipoPropiedad] = @IdTipoPropiedad
      ,[TipoZona] = @TipoZona
      ,[IdBarrio] = @IdBarrio
      ,[IdLocalidad] = @IdLocalidad
      ,[IdPais] = @IdPais
      ,[IdProvincia] = @IdProvincia
      ,[ImporteFinal] = @ImporteFinal
      ,[ImporteInicial] = @ImporteInicial
      ,[IdMoneda] = @IdMoneda
	  ,[Observaciones] = @Observaciones
	  ,[Activo] = @Activo
	  ,[FechaAlta] = @FechaAlta
 WHERE IdPedido = @IdPedido
 
 select @@rowcount
GO
/****** Objeto:  StoredProcedure [dbo].[Pedido_Guardar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pedido_Guardar] 
	
	(
					@CantidadAmbientesFinal decimal(18,1),
                    @CantidadAmbientesInicial decimal(18,1),
                    @IdCategoria int,
                    @IdCliente int ,
                    @Disposicion int,
                    @EnumEstado int,
                    @EsAptoProfesional bit,
                    @IdEstadoPropiedad int,
                    @EstadoPropiedad nvarchar(50),
                    @MetrosConstruiblesFinal int,
                    @MetrosConstruiblesInicial int,
                    @MetrosCubiertosFinal int, 
                    @MetrosCubiertosInicial int,
                    @MetrosTerrenoFinal int, 
                    @MetrosTerrenoInicial int,
                    @IdTipoPropiedad int,
                    @TipoZona int,
                    @IdBarrio int,
                    @IdLocalidad int,
                    @IdPais int,
                    @IdProvincia int,
                    @ImporteFinal int,
                    @ImporteInicial int,
                    @IdMoneda int,
					@Observaciones nvarchar(500),
					@Activo bit,
					@FechaAlta datetime
	)
	
AS
INSERT INTO [dbo].[Pedidos]
           ([CantidadAmbientesFinal]
           ,[CantidadAmbientesInicial]
           ,[IdCategoria]
           ,[IdCliente]
           ,[Disposicion]
           ,[EnumEstado]
           ,[EsAptoProfesional]
           ,[IdEstadoPropiedad]
           ,[EstadoPropiedad]
           ,[MetrosConstruiblesFinal]
           ,[MetrosConstruiblesInicial]
           ,[MetrosCubiertosFinal]
           ,[MetrosCubiertosInicial]
           ,[MetrosTerrenoFinal]
           ,[MetrosTerrenoInicial]
           ,[IdTipoPropiedad]
           ,[TipoZona]
           ,[IdBarrio]
           ,[IdLocalidad]
           ,[IdPais]
           ,[IdProvincia]
           ,[ImporteFinal]
           ,[ImporteInicial]
           ,[IdMoneda]
		   ,Observaciones
		   ,Activo
			,FechaAlta	)
     VALUES
           (@CantidadAmbientesFinal,
            @CantidadAmbientesInicial,
            @IdCategoria,
            @IdCliente,
            @Disposicion,
            @EnumEstado,
            @EsAptoProfesional,
            @IdEstadoPropiedad,
            @EstadoPropiedad,
            @MetrosConstruiblesFinal,
            @MetrosConstruiblesInicial,
            @MetrosCubiertosFinal ,
            @MetrosCubiertosInicial,
            @MetrosTerrenoFinal ,
            @MetrosTerrenoInicial,
            @IdTipoPropiedad,
            @TipoZona,
            @IdBarrio,
            @IdLocalidad,
            @IdPais,
            @IdProvincia,
            @ImporteFinal,
            @ImporteInicial,
            @IdMoneda,
			@Observaciones,
			@Activo,
			@FechaAlta)

select @@identity

/**************************************************************************************/

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Objeto:  StoredProcedure [dbo].[AdmAlquileres_RecuperarTodos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AdmAlquileres_RecuperarTodos]

	
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
GO
/****** Objeto:  StoredProcedure [dbo].[AdmAlquiler_Actualizar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AdmAlquiler_Actualizar] ( @IdPropiedad int, @IdContacto int ) AS UPDATE [dbo].[AdmAlquileres] SET [IdContacto] = @IdContacto WHERE IdPropiedad = @IdPropiedad SELECT @@rowcount
GO
/****** Objeto:  StoredProcedure [dbo].[AdmAlquiler_Guardar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AdmAlquiler_Guardar] ( @IdPropiedad int, @IdContacto int ) AS INSERT INTO [dbo].[AdmAlquileres] ([IdPropiedad] ,[IdContacto]) VALUES ( @IdPropiedad , @IdContacto ) SELECT @@rowcount
GO
/****** Objeto:  StoredProcedure [dbo].[AdmAlquileres_RecuperarPorCodigoPropiedad]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AdmAlquileres_RecuperarPorCodigoPropiedad]
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
GO
/****** Objeto:  StoredProcedure [dbo].[AdmAlquiler_Eliminar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AdmAlquiler_Eliminar] 

	(
	@IdPropiedad int
	)
AS
delete from admAlquileres where idpropiedad = @IdPropiedad
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_CrearTasacion]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Propiedades_CrearTasacion] 
(
	@IdPropiedad int,
	@Fecha datetime,
	@ImporteReal decimal,
	@ImportePublicacion decimal,
	@IdMonedaReal int,
	@IdMonedaPublicacion int,
	@Comentarios text

)
AS

insert into Tasaciones values (@IdPropiedad,@Fecha,@ImporteReal,@ImportePublicacion,@IdMonedaReal,@IdMonedaPublicacion,@Comentarios)

select @@identity
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_RecuperarTasaciones]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Propiedades_RecuperarTasaciones]
(
	@IdPropiedad int
)
AS

SELECT        IdTasacion, IdPropiedad, Fecha, ImporteValorReal, ImporteValorPublicacion, IdMonedaValorReal, IdMonedaValorPublicacion, Comentarios
FROM            Tasaciones
WHERE        (IdPropiedad = @IdPropiedad)
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_ModificarTasacion]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Propiedades_ModificarTasacion] 
(
	@IdTasacion int,
	@Fecha datetime,
	@ImporteReal decimal,
	@ImportePublicacion decimal,
	@IdMonedaReal int,
	@IdMonedaPublicacion int,
	@Comentarios text

)
AS


update Tasaciones set 
Fecha=@Fecha,
ImporteValorReal=@ImporteReal,
ImporteValorPublicacion=@ImportePublicacion,
IdMonedaValorReal=@IdMonedaReal,
IdMonedaValorPublicacion=@IdMonedaPublicacion,
Comentarios=@Comentarios
where idtasacion = @IdTasacion

select @@rowcount
GO
/****** Objeto:  StoredProcedure [dbo].[Propiedades_EliminarTasacion]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Propiedades_EliminarTasacion] 
(
	@IdTasacion int
)
AS


delete from tasaciones where idtasacion=@idtasacion
GO
/****** Objeto:  StoredProcedure [dbo].[Contrato_Actualizar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Contrato_Actualizar]
	(
			@IdContrato int
		   ,@IdInquilino int
           ,@IdPropiedad int
           ,@FechaInicio datetime
           ,@FechaVencimiento datetime
           ,@MontoDeposito decimal(18,0)
           ,@IdMonedaDeposito int
           ,@DiaVencimientoCuota tinyint
           ,@IdContratoAnterior int
           ,@FechaCancelacion datetime	
           ,@Observaciones nvarchar (400)
			,@Vigente bit
	)
	
AS
UPDATE [dbo].[Contratos]
SET

           [IdInquilino]= @IdInquilino 
           ,[IdPropiedad] = @IdPropiedad 
           ,[FechaInicio] = @FechaInicio 
           ,[FechaVencimiento] = @FechaVencimiento 
           ,[MontoDeposito] = @MontoDeposito 
           ,[IdMonedaDeposito] = @IdMonedaDeposito 
           ,[DiaVencimientoCuota] = @DiaVencimientoCuota 
           ,[IdContratoAnterior] = @IdContratoAnterior 
           ,[FechaCancelacion] = @FechaCancelacion 
           ,[Observaciones] = @Observaciones 
			,Vigente = @Vigente
           WHERE IdContrato =@IdContrato

           
           select @@ROWCOUNT
GO
/****** Objeto:  StoredProcedure [dbo].[Contrato_Guardar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Contrato_Guardar]	
	(
			@IdInquilino int
           ,@IdPropiedad int
           ,@FechaInicio datetime
           ,@FechaVencimiento datetime
           ,@MontoDeposito decimal(18,0)
           ,@IdMonedaDeposito int
           ,@DiaVencimientoCuota tinyint
           ,@IdContratoAnterior int
           ,@FechaCancelacion datetime	
           ,@Observaciones nvarchar (400)
			, @Vigente bit
	)
	
AS
INSERT INTO [dbo].[Contratos]
           ([IdInquilino]
           ,[IdPropiedad]
           ,[FechaInicio]
           ,[FechaVencimiento]
           ,[MontoDeposito]
           ,[IdMonedaDeposito]
           ,[DiaVencimientoCuota]
           ,[IdContratoAnterior]
           ,[FechaCancelacion]
           ,[Observaciones]
			, Vigente)
     VALUES
           (
            @IdInquilino 
           ,@IdPropiedad 
           ,@FechaInicio 
           ,@FechaVencimiento 
           ,@MontoDeposito 
           ,@IdMonedaDeposito 
           ,@DiaVencimientoCuota 
           ,@IdContratoAnterior 
           ,@FechaCancelacion 	
           ,@Observaciones 
			, @Vigente)
           
           select @@IDENTITY


set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Objeto:  StoredProcedure [dbo].[Contratos_RecuperarPorAdmAlquiler]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Contratos_RecuperarPorAdmAlquiler] 
	(
	@IdAdmAlquiler int
	)
AS
SELECT [IdContrato]
      ,[IdInquilino]
      ,[IdPropiedad]
      ,[FechaInicio]
      ,[FechaVencimiento]
      ,[MontoDeposito]
      ,[IdMonedaDeposito]
      ,[DiaVencimientoCuota]
      ,[IdContratoAnterior]
      ,[FechaCancelacion]
      ,[Observaciones]
      ,[Vigente]
  FROM [dbo].[Contratos]
where IdPropiedad = @IdAdmAlquiler


set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Objeto:  StoredProcedure [dbo].[Cliente_Actualizar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Cliente_Actualizar]
	
	(
	@IdCliente int,
	@Nombres nvarchar(50),
	@Apellido nvarchar(50),
	@NroDocumento nvarchar(20),
	@TipoDocumento int,
	@TelefonoParticular nvarchar(50),
	@TelefonoTrabajo nvarchar(50),
	@TelefonoCelular nvarchar(50),
	@Observaciones nvarchar(200),
	@FechaNacimiento datetime,
	@Email nvarchar(50),
	@Calle nvarchar(50),
	@Numero int,
	@Depto  nvarchar(2),
	@Piso nvarchar(2),
	@CodigoPostal nvarchar(50),
	@CalleEntre1 nvarchar(50),
	@CalleEntre2 nvarchar(50),
	@IdBarrio int,
	@IdProvincia int,
	@IdPais int,
	@IdLocalidad int
	)
	
AS
UPDATE Clientes
SET
           [Nombres] = @Nombres
           ,[Apellido] = @Apellido
           ,[NroDocumento] = @NroDocumento
           ,[TipoDocumento] = @TipoDocumento
           ,[TelefonoParticular] = @TelefonoParticular
           ,[TelefonoTrabajo] = @TelefonoTrabajo
           ,[TelefonoCelular] = @TelefonoCelular
           ,[Observaciones] = @Observaciones
           ,[FechaNacimiento] = @FechaNacimiento
           ,[Email] = @Email
           ,[Calle] = @Calle
           ,[Numero] = @Numero
           ,[Depto] = @Depto
           ,[Piso] = @Piso
           ,[CodigoPostal] = @CodigoPostal
           ,[CalleEntre1] = @CalleEntre1
           ,[CalleEntre2] = @CalleEntre2
           ,[IdBarrio] = @IdBarrio
           ,[IdProvincia] = @IdProvincia
           ,[IdPais] = @IdPais
           ,[IdLocalidad] = @IdLocalidad
WHERE IdCliente = @IdCliente
	
SELECT @@ROWCOUNT

/********************************************************************/

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Objeto:  StoredProcedure [dbo].[Cliente_Guardar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Cliente_Guardar] 
	
	(
	@Nombres nvarchar(50),
	@Apellido nvarchar(50),
	@NroDocumento nvarchar(20),
	@TipoDocumento int,
	@TelefonoParticular nvarchar(50),
	@TelefonoTrabajo nvarchar(50),
	@TelefonoCelular nvarchar(50),
	@Observaciones nvarchar(200),
	@FechaNacimiento datetime,
	@Email nvarchar(50),
	@Calle nvarchar(50),
	@Numero int,
	@Depto  nvarchar(2),
	@Piso nvarchar(2),
	@CodigoPostal nvarchar(50),
	@CalleEntre1 nvarchar(50),
	@CalleEntre2 nvarchar(50),
	@IdBarrio int,
	@IdProvincia int,
	@IdPais int,
	@IdLocalidad int
	)
	
AS
INSERT INTO Clientes
           ([Nombres]
           ,[Apellido]
           ,[NroDocumento]
           ,[TipoDocumento]
           ,[TelefonoParticular]
           ,[TelefonoTrabajo]
           ,[TelefonoCelular]
           ,[Observaciones]
           ,[FechaNacimiento]
           ,[Email]
           ,[Calle]
           ,[Numero]
           ,[Depto]
           ,[Piso]
           ,[CodigoPostal]
           ,[CalleEntre1]
           ,[CalleEntre2]
           ,[IdBarrio]
           ,[IdProvincia]
           ,[IdPais]
           ,[IdLocalidad])
     VALUES
           (	
			@Nombres,
			@Apellido ,
			@NroDocumento,
			@TipoDocumento ,
			@TelefonoParticular,
			@TelefonoTrabajo ,
			@TelefonoCelular ,
			@Observaciones ,
			@FechaNacimiento ,
			@Email ,
			@Calle ,
			@Numero ,
			@Depto  ,
			@Piso,
			@CodigoPostal ,
			@CalleEntre1 ,
			@CalleEntre2 ,
			@IdBarrio ,
			@IdProvincia ,
			@IdPais ,
			@IdLocalidad 
	)
SELECT @@IDENTITY
GO
/****** Objeto:  StoredProcedure [dbo].[SMTP_GuardarParametros]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SMTP_GuardarParametros] 
(
	@AutenticacionSmtp bit,
	@Email nvarchar(50),
	@Host nvarchar(50),
	@Nombre nvarchar(50),
	@Password nvarchar(10),
	@Puerto int,
	@SSL bit,
	@UserName nvarchar(50)
)
AS


delete from smtp;
insert into smtp values (@AutenticacionSmtp,@Email,@Host,@Nombre,@Password,@Puerto,@SSL,@UserName);

select @@rowcount
GO
/****** Objeto:  StoredProcedure [dbo].[SMTP_RecuperarConfiguracion]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SMTP_RecuperarConfiguracion]

AS


SELECT       top 1 AutenticacionSmtp, Email, Host, Nombre, Password, Puerto, SSL, UserName
FROM            Smtp
GO
/****** Objeto:  StoredProcedure [dbo].[ValorRenta_Actualizar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ValorRenta_Actualizar]
	
	(
		@IdValorRenta int,
		@Importe decimal(18,0), 
		@IdMoneda int, 
		@MesDesde int, 
		@AnioDesde int, 
		@MesHasta int, 
		@AnioHasta int
	)
	
AS
UPDATE [dbo].[ValoresRenta]
   SET 
       [IdMoneda] = @IdMoneda
      ,[Importe] = @Importe
      ,[AnioDesde] = @AnioDesde
      ,[AnioHasta] = @AnioHasta
      ,[MesDesde] = @MesDesde
      ,[MesHasta] = @MesHasta
WHERE IdValorRenta = @IdValorRenta
          
          select @@rowcount
GO
/****** Objeto:  StoredProcedure [dbo].[ValorRenta_Eliminar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ValorRenta_Eliminar]
	
	(
		@IdValorRenta int
	)
	
AS
delete [dbo].[ValoresRenta]
WHERE IdValorRenta = @IdValorRenta
          
          select @@rowcount
GO
/****** Objeto:  StoredProcedure [dbo].[ValorRenta_Guardar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ValorRenta_Guardar] 
	
	(
		@IdContrato int, 
		@Importe decimal(18,0), 
		@IdMoneda int, 
		@MesDesde int, 
		@AnioDesde int, 
		@MesHasta int, 
		@AnioHasta int
	)
	
AS
INSERT INTO [dbo].[ValoresRenta]
           (
            [IdContrato]
           ,[IdMoneda]
           ,[Importe]
           ,[AnioDesde]
           ,[AnioHasta]
           ,[MesDesde]
           ,[MesHasta])
     VALUES
           (
           @IdContrato
           ,@IdMoneda
           ,@Importe
           ,@AnioDesde
           ,@AnioHasta
           ,@MesDesde
           ,@MesHasta)
          
          select @@identity
GO
/****** Objeto:  StoredProcedure [dbo].[ValoresRenta_RecuperarPorContrato]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[ValoresRenta_RecuperarPorContrato]
	
	(
		@IdContrato int
	)
	
AS
SELECT [IdValorRenta]
      ,[IdContrato]
      ,[IdMoneda]
      ,[Importe]
      ,[AnioDesde]
      ,[AnioHasta]
      ,[MesDesde]
      ,[MesHasta]
  FROM [dbo].[ValoresRenta]
WHERE IdContrato = @IdContrato
GO
/****** Objeto:  StoredProcedure [dbo].[Propietarios_RecuperarTodos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Propietarios_RecuperarTodos] 
	
AS
select
			c.[IdCliente]
		   ,c.[Nombres]
           ,c.[Apellido]
           ,c.[NroDocumento]
           ,c.[TipoDocumento]
           ,c.[TelefonoParticular]
           ,c.[TelefonoTrabajo]
           ,c.[TelefonoCelular]
           ,c.[Observaciones]
           ,c.[FechaNacimiento]
           ,c.[Email]
           ,c.[Calle]
           ,c.[Numero]
           ,c.[Depto]
           ,c.[Piso]
           ,c.[CodigoPostal]
           ,c.[CalleEntre1]
           ,c.[CalleEntre2]
           ,c.[IdBarrio]
           ,c.[IdProvincia]
           ,c.[IdPais]
           ,c.[IdLocalidad] 
from Propietarios p , Clientes c
where p.IdCliente = c.IdCliente
GO
/****** Objeto:  StoredProcedure [dbo].[Propietarios_RecuperarPorNombre]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Propietarios_RecuperarPorNombre] 
	
	(
	@Cadena nvarchar(15)
	)
	
AS
select		
			c.[IdCliente]
		   ,c.[Nombres]
           ,c.[Apellido]
           ,c.[NroDocumento]
           ,c.[TipoDocumento]
           ,c.[TelefonoParticular]
           ,c.[TelefonoTrabajo]
           ,c.[TelefonoCelular]
           ,c.[Observaciones]
           ,c.[FechaNacimiento]
           ,c.[Email]
           ,c.[Calle]
           ,c.[Numero]
           ,c.[Depto]
           ,c.[Piso]
           ,c.[CodigoPostal]
           ,c.[CalleEntre1]
           ,c.[CalleEntre2]
           ,c.[IdBarrio]
           ,c.[IdProvincia]
           ,c.[IdPais]
           ,c.[IdLocalidad] 
from Propietarios p , Clientes c
where p.IdCliente = c.IdCliente and (c.Nombres Like '%'+@Cadena+'%' or c.Apellido like '%'+@Cadena+'%')

/***************** CLIENTES PROPIETARIO RECUPERAR TODOS ************************/
GO
/****** Objeto:  StoredProcedure [dbo].[Propietario_Guardar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Propietario_Guardar] 
	
	(
	@IdPropietario int
	)
	
AS
insert into Propietarios (IdCliente) values (@IdPropietario)
SELECT @@ROWCOUNT
GO
/****** Objeto:  StoredProcedure [dbo].[Pago_Actualizar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pago_Actualizar]
	
	(
		@IdPago int,
		@Anulado bit, 
		@FechaPago datetime, 
		@IdContrato int, 
		@Importe decimal(18,0), 
		@IdMoneda int, 
		@MesCancelado int,
		@FechaAlta datetime,
		@AnioPagado int
		
	)
	
AS
UPDATE [dbo].[Pagos]
   SET [IdContrato] = @IdContrato
      ,[Importe] = @Importe
      ,[IdMoneda] = @IdMoneda
      ,[Anulado] = @Anulado
      ,[FechaPago] = @FechaPago
      ,[MesCancelado] = @MesCancelado
      ,[FechaAlta] = @FechaAlta
	  ,[AnioPagado] = @AnioPagado
 WHERE IdPago = @IdPago
 
 select @@rowcount
GO
/****** Objeto:  StoredProcedure [dbo].[Pagos_RecuperarPorContrato]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pagos_RecuperarPorContrato] 
	
	(
	@IdContrato int 
	)
	
AS
SELECT [IdPago]
      ,[IdContrato]
      ,[Importe]
      ,[IdMoneda]
      ,[Anulado]
	  ,[MesCancelado]
	  ,[FechaPago]	
	  ,[FechaAlta]
	  ,[AnioPagado]
  FROM [dbo].[Pagos]
where IdContrato = @IdContrato and Anulado = 0

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Objeto:  StoredProcedure [dbo].[Pago_Guardar]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pago_Guardar]
	
	(
		@Anulado bit, 
		@FechaPago datetime, 
		@IdContrato int, 
		@Importe decimal(18,0), 
		@IdMoneda int, 
		@MesCancelado int,
		@FechaAlta datetime,
		@AnioPagado int
	)
	
AS
INSERT INTO[dbo].[Pagos]
           ([IdContrato]
           ,[Importe]
           ,[IdMoneda]
           ,[Anulado]
           ,[FechaPago]
           ,[MesCancelado]
           ,[FechaAlta]
		   ,[AnioPagado])
     VALUES
           (@IdContrato
           ,@Importe
           ,@IdMoneda
           ,@Anulado
           ,@FechaPago
           ,@MesCancelado
           ,@FechaAlta
			, @AnioPagado)
           
select @@identity

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Objeto:  StoredProcedure [dbo].[UbicacionesCartel_RecuperarTodas]    Fecha de la secuencia de comandos: 06/05/2008 22:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UbicacionesCartel_RecuperarTodas] 
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
select IdUbicacionCartel , Descripcion from UbicacionesCartel


/****************************************************************************/
SET ANSI_NULLS ON
GO
/****** Objeto:  ForeignKey [FK_AdmAlquileres_Alquileres]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[AdmAlquileres]  WITH CHECK ADD  CONSTRAINT [FK_AdmAlquileres_Alquileres] FOREIGN KEY([IdPropiedad])
REFERENCES [dbo].[Alquileres] ([IdPropiedad])
GO
ALTER TABLE [dbo].[AdmAlquileres] CHECK CONSTRAINT [FK_AdmAlquileres_Alquileres]
GO
/****** Objeto:  ForeignKey [FK_AdmAlquileres_Propietarios]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[AdmAlquileres]  WITH CHECK ADD  CONSTRAINT [FK_AdmAlquileres_Propietarios] FOREIGN KEY([IdContacto])
REFERENCES [dbo].[Propietarios] ([IdCliente])
GO
ALTER TABLE [dbo].[AdmAlquileres] CHECK CONSTRAINT [FK_AdmAlquileres_Propietarios]
GO
/****** Objeto:  ForeignKey [FK_Alquileres_Propiedades]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Alquileres]  WITH NOCHECK ADD  CONSTRAINT [FK_Alquileres_Propiedades] FOREIGN KEY([IdPropiedad])
REFERENCES [dbo].[Propiedades] ([IdPropiedad])
GO
ALTER TABLE [dbo].[Alquileres] CHECK CONSTRAINT [FK_Alquileres_Propiedades]
GO
/****** Objeto:  ForeignKey [FK_Barrios_Localidades]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Barrios]  WITH CHECK ADD  CONSTRAINT [FK_Barrios_Localidades] FOREIGN KEY([IdLocalidad])
REFERENCES [dbo].[Localidades] ([IdLocalidad])
GO
ALTER TABLE [dbo].[Barrios] CHECK CONSTRAINT [FK_Barrios_Localidades]
GO
/****** Objeto:  ForeignKey [FK_Carteles_Propiedades]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Carteles]  WITH CHECK ADD  CONSTRAINT [FK_Carteles_Propiedades] FOREIGN KEY([IdPropiedad])
REFERENCES [dbo].[Propiedades] ([IdPropiedad])
GO
ALTER TABLE [dbo].[Carteles] CHECK CONSTRAINT [FK_Carteles_Propiedades]
GO
/****** Objeto:  ForeignKey [FK_Carteles_UbicacionesCartel]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Carteles]  WITH CHECK ADD  CONSTRAINT [FK_Carteles_UbicacionesCartel] FOREIGN KEY([IdUbicacionCartel])
REFERENCES [dbo].[UbicacionesCartel] ([IdUbicacionCartel])
GO
ALTER TABLE [dbo].[Carteles] CHECK CONSTRAINT [FK_Carteles_UbicacionesCartel]
GO
/****** Objeto:  ForeignKey [FK_Clientes_Barrios]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Barrios] FOREIGN KEY([IdBarrio])
REFERENCES [dbo].[Barrios] ([IdBarrio])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Barrios]
GO
/****** Objeto:  ForeignKey [FK_Clientes_Localidades]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Localidades] FOREIGN KEY([IdLocalidad])
REFERENCES [dbo].[Localidades] ([IdLocalidad])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Localidades]
GO
/****** Objeto:  ForeignKey [FK_Clientes_Paises]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Paises] FOREIGN KEY([IdPais])
REFERENCES [dbo].[Paises] ([IdPais])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Paises]
GO
/****** Objeto:  ForeignKey [FK_Clientes_Provincias]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Provincias] FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincias] ([IdProvincia])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Provincias]
GO
/****** Objeto:  ForeignKey [FK_ClientesPedido_ClientesPedido]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[ClientesPedido]  WITH CHECK ADD  CONSTRAINT [FK_ClientesPedido_ClientesPedido] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[ClientesPedido] CHECK CONSTRAINT [FK_ClientesPedido_ClientesPedido]
GO
/****** Objeto:  ForeignKey [FK_Contratos_AdmAlquileres]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD  CONSTRAINT [FK_Contratos_AdmAlquileres] FOREIGN KEY([IdPropiedad])
REFERENCES [dbo].[AdmAlquileres] ([IdPropiedad])
GO
ALTER TABLE [dbo].[Contratos] CHECK CONSTRAINT [FK_Contratos_AdmAlquileres]
GO
/****** Objeto:  ForeignKey [FK_Contratos_Contratos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD  CONSTRAINT [FK_Contratos_Contratos] FOREIGN KEY([IdContratoAnterior])
REFERENCES [dbo].[Contratos] ([IdContrato])
GO
ALTER TABLE [dbo].[Contratos] CHECK CONSTRAINT [FK_Contratos_Contratos]
GO
/****** Objeto:  ForeignKey [FK_Contratos_Inquilinos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD  CONSTRAINT [FK_Contratos_Inquilinos] FOREIGN KEY([IdInquilino])
REFERENCES [dbo].[Inquilinos] ([IdCliente])
GO
ALTER TABLE [dbo].[Contratos] CHECK CONSTRAINT [FK_Contratos_Inquilinos]
GO
/****** Objeto:  ForeignKey [FK_Contratos_Monedas1]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD  CONSTRAINT [FK_Contratos_Monedas1] FOREIGN KEY([IdMonedaDeposito])
REFERENCES [dbo].[Monedas] ([IdMoneda])
GO
ALTER TABLE [dbo].[Contratos] CHECK CONSTRAINT [FK_Contratos_Monedas1]
GO
/****** Objeto:  ForeignKey [FK_EventoVisita_Eventos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[EventoVisita]  WITH CHECK ADD  CONSTRAINT [FK_EventoVisita_Eventos] FOREIGN KEY([IdEvento])
REFERENCES [dbo].[Eventos] ([IdEvento])
GO
ALTER TABLE [dbo].[EventoVisita] CHECK CONSTRAINT [FK_EventoVisita_Eventos]
GO
/****** Objeto:  ForeignKey [FK_EventoVisita_VisitasPropiedad]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[EventoVisita]  WITH CHECK ADD  CONSTRAINT [FK_EventoVisita_VisitasPropiedad] FOREIGN KEY([IdVisita])
REFERENCES [dbo].[VisitasPropiedad] ([IdVisita])
GO
ALTER TABLE [dbo].[EventoVisita] CHECK CONSTRAINT [FK_EventoVisita_VisitasPropiedad]
GO
/****** Objeto:  ForeignKey [FK_GaleriaFotos_Propiedades]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[GaleriaFotos]  WITH CHECK ADD  CONSTRAINT [FK_GaleriaFotos_Propiedades] FOREIGN KEY([IdPropiedad])
REFERENCES [dbo].[Propiedades] ([IdPropiedad])
GO
ALTER TABLE [dbo].[GaleriaFotos] CHECK CONSTRAINT [FK_GaleriaFotos_Propiedades]
GO
/****** Objeto:  ForeignKey [FK_Inquilinos_Clientes]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Inquilinos]  WITH CHECK ADD  CONSTRAINT [FK_Inquilinos_Clientes] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[Inquilinos] CHECK CONSTRAINT [FK_Inquilinos_Clientes]
GO
/****** Objeto:  ForeignKey [FK_Llamados_Propiedades]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Llamados]  WITH CHECK ADD  CONSTRAINT [FK_Llamados_Propiedades] FOREIGN KEY([IdPropiedad])
REFERENCES [dbo].[Propiedades] ([IdPropiedad])
GO
ALTER TABLE [dbo].[Llamados] CHECK CONSTRAINT [FK_Llamados_Propiedades]
GO
/****** Objeto:  ForeignKey [FK_Localidades_Provincias]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Localidades]  WITH CHECK ADD  CONSTRAINT [FK_Localidades_Provincias] FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincias] ([IdProvincia])
GO
ALTER TABLE [dbo].[Localidades] CHECK CONSTRAINT [FK_Localidades_Provincias]
GO
/****** Objeto:  ForeignKey [FK_MedidasAmbientesPropiedad_Propiedades]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[MedidasAmbientesPropiedad]  WITH NOCHECK ADD  CONSTRAINT [FK_MedidasAmbientesPropiedad_Propiedades] FOREIGN KEY([IdPropiedad])
REFERENCES [dbo].[Propiedades] ([IdPropiedad])
GO
ALTER TABLE [dbo].[MedidasAmbientesPropiedad] CHECK CONSTRAINT [FK_MedidasAmbientesPropiedad_Propiedades]
GO
/****** Objeto:  ForeignKey [FK_MedidasAmbientesPropiedad_TiposAmbiente]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[MedidasAmbientesPropiedad]  WITH CHECK ADD  CONSTRAINT [FK_MedidasAmbientesPropiedad_TiposAmbiente] FOREIGN KEY([IdTipoAmbiente])
REFERENCES [dbo].[TiposAmbiente] ([IdTipoambiente])
GO
ALTER TABLE [dbo].[MedidasAmbientesPropiedad] CHECK CONSTRAINT [FK_MedidasAmbientesPropiedad_TiposAmbiente]
GO
/****** Objeto:  ForeignKey [FK_MedidasAmbientesPropiedad_TiposDePiso]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[MedidasAmbientesPropiedad]  WITH CHECK ADD  CONSTRAINT [FK_MedidasAmbientesPropiedad_TiposDePiso] FOREIGN KEY([IdTipoPiso])
REFERENCES [dbo].[TiposDePiso] ([IdTipoPiso])
GO
ALTER TABLE [dbo].[MedidasAmbientesPropiedad] CHECK CONSTRAINT [FK_MedidasAmbientesPropiedad_TiposDePiso]
GO
/****** Objeto:  ForeignKey [FK_NotasPropiedad_Propiedades]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[NotasPropiedad]  WITH CHECK ADD  CONSTRAINT [FK_NotasPropiedad_Propiedades] FOREIGN KEY([IdPropiedad])
REFERENCES [dbo].[Propiedades] ([IdPropiedad])
GO
ALTER TABLE [dbo].[NotasPropiedad] CHECK CONSTRAINT [FK_NotasPropiedad_Propiedades]
GO
/****** Objeto:  ForeignKey [FK_Pagos_Contratos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Pagos]  WITH CHECK ADD  CONSTRAINT [FK_Pagos_Contratos] FOREIGN KEY([IdContrato])
REFERENCES [dbo].[Contratos] ([IdContrato])
GO
ALTER TABLE [dbo].[Pagos] CHECK CONSTRAINT [FK_Pagos_Contratos]
GO
/****** Objeto:  ForeignKey [FK_Pagos_Monedas]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Pagos]  WITH CHECK ADD  CONSTRAINT [FK_Pagos_Monedas] FOREIGN KEY([IdMoneda])
REFERENCES [dbo].[Monedas] ([IdMoneda])
GO
ALTER TABLE [dbo].[Pagos] CHECK CONSTRAINT [FK_Pagos_Monedas]
GO
/****** Objeto:  ForeignKey [FK_Pedidos_Barrios]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Barrios] FOREIGN KEY([IdBarrio])
REFERENCES [dbo].[Barrios] ([IdBarrio])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Barrios]
GO
/****** Objeto:  ForeignKey [FK_Pedidos_CategoriasPropiedad]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_CategoriasPropiedad] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[CategoriasPropiedad] ([IdCategoria])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_CategoriasPropiedad]
GO
/****** Objeto:  ForeignKey [FK_Pedidos_ClientesPedido]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_ClientesPedido] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[ClientesPedido] ([IdCliente])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_ClientesPedido]
GO
/****** Objeto:  ForeignKey [FK_Pedidos_EstadosPropiedad]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_EstadosPropiedad] FOREIGN KEY([IdEstadoPropiedad])
REFERENCES [dbo].[EstadosPropiedad] ([IdEstadoPropiedad])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_EstadosPropiedad]
GO
/****** Objeto:  ForeignKey [FK_Pedidos_Localidades]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Localidades] FOREIGN KEY([IdLocalidad])
REFERENCES [dbo].[Localidades] ([IdLocalidad])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Localidades]
GO
/****** Objeto:  ForeignKey [FK_Pedidos_Monedas1]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Monedas1] FOREIGN KEY([IdMoneda])
REFERENCES [dbo].[Monedas] ([IdMoneda])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Monedas1]
GO
/****** Objeto:  ForeignKey [FK_Pedidos_Paises]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Paises] FOREIGN KEY([IdPais])
REFERENCES [dbo].[Paises] ([IdPais])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Paises]
GO
/****** Objeto:  ForeignKey [FK_Pedidos_Pedidos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Pedidos] FOREIGN KEY([IdPedido])
REFERENCES [dbo].[Pedidos] ([IdPedido])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Pedidos]
GO
/****** Objeto:  ForeignKey [FK_Pedidos_Provincias]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Provincias] FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincias] ([IdProvincia])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Provincias]
GO
/****** Objeto:  ForeignKey [FK_Pedidos_TiposPropiedad]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_TiposPropiedad] FOREIGN KEY([IdTipoPropiedad])
REFERENCES [dbo].[TiposPropiedad] ([IdTipoPropiedad])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_TiposPropiedad]
GO
/****** Objeto:  ForeignKey [FK_Propiedades_Barrios]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Propiedades]  WITH NOCHECK ADD  CONSTRAINT [FK_Propiedades_Barrios] FOREIGN KEY([IdBarrio])
REFERENCES [dbo].[Barrios] ([IdBarrio])
GO
ALTER TABLE [dbo].[Propiedades] CHECK CONSTRAINT [FK_Propiedades_Barrios]
GO
/****** Objeto:  ForeignKey [FK_Propiedades_Clientes]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Propiedades]  WITH CHECK ADD  CONSTRAINT [FK_Propiedades_Clientes] FOREIGN KEY([IdPropietario])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[Propiedades] CHECK CONSTRAINT [FK_Propiedades_Clientes]
GO
/****** Objeto:  ForeignKey [FK_Propiedades_EstadosPropiedad]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Propiedades]  WITH NOCHECK ADD  CONSTRAINT [FK_Propiedades_EstadosPropiedad] FOREIGN KEY([IdEstadoPropiedad])
REFERENCES [dbo].[EstadosPropiedad] ([IdEstadoPropiedad])
GO
ALTER TABLE [dbo].[Propiedades] CHECK CONSTRAINT [FK_Propiedades_EstadosPropiedad]
GO
/****** Objeto:  ForeignKey [FK_Propiedades_InmobiliariasExternas]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Propiedades]  WITH CHECK ADD  CONSTRAINT [FK_Propiedades_InmobiliariasExternas] FOREIGN KEY([IdInmobiliariaExterna])
REFERENCES [dbo].[InmobiliariasExternas] ([IdInmobiliaria])
GO
ALTER TABLE [dbo].[Propiedades] CHECK CONSTRAINT [FK_Propiedades_InmobiliariasExternas]
GO
/****** Objeto:  ForeignKey [FK_Propiedades_Localidades]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Propiedades]  WITH NOCHECK ADD  CONSTRAINT [FK_Propiedades_Localidades] FOREIGN KEY([IdLocalidad])
REFERENCES [dbo].[Localidades] ([IdLocalidad])
GO
ALTER TABLE [dbo].[Propiedades] CHECK CONSTRAINT [FK_Propiedades_Localidades]
GO
/****** Objeto:  ForeignKey [FK_Propiedades_Monedas]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Propiedades]  WITH NOCHECK ADD  CONSTRAINT [FK_Propiedades_Monedas] FOREIGN KEY([ValorMercadoMoneda])
REFERENCES [dbo].[Monedas] ([IdMoneda])
GO
ALTER TABLE [dbo].[Propiedades] CHECK CONSTRAINT [FK_Propiedades_Monedas]
GO
/****** Objeto:  ForeignKey [FK_Propiedades_Monedas1]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Propiedades]  WITH NOCHECK ADD  CONSTRAINT [FK_Propiedades_Monedas1] FOREIGN KEY([ValorPublicacionMoneda])
REFERENCES [dbo].[Monedas] ([IdMoneda])
GO
ALTER TABLE [dbo].[Propiedades] CHECK CONSTRAINT [FK_Propiedades_Monedas1]
GO
/****** Objeto:  ForeignKey [FK_Propiedades_Paises]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Propiedades]  WITH NOCHECK ADD  CONSTRAINT [FK_Propiedades_Paises] FOREIGN KEY([IdPais])
REFERENCES [dbo].[Paises] ([IdPais])
GO
ALTER TABLE [dbo].[Propiedades] CHECK CONSTRAINT [FK_Propiedades_Paises]
GO
/****** Objeto:  ForeignKey [FK_Propiedades_Provincias]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Propiedades]  WITH NOCHECK ADD  CONSTRAINT [FK_Propiedades_Provincias] FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincias] ([IdProvincia])
GO
ALTER TABLE [dbo].[Propiedades] CHECK CONSTRAINT [FK_Propiedades_Provincias]
GO
/****** Objeto:  ForeignKey [FK_Propiedades_TiposPropiedad]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[Propiedades]  WITH NOCHECK ADD  CONSTRAINT [FK_Propiedades_TiposPropiedad] FOREIGN KEY([IdTipoPropiedad])
REFERENCES [dbo].[TiposPropiedad] ([IdTipoPropiedad])
GO
ALTER TABLE [dbo].[Propiedades] CHECK CONSTRAINT [FK_Propiedades_TiposPropiedad]
GO
/****** Objeto:  ForeignKey [FK_PropiedadesOfrecidasXPedido_Pedidos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[PropiedadesOfrecidasXPedido]  WITH CHECK ADD  CONSTRAINT [FK_PropiedadesOfrecidasXPedido_Pedidos] FOREIGN KEY([IdPedido])
REFERENCES [dbo].[Pedidos] ([IdPedido])
GO
ALTER TABLE [dbo].[PropiedadesOfrecidasXPedido] CHECK CONSTRAINT [FK_PropiedadesOfrecidasXPedido_Pedidos]
GO
/****** Objeto:  ForeignKey [FK_PropiedadesOfrecidasXPedido_Propiedades]    Fecha de la secuencia de comandos: 06/05/2008 22:01:16 ******/
ALTER TABLE [dbo].[PropiedadesOfrecidasXPedido]  WITH CHECK ADD  CONSTRAINT [FK_PropiedadesOfrecidasXPedido_Propiedades] FOREIGN KEY([IdPropiedad])
REFERENCES [dbo].[Propiedades] ([IdPropiedad])
GO
ALTER TABLE [dbo].[PropiedadesOfrecidasXPedido] CHECK CONSTRAINT [FK_PropiedadesOfrecidasXPedido_Propiedades]
GO
/****** Objeto:  ForeignKey [FK_Propietarios_Clientes]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
ALTER TABLE [dbo].[Propietarios]  WITH CHECK ADD  CONSTRAINT [FK_Propietarios_Clientes] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[Propietarios] CHECK CONSTRAINT [FK_Propietarios_Clientes]
GO
/****** Objeto:  ForeignKey [FK_Provincias_Paises]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
ALTER TABLE [dbo].[Provincias]  WITH NOCHECK ADD  CONSTRAINT [FK_Provincias_Paises] FOREIGN KEY([IdPais])
REFERENCES [dbo].[Paises] ([IdPais])
GO
ALTER TABLE [dbo].[Provincias] CHECK CONSTRAINT [FK_Provincias_Paises]
GO
/****** Objeto:  ForeignKey [FK_Publicaciones_Monedas]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
ALTER TABLE [dbo].[Publicaciones]  WITH CHECK ADD  CONSTRAINT [FK_Publicaciones_Monedas] FOREIGN KEY([IdMoneda])
REFERENCES [dbo].[Monedas] ([IdMoneda])
GO
ALTER TABLE [dbo].[Publicaciones] CHECK CONSTRAINT [FK_Publicaciones_Monedas]
GO
/****** Objeto:  ForeignKey [FK_Publicaciones_Propiedades]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
ALTER TABLE [dbo].[Publicaciones]  WITH CHECK ADD  CONSTRAINT [FK_Publicaciones_Propiedades] FOREIGN KEY([IdPropiedad])
REFERENCES [dbo].[Propiedades] ([IdPropiedad])
GO
ALTER TABLE [dbo].[Publicaciones] CHECK CONSTRAINT [FK_Publicaciones_Propiedades]
GO
/****** Objeto:  ForeignKey [FK_Tasaciones_Monedas]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
ALTER TABLE [dbo].[Tasaciones]  WITH CHECK ADD  CONSTRAINT [FK_Tasaciones_Monedas] FOREIGN KEY([IdMonedaValorReal])
REFERENCES [dbo].[Monedas] ([IdMoneda])
GO
ALTER TABLE [dbo].[Tasaciones] CHECK CONSTRAINT [FK_Tasaciones_Monedas]
GO
/****** Objeto:  ForeignKey [FK_Tasaciones_Monedas1]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
ALTER TABLE [dbo].[Tasaciones]  WITH CHECK ADD  CONSTRAINT [FK_Tasaciones_Monedas1] FOREIGN KEY([IdMonedaValorPublicacion])
REFERENCES [dbo].[Monedas] ([IdMoneda])
GO
ALTER TABLE [dbo].[Tasaciones] CHECK CONSTRAINT [FK_Tasaciones_Monedas1]
GO
/****** Objeto:  ForeignKey [FK_Tasaciones_Propiedades]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
ALTER TABLE [dbo].[Tasaciones]  WITH CHECK ADD  CONSTRAINT [FK_Tasaciones_Propiedades] FOREIGN KEY([IdPropiedad])
REFERENCES [dbo].[Propiedades] ([IdPropiedad])
GO
ALTER TABLE [dbo].[Tasaciones] CHECK CONSTRAINT [FK_Tasaciones_Propiedades]
GO
/****** Objeto:  ForeignKey [FK_TiposPropiedad_CategoriasPropiedad]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
ALTER TABLE [dbo].[TiposPropiedad]  WITH CHECK ADD  CONSTRAINT [FK_TiposPropiedad_CategoriasPropiedad] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[CategoriasPropiedad] ([IdCategoria])
GO
ALTER TABLE [dbo].[TiposPropiedad] CHECK CONSTRAINT [FK_TiposPropiedad_CategoriasPropiedad]
GO
/****** Objeto:  ForeignKey [FK_ValoresRenta_Contratos]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
ALTER TABLE [dbo].[ValoresRenta]  WITH CHECK ADD  CONSTRAINT [FK_ValoresRenta_Contratos] FOREIGN KEY([IdContrato])
REFERENCES [dbo].[Contratos] ([IdContrato])
GO
ALTER TABLE [dbo].[ValoresRenta] CHECK CONSTRAINT [FK_ValoresRenta_Contratos]
GO
/****** Objeto:  ForeignKey [FK_ValoresRenta_Monedas]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
ALTER TABLE [dbo].[ValoresRenta]  WITH CHECK ADD  CONSTRAINT [FK_ValoresRenta_Monedas] FOREIGN KEY([IdMoneda])
REFERENCES [dbo].[Monedas] ([IdMoneda])
GO
ALTER TABLE [dbo].[ValoresRenta] CHECK CONSTRAINT [FK_ValoresRenta_Monedas]
GO
/****** Objeto:  ForeignKey [FK_Ventas_Propiedades]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
ALTER TABLE [dbo].[Ventas]  WITH NOCHECK ADD  CONSTRAINT [FK_Ventas_Propiedades] FOREIGN KEY([IdPropiedad])
REFERENCES [dbo].[Propiedades] ([IdPropiedad])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Propiedades]
GO
/****** Objeto:  ForeignKey [FK_VisitasPropiedad_Propiedades]    Fecha de la secuencia de comandos: 06/05/2008 22:01:17 ******/
ALTER TABLE [dbo].[VisitasPropiedad]  WITH CHECK ADD  CONSTRAINT [FK_VisitasPropiedad_Propiedades] FOREIGN KEY([IdPropiedad])
REFERENCES [dbo].[Propiedades] ([IdPropiedad])
GO
ALTER TABLE [dbo].[VisitasPropiedad] CHECK CONSTRAINT [FK_VisitasPropiedad_Propiedades]
GO
