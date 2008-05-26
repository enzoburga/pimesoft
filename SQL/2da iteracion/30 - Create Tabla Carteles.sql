
/****** Object:  Table [dbo].[Carteles]    Script Date: 05/25/2008 23:19:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carteles](
	[IdCartel] [int] IDENTITY(1,1) NOT NULL,
	[IdPropiedad] [int] NOT NULL,
	[Activo] [bit] NOT NULL,
	[Ancho] [int] NOT NULL,
	[Alto] [int] NULL,
	[FechaAlta] [datetime] NOT NULL,
	[FechaVencimiento] [datetime] NULL,
	[TipoCartel] [nvarchar](50) COLLATE Modern_Spanish_CI_AS NULL,
 CONSTRAINT [PK_Carteles] PRIMARY KEY CLUSTERED 
(
	[IdCartel] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Carteles]  WITH CHECK ADD  CONSTRAINT [FK_Carteles_Propiedades] FOREIGN KEY([IdPropiedad])
REFERENCES [dbo].[Propiedades] ([IdPropiedad])
GO
ALTER TABLE [dbo].[Carteles] CHECK CONSTRAINT [FK_Carteles_Propiedades]