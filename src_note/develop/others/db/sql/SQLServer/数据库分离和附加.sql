use master
go

/***
数据库附加
存储过程
sp_attach_db
参数@dbname=指定数据库名称
@filename1=指定数据库数据主文件物理路径包含全路径名
@filename2=指定次数据文件物理路径

****/
exec sp_attach_db @dbname = 'brance',
@filename1 = 'I:\src-note\src\DataBase\SQLServer\Test\brance.mdf',
@filename2='I:\src-note\src\DataBase\SQLServer\Test\brance_Log.ldf';
go

/*** I:\src-note\src\DataBase\SQLServer\Project\ ./Project:**/
exec sp_attach_db @dbname='House', @filename1='I:\src-note\src\DataBase\SQLServer\Project\House.mdf', @filename2='I:\src-note\src\DataBase\SQLServer\Project\House_Log.ldf';

exec sp_attach_db @dbname='Library', @filename1='I:\src-note\src\DataBase\SQLServer\Project\Library.mdf',@filename2='I:\src-note\src\DataBase\SQLServer\Project\Library_Log.ldf';
exec sp_attach_db @dbname='Live',@filename1='I:\src-note\src\DataBase\SQLServer\Project\Live.mdf',@filename2='I:\src-note\src\DataBase\SQLServer\Project\Live_log.ldf';
exec sp_attach_db @dbname='MySchool_data',@filename1='I:\src-note\src\DataBase\SQLServer\Project\MySchool_data.mdf',@filename2='I:\src-note\src\DataBase\SQLServer\Project\MySchool_log.ldf';
exec sp_attach_db @dbname='PhoneCardSys',@filename1='I:\src-note\src\DataBase\SQLServer\Project\PhoneCardSys.mdf',@filename2='I:\src-note\src\DataBase\SQLServer\Project\PhoneCardSys_Log.ldf';
exec sp_attach_db @dbname='Price',@filename1='Price.mdf',@filename2='Price_log.ldf';
exec sp_attach_db @dbname='QQManager',@filename1='I:\src-note\src\DataBase\SQLServer\Project\QQManager.mdf',@filename2='I:\src-note\src\DataBase\SQLServer\Project\QQManager_Log.ldf';
exec sp_attach_db @dbname='SMS',@filename1='I:\src-note\src\DataBase\SQLServer\Project\SMS.mdf',@filename2='I:\src-note\src\DataBase\SQLServer\Project\SMS_log.ldf';
exec sp_attach_db @dbname='Users',@filename1='I:\src-note\src\DataBase\SQLServer\Project\Users.mdf',@filename2='I:\src-note\src\DataBase\SQLServer\Project\Users_Log.ldf';
exec sp_attach_db @dbname='newsxql',@filename1='I:\src-note\src\DataBase\SQLServer\Project\newsxql.mdf',@filename2='I:\src-note\src\DataBase\SQLServer\Project\newsxql_Log.ldf';

/** I:\src-note\src\DataBase\SQLServer\TempDataBase\ ./TempDataBase:**/
exec sp_attach_db @dbname='Pets',@filename1='I:\src-note\src\DataBase\SQLServer\TempDataBase\Pets.mdf',@filename2='I:\src-note\src\DataBase\SQLServer\TempDataBase\Pets_log.ldf';
exec sp_attach_db @dbname='QQ',@filename1='I:\src-note\src\DataBase\SQLServer\TempDataBase\QQ.mdf',@filename2='I:\src-note\src\DataBase\SQLServer\TempDataBase\QQ_log.ldf';
exec sp_attach_db @dbname='StudentDB',@filename1='I:\src-note\src\DataBase\SQLServer\TempDataBase\StudentDB.mdf',@filename2='I:\src-note\src\DataBase\SQLServer\TempDataBase\StudentDB_Log.ldf';
exec sp_attach_db @dbname='Teacher',@filename1='I:\src-note\src\DataBase\SQLServer\TempDataBase\Teacher.mdf',@filename2='I:\src-note\src\DataBase\SQLServer\TempDataBase\Teacher_Log.ldf';

/**** I:\src-note\src\DataBase\SQLServer\Test\ Test ****/
exec sp_attach_db @dbname='AirQualityDB',@filename1='I:\src-note\src\DataBase\SQLServer\Test\AirQualityDB.mdf',@filename2='I:\src-note\src\DataBase\SQLServer\Test\AirQualityDB_log.ldf';

exec sp_attach_db @dbname='ExamSys',@filename1='I:\src-note\src\DataBase\SQLServer\Test\ExamSys.mdf',@filename2='I:\src-note\src\DataBase\SQLServer\Test\ExamSys_Log.ldf';

exec sp_attach_db @dbname='FinanProduct',@filename1='I:\src-note\src\DataBase\SQLServer\Test\FinanProduct.mdf',@filename2='I:\src-note\src\DataBase\SQLServer\Test\FinanProduct_log.ldf';

exec sp_attach_db @dbname='HRSys',@filename1='I:\src-note\src\DataBase\SQLServer\Test\HRSys.mdf',@filename2='I:\src-note\src\DataBase\SQLServer\Test\HRSys_log.ldf';

exec sp_attach_db @dbname='Standard',@filename1='I:\src-note\src\DataBase\SQLServer\Test\Standard.mdf',@filename2='I:\src-note\src\DataBase\SQLServer\Test\Standard_log.ldf';

exec sp_attach_db @dbname='Test',@filename1='I:\src-note\src\DataBase\SQLServer\Test\Test.mdf',@filename2='I:\src-note\src\DataBase\SQLServer\Test\Test_Log.ldf';

exec sp_attach_db @dbname='Work',@filename1='I:\src-note\src\DataBase\SQLServer\Test\Work.mdf',@filename2='I:\src-note\src\DataBase\SQLServer\Test\Work_log.ldf';
go

