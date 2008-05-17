CREATE PROCEDURE dbo.Propiedades_RecuperarNotas 
(
	@IdPropiedad int
)
AS


SELECT        IdNota, IdPropiedad, Nota, Fecha
FROM            NotasPropiedad
WHERE        (IdPropiedad = @IdPropiedad)

;

create PROCEDURE dbo.Propiedades_EliminarNota
(
	@IdNota int
)
AS


delete from notaspropiedad where idnota=@IdNota

select @@rowcount

;

create PROCEDURE dbo.Propiedades_InsertarNota
(
	@IdPropiedad int,
	@Nota text,
	@Fecha datetime
)
AS


insert into notaspropiedad (idpropiedad, nota, fecha) values (	@IdPropiedad,@Nota,@Fecha )


select @@identity

