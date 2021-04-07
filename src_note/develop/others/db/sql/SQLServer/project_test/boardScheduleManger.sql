USE [master]
GO
/****** Object:  Database [BoardScheduleManger]    Script Date: 2016年8月17日, 星期三 下午,14:43:24 ******/
CREATE DATABASE [BoardScheduleManger]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BoardScheduleManger', FILENAME = N'I:\src-note\src\DataBase\SQLServer\Project\BoardScheduleManger.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BoardScheduleManger_log', FILENAME = N'I:\src-note\src\DataBase\SQLServer\Project\BoardScheduleManger_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BoardScheduleManger] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BoardScheduleManger].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BoardScheduleManger] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BoardScheduleManger] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BoardScheduleManger] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BoardScheduleManger] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BoardScheduleManger] SET ARITHABORT OFF 
GO
ALTER DATABASE [BoardScheduleManger] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BoardScheduleManger] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [BoardScheduleManger] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BoardScheduleManger] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BoardScheduleManger] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BoardScheduleManger] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BoardScheduleManger] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BoardScheduleManger] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BoardScheduleManger] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BoardScheduleManger] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BoardScheduleManger] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BoardScheduleManger] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BoardScheduleManger] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BoardScheduleManger] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BoardScheduleManger] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BoardScheduleManger] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BoardScheduleManger] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BoardScheduleManger] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BoardScheduleManger] SET RECOVERY FULL 
GO
ALTER DATABASE [BoardScheduleManger] SET  MULTI_USER 
GO
ALTER DATABASE [BoardScheduleManger] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BoardScheduleManger] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BoardScheduleManger] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BoardScheduleManger] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [BoardScheduleManger]
GO
/****** Object:  Table [dbo].[BoardroomInfo]    Script Date: 2016年8月17日, 星期三 下午,14:43:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BoardroomInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[boardName] [varchar](20) NOT NULL,
 CONSTRAINT [PK_BoardroomInfo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ScheduleInfo]    Script Date: 2016年8月17日, 星期三 下午,14:43:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ScheduleInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[boardroomId] [int] NOT NULL,
	[intendName] [varchar](20) NOT NULL,
	[startTime] [datetime] NOT NULL,
	[duration] [int] NOT NULL,
	[enteringName] [nchar](20) NOT NULL,
	[reason] [varchar](50) NULL,
 CONSTRAINT [PK_ScheduleInfo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[ScheduleInfo]  WITH CHECK ADD  CONSTRAINT [FK_ScheduleInfo_BoardroomInfo] FOREIGN KEY([boardroomId])
REFERENCES [dbo].[BoardroomInfo] ([id])
GO
ALTER TABLE [dbo].[ScheduleInfo] CHECK CONSTRAINT [FK_ScheduleInfo_BoardroomInfo]
GO
USE [master]
GO
ALTER DATABASE [BoardScheduleManger] SET  READ_WRITE 
GO
