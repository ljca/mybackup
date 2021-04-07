USE [master]
GO
/****** Object:  Database [Price]    Script Date: 2021/4/2 星期五 23:30:11 ******/
CREATE DATABASE [Price]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Price', FILENAME = N'I:\Temp\Data\db\SQLServer\Project\Price.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Price_log', FILENAME = N'I:\Temp\Data\db\SQLServer\Project\Price_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Price] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Price].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Price] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Price] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Price] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Price] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Price] SET ARITHABORT OFF 
GO
ALTER DATABASE [Price] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Price] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Price] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Price] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Price] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Price] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Price] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Price] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Price] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Price] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Price] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Price] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Price] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Price] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Price] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Price] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Price] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Price] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Price] SET RECOVERY FULL 
GO
ALTER DATABASE [Price] SET  MULTI_USER 
GO
ALTER DATABASE [Price] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Price] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Price] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Price] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Price', N'ON'
GO
USE [Price]
GO
/****** Object:  User [mi]    Script Date: 2021/4/2 星期五 23:30:11 ******/
CREATE USER [mi] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [mi]
GO
/****** Object:  Table [dbo].[huoche]    Script Date: 2021/4/2 星期五 23:30:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[huoche](
	[编号] [float] NULL,
	[车次] [nvarchar](255) NULL,
	[站名] [nvarchar](255) NULL,
	[站名简写] [nvarchar](255) NULL,
	[每站间隔] [float] NULL
) ON [PRIMARY]

GO
INSERT [dbo].[huoche] ([编号], [车次], [站名], [站名简写], [每站间隔]) VALUES (1, N'k1234', N'成都东', N'cdd', 0)
INSERT [dbo].[huoche] ([编号], [车次], [站名], [站名简写], [每站间隔]) VALUES (2, N'k1234', N'遂宁', N'sn', 46)
INSERT [dbo].[huoche] ([编号], [车次], [站名], [站名简写], [每站间隔]) VALUES (3, N'k1234', N'合川', N'hc', 43)
INSERT [dbo].[huoche] ([编号], [车次], [站名], [站名简写], [每站间隔]) VALUES (4, N'k1234', N'重庆北', N'cqb', 60)
INSERT [dbo].[huoche] ([编号], [车次], [站名], [站名简写], [每站间隔]) VALUES (5, N'k123', N'成都东', N'cdd', 0)
INSERT [dbo].[huoche] ([编号], [车次], [站名], [站名简写], [每站间隔]) VALUES (6, N'k123', N'遂宁', N'sn', 46)
INSERT [dbo].[huoche] ([编号], [车次], [站名], [站名简写], [每站间隔]) VALUES (7, N'k123', N'重庆北', N'cqb', 103)
INSERT [dbo].[huoche] ([编号], [车次], [站名], [站名简写], [每站间隔]) VALUES (8, N'k22', N'重庆北', N'cqb', 0)
INSERT [dbo].[huoche] ([编号], [车次], [站名], [站名简写], [每站间隔]) VALUES (9, N'k22', N'遂宁', N'sn', 103)
INSERT [dbo].[huoche] ([编号], [车次], [站名], [站名简写], [每站间隔]) VALUES (10, N'K22', N'成都东', N'cdd', 46)
USE [master]
GO
ALTER DATABASE [Price] SET  READ_WRITE 
GO
