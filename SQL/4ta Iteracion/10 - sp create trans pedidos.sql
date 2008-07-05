create PROCEDURE dbo.Transaccion_CrearTransPedido 
(
	@IdPedido int,
	@IdTipoTrans int,
	@Fecha datetime
)

AS

declare @id int

	
insert into Transaccion values (@IdTipoTrans, @Fecha, 1)
set @id = @@IDENTITY
insert into TransaccionesPedido values (@id, @IdPedido)


select @id