USE [CRUD_JD]
GO

/****** Object:  Table [dbo].[TableProduct]    Script Date: 22/02/2024 05:06:39 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TableProduct](
	[Product_ID] [int] NOT NULL,
	[ItemName] [nvarchar](50) NULL,
	[Design] [nvarchar](150) NULL,
	[Color] [nvarchar](50) NULL,
	[ItemDate] [datetime] NULL,
	[WarrantlyType] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TableProduct] PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


