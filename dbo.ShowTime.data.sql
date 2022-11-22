SET IDENTITY_INSERT [dbo].[ShowTime] ON
INSERT INTO [dbo].[ShowTime] ([ShowTimeId], [MovieId], [ScreenRoomId]) VALUES (1, 1, 2)
INSERT INTO [dbo].[ShowTime] ([ShowTimeId], [MovieId], [ScreenRoomId]) VALUES (2, 2, 3)
INSERT INTO [dbo].[ShowTime] ([ShowTimeId], [MovieId], [ScreenRoomId]) VALUES (3, 3, 1)
SET IDENTITY_INSERT [dbo].[ShowTime] OFF
