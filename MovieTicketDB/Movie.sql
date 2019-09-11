CREATE TABLE [dbo].[Movie]
(
	[MovieId] INT NOT NULL PRIMARY KEY IDENTITY,
	[AudiId] INT NOT NULL,
	[MovieTitle] VARCHAR(45) NOT NULL,
	[MoviePrice] MONEY NOT NULL,
	[MovieRate] VARCHAR(10) NOT NULL,
	[MovieAgeLimit] INT NOT NULL,
	[MovieGenre] VARCHAR(50) NOT NULL,
	CONSTRAINT [FK_Movie_Auditorium] FOREIGN KEY ([AudiId]) REFERENCES [Auditorium]([AudiId]) ON DELETE CASCADE,
)

