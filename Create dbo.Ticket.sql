USE [C:\OOP2\OOP2PROJECT\MOVIEDATABASEFINAL\MOVIEDATABASEFINAL\MOVIETHEATRE.MDF]
GO

/****** Object: Table [dbo].[Ticket] Script Date: 11/22/2022 11:53:57 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Ticket] (
    [ticketId]     INT          IDENTITY (1, 1) NOT NULL,
    [E_ticket]     INT          NOT NULL,
    [availability] VARCHAR (50) NOT NULL
);


