
GO
/****** Object:  Table [dbo].[ValoresRenta]    Script Date: 05/02/2008 21:37:17 ******/
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
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


GO
ALTER TABLE [dbo].[ValoresRenta]  WITH CHECK ADD  CONSTRAINT [FK_ValoresRenta_Contratos] FOREIGN KEY([IdContrato])
REFERENCES [dbo].[Contratos] ([IdContrato])
GO
ALTER TABLE [dbo].[ValoresRenta]  WITH CHECK ADD  CONSTRAINT [FK_ValoresRenta_Monedas] FOREIGN KEY([IdMoneda])
REFERENCES [dbo].[Monedas] ([IdMoneda])