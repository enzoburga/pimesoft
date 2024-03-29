
/****** Object:  Table [dbo].[Inquilinos]    Script Date: 04/24/2008 23:50:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inquilinos](
	[IdCliente] [int] NOT NULL,
 CONSTRAINT [PK_Inquilinos] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


GO
ALTER TABLE [dbo].[Inquilinos]  WITH CHECK ADD  CONSTRAINT [FK_Inquilinos_Clientes] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])