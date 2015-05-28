USE [FairManagement_DB]
GO

/****** Object:  Table [dbo].[VisitorZoneType_T]    Script Date: 05/27/2015 21:56:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[VisitorZoneType_T](
	[VisitorZoneID] [int] IDENTITY(1,1) NOT NULL,
	[VisitorId] [int] NULL,
	[ZoneTypeId] [int] NULL,
 CONSTRAINT [PK_VisitorZoneType_T] PRIMARY KEY CLUSTERED 
(
	[VisitorZoneID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[VisitorZoneType_T]  WITH CHECK ADD  CONSTRAINT [FK_VisitorZoneType_T_ZoneTypeId] FOREIGN KEY([ZoneTypeId])
REFERENCES [dbo].[ZoneType_T] ([Id])
GO

ALTER TABLE [dbo].[VisitorZoneType_T] CHECK CONSTRAINT [FK_VisitorZoneType_T_ZoneTypeId]
GO


