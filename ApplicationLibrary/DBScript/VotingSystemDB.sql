USE [VotingSystemDB]
GO
/****** Object:  Table [dbo].[Commissioner]    Script Date: 8/2/2020 12:55:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Commissioner](
	[CommissionerID] [varchar](50) NULL,
	[CommissionerName] [varchar](50) NULL,
	[Password] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Competitor]    Script Date: 8/2/2020 12:55:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Competitor](
	[CompetitorID] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[NoOfVote] [int] NULL,
	[Status] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Voter]    Script Date: 8/2/2020 12:55:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Voter](
	[VoterID] [varchar](100) NULL,
	[VoterName] [varchar](100) NULL,
	[VoteCast] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VoteResult]    Script Date: 8/2/2020 12:55:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VoteResult](
	[CompetitorID] [varchar](50) NULL,
	[CompetitorName] [varchar](50) NULL,
	[NoOfVote] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Commissioner] ([CommissionerID], [CommissionerName], [Password]) VALUES (N'com012137', N'Ruhul Bakhs', N'01234')
INSERT [dbo].[Competitor] ([CompetitorID], [Name], [NoOfVote], [Status]) VALUES (N'Con1212', N'Alok Paul', 0, NULL)
INSERT [dbo].[Competitor] ([CompetitorID], [Name], [NoOfVote], [Status]) VALUES (N'Con1213', N'Suroj Bora', 0, NULL)
INSERT [dbo].[Competitor] ([CompetitorID], [Name], [NoOfVote], [Status]) VALUES (N'Con1214', N'Moinul Hussain', 0, NULL)
INSERT [dbo].[Competitor] ([CompetitorID], [Name], [NoOfVote], [Status]) VALUES (N'Con1215', N'Rajat Mark', 0, NULL)
INSERT [dbo].[Voter] ([VoterID], [VoterName], [VoteCast]) VALUES (N'01234', N'Monwar Khan', N'Y')
INSERT [dbo].[Voter] ([VoterID], [VoterName], [VoteCast]) VALUES (N'09876', N'Ranju Das', N'Y')
INSERT [dbo].[Voter] ([VoterID], [VoterName], [VoteCast]) VALUES (N'34567', N'Bobi Dewan', N'Y')
INSERT [dbo].[Voter] ([VoterID], [VoterName], [VoteCast]) VALUES (N'43210', N'Domar Singh', N'Y')
INSERT [dbo].[Voter] ([VoterID], [VoterName], [VoteCast]) VALUES (N'67890', N'Dominek Rudolf', N'Y')
INSERT [dbo].[Voter] ([VoterID], [VoterName], [VoteCast]) VALUES (N'23456', N'kailash Kher', N'Y')
INSERT [dbo].[Voter] ([VoterID], [VoterName], [VoteCast]) VALUES (N'87652', N'Duti Hasan ', N'Y')
INSERT [dbo].[VoteResult] ([CompetitorID], [CompetitorName], [NoOfVote]) VALUES (N'Con1212', N'Alok Paul', 1)
INSERT [dbo].[VoteResult] ([CompetitorID], [CompetitorName], [NoOfVote]) VALUES (N'Con1213', N'Suroj Bora', 1)
INSERT [dbo].[VoteResult] ([CompetitorID], [CompetitorName], [NoOfVote]) VALUES (N'Con1214', N'Moinul Hussain', 0)
INSERT [dbo].[VoteResult] ([CompetitorID], [CompetitorName], [NoOfVote]) VALUES (N'Con1215', N'Rajat Mark', 5)
