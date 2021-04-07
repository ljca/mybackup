USE [master]
GO
/****** Object:  Database [PhoneCardSys]    Script Date: 2021/4/2 星期五 23:29:26 ******/
CREATE DATABASE [PhoneCardSys]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PhoneCardSys.mdf', FILENAME = N'I:\Temp\Data\db\SQLServer\Project\PhoneCardSys.mdf' , SIZE = 10240KB , MAXSIZE = 30720KB , FILEGROWTH = 2%)
 LOG ON 
( NAME = N'PhoneCardSys_Log.ldf', FILENAME = N'I:\Temp\Data\db\SQLServer\Project\PhoneCardSys_Log.ldf' , SIZE = 5120KB , MAXSIZE = 15360KB , FILEGROWTH = 2%)
GO
ALTER DATABASE [PhoneCardSys] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PhoneCardSys].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PhoneCardSys] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PhoneCardSys] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PhoneCardSys] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PhoneCardSys] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PhoneCardSys] SET ARITHABORT OFF 
GO
ALTER DATABASE [PhoneCardSys] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PhoneCardSys] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [PhoneCardSys] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PhoneCardSys] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PhoneCardSys] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PhoneCardSys] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PhoneCardSys] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PhoneCardSys] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PhoneCardSys] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PhoneCardSys] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PhoneCardSys] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PhoneCardSys] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PhoneCardSys] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PhoneCardSys] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PhoneCardSys] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PhoneCardSys] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PhoneCardSys] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PhoneCardSys] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PhoneCardSys] SET RECOVERY FULL 
GO
ALTER DATABASE [PhoneCardSys] SET  MULTI_USER 
GO
ALTER DATABASE [PhoneCardSys] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PhoneCardSys] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PhoneCardSys] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PhoneCardSys] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'PhoneCardSys', N'ON'
GO
USE [PhoneCardSys]
GO
/****** Object:  Table [dbo].[PhoneCard]    Script Date: 2021/4/2 星期五 23:29:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhoneCard](
	[PhoneCardId] [int] IDENTITY(1,1) NOT NULL,
	[PhoneCardMoney] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PhoneCardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhoneCardSale]    Script Date: 2021/4/2 星期五 23:29:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhoneCardSale](
	[SaleId] [int] IDENTITY(1,1) NOT NULL,
	[PhoneCardId] [int] NOT NULL,
	[SaleCount] [int] NOT NULL,
	[SaleDate] [datetime] NOT NULL,
	[SalePrice] [int] NULL,
	[Remark] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[SaleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[PhoneCard] ON 

INSERT [dbo].[PhoneCard] ([PhoneCardId], [PhoneCardMoney]) VALUES (1, 30)
INSERT [dbo].[PhoneCard] ([PhoneCardId], [PhoneCardMoney]) VALUES (2, 50)
INSERT [dbo].[PhoneCard] ([PhoneCardId], [PhoneCardMoney]) VALUES (3, 100)
SET IDENTITY_INSERT [dbo].[PhoneCard] OFF
SET IDENTITY_INSERT [dbo].[PhoneCardSale] ON 

INSERT [dbo].[PhoneCardSale] ([SaleId], [PhoneCardId], [SaleCount], [SaleDate], [SalePrice], [Remark]) VALUES (1, 1, 10, CAST(0x000001F700000000 AS DateTime), 10, N'10元')
INSERT [dbo].[PhoneCardSale] ([SaleId], [PhoneCardId], [SaleCount], [SaleDate], [SalePrice], [Remark]) VALUES (2, 2, 20, CAST(0x000001F600000000 AS DateTime), 20, N'20元')
INSERT [dbo].[PhoneCardSale] ([SaleId], [PhoneCardId], [SaleCount], [SaleDate], [SalePrice], [Remark]) VALUES (3, 3, 30, CAST(0x000001F700000000 AS DateTime), 30, N'30元')
SET IDENTITY_INSERT [dbo].[PhoneCardSale] OFF
ALTER TABLE [dbo].[PhoneCardSale]  WITH CHECK ADD  CONSTRAINT [FK_PhoneCardSale_PhoneCard] FOREIGN KEY([PhoneCardId])
REFERENCES [dbo].[PhoneCard] ([PhoneCardId])
GO
ALTER TABLE [dbo].[PhoneCardSale] CHECK CONSTRAINT [FK_PhoneCardSale_PhoneCard]
GO
USE [master]
GO
ALTER DATABASE [PhoneCardSys] SET  READ_WRITE 
GO
