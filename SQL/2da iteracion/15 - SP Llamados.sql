CREATE PROCEDURE dbo.Propiedades_RecuperarLlamados 
(
	@IdPropiedad int
)
AS


SELECT        IdLlamado, FechaHora, Contacto, Telefono, Comentarios, IdPropiedad
FROM            Llamados
WHERE        (IdPropiedad = @IdPropiedad)


;


create PROCEDURE dbo.Propiedades_CrearLlamado
(
	@IdPropiedad int,
	@FechaHora datetime,
	@Contacto nvarchar(50),
	@Telefono nvarchar(50),
	@Comentarios text
)
AS



insert into Llamados values (@FechaHora,@Contacto,@Telefono,@Comentarios,@IdPropiedad)

select @@identity

;

create PROCEDURE dbo.Propiedades_ActualizarLlamado
(
	@IdLlamado int,
	@FechaHora datetime,
	@Contacto nvarchar(50),
	@Telefono nvarchar(50),
	@Comentarios text
)
AS

update llamados set FechaHora=@FechaHora, Contacto=@Contacto, Telefono=@Telefono, Comentarios=@Comentarios
where idllamado=@IdLlamado

select @@rowcount

;

create PROCEDURE dbo.Propiedades_EliminarLlamado
(
	@IdLlamado int
)
AS


delete from llamados where idllamado = @IdLlamado


select @@rowcount


