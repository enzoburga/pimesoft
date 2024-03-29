
/****** Object:  Table [dbo].[ClientesPedido]    Script Date: 05/19/2008 00:27:16 ******/
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
ALTER TABLE [dbo].[ClientesPedido]  WITH CHECK ADD  CONSTRAINT [FK_ClientesPedido_ClientesPedido] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[ClientesPedido] CHECK CONSTRAINT [FK_ClientesPedido_ClientesPedido]