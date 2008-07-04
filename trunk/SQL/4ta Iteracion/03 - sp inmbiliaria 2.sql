create PROCEDURE dbo.Inmobiliaria_ActualizarDatos
(
	@Nombre nvarchar(200), 
	@Telefono nvarchar(50), 
	@Fax nvarchar(50), 
	@Calle nvarchar(200), 
	@Numero int, 
	@Piso nvarchar(2), 
	@Depto nvarchar(3), 
	@CodigoPostal nvarchar(10), 
	@DireccionWeb nvarchar(250)
)
AS


delete  from Inmobiliaria

insert into Inmobiliaria values (	@Nombre , 
	@Telefono , 
	@Fax , 
	@Calle , 
	@Numero , 
	@Piso , 
	@Depto , 
	@CodigoPostal , 
	@DireccionWeb )
	
	
select @@ROWCOUNT
