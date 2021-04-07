USE [master]
GO
/****** Object:  Database [Test]    Script Date: 2021/4/2 星期五 23:36:30 ******/
CREATE DATABASE [Test]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Test.mdf', FILENAME = N'I:\Temp\Data\db\SQLServer\Test\Test.mdf' , SIZE = 5120KB , MAXSIZE = 10240KB , FILEGROWTH = 2%)
 LOG ON 
( NAME = N'Test_Log.ldf', FILENAME = N'I:\Temp\Data\db\SQLServer\Test\Test_Log.ldf' , SIZE = 2048KB , MAXSIZE = 10240KB , FILEGROWTH = 2%)
GO
ALTER DATABASE [Test] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Test].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Test] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Test] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Test] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Test] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Test] SET ARITHABORT OFF 
GO
ALTER DATABASE [Test] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Test] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Test] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Test] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Test] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Test] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Test] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Test] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Test] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Test] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Test] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Test] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Test] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Test] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Test] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Test] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Test] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Test] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Test] SET RECOVERY FULL 
GO
ALTER DATABASE [Test] SET  MULTI_USER 
GO
ALTER DATABASE [Test] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Test] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Test] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Test] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Test', N'ON'
GO
USE [Test]
GO
/****** Object:  Table [dbo].[QQ]    Script Date: 2021/4/2 星期五 23:36:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QQ](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[QQID] [nvarchar](max) NOT NULL,
	[QQName] [nvarchar](max) NOT NULL,
	[Pass] [nvarchar](max) NOT NULL,
	[QQd] [nvarchar](50) NOT NULL,
	[OnlineD] [float] NOT NULL,
	[Mail] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QQInfo]    Script Date: 2021/4/2 星期五 23:36:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QQInfo](
	[QQd] [nvarchar](50) NOT NULL,
	[QQName] [nvarchar](max) NOT NULL,
	[QQID] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[QQ] ON 

INSERT [dbo].[QQ] ([ID], [QQID], [QQName], [Pass], [QQd], [OnlineD], [Mail]) VALUES (1, N'08390283022', N'有理想的猪伤不起啊', N'123456', N'*****', 211.3, N'ylldzsbqa@126.com')
INSERT [dbo].[QQ] ([ID], [QQID], [QQName], [Pass], [QQd], [OnlineD], [Mail]) VALUES (2, N'1290283022', N'有理想的猪伤不起啊', N'123456', N'*****', 22.3, N'ylldzsbqa@126.com')
INSERT [dbo].[QQ] ([ID], [QQID], [QQName], [Pass], [QQd], [OnlineD], [Mail]) VALUES (3, N'23490283022', N'有理想的猪伤不起啊', N'123456', N'*****', 392.3, N'ylldzsbqa@126.com')
INSERT [dbo].[QQ] ([ID], [QQID], [QQName], [Pass], [QQd], [OnlineD], [Mail]) VALUES (4, N'34390283022', N'有理想的猪伤不起啊', N'123456', N'*****', 190.3, N'ylldzsbqa@126.com')
INSERT [dbo].[QQ] ([ID], [QQID], [QQName], [Pass], [QQd], [OnlineD], [Mail]) VALUES (5, N'432690283022', N'有理想的猪伤不起啊', N'123456', N'*****', 29.3, N'ylldzsbqa@126.com')
INSERT [dbo].[QQ] ([ID], [QQID], [QQName], [Pass], [QQd], [OnlineD], [Mail]) VALUES (6, N'90283022356', N'有理想的猪伤不起啊', N'123456', N'*****', 0.3, N'ylldzsbqa@126.com')
INSERT [dbo].[QQ] ([ID], [QQID], [QQName], [Pass], [QQd], [OnlineD], [Mail]) VALUES (7, N'902830224784', N'有理想的猪伤不起啊', N'123456', N'*****', 2.3, N'ylldzsbqa@126.com')
INSERT [dbo].[QQ] ([ID], [QQID], [QQName], [Pass], [QQd], [OnlineD], [Mail]) VALUES (8, N'9028302334842', N'有理想的猪伤不起啊', N'123456', N'*****', 112.3, N'ylldzsbqa@126.com')
INSERT [dbo].[QQ] ([ID], [QQID], [QQName], [Pass], [QQd], [OnlineD], [Mail]) VALUES (9, N'9028302842', N'有理想的猪伤不起啊', N'123456', N'*****', 972.3, N'ylldzsbqa@126.com')
INSERT [dbo].[QQ] ([ID], [QQID], [QQName], [Pass], [QQd], [OnlineD], [Mail]) VALUES (10, N'90287433022', N'有理想的猪伤不起啊', N'123456', N'*****', 82.3, N'ylldzsbqa@126.com')
INSERT [dbo].[QQ] ([ID], [QQID], [QQName], [Pass], [QQd], [OnlineD], [Mail]) VALUES (11, N'9034283022', N'有理想的猪伤不起啊', N'123456', N'*****', 50.3, N'ylldzsbqa@126.com')
SET IDENTITY_INSERT [dbo].[QQ] OFF
INSERT [dbo].[QQInfo] ([QQd], [QQName], [QQID]) VALUES (N'*****', N'有理想的猪伤不起啊', N'08390283022')
INSERT [dbo].[QQInfo] ([QQd], [QQName], [QQID]) VALUES (N'*****', N'有理想的猪伤不起啊', N'1290283022')
INSERT [dbo].[QQInfo] ([QQd], [QQName], [QQID]) VALUES (N'*****', N'有理想的猪伤不起啊', N'23490283022')
INSERT [dbo].[QQInfo] ([QQd], [QQName], [QQID]) VALUES (N'*****', N'有理想的猪伤不起啊', N'34390283022')
INSERT [dbo].[QQInfo] ([QQd], [QQName], [QQID]) VALUES (N'*****', N'有理想的猪伤不起啊', N'432690283022')
INSERT [dbo].[QQInfo] ([QQd], [QQName], [QQID]) VALUES (N'*****', N'有理想的猪伤不起啊', N'90283022356')
INSERT [dbo].[QQInfo] ([QQd], [QQName], [QQID]) VALUES (N'*****', N'有理想的猪伤不起啊', N'902830224784')
INSERT [dbo].[QQInfo] ([QQd], [QQName], [QQID]) VALUES (N'*****', N'有理想的猪伤不起啊', N'9028302334842')
INSERT [dbo].[QQInfo] ([QQd], [QQName], [QQID]) VALUES (N'*****', N'有理想的猪伤不起啊', N'9028302842')
INSERT [dbo].[QQInfo] ([QQd], [QQName], [QQID]) VALUES (N'*****', N'有理想的猪伤不起啊', N'90287433022')
INSERT [dbo].[QQInfo] ([QQd], [QQName], [QQID]) VALUES (N'*****', N'有理想的猪伤不起啊', N'9034283022')
ALTER TABLE [dbo].[QQ] ADD  DEFAULT ('*') FOR [QQd]
GO
ALTER TABLE [dbo].[QQ] ADD  DEFAULT ((0.0)) FOR [OnlineD]
GO
ALTER TABLE [dbo].[QQ] ADD  DEFAULT ('tbnzhhdz@yeah.net') FOR [Mail]
GO
USE [master]
GO
ALTER DATABASE [Test] SET  READ_WRITE 
GO
