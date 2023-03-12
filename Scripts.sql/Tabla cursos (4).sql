use master

GO

USE DBPRUEBATEC

GO

if not exists (select * from INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'CURSOS')
create table CURSOS(
IdCurso int primary key identity(1,1),
Curso varchar (60),
Horas varchar (60),
FechaRegistroEstu datetime default getdate()
)

go 

select * from dbo.CURSOS