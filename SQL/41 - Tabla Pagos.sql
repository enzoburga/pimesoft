GO
/****** Object:  Table [dbo].[Pagos]    Script Date: 05/01/2008 18:54:28 ******/
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
 CONSTRAINT [PK_Pagos] PRIMARY KEY CLUSTERED 
(
	[IdPago] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


GO
ALTER TABLE [dbo].[Pagos]  WITH CHECK ADD  CONSTRAINT [FK_Pagos_Contratos] FOREIGN KEY([IdContrato])
REFERENCES [dbo].[Contratos] ([IdContrato])
GO
ALTER TABLE [dbo].[Pagos]  WITH CHECK ADD  CONSTRAINT [FK_Pagos_Monedas] FOREIGN KEY([IdMoneda])
REFERENCES [dbo].[Monedas] ([IdMoneda])