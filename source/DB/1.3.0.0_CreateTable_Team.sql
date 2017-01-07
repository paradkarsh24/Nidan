USE [HR]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS(SELECT 1  FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Team')
BEGIN

	CREATE TABLE [dbo].[Team](
		[TeamId] [int] IDENTITY(1,1) NOT NULL,
		[OrganisationId] [int] FOREIGN KEY REFERENCES Organisation(OrganisationId),
		[Name] [nvarchar](100) NOT NULL,
		[ColourId] [int] FOREIGN KEY REFERENCES Colour(ColourId)
	 CONSTRAINT [PK_Team] PRIMARY KEY CLUSTERED 
	(
		[TeamId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	CREATE TABLE [dbo].[EmploymentTeam](
		[EmploymentTeamId] [int] IDENTITY(1,1) NOT NULL,
		[OrganisationId] [int] FOREIGN KEY REFERENCES Organisation(OrganisationId),
		[EmploymentId] [int] FOREIGN KEY REFERENCES Employment(EmploymentId),
		[TeamId] [int] FOREIGN KEY REFERENCES Team(TeamId)
	 CONSTRAINT [PK_EmploymentTeam] PRIMARY KEY CLUSTERED 
	(
		[EmploymentTeamId], [OrganisationId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
END