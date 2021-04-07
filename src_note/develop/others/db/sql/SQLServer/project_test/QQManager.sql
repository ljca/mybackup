USE [master]
GO
/****** Object:  Database [QQManager]    Script Date: 2021/4/2 星期五 23:31:27 ******/
CREATE DATABASE [QQManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QQManager.mdf', FILENAME = N'I:\Temp\Data\db\SQLServer\Project\QQManager.mdf' , SIZE = 5120KB , MAXSIZE = 20480KB , FILEGROWTH = 2%)
 LOG ON 
( NAME = N'QQManager_Log.ldf', FILENAME = N'I:\Temp\Data\db\SQLServer\Project\QQManager_Log.ldf' , SIZE = 1024KB , MAXSIZE = 10240KB , FILEGROWTH = 2%)
GO
ALTER DATABASE [QQManager] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QQManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QQManager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QQManager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QQManager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QQManager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QQManager] SET ARITHABORT OFF 
GO
ALTER DATABASE [QQManager] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QQManager] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QQManager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QQManager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QQManager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QQManager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QQManager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QQManager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QQManager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QQManager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QQManager] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QQManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QQManager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QQManager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QQManager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QQManager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QQManager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QQManager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QQManager] SET RECOVERY FULL 
GO
ALTER DATABASE [QQManager] SET  MULTI_USER 
GO
ALTER DATABASE [QQManager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QQManager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QQManager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QQManager] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QQManager', N'ON'
GO
USE [QQManager]
GO
/****** Object:  Table [dbo].[LogInfo]    Script Date: 2021/4/2 星期五 23:31:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogInfo](
	[LogInName] [nvarchar](50) NOT NULL,
	[LogInPass] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QQD]    Script Date: 2021/4/2 星期五 23:31:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QQD](
	[QQjName] [nvarchar](50) NOT NULL,
	[Onlinex] [nvarchar](50) NOT NULL,
	[St] [char](10) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QQUserInfo]    Script Date: 2021/4/2 星期五 23:31:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QQUserInfo](
	[UNi] [nvarchar](50) NOT NULL,
	[UP] [nvarchar](50) NOT NULL,
	[Mail] [nvarchar](50) NOT NULL,
	[QQJ] [nvarchar](max) NOT NULL,
	[OnLineD] [nvarchar](max) NOT NULL,
	[QQId] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QQx]    Script Date: 2021/4/2 星期五 23:31:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QQx](
	[QQId] [nvarchar](max) NOT NULL,
	[OnLineD] [nvarchar](max) NOT NULL,
	[QQJ] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[LogInfo] ([LogInName], [LogInPass]) VALUES (N'QQ', N'12345')
INSERT [dbo].[LogInfo] ([LogInName], [LogInPass]) VALUES (N'QQ_1', N'12345')
INSERT [dbo].[QQD] ([QQjName], [Onlinex], [St]) VALUES (N'太阳', N'300', N'dc        ')
INSERT [dbo].[QQUserInfo] ([UNi], [UP], [Mail], [QQJ], [OnLineD], [QQId]) VALUES (N'无所不想的猪', N'2o93ldo', N'wsbx@126.com', N'4', N'19', N'9292920721')
INSERT [dbo].[QQUserInfo] ([UNi], [UP], [Mail], [QQJ], [OnLineD], [QQId]) VALUES (N'想飞的猪', N'349^*s2', N'xfdz@126.com', N'3', N'26', N'9292922334')
INSERT [dbo].[QQUserInfo] ([UNi], [UP], [Mail], [QQJ], [OnLineD], [QQId]) VALUES (N'想逃的猪', N'mol&$^#', N'xtdz@126.com', N'10', N'50', N'92929001122')
INSERT [dbo].[QQUserInfo] ([UNi], [UP], [Mail], [QQJ], [OnLineD], [QQId]) VALUES (N'想游泳的猪', N'26djde', N'xyydz@126.com', N'35', N'300', N'9292292')
INSERT [dbo].[QQUserInfo] ([UNi], [UP], [Mail], [QQJ], [OnLineD], [QQId]) VALUES (N'向往世界的猪', N'239xldo&', N'xwsj@126.com', N'1', N'1', N'929230421')
INSERT [dbo].[QQUserInfo] ([UNi], [UP], [Mail], [QQJ], [OnLineD], [QQId]) VALUES (N'有理想的猪', N'lxolu7', N'ylxdz@126.com', N'5', N'25', N'92929222631')
INSERT [dbo].[QQUserInfo] ([UNi], [UP], [Mail], [QQJ], [OnLineD], [QQId]) VALUES (N'郁闷的猪', N'lsdlo39', N'ymdz@126.com', N'23', N'121', N'929292987')
INSERT [dbo].[QQx] ([QQId], [OnLineD], [QQJ]) VALUES (N'9292920721', N'19', N'4')
INSERT [dbo].[QQx] ([QQId], [OnLineD], [QQJ]) VALUES (N'9292922334', N'26', N'3')
INSERT [dbo].[QQx] ([QQId], [OnLineD], [QQJ]) VALUES (N'92929001122', N'50', N'10')
INSERT [dbo].[QQx] ([QQId], [OnLineD], [QQJ]) VALUES (N'9292292', N'300', N'35')
INSERT [dbo].[QQx] ([QQId], [OnLineD], [QQJ]) VALUES (N'929230421', N'1', N'1')
INSERT [dbo].[QQx] ([QQId], [OnLineD], [QQJ]) VALUES (N'92929222631', N'25', N'5')
INSERT [dbo].[QQx] ([QQId], [OnLineD], [QQJ]) VALUES (N'929292987', N'121', N'23')
USE [master]
GO
ALTER DATABASE [QQManager] SET  READ_WRITE 
GO
