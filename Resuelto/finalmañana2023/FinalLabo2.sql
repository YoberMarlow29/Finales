CREATE DATABASE [FinalLabo2]
GO
USE [FinalLabo2]
GO
/****** Object:  Table [dbo].[planetas]    Script Date: 11/7/2023 3:09:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[planetas](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[masa] [float] NULL,
	[diametro] [float] NULL,
	[satelites] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[planetas] ([id], [nombre], [masa], [diametro], [satelites]) VALUES (1, N'Saturno', 568319, 120536, 146)
INSERT [dbo].[planetas] ([id], [nombre], [masa], [diametro], [satelites]) VALUES (2, N'Jupiter', 5638910026, 156325, 21)
GO
