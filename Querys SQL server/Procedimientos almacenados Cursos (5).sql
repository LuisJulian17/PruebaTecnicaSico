go
use DBPRUEBATEC

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' and name = 'curso_registrar')
DROP PROCEDURE curso_registrar

go

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' and name = 'curso_modificar')
DROP PROCEDURE curso_modificar

go

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' and name = 'curso_obtener')
DROP PROCEDURE curso_obtener

go

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' and name = 'curso_listar')
DROP PROCEDURE curso_obtener

go

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' and name = 'curso_eliminar')
DROP PROCEDURE curso_eliminar

go

create procedure curso_registrar(
@curso varchar (60),
@horas varchar (60)
)
as
begin

insert into CURSOS (Curso,Horas)
values
(
@curso,
@horas
)

end

go

create procedure curso_modificar(
@idcurso int,
@curso varchar (60),
@horas varchar (60)
)
as
begin

update CURSOS set
Curso = @curso,
Horas = @horas
where IdCurso = @idcurso

end

go

create procedure curso_obtener(
@idcurso int
)
as
begin

select * from CURSOS where IdCurso = @idcurso

end

go
create procedure curso_listar
as
begin

select * from CURSOS
end

go

go 

create procedure curso_eliminar(
@idcurso int
)
as
begin

delete from CURSOS where IdCurso = @idcurso

end

go