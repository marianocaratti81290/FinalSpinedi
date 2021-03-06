USE [sgpp_desarrollo]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 25/03/2016 07:19:41 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[permiso] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Login_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
