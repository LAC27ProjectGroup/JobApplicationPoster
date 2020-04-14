CREATE TABLE [dbo].[JobData]
(
	[JobID] INT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NULL, 
    [CompanyName] NVARCHAR(50) NULL, 
    [JobTitle] NVARCHAR(50) NULL, 
    [Location] NVARCHAR(50) NULL
)
