--BORRO LA TABLA
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Contratos_AdmAlquileres]') AND parent_object_id = OBJECT_ID(N'[dbo].[Contratos]'))
ALTER TABLE [dbo].[Contratos] DROP CONSTRAINT [FK_Contratos_AdmAlquileres]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Contratos_Contratos]') AND parent_object_id = OBJECT_ID(N'[dbo].[Contratos]'))
ALTER TABLE [dbo].[Contratos] DROP CONSTRAINT [FK_Contratos_Contratos]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Contratos_Inquilinos]') AND parent_object_id = OBJECT_ID(N'[dbo].[Contratos]'))
ALTER TABLE [dbo].[Contratos] DROP CONSTRAINT [FK_Contratos_Inquilinos]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Contratos_Monedas1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Contratos]'))
ALTER TABLE [dbo].[Contratos] DROP CONSTRAINT [FK_Contratos_Monedas1]
GO

GO
/****** Object:  Table [dbo].[Contratos]    Script Date: 05/03/2008 00:19:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Contratos]') AND type in (N'U'))
DROP TABLE [dbo].[Contratos]

--LA CREO DE NUEVO CON LOS CAMBIOS

GO
/****** Object:  Table [dbo].[Contratos]    Script Date: 05/03/2008 00:18:48 ******/
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
	[Observaciones] [nvarchar](200) COLLATE Traditional_Spanish_CI_AS NULL,
	[Vigente] [bit] NOT NULL,
 CONSTRAINT [PK_Contratos] PRIMARY KEY CLUSTERED 
(
	[IdContrato] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

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
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD  CONSTRAINT [FK_Contratos_Monedas1] FOREIGN KEY([IdMonedaDeposito])
REFERENCES [dbo].[Monedas] ([IdMoneda])