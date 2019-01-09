create database BoardScheduleManager
on(
	name='BoardScheduleManager',
	filename='D:\BoardScheduleManager.mdf',
	size=5mb
)
log on
(
	name='BoardScheduleManager_log',
	filename='D:\BoardScheduleManager_log.mdf',
	size=5mb
)
go

CREATE TABLE [dbo].[BoardroomInfo] (
[id] int NOT NULL IDENTITY(1,1) ,
[boardName] varchar(20) NOT NULL 
)

-- ----------------------------
-- Records of BoardroomInfo
-- ----------------------------
SET IDENTITY_INSERT [dbo].[BoardroomInfo] ON
GO
INSERT INTO [dbo].[BoardroomInfo] ([id], [boardName]) VALUES (N'1', N'富贵厅')
GO
GO
INSERT INTO [dbo].[BoardroomInfo] ([id], [boardName]) VALUES (N'2', N'高山流水')
GO
GO
INSERT INTO [dbo].[BoardroomInfo] ([id], [boardName]) VALUES (N'3', N'天外飞仙')
GO
GO
INSERT INTO [dbo].[BoardroomInfo] ([id], [boardName]) VALUES (N'4', N'饭厅')
GO
GO
SET IDENTITY_INSERT [dbo].[BoardroomInfo] OFF
GO

CREATE TABLE [dbo].[ScheduleInfo] (
[id] int NOT NULL IDENTITY(1,1) ,
[boardroomId] int NOT NULL ,
[intendedName] varchar(20) NOT NULL ,
[startTime] datetime NOT NULL ,
[duration] int NOT NULL ,
[enteringName] varchar(20) NOT NULL ,
[reason] varchar(50) NULL 
)


-- ----------------------------
-- Records of ScheduleInfo
-- ----------------------------
SET IDENTITY_INSERT [dbo].[ScheduleInfo] ON
GO
INSERT INTO [dbo].[ScheduleInfo] ([id], [boardroomId], [intendedName], [startTime], [duration], [enteringName], [reason]) VALUES (N'1', N'1', N'唐奇', N'2015-06-12 00:00:00.000', N'3', N'小萌萌', null)
GO
GO
INSERT INTO [dbo].[ScheduleInfo] ([id], [boardroomId], [intendedName], [startTime], [duration], [enteringName], [reason]) VALUES (N'3', N'2', N'唐奇', N'2015-06-12 00:00:00.000', N'3', N'小萌萌', null)
GO
GO
INSERT INTO [dbo].[ScheduleInfo] ([id], [boardroomId], [intendedName], [startTime], [duration], [enteringName], [reason]) VALUES (N'4', N'3', N'唐奇', N'2015-06-12 00:00:00.000', N'3', N'小萌萌', null)
GO
GO
INSERT INTO [dbo].[ScheduleInfo] ([id], [boardroomId], [intendedName], [startTime], [duration], [enteringName], [reason]) VALUES (N'5', N'4', N'唐奇', N'2014-06-12 00:00:00.000', N'3', N'小萌萌', null)
GO
GO
INSERT INTO [dbo].[ScheduleInfo] ([id], [boardroomId], [intendedName], [startTime], [duration], [enteringName], [reason]) VALUES (N'6', N'4', N'潘越', N'2015-06-12 00:00:00.000', N'4', N'唐奇奇', N'吃饭')
GO
GO
SET IDENTITY_INSERT [dbo].[ScheduleInfo] OFF
GO

-- ----------------------------
-- Indexes structure for table BoardroomInfo
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table BoardroomInfo
-- ----------------------------
ALTER TABLE [dbo].[BoardroomInfo] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table ScheduleInfo
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table ScheduleInfo
-- ----------------------------
ALTER TABLE [dbo].[ScheduleInfo] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[ScheduleInfo]
-- ----------------------------
ALTER TABLE [dbo].[ScheduleInfo] ADD FOREIGN KEY ([boardroomId]) REFERENCES [dbo].[BoardroomInfo] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
