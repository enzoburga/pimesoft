SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Smtp](
	[AutenticacionSmtp] [bit] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Host] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](10) NOT NULL,
	[Puerto] [int] NOT NULL,
	[SSL] [bit] NOT NULL,
	[UserName] [nchar](50) NOT NULL
) ON [PRIMARY]
