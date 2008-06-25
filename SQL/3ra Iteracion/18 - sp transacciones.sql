crate PROCEDURE dbo.Transaccion_CrearTransPropiedad 
(
	@IdPropiedad int,
	@IdTipoTrans int,
	@Fecha datetime,
	@TypePropopiedad nvarchar(150)
)

AS

declare @id int

	
insert into Transaccion values (@IdTipoTrans, @Fecha, 1)
set @id = @@IDENTITY
insert into TransaccionesPropiedad values (@id, @IdPropiedad, @TypePropopiedad)


select @id