/****** Object:  Table [dbo].[Stock]    Script Date: 2/28/2018 4:56:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Stock](
	[StockId] [int] IDENTITY(1,1) NOT NULL,
	[Symbol] [varchar](255) NULL,
	[Exchange] [varchar](255) NULL,
	[IssueType] [varchar](255) NULL,
	[IndustryId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[StockId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Stock]  WITH CHECK ADD FOREIGN KEY([IndustryId])
REFERENCES [dbo].[Industry] ([IndustryId])
GO
