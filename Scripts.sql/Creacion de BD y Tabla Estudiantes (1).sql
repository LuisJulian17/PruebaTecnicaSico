use master
go
IF NOT EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE NAME = 'DBPRUEBATEC')
CREATE DATABASE DBPRUEBATEC

GO

USE DBPRUEBATEC

GO

if not exists (select * from INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'ESTUDIANTE')
create table ESTUDIANTE(
IdEstudiante int primary key identity(1,1),
CCEstu varchar (60),
NombreEstu varchar (60),
ApellidoEstu varchar (60),
EmailEstu varchar (60),
FechaRegistroEstu datetime default getdate()
)

go 

select * from dbo.ESTUDIANTE