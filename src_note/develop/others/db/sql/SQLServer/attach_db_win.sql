-- 附加数据库。
--exec sp_attach_db '','I:\Temp\Data\db\SQLServer\Project',''

-- I:\Temp\Data\db\SQLServer\Project
--exec sp_attach_db 'myktv.sql              ','I:\Temp\Data\db\SQLServer\Project\myktv.sql
--exec sp_attach_db 'boardScheduleManger.sql'  'I:\Temp\Data\db\SQLServer\Project\boardScheduleManger.sql
exec sp_attach_db 'House','I:\Temp\Data\db\SQLServer\Project\House.mdf','I:\Temp\Data\db\SQLServer\Project\House_Log.ldf'
go

exec sp_attach_db 'Library','I:\Temp\Data\db\SQLServer\Project\Library.mdf','I:\Temp\Data\db\SQLServer\Project\Library_Log.ldf'
go

exec sp_attach_db 'Live','I:\Temp\Data\db\SQLServer\Project\Live.mdf','I:\Temp\Data\db\SQLServer\Project\Live_log.ldf'
go

exec sp_attach_db 'MySchool_data','I:\Temp\Data\db\SQLServer\Project\MySchool_data.mdf','I:\Temp\Data\db\SQLServer\Project\MySchool_log.ldf'
go

exec sp_attach_db 'newsxql','I:\Temp\Data\db\SQLServer\Project\newsxql.mdf','I:\Temp\Data\db\SQLServer\Project\newsxql_Log.ldf'
go

exec sp_attach_db 'PhoneCardSys','I:\Temp\Data\db\SQLServer\Project\PhoneCardSys.mdf','I:\Temp\Data\db\SQLServer\Project\PhoneCardSys_Log.ldf'
go

exec sp_attach_db 'Price','I:\Temp\Data\db\SQLServer\Project\Price.mdf','I:\Temp\Data\db\SQLServer\Project\Price_log.ldf'
go

exec sp_attach_db 'QQManager','I:\Temp\Data\db\SQLServer\Project\QQManager.mdf','I:\Temp\Data\db\SQLServer\Project\QQManager_Log.ldf'
go

exec sp_attach_db 'SMS','I:\Temp\Data\db\SQLServer\Project\SMS.mdf','I:\Temp\Data\db\SQLServer\Project\SMS_log.ldf'
go

exec sp_attach_db 'Users','I:\Temp\Data\db\SQLServer\Project\Users.mdf','I:\Temp\Data\db\SQLServer\Project\Users_Log.ldf'
go

--I:\Temp\Data\db\SQLServer\TempDataBase

exec sp_attach_db 'Pets','I:\Temp\Data\db\SQLServer\TempDataBase\Pets.mdf','I:\Temp\Data\db\SQLServer\TempDataBase\Pets_log.ldf'
go

exec sp_attach_db 'QQ','I:\Temp\Data\db\SQLServer\TempDataBase\QQ.mdf','I:\Temp\Data\db\SQLServer\TempDataBase\QQ_log.ldf'
go

exec sp_attach_db 'StudentDB','I:\Temp\Data\db\SQLServer\TempDataBase\StudentDB.mdf','I:\Temp\Data\db\SQLServer\TempDataBase\StudentDB_Log.ldf'
go

exec sp_attach_db 'Teacher','I:\Temp\Data\db\SQLServer\TempDataBase\Teacher.mdf','I:\Temp\Data\db\SQLServer\TempDataBase\Teacher_Log.ldf'
go


--I:\Temp\Data\db\SQLServer\Test 

exec sp_attach_db 'AirQualityDB','I:\Temp\Data\db\SQLServer\Test\AirQualityDB.mdf','I:\Temp\Data\db\SQLServer\Test\AirQualityDB_log.ldf'
go

exec sp_attach_db 'brance','I:\Temp\Data\db\SQLServer\Test\brance.mdf','I:\Temp\Data\db\SQLServer\Test\brance_log.ldf'
go

exec sp_attach_db 'ExamSys','I:\Temp\Data\db\SQLServer\Test\ExamSys.mdf','I:\Temp\Data\db\SQLServer\Test\ExamSys_Log.ldf'
go

exec sp_attach_db 'FinanProduct','I:\Temp\Data\db\SQLServer\Test\FinanProduct.mdf','I:\Temp\Data\db\SQLServer\Test\FinanProduct_log.ldf'
go

exec sp_attach_db 'HRSys','I:\Temp\Data\db\SQLServer\Test\HRSys.mdf','I:\Temp\Data\db\SQLServer\Test\HRSys_log.ldf'
go

exec sp_attach_db 'Standard','I:\Temp\Data\db\SQLServer\Test\Standard.mdf','I:\Temp\Data\db\SQLServer\Test\Standard_log.ldf'
go

exec sp_attach_db 'Test','I:\Temp\Data\db\SQLServer\Test\Test.mdf','I:\Temp\Data\db\SQLServer\Test\Test_Log.ldf'
go

exec sp_attach_db 'Work','I:\Temp\Data\db\SQLServer\Test\Work.mdf','I:\Temp\Data\db\SQLServer\Test\Work_log.ldf'
go



--分离数据库
--exec sp_detach_db 'DB_Lottery'

--附加数据库
--exec sp_attach_db DB_Lottery,'D:\DB\DB_Lottery\DB_Lottery.mdf','D:\DB\DB_Lottery\DB_Lottery_log.ldf' 
--备份数据文件
--backup database DB_Lottery to disk='D:\data\DB_Lottery_back'  
--备份日志文件 
--backup log DB_Lottery   to disk='D:\data\DB_Lottery_Log_back'  
--恢复备份数据库 
--restore database DB_Lottery from disk='D:\data\DB_Lottery_back' --(恢复的前提须要备份日志文件)



