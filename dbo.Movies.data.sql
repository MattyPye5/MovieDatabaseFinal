SET IDENTITY_INSERT [dbo].[Movies] ON
INSERT INTO [dbo].[Movies] ([MovieId], [MovieName], [Genre], [DateOfRelease], [Actors]) VALUES (1, N'The Matrix', N'Action', 1999, N'Keenu Reeves')
INSERT INTO [dbo].[Movies] ([MovieId], [MovieName], [Genre], [DateOfRelease], [Actors]) VALUES (2, N'Titanic', N'Drama', 1997, N'Kate Winslet, Leonardo DiCaprio')
INSERT INTO [dbo].[Movies] ([MovieId], [MovieName], [Genre], [DateOfRelease], [Actors]) VALUES (3, N'Top Gun', N'Action', 1986, N'Tom Cruise, Kelly McGills')
SET IDENTITY_INSERT [dbo].[Movies] OFF
