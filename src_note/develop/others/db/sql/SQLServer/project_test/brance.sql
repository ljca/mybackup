USE [master]
GO
/****** Object:  Database [brance]    Script Date: 2021/4/2 星期五 23:14:39 ******/
CREATE DATABASE [brance]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'brance', FILENAME = N'I:\Temp\Data\db\SQLServer\Test\brance.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'brance_log', FILENAME = N'I:\Temp\Data\db\SQLServer\Test\brance_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [brance] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [brance].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [brance] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [brance] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [brance] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [brance] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [brance] SET ARITHABORT OFF 
GO
ALTER DATABASE [brance] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [brance] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [brance] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [brance] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [brance] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [brance] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [brance] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [brance] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [brance] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [brance] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [brance] SET  DISABLE_BROKER 
GO
ALTER DATABASE [brance] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [brance] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [brance] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [brance] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [brance] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [brance] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [brance] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [brance] SET RECOVERY FULL 
GO
ALTER DATABASE [brance] SET  MULTI_USER 
GO
ALTER DATABASE [brance] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [brance] SET DB_CHAINING OFF 
GO
ALTER DATABASE [brance] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [brance] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'brance', N'ON'
GO
USE [brance]
GO
/****** Object:  Table [dbo].[Branches]    Script Date: 2021/4/2 星期五 23:14:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branches](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[cityAreaId] [int] NOT NULL,
	[address] [nvarchar](100) NOT NULL,
	[telephone] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Branches] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CityArea]    Script Date: 2021/4/2 星期五 23:14:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CityArea](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CityArea] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Branches] ON 

INSERT [dbo].[Branches] ([id], [name], [cityAreaId], [address], [telephone]) VALUES (1, N'海淀区xx路支行', 3, N'海淀区xx路128号', N'87654321')
INSERT [dbo].[Branches] ([id], [name], [cityAreaId], [address], [telephone]) VALUES (2, N'东城支行', 1, N'东城区xx路12号', N'89292233')
INSERT [dbo].[Branches] ([id], [name], [cityAreaId], [address], [telephone]) VALUES (3, N'西城支行', 2, N'西城区xx路34号', N'87659292')
SET IDENTITY_INSERT [dbo].[Branches] OFF
SET IDENTITY_INSERT [dbo].[CityArea] ON 

INSERT [dbo].[CityArea] ([id], [name]) VALUES (1, N'东城区')
INSERT [dbo].[CityArea] ([id], [name]) VALUES (2, N'西城区')
INSERT [dbo].[CityArea] ([id], [name]) VALUES (3, N'海淀区')
SET IDENTITY_INSERT [dbo].[CityArea] OFF
/****** Object:  Index [IX_Branches]    Script Date: 2021/4/2 星期五 23:14:40 ******/
CREATE NONCLUSTERED INDEX [IX_Branches] ON [dbo].[Branches]
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Branches]  WITH CHECK ADD  CONSTRAINT [FK_Branches_CityArea] FOREIGN KEY([cityAreaId])
REFERENCES [dbo].[CityArea] ([id])
GO
ALTER TABLE [dbo].[Branches] CHECK CONSTRAINT [FK_Branches_CityArea]
GO
USE [master]
GO
ALTER DATABASE [brance] SET  READ_WRITE 
GO
