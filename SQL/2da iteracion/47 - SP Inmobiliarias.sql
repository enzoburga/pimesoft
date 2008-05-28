CREATE PROCEDURE dbo.InmobiliariaExterna_Insertar 
(
	@Nombre nvarchar(100),
	@Telefono nvarchar(100),
	@Contacto nvarchar(100)
)
AS

insert into inmobiliariasExternas values (@Nombre, @Telefono, @Contacto)

select @@identity

;

create PROCEDURE dbo.InmobiliariaExterna_Actualizar
(
	@Nombre nvarchar(100),
	@Telefono nvarchar(100),
	@Contacto nvarchar(100),
	@IdInmobiliaria int
)
AS


update inmobiliariasExternas set nombre= @Nombre, telefono=@Telefono, contacto=@Contacto
where idinmobiliaria = @IdInmobiliaria


select @@rowcount


;

create PROCEDURE dbo.InmobiliariaExterna_RecuperarTodas

AS



select nombre, telefono, contacto, idinmobiliaria from inmobiliariasExternas

