/****** Object:  Table [dbo].[HistoricalData]    Script Date: 2/28/2018 5:07:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HistoricalData](
	[HistoricalQuoteId] [int] IDENTITY(1,2) NOT NULL,
	[StockId] [int] NULL,
	[Date] [date] NOT NULL,
	[High] [float] NULL,
	[Low] [float] NULL,
	[Open] [float] NULL,
	[Close] [float] NULL,
	[AdjustedClose] [float] NULL,
	[Volume] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[HistoricalQuoteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[HistoricalData]  WITH CHECK ADD FOREIGN KEY([StockId])
REFERENCES [dbo].[Stock] ([StockId])
GO
