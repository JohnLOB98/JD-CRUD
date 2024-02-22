USE [CRUD_JD]
GO

/****** Object:  Table [dbo].[TableSellProduct]    Script Date: 22/02/2024 05:07:30 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TableSellProduct](
	[SellID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[SellDate] [datetime] NULL,
 CONSTRAINT [PK_TableSellProduct] PRIMARY KEY CLUSTERED 
(
	[SellID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


