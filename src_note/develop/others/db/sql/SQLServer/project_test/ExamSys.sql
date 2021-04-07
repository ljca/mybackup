USE [master]
GO
/****** Object:  Database [ExamSys]    Script Date: 2021/4/2 星期五 23:16:55 ******/
CREATE DATABASE [ExamSys]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ExamSys_DB', FILENAME = N'I:\Temp\Data\db\SQLServer\Test\ExamSys.mdf' , SIZE = 5120KB , MAXSIZE = 20480KB , FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ExamSys_Log', FILENAME = N'I:\Temp\Data\db\SQLServer\Test\ExamSys_Log.ldf' , SIZE = 3072KB , MAXSIZE = 2048GB , FILEGROWTH = 1024KB )
GO
ALTER DATABASE [ExamSys] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ExamSys].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ExamSys] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ExamSys] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ExamSys] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ExamSys] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ExamSys] SET ARITHABORT OFF 
GO
ALTER DATABASE [ExamSys] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ExamSys] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ExamSys] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ExamSys] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ExamSys] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ExamSys] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ExamSys] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ExamSys] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ExamSys] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ExamSys] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ExamSys] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ExamSys] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ExamSys] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ExamSys] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ExamSys] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ExamSys] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ExamSys] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ExamSys] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ExamSys] SET RECOVERY FULL 
GO
ALTER DATABASE [ExamSys] SET  MULTI_USER 
GO
ALTER DATABASE [ExamSys] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ExamSys] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ExamSys] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ExamSys] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ExamSys', N'ON'
GO
USE [ExamSys]
GO
/****** Object:  Table [dbo].[ExamInfo]    Script Date: 2021/4/2 星期五 23:16:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ExamInfo](
	[ExamId] [int] IDENTITY(1,1) NOT NULL,
	[StuId] [char](5) NOT NULL,
	[Course] [varchar](20) NOT NULL,
	[Score] [int] NULL,
	[ExamDate] [datetime] NULL,
	[Remark] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sudent]    Script Date: 2021/4/2 星期五 23:16:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sudent](
	[StuId] [char](5) NOT NULL,
	[StuName] [varchar](20) NOT NULL,
	[StuAge] [int] NULL,
	[StuPhone] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[StuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ExamInfo] ON 

INSERT [dbo].[ExamInfo] ([ExamId], [StuId], [Course], [Score], [ExamDate], [Remark]) VALUES (1, N's001 ', N'C', 60, CAST(0x0000A12500000000 AS DateTime), N'计算机专业')
INSERT [dbo].[ExamInfo] ([ExamId], [StuId], [Course], [Score], [ExamDate], [Remark]) VALUES (2, N's002 ', N'java', 70, CAST(0x0000A10500000000 AS DateTime), N'第一次考试')
INSERT [dbo].[ExamInfo] ([ExamId], [StuId], [Course], [Score], [ExamDate], [Remark]) VALUES (3, N's100 ', N'C#', 83, CAST(0x0000A0E900000000 AS DateTime), N'第二次考试')
SET IDENTITY_INSERT [dbo].[ExamInfo] OFF
INSERT [dbo].[Sudent] ([StuId], [StuName], [StuAge], [StuPhone]) VALUES (N's001 ', N'张武', 19, NULL)
INSERT [dbo].[Sudent] ([StuId], [StuName], [StuAge], [StuPhone]) VALUES (N's002 ', N'张六子', 20, NULL)
INSERT [dbo].[Sudent] ([StuId], [StuName], [StuAge], [StuPhone]) VALUES (N's100 ', N'张六子', 19, NULL)
ALTER TABLE [dbo].[ExamInfo]  WITH CHECK ADD  CONSTRAINT [FK_ExamInfo_Sudent_StuId] FOREIGN KEY([StuId])
REFERENCES [dbo].[Sudent] ([StuId])
GO
ALTER TABLE [dbo].[ExamInfo] CHECK CONSTRAINT [FK_ExamInfo_Sudent_StuId]
GO
ALTER TABLE [dbo].[Sudent]  WITH CHECK ADD CHECK  (([StuAge]>=(15) AND [StuAge]<=(25)))
GO
USE [master]
GO
ALTER DATABASE [ExamSys] SET  READ_WRITE 
GO
