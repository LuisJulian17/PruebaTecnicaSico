go
use master

GO 

USE DBPRUEBATEC

GO

if not exists (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'ASIGCURSOS')
create table ASIGCURSOS(
IdAsignacion int primary key identity(1,1),
IdEstudiante int references ESTUDIANTE(IdEstudiante),
CCEstudiante varchar (60),
NombreEstu varchar(60),
ApellidoEstu varchar (60),
EmailEstu varchar (60),
IdCurso int references CURSOS(IdCurso),
NombreCurso varchar(50),
HorasCurso int,
FechaRegistro datetime default getdate()
)

go

drop table ASIGCURSOS
