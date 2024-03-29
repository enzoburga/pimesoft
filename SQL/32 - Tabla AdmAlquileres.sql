
GO
/****** Object:  Table [dbo].[AdmAlquileres]    Script Date: 04/30/2008 00:18:25 ******/
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
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO

GO
ALTER TABLE [dbo].[AdmAlquileres]  WITH CHECK ADD  CONSTRAINT [FK_AdmAlquileres_Alquileres] FOREIGN KEY([IdPropiedad])
REFERENCES [dbo].[Alquileres] ([IdPropiedad])
GO
ALTER TABLE [dbo].[AdmAlquileres]  WITH CHECK ADD  CONSTRAINT [FK_AdmAlquileres_Propietarios] FOREIGN KEY([IdContacto])
REFERENCES [dbo].[Propietarios] ([IdCliente])