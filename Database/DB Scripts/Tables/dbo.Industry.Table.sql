/****** Object:  Table [dbo].[Industry]    Script Date: 2/28/2018 4:59:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Industry](
	[IndustryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NULL,
	[SectorId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IndustryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Industry]  WITH CHECK ADD FOREIGN KEY([SectorId])
REFERENCES [dbo].[Sector] ([SectorId])
GO


