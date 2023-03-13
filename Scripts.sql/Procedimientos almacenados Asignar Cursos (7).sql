go
use DBPRUEBATEC

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' and name = 'asig_curso')
DROP PROCEDURE asig_curso

go

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' and name = 'modi_curso')
DROP PROCEDURE modi_curso

go

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' and name = 'obtener_asig')
DROP PROCEDURE obtener_asig

go

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' and name = 'listar_asig')
DROP PROCEDURE listar_asig

go

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' and name = 'eliminar_asig')
DROP PROCEDURE eliminar_asig

go

create procedure asig_curso(
@idestudiante int,
@ccestudiante int,
@nombreestud varchar (60),
@apellidoestud varchar (60),
@emailestud varchar (60),
@idcurso int,
@nomcurso varchar(60),
@horascurso int
)
as
begin

insert into ASIGCURSOS(IdEstudiante,CCEstudiante,NombreEstu,ApellidoEstu,EmailEstu,IdCurso,NombreCurso,HorasCurso)
values
(
@idestudiante,
@ccestudiante,
@nombreestud,
@apellidoestud,
@emailestud,
@idcurso,
@nomcurso,
@horascurso
)


end

go

create procedure modi_curso(
@idasignacion int,
@idestudiante int,
@ccestudiante varchar(60),
@nombreestud varchar (60),
@apellidoestud varchar (60),
@emailestud varchar (60),
@idcurso int,
@nomcurso varchar(60),
@horascurso int
)
as
begin

update ASIGCURSOS set
IdEstudiante = @idestudiante,
CCEstudiante = @ccestudiante,
NombreEstu = @nombreestud,
ApellidoEstu = @apellidoestud,
EmailEstu = @emailestud,
IdCurso = @idcurso,
NombreCurso = @nomcurso,
HorasCurso = @horascurso
where IdAsignacion = @idasignacion

end

go

create procedure obtener_asig(
@idasignacion int
)
as
begin

select * from ASIGCURSOS where IdAsignacion = @idasignacion

end

go
create procedure listar_asig
as
begin

select * from ASIGCURSOS
end

go

go 

create procedure eliminar_asig(
@idasignacion int
)
as
begin

delete from ASIGCURSOS where IdAsignacion = @idasignacion

end

go