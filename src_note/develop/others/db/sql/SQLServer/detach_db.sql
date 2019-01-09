use master

exec sp_databases;
alter database AirQualityDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
exec sp_detach_db @dbname='AirQualityDB';

alter database ExamSys SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
exec sp_detach_db @dbname='ExamSys';

alter database FinanProduct SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
exec sp_detach_db @dbname='FinanProduct';

alter database House SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
exec sp_detach_db @dbname='House';

alter database HRSys SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
exec sp_detach_db @dbname='HRSys';

alter database Library SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
exec sp_detach_db @dbname='Library';

/* */
-- exec sp_detach_db @dbname='Live';
if exists(select name from sys.databases where name='Live')
begin
alter database Live set single_user with rollback immediate;
exec sp_detach_db @dbname='Live';--@skipchecks='TRUE';--,@keepfulltextindexfile='TRUE';
end
go

alter database MySchool_data SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
exec sp_detach_db @dbname='MySchool_data';

alter database newsxql SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
exec sp_detach_db @dbname='newsxql';

alter database Pets SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
exec sp_detach_db @dbname='Pets';

alter database PhoneCardSys SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
exec sp_detach_db @dbname='PhoneCardSys';

alter database QQ SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
exec sp_detach_db @dbname='QQ';

alter database QQManager SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
exec sp_detach_db @dbname='QQManager';

alter database SMS SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
exec sp_detach_db @dbname='SMS';
alter database Standard SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
exec sp_detach_db @dbname='Standard';
alter database StudentDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
exec sp_detach_db @dbname='StudentDB';
alter database Teacher SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
exec sp_detach_db @dbname='Teacher';
alter database Test SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
exec sp_detach_db @dbname='Test';
alter database Users SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
exec sp_detach_db @dbname='Users';
alter database Work SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
exec sp_detach_db @dbname='Work';

if exists(select name from sys.databases where name='brance')
begin
alter database brance SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
exec sp_detach_db brance;
end;

if exists(select name from sys.databases where name='Price')
begin
alter database Price SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
exec sp_detach_db Price;
end;
go
exec sp_databases;
