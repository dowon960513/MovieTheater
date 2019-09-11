CREATE TABLE [dbo].[Customer]
(
	[CustId] INT NOT NULL PRIMARY KEY IDENTITY,
	[CustFirstname] VARCHAR(30) NOT NULL,
	[CustLastname] VARCHAR(30) NOT NULL,
	[CustAge] INT NOT NULL,
)
