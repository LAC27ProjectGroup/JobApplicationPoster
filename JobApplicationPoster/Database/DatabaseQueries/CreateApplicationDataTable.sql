CREATE TABLE [dbo].[ApplicationData]
(
	[ApplicationID] INT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	[StudentId] INT NULL, 
	[Company] NVARCHAR(MAX) NULL, 
	[JobTitle] NVARCHAR(MAX) NULL, 
	[Location] NVARCHAR(MAX) NULL,
	[Sticker] NVARCHAR(MAX) NOT NULL,
)