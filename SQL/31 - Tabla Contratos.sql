
GO
/****** Object:  Table [dbo].[Contratos]    Script Date: 04/30/2008 00:17:34 ******/
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
	[MontoCuota] [decimal](18, 0) NOT NULL,
	[IdMonedaMonto] [int] NOT NULL,
	[MontoDeposito] [decimal](18, 0) NOT NULL,
	[IdMonedaDeposito] [int] NOT NULL,
	[DiaVencimientoCuota] [tinyint] NOT NULL,
	[IdContratoAnterior] [int] NULL,
	[FechaCancelacion] [datetime] NULL,
	[Observaciones] [nvarchar](200) COLLATE Modern_Spanish_CI_AS NULL,
 CONSTRAINT [PK_Contratos] PRIMARY KEY CLUSTERED 
(
	[IdContrato] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO

GO
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD  CONSTRAINT [FK_Contratos_AdmAlquileres] FOREIGN KEY([IdPropiedad])
REFERENCES [dbo].[AdmAlquileres] ([IdPropiedad])
GO
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD  CONSTRAINT [FK_Contratos_Contratos] FOREIGN KEY([IdContratoAnterior])
REFERENCES [dbo].[Contratos] ([IdContrato])
GO
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD  CONSTRAINT [FK_Contratos_Inquilinos] FOREIGN KEY([IdInquilino])
REFERENCES [dbo].[Inquilinos] ([IdCliente])
GO
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD  CONSTRAINT [FK_Contratos_Monedas] FOREIGN KEY([IdMonedaMonto])
REFERENCES [dbo].[Monedas] ([IdMoneda])
GO
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD  CONSTRAINT [FK_Contratos_Monedas1] FOREIGN KEY([IdMonedaDeposito])
REFERENCES [dbo].[Monedas] ([IdMoneda])