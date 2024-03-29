
GO
/****** Object:  Table [dbo].[PropiedadesOfrecidasXPedido]    Script Date: 05/19/2008 22:56:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PropiedadesOfrecidasXPedido](
	[IdPedido] [int] NOT NULL,
	[IdPropiedad] [int] NOT NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[PropiedadesOfrecidasXPedido]  WITH CHECK ADD  CONSTRAINT [FK_PropiedadesOfrecidasXPedido_Pedidos] FOREIGN KEY([IdPedido])
REFERENCES [dbo].[Pedidos] ([IdPedido])
GO
ALTER TABLE [dbo].[PropiedadesOfrecidasXPedido] CHECK CONSTRAINT [FK_PropiedadesOfrecidasXPedido_Pedidos]
GO
ALTER TABLE [dbo].[PropiedadesOfrecidasXPedido]  WITH CHECK ADD  CONSTRAINT [FK_PropiedadesOfrecidasXPedido_Propiedades] FOREIGN KEY([IdPropiedad])
REFERENCES [dbo].[Propiedades] ([IdPropiedad])
GO
ALTER TABLE [dbo].[PropiedadesOfrecidasXPedido] CHECK CONSTRAINT [FK_PropiedadesOfrecidasXPedido_Propiedades]