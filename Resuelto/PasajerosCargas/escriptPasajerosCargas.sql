USE [master]
GO
/****** Object:  Database [pasajeros_db]    Script Date: 10/07/2023 02:20:40 p. m. ******/
CREATE DATABASE [pasajeros_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'pasajeros_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\pasajeros_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'pasajeros_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\pasajeros_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [pasajeros_db] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [pasajeros_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [pasajeros_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [pasajeros_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [pasajeros_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [pasajeros_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [pasajeros_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [pasajeros_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [pasajeros_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [pasajeros_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [pasajeros_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [pasajeros_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [pasajeros_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [pasajeros_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [pasajeros_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [pasajeros_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [pasajeros_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [pasajeros_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [pasajeros_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [pasajeros_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [pasajeros_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [pasajeros_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [pasajeros_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [pasajeros_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [pasajeros_db] SET RECOVERY FULL 
GO
ALTER DATABASE [pasajeros_db] SET  MULTI_USER 
GO
ALTER DATABASE [pasajeros_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [pasajeros_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [pasajeros_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [pasajeros_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [pasajeros_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [pasajeros_db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'pasajeros_db', N'ON'
GO
ALTER DATABASE [pasajeros_db] SET QUERY_STORE = ON
GO
ALTER DATABASE [pasajeros_db] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [pasajeros_db]
GO
/****** Object:  Table [dbo].[Pasajeros]    Script Date: 10/07/2023 02:20:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pasajeros](
	[dni] [int] NULL,
	[nombre] [varchar](50) NULL,
	[equipaje] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Pasajeros] ([dni], [nombre], [equipaje]) VALUES (12345678, N'Pasajero1', 2)
INSERT [dbo].[Pasajeros] ([dni], [nombre], [equipaje]) VALUES (23456789, N'Pasajero45', 1)
INSERT [dbo].[Pasajeros] ([dni], [nombre], [equipaje]) VALUES (34567890, N'Pasajero3', 3)
INSERT [dbo].[Pasajeros] ([dni], [nombre], [equipaje]) VALUES (45678901, N'Pasajero4', 0)
INSERT [dbo].[Pasajeros] ([dni], [nombre], [equipaje]) VALUES (56789012, N'Pasajero5', 2)
INSERT [dbo].[Pasajeros] ([dni], [nombre], [equipaje]) VALUES (67890123, N'Pasajero6', 1)
INSERT [dbo].[Pasajeros] ([dni], [nombre], [equipaje]) VALUES (78901234, N'Pasajero7', 4)
INSERT [dbo].[Pasajeros] ([dni], [nombre], [equipaje]) VALUES (89012345, N'Pasajero8', 2)
INSERT [dbo].[Pasajeros] ([dni], [nombre], [equipaje]) VALUES (90123456, N'Pasajero9', 3)
INSERT [dbo].[Pasajeros] ([dni], [nombre], [equipaje]) VALUES (12345098, N'Pasajero10', 1)
INSERT [dbo].[Pasajeros] ([dni], [nombre], [equipaje]) VALUES (121, N'yober', 121)
GO
USE [master]
GO
ALTER DATABASE [pasajeros_db] SET  READ_WRITE 
GO
