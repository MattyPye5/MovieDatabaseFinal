USE [C:\OOP2\OOP2PROJECT\MOVIEDATABASEFINAL\MOVIEDATABASEFINAL\MOVIETHEATRE.MDF]
GO

/****** Object: Table [dbo].[Movies] Script Date: 11/22/2022 11:20:18 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Movies] (
    [MovieId]       INT          IDENTITY (1, 1) NOT NULL,
    [MovieName]     VARCHAR (50) NOT NULL,
    [Genre]         VARCHAR (50) NOT NULL,
    [DateOfRelease] INT          NOT NULL,
    [Actors]        VARCHAR (50) NOT NULL
);


