GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 04/26/2008 14:29:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Nombres] [nvarchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Apellido] [nvarchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[NroDocumento] [nvarchar](20) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[TipoDocumento] [int] NOT NULL,
	[TelefonoParticular] [int] NULL,
	[TelefonoTrabajo] [int] NULL,
	[TelefonoCelular] [int] NULL,
	[Observaciones] [nvarchar](200) COLLATE Modern_Spanish_CI_AS NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[Email] [nvarchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[Calle] [nvarchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[Numero] [int] NULL,
	[Depto] [nvarchar](2) COLLATE Modern_Spanish_CI_AS NULL,
	[Piso] [nvarchar](2) COLLATE Modern_Spanish_CI_AS NULL,
	[CodigoPostal] [nvarchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[CalleEntre1] [nvarchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[CalleEntre2] [nvarchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[IdBarrio] [int] NULL,
	[IdProvincia] [int] NULL,
	[IdPais] [int] NULL,
	[IdLocalidad] [int] NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [Pime]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Barrios] FOREIGN KEY([IdBarrio])
REFERENCES [dbo].[Barrios] ([IdBarrio])
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Localidades] FOREIGN KEY([IdLocalidad])
REFERENCES [dbo].[Localidades] ([IdLocalidad])
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Paises] FOREIGN KEY([IdPais])
REFERENCES [dbo].[Paises] ([IdPais])
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Provincias] FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincias] ([IdProvincia])