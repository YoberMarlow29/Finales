USE [master]
GO
/****** Object:  Database [concesionaria]    Script Date: 11/07/2023 01:18:05 p. m. ******/
CREATE DATABASE [concesionaria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'concesionaria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\concesionaria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'concesionaria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\concesionaria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [concesionaria] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [concesionaria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [concesionaria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [concesionaria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [concesionaria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [concesionaria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [concesionaria] SET ARITHABORT OFF 
GO
ALTER DATABASE [concesionaria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [concesionaria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [concesionaria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [concesionaria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [concesionaria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [concesionaria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [concesionaria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [concesionaria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [concesionaria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [concesionaria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [concesionaria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [concesionaria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [concesionaria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [concesionaria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [concesionaria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [concesionaria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [concesionaria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [concesionaria] SET RECOVERY FULL 
GO
ALTER DATABASE [concesionaria] SET  MULTI_USER 
GO
ALTER DATABASE [concesionaria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [concesionaria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [concesionaria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [concesionaria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [concesionaria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [concesionaria] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'concesionaria', N'ON'
GO
ALTER DATABASE [concesionaria] SET QUERY_STORE = ON
GO
ALTER DATABASE [concesionaria] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [concesionaria]
GO
/****** Object:  Table [dbo].[autos]    Script Date: 11/07/2023 01:18:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[autos](
	[marca] [varchar](50) NULL,
	[modelo] [varchar](50) NULL,
	[kms] [int] NULL,
	[color] [varchar](50) NULL,
	[patente] [varchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[autos] ([marca], [modelo], [kms], [color], [patente]) VALUES (N'asas', N'asasa', 1212, N'asasa', N'AC188AD')
INSERT [dbo].[autos] ([marca], [modelo], [kms], [color], [patente]) VALUES (N'asasa', N'acx', 12, N'verde', N'asas')
INSERT [dbo].[autos] ([marca], [modelo], [kms], [color], [patente]) VALUES (N'asasa', N'asas', 1212, N'verde', N'asas')
INSERT [dbo].[autos] ([marca], [modelo], [kms], [color], [patente]) VALUES (N'sas', N'asas', 1, N'verde', N'asa')
INSERT [dbo].[autos] ([marca], [modelo], [kms], [color], [patente]) VALUES (N'asasa', N'asas', 1, N'verde', N'asas')
INSERT [dbo].[autos] ([marca], [modelo], [kms], [color], [patente]) VALUES (N'toyoya', N'asas', 121, N'ada', N'AC188AD')
INSERT [dbo].[autos] ([marca], [modelo], [kms], [color], [patente]) VALUES (N'Arcor', N'pipita', 1, N'aszul', N'adadsa')
INSERT [dbo].[autos] ([marca], [modelo], [kms], [color], [patente]) VALUES (N'Pipo', N'Zancor', 121, N'verde', N'1131')
INSERT [dbo].[autos] ([marca], [modelo], [kms], [color], [patente]) VALUES (N'asasa', N'asas', 1, N'verde', N'1212')
INSERT [dbo].[autos] ([marca], [modelo], [kms], [color], [patente]) VALUES (N'asas', N'ada', 12, N'verde', N'asasas')
INSERT [dbo].[autos] ([marca], [modelo], [kms], [color], [patente]) VALUES (N'adsa', N'asas', 12, N'verde', N'asas')
INSERT [dbo].[autos] ([marca], [modelo], [kms], [color], [patente]) VALUES (N'sas', N'asas', 12, N'verde', N'asas')
INSERT [dbo].[autos] ([marca], [modelo], [kms], [color], [patente]) VALUES (N'asasa', N'asas', 121, N'verde', N'asas')
INSERT [dbo].[autos] ([marca], [modelo], [kms], [color], [patente]) VALUES (N'aasa', N'asas', 12, N' verde', N'asa')
INSERT [dbo].[autos] ([marca], [modelo], [kms], [color], [patente]) VALUES (N'asas', N'asas', 12, N'verde', N'asas')
GO
USE [master]
GO
ALTER DATABASE [concesionaria] SET  READ_WRITE 
GO
