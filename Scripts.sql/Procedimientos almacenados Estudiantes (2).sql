go
use DBPRUEBATEC

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' and name = 'est_registrar')
DROP PROCEDURE est_registrar

go

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' and name = 'est_modificar')
DROP PROCEDURE est_modificar

go

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' and name = 'est_obtener')
DROP PROCEDURE est_obtener

go

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' and name = 'est_listar')
DROP PROCEDURE est_obtener

go

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' and name = 'est_eliminar')
DROP PROCEDURE est_eliminar

go

create procedure est_registrar(
@ccestu varchar (60),
@nombreestu varchar (60),
@apellidoestu varchar (60),
@emailestu varchar (60)
)
as
begin

insert into ESTUDIANTE (CCEstu,NombreEstu,ApellidoEstu,EmailEstu)
values
(
@ccestu,
@nombreestu,
@apellidoestu,
@emailestu
)

end

go

create procedure est_modificar(
@idestudiante int,
@ccestu varchar (60),
@nombreestu varchar (60),
@apellidoestu varchar (60),
@emailestu varchar (60)
)
as
begin

update ESTUDIANTE set
CCEstu = @ccestu,
NombreEstu = @nombreestu,
ApellidoEstu = @apellidoestu,
EmailEstu = @emailestu
where IdEstudiante = @idestudiante

end

go

create procedure est_obtener(
@idestudiante int
)
as
begin

select * from ESTUDIANTE where IdEstudiante = @idestudiante

end

go
create procedure est_listar
as
begin

select * from ESTUDIANTE
end

go

go 

create procedure est_eliminar(
@idestudiante int
)
as
begin

delete from ESTUDIANTE where IdEstudiante = @idestudiante

end

go