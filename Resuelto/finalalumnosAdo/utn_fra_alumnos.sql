USE [master]
GO
/****** Object:  Database [utn_fra_alumnos]    Script Date: 11/07/2023 09:47:41 p. m. ******/
CREATE DATABASE [utn_fra_alumnos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'utn_fra_alumnos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\utn_fra_alumnos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'utn_fra_alumnos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\utn_fra_alumnos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [utn_fra_alumnos] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [utn_fra_alumnos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [utn_fra_alumnos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET ARITHABORT OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [utn_fra_alumnos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [utn_fra_alumnos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [utn_fra_alumnos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [utn_fra_alumnos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET RECOVERY FULL 
GO
ALTER DATABASE [utn_fra_alumnos] SET  MULTI_USER 
GO
ALTER DATABASE [utn_fra_alumnos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [utn_fra_alumnos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [utn_fra_alumnos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [utn_fra_alumnos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [utn_fra_alumnos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'utn_fra_alumnos', N'ON'
GO
ALTER DATABASE [utn_fra_alumnos] SET QUERY_STORE = ON
GO
ALTER DATABASE [utn_fra_alumnos] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [utn_fra_alumnos]
GO
/****** Object:  Table [dbo].[alumnos]    Script Date: 11/07/2023 09:47:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alumnos](
	[dni] [int] NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[nota] [float] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[alumnos] ([dni], [apellido], [nombre], [nota]) VALUES (34, N'aa', N'asa', 12)
INSERT [dbo].[alumnos] ([dni], [apellido], [nombre], [nota]) VALUES (999555, N'Lucas', N'Modric', 2)
INSERT [dbo].[alumnos] ([dni], [apellido], [nombre], [nota]) VALUES (665413, N'Popo', N'Sanchez', 5)
INSERT [dbo].[alumnos] ([dni], [apellido], [nombre], [nota]) VALUES (0, N'', N'', 1)
GO
USE [master]
GO
ALTER DATABASE [utn_fra_alumnos] SET  READ_WRITE 
GO
