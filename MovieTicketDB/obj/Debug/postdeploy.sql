/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

GO
delete from [dbo].[Auditorium]
DBCC CHECKIDENT (Auditorium, RESEED, 0)
GO
delete from [dbo].[Time]
DBCC CHECKIDENT (Time, RESEED, 0)

GO
SET IDENTITY_INSERT [dbo].[Auditorium] ON
INSERT INTO [dbo].[Auditorium] ([AudiId], [AudiName]) VALUES (1, N'A')
INSERT INTO [dbo].[Auditorium] ([AudiId], [AudiName]) VALUES (2, N'B')
INSERT INTO [dbo].[Auditorium] ([AudiId], [AudiName]) VALUES (3, N'C')
INSERT INTO [dbo].[Auditorium] ([AudiId], [AudiName]) VALUES (4, N'D')
INSERT INTO [dbo].[Auditorium] ([AudiId], [AudiName]) VALUES (5, N'E')
SET IDENTITY_INSERT [dbo].[Auditorium] OFF

GO
SET IDENTITY_INSERT [dbo].[Time] ON
INSERT INTO [dbo].[Time] (TimeId, TimeStart, TimeEnd) VALUES (1, '8:30AM', '11:30AM')
INSERT INTO [dbo].[Time] (TimeId, TimeStart, TimeEnd) VALUES (2, '11:30AM', '14:30PM')
INSERT INTO [dbo].[Time] (TimeId, TimeStart, TimeEnd) VALUES (3, '14:30PM', '17:30PM')
INSERT INTO [dbo].[Time] (TimeId, TimeStart, TimeEnd) VALUES (4, '17:30PM', '20:30PM')
SET IDENTITY_INSERT [dbo].[Time] OFF

GO
delete from [dbo].[Movie]
DBCC CHECKIDENT (Movie, RESEED, 0)

GO
SET IDENTITY_INSERT [dbo].[Movie] ON
INSERT INTO [dbo].[Movie] (MovieId, AudiId, MovieTitle, MoviePrice, MovieRate, MovieAgeLimit, MovieGenre) VALUES (1, 1, 'Ready Player One', 12, 'PG', 6, 'Science Fiction')
INSERT INTO [dbo].[Movie] (MovieId, AudiId, MovieTitle, MoviePrice, MovieRate, MovieAgeLimit, MovieGenre) VALUES (2, 2, 'Pacific Rim: Uprising', 12, 'PG-13', 13, 'Science Fiction')
INSERT INTO [dbo].[Movie] (MovieId, AudiId, MovieTitle, MoviePrice, MovieRate, MovieAgeLimit, MovieGenre) VALUES (3, 3, 'Tomb Raider', 12, 'PG-13', 13, 'Action Adventure')
INSERT INTO [dbo].[Movie] (MovieId, AudiId, MovieTitle, MoviePrice, MovieRate, MovieAgeLimit, MovieGenre) VALUES (4, 4, 'Black Panther', 12, 'PG-13', 13, 'Action Fantasy')
INSERT INTO [dbo].[Movie] (MovieId, AudiId, MovieTitle, MoviePrice, MovieRate, MovieAgeLimit, MovieGenre) VALUES (5, 5, 'Fifty Shades of Grey', 12, '18A', 18, 'Action Adventure Comedy')
SET IDENTITY_INSERT [dbo].[Movie] OFF
GO


GO
