
GO
/****** Object:  Table [dbo].[Pedidos]    Script Date: 05/19/2008 00:21:30 ******/
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
	[EstadoPropiedad] [nvarchar](50) COLLATE Modern_Spanish_CI_AS NULL,
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
 CONSTRAINT [PK_Pedidos] PRIMARY KEY CLUSTERED 
(
	[IdPedido] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Barrios] FOREIGN KEY([IdBarrio])
REFERENCES [dbo].[Barrios] ([IdBarrio])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Barrios]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_CategoriasPropiedad] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[CategoriasPropiedad] ([IdCategoria])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_CategoriasPropiedad]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_ClientesPedido] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[ClientesPedido] ([IdCliente])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_ClientesPedido]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_EstadosPropiedad] FOREIGN KEY([IdEstadoPropiedad])
REFERENCES [dbo].[EstadosPropiedad] ([IdEstadoPropiedad])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_EstadosPropiedad]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Localidades] FOREIGN KEY([IdLocalidad])
REFERENCES [dbo].[Localidades] ([IdLocalidad])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Localidades]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Monedas1] FOREIGN KEY([IdMoneda])
REFERENCES [dbo].[Monedas] ([IdMoneda])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Monedas1]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Paises] FOREIGN KEY([IdPais])
REFERENCES [dbo].[Paises] ([IdPais])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Paises]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Pedidos] FOREIGN KEY([IdPedido])
REFERENCES [dbo].[Pedidos] ([IdPedido])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Pedidos]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Provincias] FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincias] ([IdProvincia])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Provincias]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_TiposPropiedad] FOREIGN KEY([IdTipoPropiedad])
REFERENCES [dbo].[TiposPropiedad] ([IdTipoPropiedad])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_TiposPropiedad]