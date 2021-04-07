USE [master]
GO
/****** Object:  Database [MySchool_data]    Script Date: 2021/4/2 星期五 23:25:05 ******/
CREATE DATABASE [MySchool_data]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MySchool_data', FILENAME = N'I:\Temp\Data\db\SQLServer\Project\MySchool_data.mdf' , SIZE = 5120KB , MAXSIZE = 102400KB , FILEGROWTH = 15%)
 LOG ON 
( NAME = N'MySchool_log', FILENAME = N'I:\Temp\Data\db\SQLServer\Project\MySchool_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 1024KB )
GO
ALTER DATABASE [MySchool_data] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MySchool_data].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MySchool_data] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MySchool_data] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MySchool_data] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MySchool_data] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MySchool_data] SET ARITHABORT OFF 
GO
ALTER DATABASE [MySchool_data] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MySchool_data] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [MySchool_data] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MySchool_data] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MySchool_data] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MySchool_data] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MySchool_data] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MySchool_data] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MySchool_data] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MySchool_data] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MySchool_data] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MySchool_data] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MySchool_data] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MySchool_data] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MySchool_data] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MySchool_data] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MySchool_data] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MySchool_data] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MySchool_data] SET RECOVERY FULL 
GO
ALTER DATABASE [MySchool_data] SET  MULTI_USER 
GO
ALTER DATABASE [MySchool_data] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MySchool_data] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MySchool_data] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MySchool_data] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MySchool_data', N'ON'
GO
USE [MySchool_data]
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 2021/4/2 星期五 23:25:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[GradeId] [int] IDENTITY(1,1) NOT NULL,
	[GradeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_GradeID] PRIMARY KEY CLUSTERED 
(
	[GradeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Result]    Script Date: 2021/4/2 星期五 23:25:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Result](
	[StudentNo] [int] NOT NULL,
	[SubjectNo] [int] NOT NULL,
	[ExamDAte] [datetime] NOT NULL,
	[StudentResult] [int] NOT NULL,
 CONSTRAINT [PK_StudentNo_SubjectNo_ExamDate] PRIMARY KEY CLUSTERED 
(
	[StudentNo] ASC,
	[SubjectNo] ASC,
	[ExamDAte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student]    Script Date: 2021/4/2 星期五 23:25:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student](
	[StudentNo] [int] NOT NULL,
	[LoginPwd] [nvarchar](50) NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[Sex] [bit] NOT NULL,
	[GradeId] [int] NOT NULL,
	[Phone] [varchar](50) NULL,
	[Address] [nvarchar](255) NULL,
	[BronDate] [datetime] NOT NULL,
	[Email] [varchar](50) NULL,
	[IdentityCard] [varchar](18) NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 2021/4/2 星期五 23:25:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[SubjectNo] [int] IDENTITY(1,1) NOT NULL,
	[SubjectName] [nvarchar](50) NULL,
	[ClassHour] [int] NULL,
	[GradeId] [int] NULL,
 CONSTRAINT [PK_SubjectNo] PRIMARY KEY CLUSTERED 
(
	[SubjectNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[L]    Script Date: 2021/4/2 星期五 23:25:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[L] as
select * from Student

GO
SET IDENTITY_INSERT [dbo].[Grade] ON 

INSERT [dbo].[Grade] ([GradeId], [GradeName]) VALUES (1, N'一年级')
INSERT [dbo].[Grade] ([GradeId], [GradeName]) VALUES (2, N'二年级')
INSERT [dbo].[Grade] ([GradeId], [GradeName]) VALUES (3, N'三年级')
SET IDENTITY_INSERT [dbo].[Grade] OFF
INSERT [dbo].[Result] ([StudentNo], [SubjectNo], [ExamDAte], [StudentResult]) VALUES (1, 1, CAST(0x00009FF300000000 AS DateTime), 80)
INSERT [dbo].[Result] ([StudentNo], [SubjectNo], [ExamDAte], [StudentResult]) VALUES (2, 2, CAST(0x00009F7A00000000 AS DateTime), 70)
INSERT [dbo].[Result] ([StudentNo], [SubjectNo], [ExamDAte], [StudentResult]) VALUES (3, 3, CAST(0x00009E5E00000000 AS DateTime), 60)
INSERT [dbo].[Student] ([StudentNo], [LoginPwd], [StudentName], [Sex], [GradeId], [Phone], [Address], [BronDate], [Email], [IdentityCard]) VALUES (1, N'clsls2', N'张三', 0, 1, N'92892922', NULL, CAST(0x00001E2000000000 AS DateTime), NULL, N'9292792792729')
INSERT [dbo].[Student] ([StudentNo], [LoginPwd], [StudentName], [Sex], [GradeId], [Phone], [Address], [BronDate], [Email], [IdentityCard]) VALUES (2, N'lxsljlsjls', N'李四', 1, 2, N'626252', NULL, CAST(0x0000878B00000000 AS DateTime), NULL, N'2545454544545474')
INSERT [dbo].[Student] ([StudentNo], [LoginPwd], [StudentName], [Sex], [GradeId], [Phone], [Address], [BronDate], [Email], [IdentityCard]) VALUES (3, N'njllsk', N'王五', 1, 3, N'0230902', NULL, CAST(0x0000864500000000 AS DateTime), NULL, N'9999279292922')
SET IDENTITY_INSERT [dbo].[Subject] ON 

INSERT [dbo].[Subject] ([SubjectNo], [SubjectName], [ClassHour], [GradeId]) VALUES (1, N'java', 200, 1)
INSERT [dbo].[Subject] ([SubjectNo], [SubjectName], [ClassHour], [GradeId]) VALUES (2, N'C#', 300, 2)
INSERT [dbo].[Subject] ([SubjectNo], [SubjectName], [ClassHour], [GradeId]) VALUES (3, N'PS', 100, 3)
SET IDENTITY_INSERT [dbo].[Subject] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_IdentityCard]    Script Date: 2021/4/2 星期五 23:25:05 ******/
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [UQ_IdentityCard] UNIQUE NONCLUSTERED 
(
	[IdentityCard] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Result]  WITH CHECK ADD  CONSTRAINT [FK_Student_Result] FOREIGN KEY([StudentNo])
REFERENCES [dbo].[Student] ([StudentNo])
GO
ALTER TABLE [dbo].[Result] CHECK CONSTRAINT [FK_Student_Result]
GO
ALTER TABLE [dbo].[Result]  WITH CHECK ADD  CONSTRAINT [FK_Subject_Result] FOREIGN KEY([SubjectNo])
REFERENCES [dbo].[Subject] ([SubjectNo])
GO
ALTER TABLE [dbo].[Result] CHECK CONSTRAINT [FK_Subject_Result]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Grade_Student] FOREIGN KEY([GradeId])
REFERENCES [dbo].[Grade] ([GradeId])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Grade_Student]
GO
ALTER TABLE [dbo].[Subject]  WITH CHECK ADD  CONSTRAINT [FK_Grade_Subject] FOREIGN KEY([GradeId])
REFERENCES [dbo].[Grade] ([GradeId])
GO
ALTER TABLE [dbo].[Subject] CHECK CONSTRAINT [FK_Grade_Subject]
GO
USE [master]
GO
ALTER DATABASE [MySchool_data] SET  READ_WRITE 
GO
