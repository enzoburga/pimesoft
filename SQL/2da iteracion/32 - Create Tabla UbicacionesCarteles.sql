
/****** Object:  Table [dbo].[UbicacionesCartel]    Script Date: 05/26/2008 22:31:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UbicacionesCartel](
	[IdUbicacionCartel] [int] NOT NULL,
	[Descripcion] [nvarchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
 CONSTRAINT [PK_UbicacionesCartel] PRIMARY KEY CLUSTERED 
(
	[IdUbicacionCartel] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

/***** INSERTS ***********/

insert into UbicacionesCartel (IdUbicacionCartel, Descripcion) values (1,'Sin Definir')
insert into UbicacionesCartel (IdUbicacionCartel, Descripcion) values (2,'Frente')
insert into UbicacionesCartel (IdUbicacionCartel, Descripcion) values (3,'ContraFrente')

